﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektParkplatzManagement.com.dto.response
{
    public abstract class ResponseObject
    {
        protected readonly bool worked;
        protected readonly string message;

    protected ResponseObject(string message, bool worked)
        {
            this.message = message;
            this.worked = worked;
        }

        public string getMessage()
        {
            return this.message;
        }
        public bool getWorked()
        {
            return this.worked;
        }
    }
}