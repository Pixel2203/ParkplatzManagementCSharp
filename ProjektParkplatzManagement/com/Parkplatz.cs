using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektParkplatzManagement.com
{
    public class Parkplatz
    {
        private byte status;
        private byte id;


        public string getStatusInfo()
        {
            if (status == 0)
            {
                return "frei";
            }
            else if (status == 1)
            {
                return "gebucht";
            }
            else if(status == 2)
            {
                return "blockiert";
            }
            return "fehler";
        }
        public byte getId()
        {
            return id;
        }
    }
}
