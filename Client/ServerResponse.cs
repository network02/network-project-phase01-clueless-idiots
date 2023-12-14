using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    internal class ServerResponse
    {
        public string response { get; set; }
        public string header { get; set; }
        public Data data { get; set; }
    }
}
