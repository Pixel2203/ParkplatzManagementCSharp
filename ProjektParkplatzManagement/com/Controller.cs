using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektParkplatzManagement.com
{
    public class Controller
    {
        public ManagementData managementData;
        public Controller()
        {
            this.managementData = new ManagementData();
            registerUsers();
            registerParkingLots();
        }

        private void registerUsers()
        {

            this.managementData.registerUser(new Benutzer("Marvin Kaiser", "1234", Permissions.ADMIN));
            this.managementData.registerUser(new Benutzer("Elias Liebelt", "56789", Permissions.DEFAULT));
        }
        private void registerParkingLots()
        {
            for(int i = 0; i < 5; i++)
            {
                this.managementData.registerParkingLot(new StandartParkplatz((byte)i, this.managementData.parkGebühr));
            }
            this.managementData.registerParkingLot(new EParkplatz(0, this.managementData.parkGebühr));

        }
        public void bookParkingLot(int parkplatzIndex, DateTime selectedDate,  int time, int duration)
        {

        }
    }
}
