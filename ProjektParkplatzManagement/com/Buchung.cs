using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektParkplatzManagement.com
{
    public class Buchung
    {
        private DateTime startDatum;
        private int uhrzeit;
        private int dauer;
        private int parkplatzIndex;
        public Buchung(DateTime startDatum, int uhrzeit, int dauer, int parkplatzIndex)
        {
            this.startDatum = startDatum;
            this.uhrzeit = uhrzeit;
            this.dauer = dauer;
            this.parkplatzIndex = parkplatzIndex;
        }

        public bool isRightNow()
        {
            return false;
        }

    }
}
