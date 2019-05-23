using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Afdeling
    {
        int _Anr;
        string _Adresse;
        int _Postnr;

        public Afdeling(string adresse, int postnr)
        {
            _Anr = anr;
            _Adresse = adresse;
            _Postnr = postnr;
        }

        public int anr
        {
            get { return _Anr; }
        }

        public string adresse
        {
            get { return _Adresse; }
        }

        public int postnr{
            get { return _Postnr; }
        }
        


    }
}
