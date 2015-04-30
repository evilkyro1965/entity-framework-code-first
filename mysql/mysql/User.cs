using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mysql
{
    [Table("user")]
    public class User
    {
        [Key]
        public int id { get; set; }
        public String username { get; set; }
        public String password { get; set; }

    }
}
