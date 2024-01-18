using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektParkplatzManagement.com.dto
{
    public record ParkingLotData(int id, string name, ParkingLotType type, bool bookable);
}
