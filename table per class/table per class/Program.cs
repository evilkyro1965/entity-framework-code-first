using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace table_per_class
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new DaoContext();

            Lodging lodging = new Lodging();
            lodging.Name = "Lodge1";
            lodging.Owner = "Fahrur";

            Resort resort = new Resort();
            resort.Name = "resort1";
            resort.Owner = "fahrur";
            resort.Activities = "golf";
            resort.Entertainment = "spa";

            context.Lodgings.Add(lodging);
            context.Resorts.Add(resort);
            context.SaveChanges();

            Console.ReadKey();
        }
    }
}
