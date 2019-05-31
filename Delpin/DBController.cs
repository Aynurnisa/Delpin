using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delpin
{
    class DBController
    {
        DBManager connection = new DBManager();
        public List<ReservationLine> reservationLines = new List<ReservationLine>();
        public List<Ressource> ressources = new List<Ressource>();

        public void HentLedigRessourcer(){

            ressources = connection.FindAlleFrieRessourcer;

        }


    }
}
