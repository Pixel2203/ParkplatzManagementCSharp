using MySqlConnector;
using ProjektParkplatzManagement.com.dto;
using ProjektParkplatzManagement.com.dto.response;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.Design.AxImporter;

namespace ProjektParkplatzManagement.com.dao
{
    public class UserDAO : DAO
    {
        public UserDAO(MySqlConnection connection) : base(connection)
        {
        }
        public User? authenticateUser(string email, string password)
        {
            string sql = string.Format("SELECT * FROM user WHERE email='{0}' AND password = '{1}'", email, password);
            return getUserBySql(sql);
        }
        private User? getUserBySql(MySqlCommand command)
        {
            MySqlDataReader reader = Utils.runCommandWithReader(command);
            if (reader.Read())
            {
                Permissions permission =(Permissions)Enum.Parse(typeof(Permissions), reader.GetString("permission"));
                User user = new User(
                        reader.GetInt32("id"),
                        reader.GetString("prename"),
                        reader.GetString("name"),
                        reader.GetString("plate"),
                        reader.GetString("email"),
                        reader.GetInt32("penalties"),
                        permission,
                        reader.GetString("password")

                ) ;
                reader.Close();
                return user;

            }
            reader.Close();
            return null;
        }
        private User? getUserBySql(string sql)
        {
            MySqlDataReader reader = Utils.runCommandWithReader(connection,sql);
            if (reader.Read())
            {
                Permissions permission = (Permissions)Enum.Parse(typeof(Permissions), reader.GetString("permission"));
                User user = new User(
                        reader.GetInt32("id"),
                        reader.GetString("prename"),
                        reader.GetString("name"),
                        reader.GetString("plate"),
                        reader.GetString("email"),
                        reader.GetInt32("penalties"),
                        permission,
                        reader.GetString("password")

                );
                reader.Close();
                return user;

            }
            reader.Close();
            return null;
        }

        public ResponseObject registerUser(User user)
        {
            //TODO umwandeln um gegen SQL injection zu schützen
            if(getUserByEmail(user.email) != null)
            {
                return new ResponseObject("Nutzer mit dieser Email existiert bereits", false);
            }

            string sql = string.Format("INSERT INTO user (prename,name,email,plate,penalties, password, permission) VALUES ('{0}','{1}','{2}','{3}',{4}, '{5}', '{6}')", user.prename, user.name, user.email, user.plate, user.penalties, user.password, Enum.GetName(user.permission));
            int penalties = getPenaltiesByPlate(user.plate);
            MySqlCommand command = new MySqlCommand(sql,connection);
            bool worked = command.ExecuteNonQuery() > 0;
            string message =  worked ? "Benutzer erfolgreich registriert!" : "Konnte Benutzer nicht registrieren!";
            return new ResponseObject(message, worked);
        }


        private int getPenaltiesByPlate(string plate)
        {
            string sql = string.Format("SELECT penalties,plate FROM user WHERE plate LIKE '{0}'", plate);
            MySqlDataReader reader = Utils.runCommandWithReader(connection, sql);
            if(reader.Read())
            {
            
                int penalties = reader.GetInt32("penalties");
                reader.Close();
                return penalties;
            }
            reader.Close();
            return 0;
        }

        public User? getUserByEmail(string email)
        {
            //TODO sql injection absichern
            string sql = string.Format("SELECT * FROM user WHERE email LIKE '{0}'",email);
            return getUserBySql(sql);
        }

        /*

        public void imposePenalty(String plate)
        {
            // Get current Penalties

            try
            {
                int currentPenalties = getPenaltiesByPlate(plate);
                String sql = "UPDATE user SET penalties=" + (currentPenalties + 1) + " WHERE plate LIKE '" + plate + "'";
                Statement statement = dbManager.getConnection().createStatement();
                statement.execute(sql);
            }
            catch (SQLException e)
            {
                throw new RuntimeException(e);
            }


        }


        public User getUserByEmailAndPlate(String email, String plate)
        {
            String sql = "SELECT * FROM user WHERE email LIKE '" + email + "' AND plate LIKE '" + plate + "'";
            Statement statement = null;
            return getUserBySql(sql);

        }


        public Optional<User> getUserById(int userId)
        {
            String sql = "SELECT * FROM user WHERE id=" + userId;
            User foundUser = getUserBySql(sql);
            if (foundUser == null)
            {
                return Optional.empty();
            }
            return Optional.of(foundUser);
        }




        */
    }
}
