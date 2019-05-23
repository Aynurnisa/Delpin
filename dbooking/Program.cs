using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            DBmanager dBManager = new DBmanager();

            List<AfdRessObj> listRessAfdObj = new List<AfdRessObj>();
            listRessAfdObj =  dBManager.FindLedigeResourcerForAfdeling();
            foreach (AfdRessObj obj in listRessAfdObj)
            {
                Console.WriteLine(obj.Name + "\t" + obj.Pris + "\t" + obj.Adresse + "\t" + obj.PostNr);
            }
        }
    }
}
