using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Erorrs
{
    public class ApiException
    {
        public ApiException(int statussCode, string message = null, string details = null)
        {
            StatussCode = statussCode;
            Message = message;
            Details = details;
        }

        public int StatussCode { get; set; }

        public string Message { get; set; }

        public string Details { get; set; }


    }
}