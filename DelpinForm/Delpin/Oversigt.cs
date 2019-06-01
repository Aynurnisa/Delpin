using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Delpin
{
    public partial class Oversigt : Form
    {
        private const string username = "User Id=delpin1;";
        private const string server = "Data Source=den1.mssql7.gear.host;";
        private const string pwd = "Password=Ju67eM1Z!?q1";
        private const string db = "Initial Catalog=delpin1;";
        SqlConnection conn = new SqlConnection(server + db + username + pwd);

        private List<RessObj> ressources;
        
        public Oversigt()
        {
            ressources = new List<RessObj>();
            
            InitializeComponent();

            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            listView1.Columns.Add("Navn", 75);
            listView1.Columns.Add("rnr", 50);
            listView1.Columns.Add("Maerke", 150);
            listView1.Columns.Add("Pris", 50);
            listView1.Columns.Add("Adresse", 150);
            listView1.Columns.Add("PostNr", 50);

            PopulateList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] arr = new string[6];

            for(int i = 0; i < ressources.Count; i++) {
                arr[0] = ressources[i].Navn;
                arr[1] = ressources[i].ResNr.ToString();
                arr[2] = ressources[i].Maerke;
                arr[3] = ressources[i].Pris.ToString();
                arr[4] = ressources[i].Adresse;
                arr[5] = ressources[i].PostNr.ToString();

                ListViewItem itm = new ListViewItem(arr);
                listView1.Items.Add(itm);
            }
        }

        private void PopulateList()
        {
            string sqlCmdText = "select r.Navn, r.rnr, r.Maerke, r.Pris, a.Adresse, a.Postnr " +
                         "from v2_Ressourcer r join v2_Afdeling a on not exists" +
                         "(select '' from v2_Reservation_Line_Ressourcer rs where rs.rnr = r.rnr)";

            SqlCommand com = new SqlCommand(sqlCmdText, conn);
            com.Connection.Open();
            SqlDataReader reader = com.ExecuteReader();

            while (reader.Read()) {
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
            com.Connection.Close();
        }
    }
}
