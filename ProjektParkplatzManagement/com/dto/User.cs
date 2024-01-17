using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektParkplatzManagement.com.dto
{
    public record User(int id, string prename, string name, string plate, string email, int penalties, Permissions permission, string password);
}
