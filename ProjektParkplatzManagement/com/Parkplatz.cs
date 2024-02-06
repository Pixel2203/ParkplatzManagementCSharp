using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektParkplatzManagement.com
{
    public abstract class Parkplatz
    {
        protected float pauschale;
        protected float parkzeitInMinuten;
        protected float stehkostenProMinute;

        protected Parkplatz(float pauschale, float parkzeitInMinuten, float stehkostenProMinute)
        {
            this.pauschale = pauschale;
            this.parkzeitInMinuten = parkzeitInMinuten;
            this.stehkostenProMinute = stehkostenProMinute;
        }
        protected float berechneStehKosten()
        {
            return this.stehkostenProMinute * this.parkzeitInMinuten;
        }

        public abstract float berechneKosten();
        
    }
}
