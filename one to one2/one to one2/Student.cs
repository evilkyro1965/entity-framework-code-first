using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace one_to_one2
{
    class Student
    {
        public Student() { }

        public int StudentId { get; set; }
        public string StudentName { get; set; }

        [ForeignKey("StudentAddressId")]
        public virtual StudentAddress StudentAddress { get; set; }
        public int StudentAddressId { get; set; }
    }
}
