using MySqlConnector;
using ProjektParkplatzManagement.com.dao;
using ProjektParkplatzManagement.com.dto;
using ProjektParkplatzManagement.com.dto.response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektParkplatzManagement.com.manager
{
    public class UserManager
    {
        private readonly UserDAO agent;
        public UserManager(MySqlConnection connection)
        {
            this.agent = new UserDAO(connection);
        }


        public ResponseObject registerUser(User user)
        {
            return agent.registerUser(user);
        }
        public FullUserResponse getUserByCredentials(string email, string hashedPassword)
        {
            User? foundUser = agent.authenticateUser(email, hashedPassword);
            if(foundUser == null)
            {
                return new FullUserResponse("Es wurde kein Benutzerkonto gefunden!", false, null);
            }
            return new FullUserResponse("Erfolgreich angemeldet!", true, foundUser);
        }
        public FullUserListResponse getAllUsers()
        {
            List<User> users = agent.getAllUsers();
            if(users == null)
            {
                return new FullUserListResponse("Fehler bei der Auswertung", false, null);
            }
            if(users.Count == 0)
            {
                return new FullUserListResponse("Es konnten keine Benutzer gefunden werden!", true, users);
            }
            return new FullUserListResponse("User gefunden!", true, users);
        }
        public ResponseObject changePasswordOfUser(int userId, string password)
        {
            bool worked = agent.changePasswordByUserId(userId, password);
            string message = worked ? string.Format("Password von id='{0}' erfolgreich geändert", userId) : "Konnte Password nicht ändern!";
            return new ResponseObject(message, worked);
        }
        public ResponseObject blockuserById(int userId)
        {
            bool worked = agent.blockUserById(userId);
            string message = worked ? "Benutzer erfolgreich gesperrt!" : "Konnte Benutzer nicht sperren";
            return new ResponseObject(message, worked);
        }

        public ResponseObject updateUser(User user)
        {
            bool worked = agent.updateUser(user);
            string message = worked ? "Benutzerdaten geändert!" : "Konnte Benutzerdaten nicht ändern!";
            return new ResponseObject(message, worked); 
        }
    }   
}
