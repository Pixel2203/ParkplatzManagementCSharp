using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektParkplatzManagement.com
{
    public abstract class Parkplatz
    {
        protected byte status;
        protected byte id;
        protected float costs;
        protected float parkGebühr;
        public Parkplatz(byte status, byte id)
        {
            this.status = status;
            this.id = id;
            this.costs = 0;
        }

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
        public float getCosts()
        {
            return this.costs;
        }
        public abstract void calculateCosts(int parkzeitInMinuten);

    }
}
