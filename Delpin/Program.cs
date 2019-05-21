using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Delpin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Velkommen, tryk enter for at fortsætte...");

            Console.ReadKey();
            Console.Clear();

            Bestilling.Reserver();
           

            Console.ReadKey();
        }
    }
}
