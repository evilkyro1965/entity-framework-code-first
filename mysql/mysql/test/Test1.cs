using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using mysql;

namespace test
{
    [TestFixture]
    public class Test1
    {
        [Test]
        public void test1()
        {
            var context = new DaoContext();

            User user = new User();
            user.username = "fahrur";
            user.password = "drowssap";
            context.Users.Add(user);
            context.SaveChanges();
        }

    }
}
