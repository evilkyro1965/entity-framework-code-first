﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mysql
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new DaoContext();

            User user = new User();
            user.username = "fahrur";
            user.password = "drowssap";
            context.Users.Add(user);
            context.SaveChanges();

            Console.ReadKey();
        }
    }
}
