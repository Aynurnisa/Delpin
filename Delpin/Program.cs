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

            Tilbehoer t = new Tilbehoer();

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
                Console.WriteLine("tryk 7 for at se reservation på tilbehør");
                Console.WriteLine("tryk 8 for at opdatere en reservation på tilbehør");
                Console.WriteLine("tryk 9 for at slette en reservation på et tilbehør");
                Console.WriteLine("tryk 10 for at oprette en reservation på et Ressource");
                Console.WriteLine("tryk 11 for at se reservation på Ressource");
                Console.WriteLine("tryk 12 for at opdatere en reservation på Ressource");
                Console.WriteLine("tryk 13 for at slette en reservation på et Ressource");
                Console.WriteLine("tryk 14 for at lukke ned");
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
                if (valg == "8")
                {
                    Console.Clear();
                    Tilbehoer.UpdaterReservationTilbehoer();
                    Console.ReadKey();

                }
                if (valg == "9")
                {
                    Console.Clear();
                    t.SletReservationTilbehoer();
                    Console.ReadKey();
                }
                if (valg == "10")
                {
                    Console.Clear();
                    Ressource.LavReservationRessourcer();
                    Console.ReadKey();
                }
                if (valg == "11")
                {
                    Console.Clear();
                    Ressource.HentReservationRessourcer();
                    Console.ReadKey();
                }
                if (valg == "12")
                {
                    Console.Clear();
                    Ressource.UpdaterReservationRessourcer();
                    Console.ReadKey();
                }
                if (valg == "13")
                {
                    Console.Clear();
                    Ressource.SletReservationRessourcer();
                    Console.ReadKey();
                }
                if (valg == "14")
                {
                    Environment.Exit(0);
                }
            }



            Console.ReadKey();
        }
    }
}
