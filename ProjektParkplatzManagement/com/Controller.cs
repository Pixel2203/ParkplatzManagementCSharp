using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using ProjektParkplatzManagement.com.dao;
using ProjektParkplatzManagement.com.dto;

namespace ProjektParkplatzManagement.com
{
    public class Controller
    {
        private Benutzer? currentUser;
        private DBManager dBManager;
        private BookingManager bookingManager;
        private readonly string connectionString = "server=127.0.0.1;uid=root;pwd=Kaiser.331;database=parkingdatabase";
        public Controller()
        {
            currentUser = null;
            this.dBManager = new DBManager();
            this.dBManager.establishConnection(connectionString);
            bookingManager = new BookingManager(this.dBManager.getConnection());
        }


        public FullBookingResponse bucheParkplatz(BookingRequest request)
        {
            return bookingManager.bookParkingLot(request);
        }
        
        public void loginUser(Benutzer user)
        {
            this.currentUser = user;
        }
        public void logoutUser()
        {
            this.currentUser = null;

        }
        public Benutzer? getBenutzer()
        {
            return this.currentUser;
        }
    }
}
