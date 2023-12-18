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
        private Permissions permission;

        public Benutzer(string name, string password, Permissions permission)
        {
            this.name = name;
            this.hashedPassword = erzeugeHashWert(password);
            if(permission != null)
            {
                this.permission = permission;
            }else
            {
                this.permission = Permissions.DEFAULT;
            }
           
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
            return this.hashedPassword.SequenceEqual(hashedPassword);
        }
        public Permissions getPermissions()
        {
            return this.permission;
        }
    }
}
