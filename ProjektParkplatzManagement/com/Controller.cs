using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektParkplatzManagement.com
{
    public class Controller
    {
        public ManagementData managementData;
        public Controller()
        {
            this.managementData = new ManagementData();
            registerUsers();
            registerParkingLots();
        }

        private void registerUsers()
        {

            this.managementData.registerUser(new Benutzer("Marvin Kaiser", "1234", Permissions.ADMIN));
            this.managementData.registerUser(new Benutzer("Elias Liebelt", "56789", Permissions.DEFAULT));
        }
        private void registerParkingLots()
        {
            for(int i = 0; i < 5; i++)
            {
                this.managementData.registerParkingLot(new StandartParkplatz((byte)i, this.managementData.parkGebühr));
            }
            this.managementData.registerParkingLot(new EParkplatz(0, this.managementData.parkGebühr));

        }
        public void bookParkingLot(int parkplatzIndex, DateTime selectedDate,  int time, int duration)
        {
            Benutzer? currentUser = this.managementData.getCurrentUser();
            if(currentUser == null)
            {
                return;
            }
            if (currentUser.isBanned())
            {
                return;
            }
            Buchung booking = new Buchung(selectedDate.Date, time, duration, parkplatzIndex, currentUser);
            bool isValid = isBookingValid(booking);
            if (isValid)
            {
                this.managementData.addBooking(booking);
            }
        }

        private bool isBookingValid(Buchung buchung)
        {
            DateTime now = DateTime.Now.Date;
            int compared = DateTime.Compare(now, buchung.getStartDatum());
            if(compared < 0) { return false; }

            foreach(Buchung cBuchung in managementData.getBookins())
            {
                if(buchung == cBuchung)
                {
                    continue;
                }
                bool notValid = isInterfering(
                    buchung.getUhrzeit(), 
                    buchung.getUhrzeit() + (buchung.getDauer() / 60), 
                    cBuchung.getUhrzeit(), 
                    cBuchung.getUhrzeit() + (cBuchung.getDauer() / 60)
                    );
                if (notValid)
                {
                    return false;
                }




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

        public void loginUser(Benutzer user)
        {
            Form1.controller.managementData.setLoggedInUser(user);
        }
        public void logoutUser()
        {
            Form1.controller.managementData.setLoggedInUser(null);

        }
    }
}
