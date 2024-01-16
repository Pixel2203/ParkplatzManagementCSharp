﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.Design.AxImporter;
using Tweetinvi.Core.Extensions;
using ProjektParkplatzManagement.com.dto;
using static System.Windows.Forms.AxHost;
using Tweetinvi.Models;
using MySqlConnector;

namespace ProjektParkplatzManagement.com.dao
{
    public class BookingDAO : DAO
    {
        public BookingDAO(MySqlConnection connection) : base(connection)
        {
        }

        public ParkingTicket? createBooking(BookingRequest request)
        {
            // Buchungen dürfen sich beim selben Nutzer nicht überschneiden
            // --> Gleiches fahrzeug kann zur selben Zeit nicht auf 2 Parkplätzen stehen
            // --> Mitarbeiter besitzt mehrere Fahrzeuge --> Dann erlaubt (nicht sicher)
            DateTime startDate = Utils.fromMilliseconds(request.startDate);
            DateTime endDate = Utils.fromMilliseconds(request.endDate);
            int sensorId = request.sensorId;
            string plate = request.user.plate;
            if (string.IsNullOrEmpty(plate))
            {
                return null;
            }
            //string insertSQL = "INSERT INTO booking (start, end, plate, sensorId,removed,entered,reminded,userId) VALUES (?, ?, ?, ?,0,0,0,?)";
            string sql = string.Format("INSERT INTO booking(start, end, plate, sensorId, removed, entered, reminded, userId) VALUES({0}, {1}, {2}, {3}, 0, 0, 0,{4})", startDate, endDate, plate, sensorId, request.user.id);
            SensorData? sensor = getSensorDataBySensorId(request.sensorId);
            if(sensor == null)
            {
                return null;
            }
            MySqlCommand registerBookingCMD = this.connection.CreateCommand();
            registerBookingCMD.CommandText = sql;
            object? generated = registerBookingCMD.ExecuteScalar();
            int userId = request.user.id;
            if(generated == null)
            {
                return null;
            }
            int bookingId = (int)generated;
            return new ParkingTicket(sensor.name, bookingId, Utils.toMilliseconds(startDate), Utils.toMilliseconds(endDate), plate, request.sensorId);
        }

        public List<SensorData> getSensorData()
        {
            String sql = "SELECT * FROM sensor";
            MySqlDataReader reader = Utils.runCommandWithReader(connection,sql);
            List<SensorData> foundSensors = new List<SensorData>();
            while (reader.Read())
            {
                String name = reader.GetString("name");
                int id = reader.GetInt32("id");
                bool status = reader.GetBoolean("status");
                DateTime timeStamp1 = DateTime.Now;
                DateTime timeStamp2 = DateTime.Now.AddMilliseconds(1800000);
                bool bookable = !getBookingStatusInPeriodBySensorId(id, Utils.toMilliseconds(timeStamp1), Utils.toMilliseconds(timeStamp2));
                foundSensors.Add(new SensorData(id, name, status, bookable));
            }
            reader.Close();
            return foundSensors;
            


        }
       
        private SensorData? getSensorDataBySensorId(int id)
        {
            String sql = "SELECT * FROM sensor WHERE id=" + id;
            MySqlDataReader reader =Utils.runCommandWithReader(connection, sql);
            DateTime timestamp = DateTime.Now;
            DateTime timestamp2 = DateTime.Now.AddMilliseconds(1800000);
            bool bookable = !getBookingStatusInPeriodBySensorId(id, Utils.toMilliseconds(timestamp), Utils.toMilliseconds(timestamp2));
            if (reader.Read())
            {
                reader.Close();
                return new SensorData(
                    id,
                    reader.GetString("name"),
                    reader.GetBoolean("status"),
                    bookable
                    );
            }
            reader.Close();
            return null;


        }

