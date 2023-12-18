using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektParkplatzManagement.com
{
    public class StandartParkplatz : Parkplatz
    {
        public StandartParkplatz(byte status, byte id, float parkGebühr) : base(status, id,parkGebühr)
        {
        }
        public StandartParkplatz(byte id, float parkGebühr) : base(0, id,parkGebühr)
        {
        }

        public override void calculateCosts(int parkzeitInMInuten)
        {
            this.costs = getParkGebühr() * parkzeitInMInuten;
        }
    }
}
