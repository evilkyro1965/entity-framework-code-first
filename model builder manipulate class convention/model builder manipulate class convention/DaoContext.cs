using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace model_builder_manipulate_class_convention
{
    public class DaoContext:DbContext
    {
        public DbSet<Student> Students {get; set;}
        public DbSet<StudentAddress> StudentAdresses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentAddress>()
                .HasKey(e => e.StudentId);
            modelBuilder.Entity<Student>()
                .HasOptional(s => s.StudentAddress)
                .WithRequired(address => address.Student);

            /* Manipulate all property that string type to have max lengh 150 */
            modelBuilder.Properties<String>().Configure(s => s.HasMaxLength(150));


        }
    }
}
