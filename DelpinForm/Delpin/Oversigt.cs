using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Delpin
{
    public partial class Oversigt : Form
    {
        private const string username = "user id = delpin1;";
        private const string server = "server = den1.mssql7.gear.host;";
        private const string pwd = "password=Ju67eM1Z!?q1;";
        private const string db = "database = delpin1;";
        private SqlConnection conn = new SqlConnection(server + db + username + pwd);
        private List<RessObj> ressources;
        
        public Oversigt()
        {
            ressources = new List<RessObj>();

            SqlCommand com = new SqlCommand();

            string sql = "select r.Navn, r.rnr, r.Maerke, r.Pris, a.Adresse, a.Postnr " +
                         "from v2_Ressourcer r join v2_Afdeling a on not exists" +
                         "(select '' from v2_Reservation_Line_Ressourcer rs where rs.rnr = r.rnr)";

            com.CommandText = sql;
            conn.Open();
            SqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {
                ressources.Add(
                    new RessObj(
                    Convert.ToString(reader["Navn"]),
                    Convert.ToInt32(reader["rnr"]),
                    Convert.ToString(reader["Maerke"]),
                    Convert.ToInt32(reader["Pris"]),
                    Convert.ToString(reader["Adresse"]),
                    Convert.ToInt16(reader["Postnr"])
                    ));
            }

            reader.Close();
            conn.Close();

            InitializeComponent();
        }

        private void Oversigt_Load()
        {

            listView1.Columns.Add("Navn");
            listView1.Columns.Add("rnr");
            listView1.Columns.Add("Maerke");
            listView1.Columns.Add("Pris");
            listView1.Columns.Add("Adresse");
            listView1.Columns.Add("PostNr");
            ListViewItem itm;
            string[] stringArr = new string[5];

            for (int i = 0; i <= 5; i++)
            {
                stringArr[i] = ressources[0].Name;
                stringArr[i] = ressources[1].ResNr.ToString();
                stringArr[i] = ressources[2].Maerke;
                stringArr[i] = ressources[3].Pris.ToString();
                stringArr[i] = ressources[4].Adresse;
                stringArr[i] = ressources[5].PostNr.ToString();
                itm = new ListViewItem(stringArr);
                listView1.Items.Add(itm);
            }

        }
    }
}
