using ProjektParkplatzManagement.com.dto.response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektParkplatzManagement.com.dto
{
    public class FullBookingResponse : ResponseObject
    {

    private readonly ParkingTicket? parkingTicket;
    public FullBookingResponse(String message, bool worked, ParkingTicket? parkingTicket): base(message,worked)
    {
        this.parkingTicket = parkingTicket;
    }

    public ParkingTicket? getParkingTicket()
    {
        return parkingTicket;
    }
}
}
