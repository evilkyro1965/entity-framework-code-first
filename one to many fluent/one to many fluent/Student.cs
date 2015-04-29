using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace one_to_many_fluent
{
    public class Student
    {
        public Student() { }

        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int StandardRefId { get; set; }

        public virtual Standard Standard { get; set; }
    }
}
