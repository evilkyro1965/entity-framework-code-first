using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace table_per_hierarchy2
{
    class DaoContext : DbContext
    {
        public DbSet<Resort> Resorts { get; set; }
        public DbSet<Lodging> Lodgings { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Lodging>()
                .Map(m =>
                {
                    m.ToTable("Lodgings");
                    m.Requires("LodgingType").HasValue("Standard");
                })
                .Map<Resort>(m =>
                {
                    m.Requires("LodgingType").HasValue("Resort");
                });
        }
    }
}
