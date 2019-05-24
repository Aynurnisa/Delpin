﻿using System;
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

            Console.WriteLine("tryk 1 for at oprette en kunde, tryk 2 for at oprette en reservation, tryk 3 for at se ledige ressourcer");
            string valg = Console.ReadLine();

            if (valg == "1")
            {
                Console.Clear();
                Debitor.OpretKunde();
            }
            if (valg == "2")
            {
                Console.Clear();
                Bestilling.Reserver();
            }
            if (valg == "3")
            {

                Console.Clear(); 

                DBManager dBManager = new DBManager();

                List<AfdRessObj> listRessAfdObj = new List<AfdRessObj>();

                listRessAfdObj = dBManager.FindLedigeResourcerForAfdeling();

                foreach (AfdRessObj obj in listRessAfdObj)
                {
                    Console.WriteLine(obj.Name + "\t" + obj.Pris + "\t" + obj.Adresse + "\t" + obj.PostNr);
                }
            }

            


            Console.ReadKey();
        }
    }
}
