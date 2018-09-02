using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apimimporter.lib
{
    class singleApiRevsion
    {
        public RevsionValue[] value { get; set; }
        public int count { get; set; }
        public object nextLink { get; set; }
    }

    public class RevsionValue
    {
        public string apiId { get; set; }
        public string apiRevision { get; set; }
        public DateTime createdDateTime { get; set; }
        public DateTime updatedDateTime { get; set; }
        public string description { get; set; }
        public string privateUrl { get; set; }
        public bool isOnline { get; set; }
        public bool isCurrent { get; set; }
    }

}

