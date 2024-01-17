using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Tweetinvi.Security;
using static System.Net.Mime.MediaTypeNames;

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
        public static MySqlDataReader runCommandWithReader(MySqlCommand command)
        {
            return command.ExecuteReader(); ;
        }
        public static string erzeugeHashWert(string unhashed)
        {
            if (String.IsNullOrEmpty(unhashed))
                return String.Empty;
            
            using (var sha = SHA256.Create())
            {
                byte[] textData = Encoding.UTF8.GetBytes(unhashed);
                byte[] hash = sha.ComputeHash(textData);
                return BitConverter.ToString(hash).Replace("-", String.Empty);
            }
        }
    }
}
