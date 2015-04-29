using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace One_To_Many1
{
    public class Student
    {
        public Student() { }

        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int StandardRefId { get; set; }
        [ForeignKey("StandardRefId")]
        public virtual Standard Standard { get; set; }
    }
}
