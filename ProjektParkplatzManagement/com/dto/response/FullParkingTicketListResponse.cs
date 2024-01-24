using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektParkplatzManagement.com.dto.response
{
    public class FullParkingTicketListResponse : ResponseObject, IValueResponse<List<ParkingTicket>>
    {
        private readonly List<ParkingTicket>? bookingList;
        public FullParkingTicketListResponse(string message, bool worked, List<ParkingTicket>? bookings) : base(message, worked)
        {
            this.bookingList = bookings;
        }

        public List<ParkingTicket>? getValue()
        {
            return bookingList;
        }
    }
}
