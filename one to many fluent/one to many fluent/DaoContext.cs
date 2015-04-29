using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace one_to_many_fluent
{
    public class DaoContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Standard> Standards { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Standard>()
                .HasMany<Student>(s => s.Students)
                .WithRequired(s => s.Standard)
                .HasForeignKey(s => s.StandardRefId);
        }

    }
}
