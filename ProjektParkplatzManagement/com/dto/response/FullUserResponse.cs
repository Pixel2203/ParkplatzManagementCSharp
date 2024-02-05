    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektParkplatzManagement.com.dto.response
{
    public class FullUserResponse : ResponseObject, IValueResponse<User>
    {
        private readonly User? user;
        public FullUserResponse(string message, bool worked, User? user): base(message, worked)
        {
            this.user = user;
        }

        public User? getValue()
        {
            return user;
        }
    }

}
