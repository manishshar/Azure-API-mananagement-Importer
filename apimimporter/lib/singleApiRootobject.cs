using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apimimporter.lib
{
    class singleApiRootobject
    {
            public string id { get; set; }
            public string name { get; set; }
            public string apiRevision { get; set; }
            public object description { get; set; }
            public string serviceUrl { get; set; }
            public string path { get; set; }
            public string[] protocols { get; set; }
            public Authenticationsettings authenticationSettings { get; set; }
            public Subscriptionkeyparameternames subscriptionKeyParameterNames { get; set; }
            public string type { get; set; }
            public bool isCurrent { get; set; }
        }

        public class Authenticationsettings
        {
            public object oAuth2 { get; set; }
            public object openid { get; set; }
        }

        public class Subscriptionkeyparameternames
        {
            public string header { get; set; }
            public string query { get; set; }
        }

    }

