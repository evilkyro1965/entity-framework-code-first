using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace mysql
{
    class DaoContext:DbContext
    {
        public DaoContext() : base(nameOrConnectionString: "bookkeeping") { }

        public DbSet<User> Users { get; set; }
    }
}
