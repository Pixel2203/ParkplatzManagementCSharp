using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektParkplatzManagement.com.dto.response
{
    public interface IValueResponse<T>
    {
        T? getValue();
    }
}
