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
            Benutzer[] benutzer = generiereBenutzer();
            this.managementData.Benutzer = benutzer;
        }

        private Benutzer[] generiereBenutzer()
        {
            return new Benutzer[] { new Benutzer("Marvin Kaiser", "1234"), new Benutzer("Elias Liebelt", "56789")};
        }
    }
}
