using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektParkplatzManagement.com.dto
{
    public record AdvancedBooking(int id, long startDate, string plate, string parkinglotname , string email)
    {
    }
}
