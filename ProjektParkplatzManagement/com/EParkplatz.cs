using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektParkplatzManagement.com
{
    public class EParkplatz : Parkplatz
    {
        private readonly float strompreisProMinute;
        private readonly float enegryFlowPerMinute;
        private float verbrauchterStrom;
        public EParkplatz(byte status, byte id, float parkGebühr) : base(status, id, parkGebühr)
        {
        }
        public EParkplatz(byte id, float parkGebühr) : base(0, id, parkGebühr)
        {

        }

        public override void calculateCosts(int parkzeitInMinuten)
        {
            calculateUsedEnergy(parkzeitInMinuten, this.enegryFlowPerMinute);
            this.costs = this.grundGebühr * parkzeitInMinuten;
            this.costs += this.verbrauchterStrom * strompreisProMinute;
        }
        private void calculateUsedEnergy(float parkzeitInMinuten, float energyFlowPerMinute )
        {
            this.verbrauchterStrom = parkzeitInMinuten * energyFlowPerMinute;
        }
    }
}
