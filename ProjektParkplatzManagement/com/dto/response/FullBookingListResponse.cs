using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektParkplatzManagement.com.dto.response
{
    public class FullBookingListResponse : ResponseObject, IValueResponse<List<Booking>>
    { 
        private readonly List<Booking>? bookings;
    
        public FullBookingListResponse(string message, bool worked, List<Booking>? bookings) : base(message, worked)
        {
            this.bookings = bookings;
        }

        public List<Booking>? getValue()
        {
            return this.bookings;
        }
    }
}
