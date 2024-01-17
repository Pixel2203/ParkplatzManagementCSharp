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
    }   
}
