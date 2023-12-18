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
        public readonly float parkGebühr = 1;

        public ManagementData()
        {
            this.users = new List<Benutzer>();
            this.parkingLots = new List<Parkplatz>();
        }

        public Benutzer? getUserByName(string name)
        {
            foreach(Benutzer user in users)
            {
                if(user.name.ToUpper().Equals(name.ToUpper()))
                {
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
    }
}
