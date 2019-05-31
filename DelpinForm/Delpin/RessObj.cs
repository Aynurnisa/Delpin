using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delpin
{
    class RessObj
    {
        private string name;
        private int resNr;
        private string maerke;
        private int pris;
        private string adresse;
        private int postNr;

        public RessObj(string _name, int _resNr, string _maerke, int _pris, string _adresse, int _postNr)
        {
            name = _name;
            resNr = _resNr;
            maerke = _maerke;
            pris = _pris;
            adresse = _adresse;
            postNr = _postNr;
        }

        public string Name
        {
            get { return name; }
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
