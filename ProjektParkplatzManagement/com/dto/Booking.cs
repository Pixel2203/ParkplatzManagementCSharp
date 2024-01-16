using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektParkplatzManagement.com.dto
{
    public record Booking(int id, long startDate, long endDate, string plate, int sensorId, bool entered, bool removed, int userId);
}
