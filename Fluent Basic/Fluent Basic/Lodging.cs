using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fluent_Basic
{
    public class Lodging
    {
        public int LodgingId { get; set; }
        public string Name { get; set; }
        public bool IsResort { get; set; }
        public Destination Destination { get; set; }
    }
}
