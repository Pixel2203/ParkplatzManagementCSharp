using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
//using Tweetinvi.Core.Extensions;

namespace ProjektParkplatzManagement.com
{
    public class ManagementData
    {
        private List<Benutzer> users;
        private List<Parkplatz> parkingLots;
        private List<Buchung> bookings;
        public readonly float parkGebühr = 1;
        private Benutzer? currentUser;

        public ManagementData()
        {
            this.users = new List<Benutzer>();
            this.parkingLots = new List<Parkplatz>();
            this.bookings = new List<Buchung>();
            this.currentUser = null;
        }

        public Benutzer? getUserByCredentials(string name, string password)
        {
            foreach(Benutzer user in users)
            {
                if(user.name.ToUpper().Equals(name.ToUpper()))
                {
                    if (!user.isPassword(password))
                    {
                        return null;
                    }
                    return user;
                }
            }
            return null;
        }
        public void registerUser(Benutzer user)
        {
            if(user == null)
            {
                return;
            }
            this.users.Add(user);
        }
        public void registerParkingLot(Parkplatz parkplatz)
        {
            if(parkplatz == null)
            {
                return;
            }
            this.parkingLots.Add(parkplatz);
        }

        public List<Parkplatz> getParkingLots()
        {
            return parkingLots;
        }
        public void setLoggedInUser(Benutzer user)
        {
            this.currentUser = user;
        }
        public Benutzer? getCurrentUser()
        {
            return this.currentUser;
        }
        public void addBooking(Buchung buchung)
        {
            this.bookings.Add(buchung);
        }
        public List<Buchung> getBookins()
        {
            return this.bookings;
        }
    }
}
