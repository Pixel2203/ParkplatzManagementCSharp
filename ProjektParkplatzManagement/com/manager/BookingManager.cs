using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using ProjektParkplatzManagement.com.dao;
using ProjektParkplatzManagement.com.dto;
using ProjektParkplatzManagement.com.dto.response;

namespace ProjektParkplatzManagement.com.manager
{
    public class BookingManager
    {
        private readonly BookingDAO bookingDAO;
        public BookingManager(MySqlConnection connection)
        {
            bookingDAO = new BookingDAO(connection);
        }
        public FullBookingResponse bookParkingLot(BookingRequest request)
        {
            long bookingStartTime = request.startDate;
            long bookingEndTime = request.endDate;
            bool booked = bookingDAO.getBookingStatusInPeriodBySensorId(request.parkingLotId, bookingStartTime, bookingEndTime);
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
            if (ticket == null)
            {
                return new FullBookingResponse("Buchung konnte nicht erstellt werden!", false, null);
            }
            return new FullBookingResponse("Buchung wurde erstellt", true, ticket);
        }
        public FullParkingTicketListResponse getRecentBookingsByUser(User currentUser)
        {
            List<ParkingTicket>? foundBookings = bookingDAO.getBookingHistoryByUser(currentUser);
            string message = foundBookings == null ?
                "Fehler beim Aufrufen vorheriger Buchungen!" : foundBookings.Count == 0 ?
                "Konnte keine vorherigen Buchungen finden!" : "Buchungen erfolgreich abgerufen!";
            return new FullParkingTicketListResponse(message, foundBookings != null, foundBookings);
        }
        public List<ParkingLotData> getParkingLotData()
        {
            return bookingDAO.getParkingLotData();
        }


    }
}
