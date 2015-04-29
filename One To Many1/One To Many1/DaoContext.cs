using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace One_To_Many1
{
    public class DaoContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Standard> Standards { get; set; }


    }
}
