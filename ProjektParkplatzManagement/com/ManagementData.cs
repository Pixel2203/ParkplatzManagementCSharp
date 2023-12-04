using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Tweetinvi.Core.Extensions;

namespace ProjektParkplatzManagement.com
{
    public class ManagementData
    {
        public Benutzer[] Benutzer { get; set; }

        public Benutzer? getUserByName(string name)
        {
            foreach(Benutzer user in Benutzer)
            {
                if(user.name.ToUpper().Equals(name.ToUpper()))
                {
                    return user;
                }
            }
            return null;
        }
    }
}
