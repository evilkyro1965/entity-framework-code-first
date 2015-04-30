using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace table_per_hierarchy1
{
    class DaoContext : DbContext
    {
        public DbSet<Resort> Resorts { get; set; }
        public DbSet<Lodging> Lodgings { get; set; }
    }
}
