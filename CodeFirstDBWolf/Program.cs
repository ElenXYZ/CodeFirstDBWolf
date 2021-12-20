using DAL2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDBWolf
{
    class Program
    {
        static void Main(string[] args)
        {

            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                var result = db.Database.CreateIfNotExists();
                Console.WriteLine(String.Format("Db is {0}created.",result ? "":"not "));
                Console.ReadLine();
            }
        }
    }
}
