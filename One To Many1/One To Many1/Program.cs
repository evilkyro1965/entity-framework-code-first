using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace One_To_Many1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.StudentName = "fahrur";

            Standard standard = new Standard();
            standard.Description = "Standard1";
            standard.Students.Add(student);

            var context = new DaoContext();
            context.Standards.Add(standard);
            context.SaveChanges();
        }
    }
}
