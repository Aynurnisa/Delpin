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
        public void OpretKunde(string navn, string adresse, string postnr, string manr, string kundetype, string kundenr)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=den1.mssql7.gear.host; Initial Catalog=delpin1; User Id=delpin1; Password=Ju67eM1Z!?q1";

            SqlCommand sqlCmd = new SqlCommand();

            string OpretKunde = $"insert into v2_Debitor ( Navn, Adresse, Postnr, [By], manr, Kundetype, TLF, Kundenr) " +
            $"values ('{textBox1.Text}', '{textBox2.Text}', {textBox4.Text}, '{textBox3.Text}', {textBox5.Text}, '{textBox6.Text}', {textBox8.Text}, '{textBox7.Text}')";

            SqlCmd.CommandText = OpretKunde;
            
            conn.Open();
            sqlCmd.ExecuteNonQuery();

            conn.Close();
        }

        public static void HentKunde()
        {
            Console.WriteLine("Indtast dnr");
            string dnr = Console.ReadLine();

            SqlDataReader myReader = null;
            string HentKunde = $"select * from v2_Debitor where dnr = '{dnr}'";

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=den1.mssql7.gear.host; Initial Catalog=delpin1; User Id=delpin1; Password=Ju67eM1Z!?q1";
            conn.Open();


            
            SqlCommand com = new SqlCommand();
            com.Connection = conn;
            com.CommandText = HentKunde;

            myReader = com.ExecuteReader();

            while (myReader.Read())
            {
                
                Console.Write(myReader["Navn"].ToString() + ", ");

                Console.Write(myReader["Adresse"].ToString() + ", ");

                Console.Write(myReader["By"].ToString() + ", ");

                Console.Write(myReader["manr"].ToString() + ", ");

                Console.Write(myReader["dnr"].ToString() + ", ");

                Console.Write(myReader["Kundetype"].ToString() + ", ");

                Console.Write(myReader["TLF"].ToString() + ", ");

                Console.Write(myReader["kundenr"].ToString());


            }


            
            conn.Close();
        }

        public static void SletKunde() //Daniel
        {
            Console.WriteLine("Indtast dnr");
            string dnr = Console.ReadLine();

            string SletKunde = $"delete from v2_Debitor where dnr = '{dnr}'";

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=den1.mssql7.gear.host; Initial Catalog=delpin1; User Id=delpin1; Password=Ju67eM1Z!?q1";
            conn.Open();

            SqlCommand com = new SqlCommand();
            com.Connection = conn;
            com.CommandText = SletKunde;
            com.ExecuteNonQuery();
        }

        public static void ÆndreKunde() //Daniel
        {
            Console.WriteLine("Indtast dnr");
            string dnr = Console.ReadLine();

            Console.WriteLine("Indtast Navn");
            string Navn = Console.ReadLine();

            Console.WriteLine("Indtast Adresse");
            string Adresse = Console.ReadLine();

            Console.WriteLine("Indtast Postnr");
            string Postnr = Console.ReadLine();

            Console.WriteLine("Indtast By");
            string By = Console.ReadLine();

            Console.WriteLine("Indtast manr");
            string manr = Console.ReadLine();

            Console.WriteLine("Indtast Kundetype");
            string Kundetype = Console.ReadLine();

            Console.WriteLine("Indtast TLF");
            string TLF = Console.ReadLine();

            Console.WriteLine("Indtast Kundenr");
            string Kundenr = Console.ReadLine();

            string ÆndreKunde = $"Update v2_Debitor " +
                                $"set Navn = '{Navn}'" +
                                $"set Adresse = { Adresse }'"+
                                $"set Postnr= '{Postnr}'" +
                                $"set By= '{By}'" +
                                $"set manr= '{manr}'" +
                                $"set Kundetype = '{Kundetype}'" +
                                $"set TLF= '{TLF}'" +
                                $"set kundenr= '{Kundenr}''" +
                                $" where dnr= '{dnr}'";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=den1.mssql7.gear.host; Initial Catalog=delpin1; User Id=delpin1; Password=Ju67eM1Z!?q1";
            conn.Open();

            SqlCommand com = new SqlCommand();
            com.Connection = conn;
            com.CommandText = ÆndreKunde;
            com.ExecuteNonQuery();

        }

    }
}
