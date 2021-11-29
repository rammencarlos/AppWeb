using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WS.DTO
{
    public class ResponseDTO    
    {
        public string Message { get; set; }
        public int StatusCode { get; set; }
        public Object ResponseObject { get; set; }
    }
}
