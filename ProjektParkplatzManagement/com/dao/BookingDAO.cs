using Tweetinvi.Core.Extensions;
using ProjektParkplatzManagement.com.dto;
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
            DateTime startDate = Utils.fromMilliseconds(request.startDate);
            DateTime endDate = Utils.fromMilliseconds(request.endDate);
            int parkingLotId = request.parkingLotId;
            string plate = request.user.plate;
            if (string.IsNullOrEmpty(plate))
            {
                return null;
            }
            string sql = string.Format("INSERT INTO booking (start, end, plate, parkinglotId, userId) VALUES('{0}', '{1}', '{2}', '{3}','{4}'); SELECT LAST_INSERT_ID();", startDate.ToString(Utils.formatDateWithYearMonthDayHoursMinutes), endDate.ToString(Utils.formatDateWithYearMonthDayHoursMinutes), plate, parkingLotId, request.user.id);
            ParkingLotData? parkingLotData = getParkingLotDataById(request.parkingLotId);
            if(parkingLotData == null)
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
            UInt64 bookingId = (UInt64) generated;
            return new ParkingTicket(parkingLotData.name, (int)bookingId, Utils.toMilliseconds(startDate), Utils.toMilliseconds(endDate), plate, request.parkingLotId, request.type);
        }



        public bool getBookingStatusInPeriodBySensorId(int sensorId, long bookingStartTime, long bookingEndTime)
        {
            string sql = string.Format("SELECT COUNT(*) FROM booking WHERE parkinglotId={0} AND ((start >= '{1}' AND start <= '{2}') OR (end >= '{1}' AND end <= '{2}') OR (start <= '{1}' AND end >= '{2}'))", sensorId, Utils.fromMilliseconds(bookingStartTime).ToString(Utils.formatDateWithYearMonthDayHoursMinutes), Utils.fromMilliseconds(bookingEndTime).ToString(Utils.formatDateWithYearMonthDayHoursMinutes));
            long rows = (long)new MySqlCommand(sql, connection).ExecuteScalar();
            return rows > 0;
        }

        public bool checkParallelBookings(string plate, long plannedBookingStart, long plannedBookingEnd)
        {
            string sql = string.Format("SELECT COUNT(*) FROM booking WHERE plate='{0}' AND ((start >= '{1}' AND start <= '{2}') OR (end >= '{1}' AND end <= '{2}') OR (start <= '{1}' AND end >= '{2}'))", plate, Utils.fromMilliseconds(plannedBookingStart).ToString(Utils.formatDateWithYearMonthDayHoursMinutes), Utils.fromMilliseconds(plannedBookingEnd).ToString(Utils.formatDateWithYearMonthDayHoursMinutes));
            return ((long)new MySqlCommand(sql, connection).ExecuteScalar()) > 0;

        }

        public int getParkingTimeForDay(string plate, long startDateInMilliseconds)
        {
            DateTime date = Utils.fromMilliseconds(startDateInMilliseconds);

            string sql = "SELECT * FROM booking WHERE plate LIKE '" + plate + "' AND start LIKE '" + date.ToString() + "%' ORDER BY start desc";
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
                                reader.GetInt32("parkinglotId"),
                                reader.GetInt32("userId")
                        )
                );
            }
            reader.Close();
            return bookings;
        }

        public List<ParkingLotData> getParkingLotData()
        {
            string sql = "SELECT * FROM parkinglot, parkinglottypes WHERE parkinglot.typeId = parkinglottypes.id";
            MySqlDataReader reader = Utils.runCommandWithReader(connection, sql);
            List<ParkingLotData> foundSensors = new List<ParkingLotData>();
            DateTime timeStamp1 = DateTime.Now;
            DateTime timeStamp2 = DateTime.Now.AddMilliseconds(1800000); // + 30 Minuten da dies die Minimum Buchungsdauer ist
            while (reader.Read())
            {
                ParkingLotType type = (ParkingLotType)Enum.Parse(typeof(ParkingLotType), reader.GetString("type"));
                string name = reader.GetString("name");
                int id = reader.GetInt32("id");
                bool bookable = false;
                foundSensors.Add(new ParkingLotData(id, name, type, bookable));
                
            }
            reader.Close();

            List<ParkingLotData> updatedSensors = new List<ParkingLotData>();
            foundSensors.ForEach(foundSensor =>
            {
                bool bookable = !getBookingStatusInPeriodBySensorId(foundSensor.id, Utils.toMilliseconds(timeStamp1), Utils.toMilliseconds(timeStamp2));
                ParkingLotData parkingLot = new ParkingLotData(foundSensor.id,foundSensor.name,foundSensor.type,bookable);
                updatedSensors.Add(parkingLot);
            });

            return updatedSensors;
        }

        private ParkingLotData? getParkingLotDataById(int parkingLotId)
        {
            DateTime timestamp = DateTime.Now;
            DateTime timestamp2 = DateTime.Now.AddMilliseconds(1800000);
            bool bookable = !getBookingStatusInPeriodBySensorId(parkingLotId, Utils.toMilliseconds(timestamp), Utils.toMilliseconds(timestamp2));
            string sql = string.Format("SELECT * FROM parkinglot,parkinglottypes WHERE parkinglot.id={0} AND typeId=parkinglottypes.id", parkingLotId);
            MySqlDataReader reader = Utils.runCommandWithReader(connection, sql);

            if (reader.Read())
            {
                ParkingLotType type = (ParkingLotType)Enum.Parse(typeof(ParkingLotType), reader.GetString("type"));
                ParkingLotData data = new ParkingLotData(
                    parkingLotId,
                    reader.GetString("name"),
                    type,
                    bookable
                    );
                reader.Close();
                return data;
            }
            reader.Close();
            return null;
        }


        public List<Booking>? getAllBookingsByUserId(int userId)
        {
            string sql = string.Format("SELECT * FROM booking WHERE userId = {0}", userId.ToString());
            return getBookingsBySql(sql);
        }

        public bool deleteBooking(int bookingId)
        {
            string sql = string.Format("DELETE FROM booking WHERE id={0}", bookingId);
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = sql;
            return command.ExecuteNonQuery() == 1;
        }
        public List<AdvancedBooking> getAdvancedBookingsByFilter(string filter, string value)
        {
            List<AdvancedBooking> advancedBookings = new List<AdvancedBooking>();

            string sql = string.Format("SELECT booking.id,booking.start,booking.plate,parkinglot.name,user.email FROM booking,parkinglot,user WHERE booking.parkinglotId = parkinglot.id AND user.id = booking.userId AND {0} LIKE '%{1}%' ORDER BY start desc", filter, value);
            MySqlDataReader reader = Utils.runCommandWithReader(connection, sql);

            while (reader.Read())
            {
                AdvancedBooking booking = new AdvancedBooking(
                        reader.GetInt32("id"),
                        Utils.toMilliseconds(reader.GetDateTime("start")),
                        reader.GetString("plate"),
                        reader.GetString("name"),
                        reader.GetString("email")
                    );
                advancedBookings.Add(booking);
            }

            reader.Close();
            return advancedBookings;
        }
        public List<ParkingTicket>? getBookingHistoryByUser(User user)
        {
            String sql = string.Format("SELECT booking.id,parkinglot.name,booking.start,booking.end,parkinglottypes.type,booking.plate,booking.parkinglotId FROM booking,user,parkinglot,parkinglottypes WHERE user.id = booking.userId AND booking.parkinglotId = parkinglot.id AND parkinglottypes.id = parkinglot.typeId AND booking.end < '{0}' AND user.id = {1} ORDER BY start desc", DateTime.Now.ToString(Utils.formatDateWithYearMonthDayHoursMinutes), user.id);
            return getParkingTicketListBySql(sql);
        }
        public List<ParkingTicket>? getAllParkingTicketsByUser(int id)
        {
            string sql = string.Format("SELECT booking.id,parkinglot.name,booking.start,booking.end,parkinglottypes.type,booking.plate,booking.parkinglotId FROM booking,user,parkinglot,parkinglottypes WHERE user.id = booking.userId AND booking.parkinglotId = parkinglot.id AND parkinglottypes.id = parkinglot.typeId AND user.id = {0} ORDER BY start desc", id);
            return getParkingTicketListBySql(sql);
        }
        public List<ParkingTicket>? getParkingTicketsByUserInFuture(int id)
        {
            string sql = string.Format("SELECT booking.id,parkinglot.name,booking.start,booking.end,parkinglottypes.type,booking.plate,booking.parkinglotId FROM booking,user,parkinglot,parkinglottypes WHERE user.id = booking.userId AND booking.parkinglotId = parkinglot.id AND parkinglottypes.id = parkinglot.typeId AND user.id = {0} AND start > '{1}' ORDER BY start desc", id, DateTime.Now.ToString(Utils.formatDateWithYearMonthDayHoursMinutes));
            return getParkingTicketListBySql(sql);
        }
        private List<ParkingTicket> getParkingTicketListBySql(string sql)
        {
            MySqlDataReader reader = Utils.runCommandWithReader(connection, sql);
            List<ParkingTicket> parkingTickets = new List<ParkingTicket>();
            while (reader.Read())
            {
                ParkingLotType type = (ParkingLotType)Enum.Parse(typeof(ParkingLotType), reader.GetString("type"));
                ParkingTicket ticket = new ParkingTicket(
                        reader.GetString("name"),
                        (int)reader.GetUInt64("id"),
                        Utils.toMilliseconds(reader.GetDateTime("start")),
                        Utils.toMilliseconds(reader.GetDateTime("end")),
                        reader.GetString("plate"),
                        reader.GetInt32("parkinglotId"),
                        type);

                parkingTickets.Add(ticket);

            }
            reader.Close();
            return parkingTickets;
        }

    }
}
