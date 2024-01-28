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
            if (response.worked)
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
        public FullParkingTicketListResponse getRecentBookingsByLoggedInUser()
        {
            if(currentUser == null)
            {
                return new FullParkingTicketListResponse("Es ist kein Benutzer angemeldet!", false, null);
            }
            return bookingManager.getRecentBookingsByUser(this.currentUser);
        }
        public FullBookingListResponse getAllBookingsByUserId(int userId)
        {
            return bookingManager.getAllBookingsByUserId(userId);
        }
        public FullUserListResponse getAllUsers()
        {
            return userManager.getAllUsers();
        }
        public ResponseObject deleteBookingById(int id)
        {
            return bookingManager.deleteBookingById(id);
        }
        public ResponseObject changePasswordOfUserById(int userId, String password)
        {
            return userManager.changePasswordOfUser(userId, password);
        }
        public ResponseObject blockUserById(int userId)
        {
            return userManager.blockuserById(userId);
        }

        public void logoutUser(Form form)
        {
            form.Hide();
            this.currentUser = null;
            new Form1().ShowDialog();
            form.Close();
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
