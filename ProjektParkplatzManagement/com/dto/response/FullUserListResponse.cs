using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektParkplatzManagement.com.dto.response
{
    public class FullUserListResponse : ResponseObject, IValueResponse<List<User>>
    {
        private readonly List<User>? user;
        public FullUserListResponse(string message, bool worked, List<User>? user): base(message, worked)
        {
            this.user = user;
        }

        public List<User>? getValue()
        {
            return user;
        }
    }

}
