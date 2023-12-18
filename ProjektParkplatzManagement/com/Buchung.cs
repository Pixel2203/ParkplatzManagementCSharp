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
            return this.uhrzeit;
        }
        public int getDauer()
        {
            return this.dauer;
        }
        public DateTime getStartDatum()
        {
            return this.startDatum;
        }
        public bool interfereresWithBooking(Buchung buchung)
        {
            if (buchung.parkplatzIndex != this.parkplatzIndex)
            {
                return false;
            }
            int compared = DateTime.Compare(buchung.getStartDatum(), startDatum);
            if(compared != 0)
            {
                return false;
            }
            int startNEU = buchung.getUhrzeit();
            float endeNEU = buchung.getUhrzeit() + (buchung.getDauer() / 60);

            int start = uhrzeit;
            float ende = uhrzeit + (dauer / 60);
            bool doesInterfere = isInterfering(startNEU, endeNEU, start, ende);
            if (doesInterfere)
            {
                return false;
            }
            
            return true;
        }
        private bool isInterfering(int start1, float ende1, int start2, float ende2)
        {
            if ((start1 >= start2 && start1 <= ende2) || (ende2 >= start1 && ende2 <= ende1) || (start2 <= start1 && ende2 >= ende1))
            {
                return true;
            }
            return false;
        }

    }
}
