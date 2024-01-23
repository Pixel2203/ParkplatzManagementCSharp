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
        public byte id { get; }
        public float costs { get; }
        protected float grundGebühr { get; }
        public ParkingLotType type { get; }
        public Parkplatz(byte status, byte id, float grundGebühr)
        {
            this.status = status;
            this.id = id;
            this.costs = 0;
            this.grundGebühr = grundGebühr;
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
    }
}
