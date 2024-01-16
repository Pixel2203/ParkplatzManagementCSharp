﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tweetinvi.Security;

namespace ProjektParkplatzManagement.com.dao
{
    public class Benutzer
    {
        public string name;
        public byte[] hashedPassword;
        private Permissions permission;
        private bool banned;

        public Benutzer(string name, string password, Permissions permission)
        {
            this.name = name;
            hashedPassword = erzeugeHashWert(password);
            this.permission = permission;
            banned = false;

        }

        private byte[] erzeugeHashWert(string unhashed)
        {

            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();
            byte[] hashedString = sha1.ComputeHash(Encoding.ASCII.GetBytes(unhashed));
            return hashedString;
        }
        public bool isSamePassword(string password)
        {
            byte[] hashedPassword = erzeugeHashWert(password);
            return this.hashedPassword.SequenceEqual(hashedPassword);
        }
        public Permissions getPermissions()
        {
            return permission;
        }
        public void ban()
        {
            banned = true;
        }
        public void unban()
        {
            banned = false;
        }
        public bool isBanned()
        {
            return banned;
        }
    }
}