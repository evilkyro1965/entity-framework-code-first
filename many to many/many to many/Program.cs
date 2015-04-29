using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace many_to_many
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new DaoContext();

            Student student = new Student();
            student.StudentName = "fahrur";

            Course course = new Course();
            course.CourseName = "programming java";

            course.Students.Add(student);

            context.Courses.Add(course);
            context.SaveChanges();
        }
    }
}
