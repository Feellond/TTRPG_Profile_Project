using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTRPG_Project.BL.DTO.Exceptions
{
    public class CustomException : Exception
    {
        public string Details { get; set; }
        public int StatusCode { get; set; }

        public CustomException()
        {
            StatusCode = 400;
        }

        public CustomException(string message)
            : base(message)
        {

        }
        public CustomException(string message, string details)
            : base(message)
        {
            Details = details;
        }
    }
}
