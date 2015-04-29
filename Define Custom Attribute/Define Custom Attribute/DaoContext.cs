using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Define_Custom_Attribute
{
    public class DaoContext:DbContext
    {
        public DbSet<Student> Students {get; set;}
        public DbSet<StudentAddress> StudentAdresses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Dimana attribute di gunakan 
            // Attribute pada contoh yaitu setiap Class yg terdapat AttributNamaDatabase
            // Maka class tersebut di letakkan pada tabel dengan nama tabel = nama class
            // Dan schema database sama dengan AttributNamaDatabase
            modelBuilder.Types()
                .Where(x => x.GetCustomAttributes(false).OfType<AttributNamaDatabase>().Any())
                .Configure(
                    c => c.ToTable(c.ClrType.Name, /* Membuat nama tabel sesuai nama class dan custom attribut */
                        (
                            (AttributNamaDatabase)c.ClrType.GetCustomAttributes(false).OfType<AttributNamaDatabase>().Single()
                        ).SchemaName
                    ));

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