        public bool getBookingStatusInPeriodBySensorId(int sensorId, long bookingStartTime, long bookingEndTime)
        {
            string sql = string.Format("SELECT COUNT(*) FROM booking WHERE sensorId={0} AND ((start >= {1} AND start <= {2}) OR (end >= {1} AND end <= {2}) OR (start <= {1} AND end >= {2}))", sensorId, Utils.fromMilliseconds(bookingStartTime), Utils.fromMilliseconds(bookingEndTime));
            MySqlDataReader reader = Utils.runCommandWithReader(connection, sql);
            if (reader.Read())
            {
                bool found = reader.GetInt32(1) > 0;
                reader.Close();
                return found;
            }
            reader.Close();
            return false;
        }

        public bool checkParallelBookings(string plate, long plannedBookingStart, long plannedBookingEnd)
        {
            string sql = string.Format("SELECT COUNT(*) FROM booking WHERE plate={0} AND ((start >= {1} AND start <= {2}) OR (end >= {1} AND end <= {2}) OR (start <= {1} AND end >= {2}))", plate, Utils.fromMilliseconds(plannedBookingStart), Utils.fromMilliseconds(plannedBookingEnd));
            MySqlDataReader reader = Utils.runCommandWithReader(connection, sql);
            if (reader.Read())
            {

                bool found = reader.GetInt32(1) > 0;
                reader.Close();
                return found;
            }
            reader.Close();
            return false;

        }

        public int getParkingTimeForDay(string plate, long startDateInMilliseconds)
        {
            DateTime date = Utils.fromMilliseconds(startDateInMilliseconds);

            string sql = "SELECT * FROM booking WHERE plate LIKE '" + plate + "' AND start LIKE '" + date.ToString() + "%'";
            List<Booking>? bookings = getBookingsBySql(sql);
            if (bookings != null)
            {
                if (bookings.IsEmpty())
                {
                    return 0;
                }
                int usedTime = 0;

                foreach (Booking booking in bookings)
                {
                    long timeDiff = booking.endDate - booking.startDate;
                    usedTime += (int)timeDiff / 1000 / 60;
                }
                return usedTime;
            }
            else
            {
                return 9999;
            }
        }


        private List<Booking>? getBookingsBySql(string sql)
        {

            MySqlDataReader reader = Utils.runCommandWithReader(connection, sql);
            List<Booking> bookings = new List<Booking>();
            while (reader.Read())
            {
                bookings.Add(
                        new Booking(
                                reader.GetInt32("id"),
                                Utils.toMilliseconds(reader.GetDateTime("start")),
                                Utils.toMilliseconds(reader.GetDateTime("end")),
                                reader.GetString("plate"),
                                reader.GetInt32("sensorId"),
                                reader.GetBoolean("entered"),
                                reader.GetBoolean("removed"),
                                reader.GetInt32("userId")
                        )
                );
            }
            reader.Close();
            return bookings;
        }

