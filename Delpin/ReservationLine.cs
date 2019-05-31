using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delpin
{
    class ReservationLine
    {
        private int _ResNr;
        private DateTime _OrderStart;
        private DateTime _OrderSlut;
        private double _TotalPris;
        private int _Debitornr;
        private int _Ressourcenr;
        public ReservationLine(int ResNr, DateTime orderstart, DateTime orderSlut, double totalpris, int debitornr, int resourcenr)
        {
            _ResNr = ResNr;
            _OrderStart = orderstart;
            _OrderSlut = orderSlut;
            _TotalPris = totalpris;
            _Debitornr = debitornr;
            _Ressourcenr = resourcenr;
        }
        public int ResNr
        {
            get
            {
                return _ResNr;
            }
        }
        public DateTime Orderstart
        {
            get
            {
                return _OrderStart;
            }
        }

        public DateTime Orderslut
        {
            get
            {
                return _OrderSlut;
            }
        }

        public double Totalpris
        {
            get
            {
                return _TotalPris;



            }



        }







        public int Tilbehornr



        {





        }







        public int Debitornr



        {



            get



            {



                return _Debitornr;



            }



        }







        public int Resoursenr
        {



            get



            {
                return _Ressourcenr;
            }

        }
    }
}
