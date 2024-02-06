using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektParkplatzManagement.com.dto.response
{
    public class FullAdvancedBookingListResponse : ResponseObject, IValueResponse<List<AdvancedBooking>>
    { 
        private readonly List<AdvancedBooking>? bookings;
    
        public FullAdvancedBookingListResponse(string message, bool worked, List<AdvancedBooking>? bookings) : base(message, worked)
        {
            this.bookings = bookings;
        }

        public List<AdvancedBooking>? getValue()
        {
            return this.bookings;
        }
    }
}
