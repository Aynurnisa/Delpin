using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Delpin
{
    class Tilbehoer
    {
        //Daniel
        public void SletReservationTilbehoer() //delete
        {
            Console.WriteLine("Indtast ResNr");
            string ResNr = Console.ReadLine();

            string SletReservationTilbehoer = $"delete from v2_Reservation_Line_Tilbehoer where ResNr = '{ResNr}'";

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=den1.mssql7.gear.host; Initial Catalog=delpin1; User Id=delpin1; Password=Ju67eM1Z!?q1";
            conn.Open();

            SqlCommand com = new SqlCommand();
            com.Connection = conn;
            com.CommandText = SletReservationTilbehoer;
            com.ExecuteNonQuery();
        }
        public static void HentReservationTilbehoer() //read
        {
            Console.WriteLine("Indtast ResNr");
            string ResNr = Console.ReadLine();

            SqlDataReader myReader = null;
            string HentReservationTilbehoer = $"select * from v2_Reservation_Line_Tilbehoer where ResNr = '{ResNr}'";

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=den1.mssql7.gear.host; Initial Catalog=delpin1; User Id=delpin1; Password=Ju67eM1Z!?q1";
            conn.Open();

            SqlCommand com = new SqlCommand();
            com.Connection = conn;
            com.CommandText = HentReservationTilbehoer;
            myReader = com.ExecuteReader();

            while (myReader.Read())
            {

                Console.Write(myReader["ResNr"].ToString() + ", ");

                Console.Write(myReader["OrderStart"].ToString() + ", ");

                Console.Write(myReader["OrderSlut"].ToString() + ", ");

                Console.Write(myReader["Total"].ToString() + ", ");

                Console.Write(myReader["Afsluttet"].ToString() + ", ");

                Console.Write(myReader["tnr"].ToString() + ", ");

                Console.Write(myReader["Book_ID"].ToString());


            }

            conn.Close();
        }
        public static void UpdaterReservationTilbehoer() //update
        {

            Console.WriteLine("Indtast ResNr");
            string ResNr = Console.ReadLine();
            Console.WriteLine("Indtast Dato Start");
            string OrderStart = Console.ReadLine();
            Console.WriteLine("Indtast Dato Slut");
            string Orderslut = Console.ReadLine();
            Console.WriteLine("Indtast pris");
            string total = Console.ReadLine();
            Console.WriteLine("Indtast Afsluttet J/N");
            string Afsluttet = Console.ReadLine();
            Console.WriteLine("Indtast tnr");
            string tnr = Console.ReadLine();
            Console.WriteLine("Indtast Booking ID");
            String Book_ID2 = Console.ReadLine();

            string UpdaterReservationTilbehoer = $"Update v2_Reservation_Line_Tilbehoer" +
                $"set OrderStart= '{OrderStart}" +
                $"set Orderslut= '{Orderslut}" +
                $"set total= '{total}" +
                $"set Afsluttet= '{Afsluttet}" +
                $"set tnr= '{tnr}" +
                $"set Book_ID2= '{Book_ID2}" +
                $" where ResNr = '{ResNr}'";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=den1.mssql7.gear.host; Initial Catalog=delpin1; User Id=delpin1; Password=Ju67eM1Z!?q1";
            conn.Open();

            SqlCommand com = new SqlCommand();
            com.Connection = conn;
            com.CommandText = UpdaterReservationTilbehoer;
            com.ExecuteNonQuery();
        }

        public static void LavReservationResourcer() //create
        {
            Console.WriteLine("indtast startdatoen på tilbehøret du vil bestille");
            string OrderStart = Console.ReadLine();

            Console.WriteLine("indtast slutdatoen på tilbehøret du vil bestille");
            string Orderslut = Console.ReadLine();

            Console.WriteLine("indtast TotalPrisen på tilbehøret du vil bestille");
            string Total = Console.ReadLine();

            Console.WriteLine("indtast tilbehoersnummer på tilbehoeret du vil bestille");
            string tnr = Console.ReadLine();

            Console.WriteLine("indtast Booking ID");
            string Book_ID = Console.ReadLine();

            string InsertReservationTilbehoer = $"insert into v2_Reservation_Line_Tilbehoer ( Orderstart, Orderslut, Total, tnr, rnr, dnr) " +
                $"values ('{OrderStart}', '{Orderslut}', '{Total}', '{tnr}', '{Book_ID}')";

            Console.WriteLine(InsertReservationTilbehoer);
            Console.ReadKey();

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=den1.mssql7.gear.host; Initial Catalog=delpin1; User Id=delpin1; Password=Ju67eM1Z!?q1";
            conn.Open();

            SqlCommand com = new SqlCommand();
            com.Connection = conn;
            com.CommandText = InsertReservationTilbehoer;
            com.ExecuteNonQuery();

            conn.Close();

        }

    }
}
