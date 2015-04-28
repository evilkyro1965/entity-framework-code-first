using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace one_to_one2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new DaoContext())
            {
                StudentAddress address = new StudentAddress();
                address.Address1 = "jalan karya kasih";

                Student student = new Student();
                student.StudentName = "fahrur";
                student.StudentAddress = address;
                context.Students.Add(student);
                context.SaveChanges();
            }
            Console.ReadKey();
        }
    }
}
