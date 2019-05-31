using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delpin
{
    class RessObj
    {
        private string navn;
        private int resNr;
        private string maerke;
        private int pris;
        private string adresse;
        private int postNr;

        public RessObj(string navn, int resNr, string maerke, int pris, string adresse, int postNr)
        {
            this.navn = navn;
            this.resNr = resNr;
            this.maerke = maerke;
            this.pris = pris;
            this.adresse = adresse;
            this.postNr = postNr;
        }

        public string Navn
        {
            get { return navn; }
        }

        public int ResNr
        {
            get { return resNr; }
        }

        public string Maerke
        {
            get { return maerke; }
        }

        public int Pris
        {

            get { return pris; }
        }

        public string Adresse
        {

            get { return adresse; }

        }

        public int PostNr
        {

            get { return postNr; }

        }
    }
}
