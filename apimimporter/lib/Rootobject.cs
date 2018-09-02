using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apimimporter.lib
{

    public class Rootobject
    {
        public Value[] value { get; set; }
        public int count { get; set; }
        public object nextLink { get; set; }
    }

    public class Value
    {
        public string id { get; set; }
        public string name { get; set; }
        public string apiRevision { get; set; }
        public string description { get; set; }
        public string serviceUrl { get; set; }
        public string path { get; set; }
        public string[] protocols { get; set; }
        public object authenticationSettings { get; set; }
        public object subscriptionKeyParameterNames { get; set; }
        public bool isCurrent { get; set; }
        public string apiRevisionDescription { get; set; }
        public string type { get; set; }
    }



}
