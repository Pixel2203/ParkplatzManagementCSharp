using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektParkplatzManagement.com.dto
{
    public record ParkingTicket(string name, Int64 bookingId, long startDate, long endDate, string plate, int sensorId)
    {
        public long getParkingDuration()
        {
            return endDate - startDate;
        }
    }
}
