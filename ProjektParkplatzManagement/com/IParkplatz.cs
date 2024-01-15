using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektParkplatzManagement.com
{
    public interface IParkplatz
    {
        public string getStatusInfo();
        public void calculateCosts(int parkzeitInMinuten);
        public float getParkgebühr();
    }
}
