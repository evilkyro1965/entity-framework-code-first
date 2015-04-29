using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace one_to_one2
{
    class DaoContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentAddress> StudentAdresses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }

    }
}
