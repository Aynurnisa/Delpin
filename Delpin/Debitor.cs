using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Delpin
{
    class Debitor
    {
        public static void OpretKunde()
        {
            Console.WriteLine("indtast dit navn");
            string navn = Console.ReadLine();

            Console.WriteLine("indtast din adresse");
            string adresse = Console.ReadLine();

            Console.WriteLine("indtast postnr");
            string postnr = Console.ReadLine();

            Console.WriteLine("indtast medarbejdernr");
            string manr = Console.ReadLine();

            Console.WriteLine("indtast kundetype ( e for erhverv eller p for privat");
            string kundetype = Console.ReadLine();

            Console.WriteLine("indtast CVR eller CPR nummer");
            string kundenr = Console.ReadLine();

            string OpretKunde = $"insert into Debitor ( Navn, Adresse, Postnr, manr, Kundetype, Kundenr) " +
                $"values ('{navn}', '{adresse}', '{postnr}', '{manr}', '{kundetype}', '{kundenr}')";



            Console.WriteLine(OpretKunde);
            Console.ReadKey();

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=den1.mssql7.gear.host; Initial Catalog=delpin1; User Id=delpin1; Password=Ju67eM1Z!?q1";
            conn.Open();

            SqlCommand com = new SqlCommand();
            com.Connection = conn;
            com.CommandText = OpretKunde;
            com.ExecuteNonQuery();

            conn.Close();
        }
    }
}
