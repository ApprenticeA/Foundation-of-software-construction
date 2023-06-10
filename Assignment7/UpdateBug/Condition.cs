using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdateBug
{
    internal class Condition
    {
        public int count;
        public string url;
        public string IfOk;
        public string type;
        public Condition(int count, string url, string IfOk,string type)
        {
            this.count = count;
            this.url = url;
            this.IfOk = IfOk;
            this.type = type;
        }
    }
}
