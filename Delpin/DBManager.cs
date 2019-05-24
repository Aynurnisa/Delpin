using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Delpin
{
    class DBManager
    {
        private const string username = "user id = delpin1;";
        private const string server = "server = den1.mssql7.gear.host;";
        private const string pwd = "password=Ju67eM1Z!?q1;";
        private const string db = "database = delpin1;";

        SqlConnection conn = new SqlConnection(server + db + username + pwd);

        //Finder alle frie resourcer med mulig for at tilføre en string med sql
        //startdate: hvornår man have ressourcen
        //slutdate: hvornår man formoder man er færdig med ressourcen
        //opt : whereString mulighed for at tilføre mere sql.



        public List<Ressource> FindAlleFrieRessourcer(string startdate, string slutdate, string whereString = null)
        {

            conn.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = conn;

            string sql = "Select * from ressourcer " +
                "where not exists (select '' reserveret " +
                "where '" + startdate + "' <= reserveret.Orderslut " +
                "and '" + slutdate + "' >= reserveret.Orderstart " +
                "and reserveret.rnr = ressourcer.rnr) " + whereString;

            com.CommandText = sql;

            List<Ressource> ressources = new List<Ressource>();
            SqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {
                //string navn, int rnr, int aagang, string maerke, double pris, int anr

                Ressource r = new Ressource(
                    Convert.ToString(reader["Navn"]),
                    Convert.ToInt32(reader["rnr"]),
                    Convert.ToInt32(reader["Aagang"]),
                    Convert.ToString(reader["Maerke"]),
                    Convert.ToDouble(reader["Pris"]),
                    Convert.ToInt32(reader["anr"])
                );
                ressources.Add(r);
            }

            reader.Close();
            conn.Close();
            return ressources;
        }

        public void updateReservering(string Navn, int rnr, int Aargang, string Maerke, int Pris, int anr)
        {
            conn.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = conn;

            //string navn, int rnr, int aagang, string maerke, double pris, int anr

            string sql = "update Reserveret " +
                        "set" +
                            " Navn = " + Navn +
                            " Aagang = " + Aargang +
                            " Maerke = " + Maerke +
                            " Pris = " + Pris +
                            " anr = " + anr +
                        " Where rnr =" + rnr;



            com.CommandText = sql;
            com.ExecuteNonQuery();
            conn.Close();
        }







        public void deleteReservering(string Navn, int rnr, int Aargang, string Maerke, int Pris, int anr)
        {



            conn.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = conn;

            //string navn, int rnr, int aagang, string maerke, double pris, int anr

            string sql = "delete reserveret where rnr"; 

            com.CommandText = sql;
            com.ExecuteNonQuery();
            conn.Close();

        }

        public void updateReservering(string Navn, int rnr, int Aargang, string Maerke, int Pris, int anr)
        {
            conn.Open();

            SqlCommand com = new SqlCommand();
            com.Connection = conn;

            //string navn, int rnr, int aagang, string maerke, double pris, int anr

            string sql = "update Reserveret " +
                        "set" +
                            " Navn = " + Navn +
                            " Aagang = " + Aargang +
                            " Maerke = " + Maerke +
                            " Pris = " + Pris +
                            " anr = " + anr +
                        " Where rnr =" + rnr;
            com.CommandText = sql;
            com.ExecuteNonQuery();
            conn.Close();

        }

        public List<AfdRessObj> FindLedigeResourcerForAfdeling()
        {
            conn.Open();
            
            SqlCommand com = new SqlCommand();
            com.Connection = conn;
            
            string sql = "select r.Navn, r.rnr, r.Maerke, r.Pris, a.Adresse, a.Postnr " +
                         "from Ressourcer r join Afdeling a on not exists" +
                         "(select '' from reserveret rs where rs.rnr = r.rnr)";
            
            com.CommandText = sql;
            
            List<AfdRessObj> ressources = new List<AfdRessObj>();
            
            SqlDataReader reader = com.ExecuteReader();

            
            while (reader.Read())
                
            {
                ressources.Add(

                    new AfdRessObj(
                    Convert.ToString(reader["Navn"]),
                    Convert.ToInt32(reader["rnr"]),
                    Convert.ToString(reader["Maerke"]),
                    Convert.ToInt32(reader["Pris"]),
                    Convert.ToString(reader["Adresse"]),
                    Convert.ToInt16(reader["Postnr"])
                    
                                    )
                                );
                
            }
            
            reader.Close();
            conn.Close();
            return ressources;
        }
    }
}
