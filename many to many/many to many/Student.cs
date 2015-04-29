using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace many_to_many
{
    public class Student
    {
        public Student() { }

        public int StudentId { get; set; }

        public string StudentName { get; set; }

        public int StandardId { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}
