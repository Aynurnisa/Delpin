using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Delpin
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

        public int Rnr
        {

            get
            {
                return _Rnr;
            }
        }

        public static void LavReservationRessourcer() //create
        {
            Console.WriteLine("indtast startdatoen på ressourcen du vil bestille");
            string OrderStart = Console.ReadLine();

            Console.WriteLine("indtast slutdatoen på ressourcen du vil bestille");
            string Orderslut = Console.ReadLine();

            Console.WriteLine("indtast TotalPrisen på ressourcen du vil bestille");
            string Total = Console.ReadLine();

            Console.WriteLine("indtast Ressourcersnummer på ressourcen du vil bestille");
            string rnr = Console.ReadLine();

            Console.WriteLine("indtast Booking ID");
            string Book_ID = Console.ReadLine();

            string InsertReservationRessourcer = $"insert into v2_Reservation_Line_Ressourcer ( Orderstart, Orderslut, Total, rnr, Book_ID) " +
                $"values ('{OrderStart}', '{Orderslut}', '{Total}', '{rnr}', '{Book_ID}')";

            Console.WriteLine(InsertReservationRessourcer);
            Console.ReadKey();

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=den1.mssql7.gear.host; Initial Catalog=delpin1; User Id=delpin1; Password=Ju67eM1Z!?q1";
            conn.Open();

            SqlCommand com = new SqlCommand();
            com.Connection = conn;
            com.CommandText = InsertReservationRessourcer;
            com.ExecuteNonQuery();

            conn.Close();

        }

        public static void HentReservationRessourcer() //read
        {
            Console.WriteLine("Indtast Book_ID");
            string Book_ID = Console.ReadLine();

            SqlDataReader myReader = null;
            string HentReservationRessourcer = $"select * from v2_Reservation_Line_Ressourcer where Book_ID = '{Book_ID}'";

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=den1.mssql7.gear.host; Initial Catalog=delpin1; User Id=delpin1; Password=Ju67eM1Z!?q1";
            conn.Open();

            SqlCommand com = new SqlCommand();
            com.Connection = conn;
            com.CommandText = HentReservationRessourcer;
            myReader = com.ExecuteReader();

            while (myReader.Read())
            {

                Console.Write(myReader["ResNr"].ToString() + ", ");

                Console.Write(myReader["OrderStart"].ToString() + ", ");

                Console.Write(myReader["OrderSlut"].ToString() + ", ");

                Console.Write(myReader["Total"].ToString() + ", ");

                Console.Write(myReader["rnr"].ToString() + ", ");

                Console.Write(myReader["Book_ID"].ToString());


            }

            conn.Close();


        }

        public static void UpdaterReservationRessourcer() //update
        {

            Console.WriteLine("Indtast ResNr");
            string ResNr = Console.ReadLine();
            Console.WriteLine("Indtast Dato Start");
            string OrderStart = Console.ReadLine();
            Console.WriteLine("Indtast Dato Slut");
            string Orderslut = Console.ReadLine();
            Console.WriteLine("Indtast pris");
            string total = Console.ReadLine();
            //Console.WriteLine("Indtast Afsluttet J/N");
            //string Afsluttet = Console.ReadLine();
            Console.WriteLine("Indtast rnr");
            string rnr = Console.ReadLine();
            Console.WriteLine("Indtast Booking ID");
            string Book_ID = Console.ReadLine();


            string UpdaterReservationRessourcer = $"Update v2_Reservation_Line_Ressourcer " +
                $"set OrderStart = '{OrderStart}', " +
                $"Orderslut = '{Orderslut}', " +
                $"total = '{total}', " +
                //$"Afsluttet= '{Afsluttet}', " +
                $"rnr = '{rnr}', " +
                $"Book_ID = '{Book_ID}' " +
                $"where ResNr = '{ResNr}'";

            Console.WriteLine(UpdaterReservationRessourcer);
            Console.ReadKey();

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=den1.mssql7.gear.host; Initial Catalog=delpin1; User Id=delpin1; Password=Ju67eM1Z!?q1";
            conn.Open();

            SqlCommand com = new SqlCommand();
            com.Connection = conn;
            com.CommandText = UpdaterReservationRessourcer;
            com.ExecuteNonQuery();
        }


        public static void SletReservationRessourcer() //delete
        {
            Console.WriteLine("Indtast ResNr");
            string ResNr = Console.ReadLine();

            string SletReservationRessourcer = $"delete from v2_Reservation_Line_Ressourcer " +
                $"where ResNr = '{ResNr}'";
            Console.WriteLine(SletReservationRessourcer);
            Console.ReadKey();

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=den1.mssql7.gear.host; Initial Catalog=delpin1; User Id=delpin1; Password=Ju67eM1Z!?q1";
            conn.Open();

            SqlCommand com = new SqlCommand();
            com.Connection = conn;
            com.CommandText = SletReservationRessourcer;
            com.ExecuteNonQuery();
        }


    }
}
