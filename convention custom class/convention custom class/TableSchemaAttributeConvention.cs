using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Infrastructure.Pluralization;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace convention_custom_class
{
    public class TableSchemaAttributeConvention : Convention
    {
        public TableSchemaAttributeConvention()
        {
            Types()
                .Where(x => x.GetCustomAttributes(false).OfType<AttributNamaDatabase>().Any())
                .Configure(
                    c => c.ToTable(c.ClrType.Name, /* Membuat nama tabel sesuai nama class dan custom attribut */
                        (
                            (AttributNamaDatabase)c.ClrType.GetCustomAttributes(false).OfType<AttributNamaDatabase>().Single()
                        ).SchemaName
                    ));
        }
    }
}
