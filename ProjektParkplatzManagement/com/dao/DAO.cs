using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektParkplatzManagement.com.dto
{
    public abstract class DAO
    {
        protected MySqlConnection connection;
        public DAO(MySqlConnection connection)
        {
            this.connection = connection;
        }
    }
}
