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
            this.managementData.Benutzer = generiereBenutzer();
        }

        private Benutzer[] generiereBenutzer()
        {
            return new Benutzer[] { new Benutzer("Marvin Kaiser", "1234"), new Benutzer("Elias Liebelt", "56789")};
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
