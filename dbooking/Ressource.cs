using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Ressource
    {
        private string _Navn;
        private int _Rnr;
        private int _Aargang;
        private string _Maerke;
        private double _Pris;
        private int _Anr;

        public Ressource(string navn, int rnr, int aagang, string maerke, double pris, int anr)
        {
            _Navn = navn;
            _Rnr = rnr;
            _Aargang = aagang;
            _Maerke = maerke;
            _Pris = pris;
            _Anr = anr;
        }

        public string Navn
        {
            get
            {
                return _Navn;
            }
        }

        public int Aargang
        {
            get
            {
                return _Aargang;
            }
        }

        public string Maerke
        {
            get
            {
                return _Maerke;
            }
        }

        public double Pris
        {
            get
            {
                return _Pris;
            }
        }

        public int Anr
        {
            get
            {
                return _Anr;
            }
        }
    }
}
