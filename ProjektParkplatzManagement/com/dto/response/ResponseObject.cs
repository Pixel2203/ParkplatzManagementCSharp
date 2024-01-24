using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektParkplatzManagement.com.dto.response
{
    public class ResponseObject
    {
        public bool worked { get; }
        public string message { get; }

    public ResponseObject(string message, bool worked)
        {
            this.message = message;
            this.worked = worked;
        }
    }
}
