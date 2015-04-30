using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace table_per_hierarchy1
{
    class Lodging
    {
        public int LodgingId { get; set; }

        public string Name { get; set; }
        public string Owner { get; set; }
    }
}
