using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using ProjektParkplatzManagement.com.dao;
using ProjektParkplatzManagement.com.dto;

namespace ProjektParkplatzManagement.com
{
    public class BookingManager
    {
        private BookingDAO bookingDAO;
        public BookingManager(MySqlConnection connection)
        {
            this.bookingDAO = new BookingDAO(connection);
        }
        public FullBookingResponse bookParkingLot(BookingRequest request)
        {
            long bookingStartTime = request.startDate;
            long bookingEndTime = request.endDate;
            bool booked = bookingDAO.getBookingStatusInPeriodBySensorId(request.sensorId, bookingStartTime, bookingEndTime);
            if (booked)
            {
                return new FullBookingResponse("Buchung überschneidet sich!", false, null);
            }



            // Überprüfen ob gleiches Auto in diesem Zeitraum auf einem anderen Parkplatz steht
            bool isParallelBooked = bookingDAO.checkParallelBookings(request.user.plate, bookingStartTime, bookingEndTime);
            if (isParallelBooked)
            {
                return new FullBookingResponse("Parallele Buchungen entdeckt!", false, null);
            }

            // Nicht mehr als 4 Stunden pro Tag
            int minutesParked = bookingDAO.getParkingTimeForDay(request.user.plate, request.startDate);
            int minutesPlanned = (int)((request.endDate - request.startDate) / 1000 / 60);
            if (minutesParked + minutesPlanned > 240)
            {
                return new FullBookingResponse("Parklimit überschritten, " + (240 - minutesParked) + " Minuten übrig!", false, null);
            }
            ParkingTicket? ticket = bookingDAO.createBooking(request);
            if(ticket == null)
            {
                return new FullBookingResponse("Buchung konnte nicht erstellt werden!", false, null);
            }
            return new FullBookingResponse("Buchung wurde erstellt", true, ticket);
        }
    }
}
