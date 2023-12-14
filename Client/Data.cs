using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    internal class Data
    {
        public string name { get; set; }
        public int age { get; set; }
        public Data(string _name,int _age) 
        {
            this.name = _name;
            this.age = _age;
        }

    }
}
