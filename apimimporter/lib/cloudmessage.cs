using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apimimporter.lib
{
   
    public class Detail
    {
        public string code { get; set; }
        public string target { get; set; }
        public string message { get; set; }
    }

    public class Error
    {
        public string code { get; set; }
        public string message { get; set; }
        public List<Detail> details { get; set; }
    }

    public class cloudmessage
    {
        public Error error { get; set; }
    }
}