        /*
       public Optional<List<Booking>> findBookingsByDateAndSensor(int sensorId, long dateInMilliseconds)
       {
           Timestamp timestamp = new Timestamp(dateInMilliseconds);
           String timestampString = timestamp.toString();
           Date date = new Date(dateInMilliseconds);
           String dateString = date.toString();
           String sql = "SELECT * FROM booking WHERE sensorId=" + sensorId +
                   " AND ((start > '" + timestampString + "' AND start LIKE '" + dateString + "%') " +
                   " OR (start < '" + timestampString + "' AND end > '" + timestampString + "'))";
           return getBookingsBySql(sql);

       }

       public Optional<List<Booking>> getBookingsByPlate(String plate)
       {
           String sql = "SELECT * FROM booking WHERE plate LIKE '" + plate + "'";
           return getBookingsBySql(sql);
       }

       public Optional<List<Booking>> getFutureBookingsByPlate(String plate)
       {

           Timestamp now = Timestamp.from(Instant.now());
           String sql = "SELECT * FROM booking WHERE start > '" + now + "' AND plate LIKE '" + plate + "'";
           return getBookingsBySql(sql);
       }

       

       


       public Optional<List<Booking>> getBookingHistoryByPlate(String plate)
       {
           Timestamp now = Timestamp.from(Instant.now());
           String sql = "SELECT * FROM booking WHERE start < '" + now + "' AND end < '" + now + "' AND plate LIKE '" + plate + "'";
           return getBookingsBySql(sql);
       }
       public Optional<Map<Integer, List<ParkingTicket>>> getAvailableTimesFromStartDate(long startDate, int duration)
       {

           // Return List :)
           Map<Integer, List<ParkingTicket>> parkingTicketMap = new HashMap<>();

           // Get Booking
           Optional<Map<Integer, List<Booking>>> listMap = getBookingsByDateGroupedBySensorId(new Timestamp(startDate));
           if (listMap.isEmpty())
           {
               return Optional.empty();
           }
           Map<Integer, List<Booking>> foundBookingsGrouped = listMap.get();
           // Get Sensors

           Optional<List<SensorData>> optionalSensorDataList = getSensorData();
           if (optionalSensorDataList.isEmpty())
           {
               return Optional.empty();
           }
           List<SensorData> sensorList = optionalSensorDataList.get();

           for (SensorData sensor : sensorList)
           {
               if (foundBookingsGrouped.get(sensor.id()) == null)
               {
                   Optional<List<ParkingTicket>> availableTimes = getRecommendationsByDate(startDate, sensor, List.of(), duration * 1000 * 60);
                   if (availableTimes.isEmpty())
                   {
                       continue;
                   }
                   parkingTicketMap.put(
                           sensor.id(),
                           availableTimes.get()
                   );
                   continue;
               }

               Optional<List<ParkingTicket>> availableTimes = getRecommendationsByDate(startDate, sensor, foundBookingsGrouped.get(sensor.id()), duration * 1000 * 60);
               if (availableTimes.isEmpty())
               {
                   continue;
               }
               parkingTicketMap.put(
               sensor.id(),
                       availableTimes.get()
               );
           }

           return Optional.of(parkingTicketMap);

       }

       private Optional<Map<Integer, List<Booking>>> getBookingsByDateGroupedBySensorId(Timestamp startTime)
       {
           Date startDate = new Date(startTime.getTime());
           String sql = "SELECT * FROM booking WHERE (start >= '" + startTime + "' AND start LIKE '" + startDate + "%') OR (end >= '" + startTime + "' AND end LIKE '" + startDate + "%')";
           Optional<List<Booking>> bookings = getBookingsBySql(sql);
           return bookings.map(bookingList->bookingList
                   .stream()
                   .sorted(Comparator.comparing(Booking::startDate))
                   .collect(Collectors.groupingBy(Booking::sensorId)));

       }
       public Optional<List<ParkingTicket>> getRecommendationsByDate(long startDate, SensorData sensorData, List<Booking> bookingListWithSameSensorId, int minDuration)
       {
           List<ParkingTicket> newList = new ArrayList<>();

           Timestamp lastAvailableTime = new Timestamp(startDate);
           lastAvailableTime.setHours(23);
           lastAvailableTime.setMinutes(59);
           final String sensorName = sensorData.name();
           if (bookingListWithSameSensorId.isEmpty())
           {
               return Optional.of(List.of(
                       new ParkingTicket(sensorName, 0, startDate, lastAvailableTime.getTime(), null, sensorData.id())
               ));
           }
           for (int i = 0; i <= bookingListWithSameSensorId.size(); i++)
           {
               boolean lastElement = i == bookingListWithSameSensorId.size();
               Timestamp endDate;
               if (lastElement)
               {
                   newList.add(new ParkingTicket(sensorName, 0,
                           bookingListWithSameSensorId.get(bookingListWithSameSensorId.size() - 1).endDate() + (1000 * 60),
                           lastAvailableTime.getTime(),
                           null, sensorData.id())
                   );
                   continue;
               }

               if (bookingListWithSameSensorId.get(i).startDate() - startDate > minDuration)
               {
                   // Calc end Time;
                   endDate = new Timestamp(bookingListWithSameSensorId.get(i).startDate());
                   //long correctedStartDate = bookingListWithSameSensorId.get(i-1).endDate() == startDate ? startDate + (60*1000) : startDate;
                   long correctedStartDate = startDate;
                   if (i > 0)
                   {
                       correctedStartDate += 60000;
                   }
                   newList.add(new ParkingTicket(sensorName, 0, correctedStartDate, endDate.getTime(), null, sensorData.id()));
               }
               startDate = bookingListWithSameSensorId.get(i).endDate();

           }
           return Optional.of(newList);
       }

       public Optional<String> updateSensor(int id, int sensorStatus)
       {
           String sql = "UPDATE sensor SET status=" + sensorStatus + " WHERE id=" + id;
           try
           {
               Statement statement = dbManager.getConnection().createStatement();
               statement.execute(sql);
               statement.close();
               return Optional.of("MEINE ID: " + id + " Mein Status: " + sensorStatus);
           }
           catch (SQLException e)
           {
               return Optional.empty();
           }

       }

 

       public boolean carRemovedFromParkingLot(UserService userService, int sensorId)
       {
           Booking booking = getActiveBooking(sensorId);
           if (booking == null)
           {
               return false;
           }
           boolean worked = updateBookingEndedStatus(booking.id());

           Timestamp currentTime = Timestamp.from(Instant.now());
           long timeDifference = (currentTime.getTime() - booking.endDate()) / 1000 / 60;
           if (timeDifference > 2)
           {
               // Mehr als 2 Stunden zu spät
               userService.imposePenalty(booking.plate());
           }
           return worked;
       }

       public boolean carEnteredParkingLot(int sensorId)
       {
           Booking booking = getCurrentBooking(sensorId);
           if (booking == null)
           {
               return false;
           }
           return updateBookingStartedStatus(booking.id());
       }
       private Booking getCurrentBooking(int sensorId)
       {
           Timestamp currentTime = Timestamp.from(Instant.now());
           String sql = "SELECT * FROM booking WHERE sensorId=" + sensorId + " AND start <= '" + currentTime + "' AND end >= '" + currentTime + "'";
           return getBooking(sql);

       }
       private Booking getActiveBooking(int sensorId)
       {
           String sql = "SELECT * from booking WHERE sensorId=" + sensorId + " AND entered=1 AND removed=0";
           return getBooking(sql);
       }

       private Booking getBooking(String sql)
       {
           Optional<List<Booking>> optionalBookings = getBookingsBySql(sql);
           if (optionalBookings.isEmpty())
           {
               return null;
           }
           else if (optionalBookings.get().size() > 1 || optionalBookings.get().isEmpty())
           {
               // Wäre ein Fehler in der Datenbank (mehrere Fahrzeuge auf einem Parkplatz)
               return null;
           }
           return optionalBookings.get().get(0);
       }

       private boolean updateBookingEndedStatus(int bookingId)
       {
           String sql = "UPDATE booking SET removed=" + 1 + " WHERE id=" + bookingId;
           try
           {
               Statement statement = dbManager.getConnection().createStatement();
               statement.execute(sql);
               statement.close();
               return true;
           }
           catch (SQLException e)
           {
               return false;
           }
       }
       private boolean updateBookingStartedStatus(int bookingId)
       {
           String sql = "UPDATE booking SET entered=" + 1 + ", removed=0 WHERE id=" + bookingId;
           try
           {
               Statement statement = dbManager.getConnection().createStatement();
               statement.execute(sql);
               statement.close();
               return true;
           }
           catch (SQLException e)
           {
               return false;
           }
       }


       public List<Booking> getBookingsRunningOut(Timestamp endTime)
       {
           Timestamp timeNow = Timestamp.from(Instant.now());
           String sql = "SELECT * FROM booking WHERE start<= '" + timeNow + "' AND end <= '" + endTime + "' AND reminded=0 AND end > '" + timeNow + "'";
           Optional<List<Booking>> bookings = getBookingsBySql(sql);
           return bookings.orElseGet(List::of);
       }

       public void remindedUser(int id)
       {
           String sql = "UPDATE booking SET reminded=1 WHERE id=" + id;
           try
           {
               Statement statement = dbManager.getConnection().createStatement();
               statement.execute(sql);
               statement.close();
           }
           catch (SQLException ignored)
           {

           }

       }
       */
    }
}