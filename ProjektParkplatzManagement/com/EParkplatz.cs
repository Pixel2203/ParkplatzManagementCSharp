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
        public EParkplatz(byte status, byte id) : base(status, id)
        {
        }

        public override void calculateCosts(int parkzeitInMinuten)
        {
            calculateUsedEnergy(parkzeitInMinuten, this.enegryFlowPerMinute);
            this.costs = this.parkGebühr * parkzeitInMinuten;
            this.costs += this.verbrauchterStrom * strompreisProMinute;
        }
        private void calculateUsedEnergy(float parkzeitInMinuten, float energyFlowPerMinute )
        {
            this.verbrauchterStrom = parkzeitInMinuten * energyFlowPerMinute;
        }
    }
}
