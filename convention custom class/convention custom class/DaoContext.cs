using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace convention_custom_class
{
    public class DaoContext:DbContext
    {
        public DbSet<Student> Students {get; set;}
        public DbSet<StudentAddress> StudentAdresses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // register Convention class
            modelBuilder.Conventions.Add(new TableSchemaAttributeConvention());

            /*
             * Model Builder
             */
            modelBuilder.Entity<StudentAddress>()
                .HasKey(e => e.StudentId);
            modelBuilder.Entity<Student>()
                .HasOptional(s => s.StudentAddress)
                .WithRequired(address => address.Student);
        }
    }
}
