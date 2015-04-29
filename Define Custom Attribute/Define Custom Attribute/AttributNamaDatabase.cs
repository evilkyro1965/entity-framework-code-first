using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Define_Custom_Attribute
{
    [AttributeUsage(AttributeTargets.Class,AllowMultiple=false)]
    class AttributNamaDatabase:Attribute
    {
        public string SchemaName { get; set; }
        public AttributNamaDatabase(string schemaName)
        {
            SchemaName = schemaName;
        }
    }
}
