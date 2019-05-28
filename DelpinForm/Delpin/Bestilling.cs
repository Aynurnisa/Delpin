using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Delpin
{
    class Bestilling
    {
        public static void Reserver()
        {
            Console.WriteLine("indtast startdatoen på ressourcen du vil bestille");
            string ordrestart = Console.ReadLine();

            Console.WriteLine("indtast slutdatoen på ressourcen du vil bestille");
            string ordreslut = Console.ReadLine();

            Console.WriteLine("indtast TotalPrisen på ressourcen du vil bestille");
            string Total = Console.ReadLine();

            Console.WriteLine("indtast Tilbehørnummeret på ressourcen du vil bestille");
            string Tnr = Console.ReadLine();

            Console.WriteLine("indtast ressourcenummer på ressourcen du vil bestille");
            string rnr = Console.ReadLine();

            Console.WriteLine("indtast debitornummer");
            string dnr = Console.ReadLine();

            string InsertReservation = $"insert into Reserveret ( Orderstart, Orderslut, Total, tnr, rnr, dnr) " +
                $"values ('{ordrestart}', '{ordreslut}', '{Total}', '{Tnr}', '{rnr}', '{dnr}')";



            Console.WriteLine(InsertReservation);
            Console.ReadKey();

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=den1.mssql7.gear.host; Initial Catalog=delpin1; User Id=delpin1; Password=Ju67eM1Z!?q1";
            conn.Open();

            SqlCommand com = new SqlCommand();
            com.Connection = conn;
            com.CommandText = InsertReservation;
            com.ExecuteNonQuery();

            conn.Close();
        }

    }
}
