using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tweetinvi.Security;

namespace ProjektParkplatzManagement.com
{
    public class Benutzer
    {
        private string hashedName;
        private string hashedPasswort;

        public Benutzer(string name, string password)
        {
            this.hashedName = erzeugeHashWert(name);
            this.hashedPasswort = erzeugeHashWert(password);
        }

        private string erzeugeHashWert()
        {
            var sha1 = new SHA1CryptoServiceProvider();
            var sha1data = sha1.ComputeHash(data);
        }
    }
}
