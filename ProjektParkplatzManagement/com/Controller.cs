using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using ProjektParkplatzManagement.com.dao;
using ProjektParkplatzManagement.com.dto;
using ProjektParkplatzManagement.com.dto.response;
using ProjektParkplatzManagement.com.manager;

namespace ProjektParkplatzManagement.com
{
    public class Controller
    {
        private User? currentUser;
        private readonly DBManager dBManager;
        private readonly BookingManager bookingManager;
        private readonly UserManager userManager;
        private readonly string connectionString = "server=127.0.0.1;uid=root;pwd=Kaiser.331;database=parkingdatabase";
        public Controller()
        {
            currentUser = null;
            this.dBManager = new DBManager();
            this.dBManager.establishConnection(connectionString);
            bookingManager = new BookingManager(this.dBManager.getConnection());
            userManager = new UserManager(this.dBManager.getConnection());
        }


        public FullBookingResponse bucheParkplatz(BookingRequest request)
        {
            return bookingManager.bookParkingLot(request);
        }
        public FullUserResponse loginUserByCredentials(string email, string password)
        {
            FullUserResponse response = userManager.getUserByCredentials(email, password);
            if (response.getWorked())
            {
                this.currentUser = response.getValue();
            }
            return response;
        }

        public ResponseObject registerUser(User user)
        {
            return userManager.registerUser(user);
        }

        public List<ParkingLotData> getParkingLotData()
        {
            return bookingManager.getParkingLotData();
        }

        public void logoutUser()
        {
            this.currentUser = null;
        }
        public User? getUser()
        {
            return this.currentUser;
        }

        public Boolean isValidConnection()
        {
            return dBManager.isConnected();
        }
    }
}
