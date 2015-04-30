using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace table_per_hierarchy1
{
    class Resort:Lodging
    {
        public string Entertainment { get; set; }
        public string Activities { get; set; }
    }
}
