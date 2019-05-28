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
        public static void Main(string[] args)
        {
            
            
                 
            Console.WriteLine("Velkommen, tryk enter for at fortsætte...");
            Console.ReadKey();
            Console.Clear();
            for (int i = 0; i != 10; i++)
            {
                Console.Clear();
                Console.WriteLine("tryk 1 for at oprette en kunde, ");
                Console.WriteLine("tryk 2 for at se ledige ressourcer, ");
                Console.WriteLine("tryk 3 for at finde en kunde, ");
                Console.WriteLine("tryk 4 for at slette kunde, ");
                Console.WriteLine("tryk 5 for at ændre kunde, ");
                Console.WriteLine("tryk 6 for at oprette en reservation på et tilbehør");
                Console.WriteLine("tryk 7 for at se reservation ");
                Console.WriteLine("tryk 10 for at lukke ned");
                string valg = Console.ReadLine();

                if (valg == "1")
                {
                    Console.Clear();
                    Debitor.OpretKunde();
                    Console.ReadKey();
                }
                if (valg == "2")
                {

                    Console.Clear();

                    DBManager dBManager = new DBManager();

                    List<AfdRessObj> listRessAfdObj = new List<AfdRessObj>();

                    listRessAfdObj = dBManager.FindLedigeResourcerForAfdeling();

                    foreach (AfdRessObj obj in listRessAfdObj)
                    {
                        Console.WriteLine(obj.Name + "\t" + obj.Pris + "\t" + obj.Adresse + "\t" + obj.PostNr);
                    }
                    Console.ReadKey();
                }
                if (valg == "3")
                {
                    Console.Clear();
                    Debitor.HentKunde();
                    Console.ReadKey();
                }
                if (valg == "4")
                {
                    Console.Clear();
                    Debitor.SletKunde();
                    Console.ReadKey();
                }
                if (valg == "5")
                {
                    Console.Clear();
                    Debitor.ÆndreKunde();
                    Console.ReadKey();
                }
                if (valg == "6")
                {
                    Console.Clear();
                    Tilbehoer.LavReservationTilbehoer();
                    Console.ReadKey();
                }
                if (valg == "7")
                {
                    Console.Clear();
                    Tilbehoer.HentReservationTilbehoer();
                    Console.ReadKey();
                }
                if (valg == "10")
                {
                    Environment.Exit(0);
                }
            }

            Console.ReadKey();
            
        }
    }
}
