using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektParkplatzManagement.com.dto
{
    public record Booking(int id, long startDate, long endDate, string plate, int parkingLotId, int userId)
    {
        public int getDurationInMinutes()
        {
            return (int) (endDate - startDate) / 1000 / 60;
        }
    }
}
