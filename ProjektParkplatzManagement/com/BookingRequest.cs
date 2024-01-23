using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjektParkplatzManagement.com.dto;

namespace ProjektParkplatzManagement.com
{
    public record BookingRequest(long startDate, long endDate, User user, int parkingLotId, ParkingLotType type);
}
