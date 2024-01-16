using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektParkplatzManagement.com.dao
{
    public class Buchung
    {
        private DateTime startDatum;
        private int uhrzeit;
        private int dauer;
        private int parkplatzIndex;
        private Benutzer benutzer;
        public Buchung(DateTime startDatum, int uhrzeit, int dauer, int parkplatzIndex, Benutzer benutzer)
        {
            this.startDatum = startDatum;
            this.uhrzeit = uhrzeit;
            this.dauer = dauer;
            this.parkplatzIndex = parkplatzIndex;
            this.benutzer = benutzer;
        }

        public bool isRightNow()
        {
            return false;
        }
        public int getUhrzeit()
        {
            return uhrzeit;
        }
        public int getDauer()
        {
            return dauer;
        }
        public DateTime getStartDatum()
        {
            return startDatum;
        }
        public Benutzer getBenutzer()
        {
            return benutzer;
        }
        public int getParkplatzIndex()
        {
            return parkplatzIndex;
        }

    }
}
