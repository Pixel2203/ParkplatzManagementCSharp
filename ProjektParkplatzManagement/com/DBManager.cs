using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektParkplatzManagement.com
{
    public class DBManager
    {
        private MySqlConnection connection;

        public DBManager()
        {
            this.connection = new MySqlConnection();
        }

        public bool establishConnection(string connectionDetails)
        {
            if(!isConnected())
            {
                try
                {
                    connection.ConnectionString = connectionDetails;
                    connection.Open();
                    return true;
                }
                catch (Exception)
                {

                    return false;
                }
            }
            return false;
        }

        public bool isConnected()
        {
            return connection.State == System.Data.ConnectionState.Open;
        }
        public MySqlConnection getConnection()
        {
            return this.connection;
        }
    }
}
