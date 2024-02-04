using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektParkplatzManagement.com
{
    public class StandartParkplatz : Parkplatz
    {
        private readonly static float PAUSCHALE_STANDARD = 25;
        private readonly static float STEHKOSTEN_STANDARD = 0.025f;
        public StandartParkplatz(float parkzeitInMinuten) : base(PAUSCHALE_STANDARD, parkzeitInMinuten, STEHKOSTEN_STANDARD)
        {
        }
        public override float berechneKosten()
        {
            // Stehkosten holen
            float stehKosten = this.berechneStehKosten();
            // Pauschale Addieren
            float kosten = stehKosten + this.pauschale;
            return kosten;
        }
    }
}
