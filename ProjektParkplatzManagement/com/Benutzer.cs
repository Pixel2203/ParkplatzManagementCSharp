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
        public string name;
        public byte[] hashedPassword;

        public Benutzer(string name, string password)
        {
            this.name = name;
            this.hashedPassword = erzeugeHashWert(password);
        }

        private byte[] erzeugeHashWert(string unhashed)
        {
            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();
            byte[] hashedString = sha1.ComputeHash(Encoding.ASCII.GetBytes(unhashed));
            return hashedString;
        }
        public bool isPassword(string password)
        {
            byte[] hashedPassword = this.erzeugeHashWert(password);
            return this.hashedPassword == hashedPassword;
        }
    }
}
