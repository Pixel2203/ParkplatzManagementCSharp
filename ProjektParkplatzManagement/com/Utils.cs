using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektParkplatzManagement.com
{
    public class Utils
    {
        public static long toMilliseconds(DateTime time)
        {
            return time.Ticks / TimeSpan.TicksPerMillisecond;
        }
        public static DateTime fromMilliseconds(long milliseconds)
        {
            DateTime epochDateTime = new DateTime(1, 1, 1, 0, 0, 0, DateTimeKind.Local);
            return epochDateTime.AddMilliseconds(milliseconds);
        }
        public static MySqlDataReader runCommandWithReader(MySqlConnection connection, string sql)
        {
            MySqlCommand ort = connection.CreateCommand();
            ort.CommandText = sql;
            MySqlDataReader r = ort.ExecuteReader();
            return r;
        }
    }
}
