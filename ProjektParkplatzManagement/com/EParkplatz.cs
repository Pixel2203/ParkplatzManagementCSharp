using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektParkplatzManagement.com
{
    public class EParkplatz : Parkplatz
    {
        private readonly static float PAUSCHALE_E = 35;
        private readonly static float STEHKOSTEN_E = 0.025f;
        private readonly static float STROMKOSTEN_PRO_MINUTE = 0.125f;
        public EParkplatz(float parkzeitInMinuten) : base(PAUSCHALE_E, parkzeitInMinuten, STEHKOSTEN_E)
        {
        }
        public override float berechneKosten()
        {
            float kosten = 0;
            // Stehkosten holen
            float stehKosten = this.berechneStehKosten();
            // Stromkosten berechnen
            float stromkosten = STROMKOSTEN_PRO_MINUTE * parkzeitInMinuten;
            // Pauschale Addieren
            kosten = stehKosten + stromkosten + this.pauschale;
            return kosten;
        }
    }
}
