using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace convention_custom_class
{
    [AttributNamaDatabase("School")]
    public class Student
    {
        public Student() { }

        public int StudentId { get; set; }
        public string StudentName { get; set; }

        public virtual StudentAddress StudentAddress { get; set; }
    }
}
