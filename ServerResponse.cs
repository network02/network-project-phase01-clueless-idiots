using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    internal class ServerResponse
    {
        public string response { get; set; }
        public string header { get; set; }
        public Data data { get; set; }

        public ServerResponse(string response, string header, Data data)
        {
            this.response=response;
            this.header=header;
            this.data=data;
        }
    }
}
