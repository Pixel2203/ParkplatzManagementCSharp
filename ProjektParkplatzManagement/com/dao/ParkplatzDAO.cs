using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektParkplatzManagement.com.dto
{
    internal class UserDTO : DAO
    {
        public UserDTO(MySqlConnection connection) : base(connection)
        {
        }
    }
}
