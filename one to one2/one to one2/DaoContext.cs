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

            modelBuilder.Entity<Student>()
                .HasOptional<StudentAddress>(s => s.StudentAddress)
                .WithOptionalDependent(a => a.Student) /* dependent object adalah object dimana foreign key di letakkan */
                .Map(m => m.MapKey("StudentAddressId"));

            
        }

    }
}
