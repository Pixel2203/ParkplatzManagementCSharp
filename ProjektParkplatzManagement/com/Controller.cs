using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektParkplatzManagement.com
{
    public class Controller
    {
        private ManagementData managementData;
        public Controller()
        {
            this.managementData = new ManagementData();
            registerUsers();
            registerParkingLots();
        }

        private void registerUsers()
        {
            this.managementData.registerUser(new Benutzer("Marvin Kaiser", "1234"));
            this.managementData.registerUser(new Benutzer("Elias Liebelt", "56789"));
        }
        private void registerParkingLots()
        {
            this.managementData.registerParkingLot(new Parkplatz(0, 1));
            this.managementData.registerParkingLot(new Parkplatz(0, 2));
            this.managementData.registerParkingLot(new Parkplatz(0, 3));
            this.managementData.registerParkingLot(new Parkplatz(0, 4));
            this.managementData.registerParkingLot(new Parkplatz(0, 5));
            this.managementData.registerParkingLot(new Parkplatz(0, 6));
        }
        public bool isValidUser(string name, string password)
        {
            Benutzer loginUser = new Benutzer(name, password);
            Benutzer? foundUser = managementData.getUserByName(name); 
            if(foundUser == null)
            {
                return false;
            }
            return foundUser.hashedPassword.SequenceEqual(loginUser.hashedPassword);
        }
    }
}
