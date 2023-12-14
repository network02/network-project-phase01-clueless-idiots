using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    internal class ServerRequest
    {
        public string requestType { get; set; }
        public Data data { get; set; }
        public int id { get; set; }
    }
}
