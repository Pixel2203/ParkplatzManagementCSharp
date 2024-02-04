using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektParkplatzManagement.com.dto
{
    public record BookingRequest(long startDate, long endDate, User user, int parkingLotId, ParkingLotType type);
}
