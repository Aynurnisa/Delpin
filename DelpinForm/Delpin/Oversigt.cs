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
        
        private List<RessObj> ressources;
        
        public Oversigt()
        {
            ressources = new List<RessObj>();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            listView1.Columns.Add("Navn", 50);
            listView1.Columns.Add("rnr", 50);
            listView1.Columns.Add("Maerke", 50);
            listView1.Columns.Add("Pris", 50);
            listView1.Columns.Add("Adresse", 50);
            listView1.Columns.Add("PostNr", 50);

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=den1.mssql7.gear.host; Initial Catalog=delpin1; User Id=delpin1; Password=Ju67eM1Z!?q1";

            string sql = "select r.Navn, r.rnr, r.Maerke, r.Pris, a.Adresse, a.Postnr " +
                         "from v2_Ressourcer r join v2_Afdeling a on not exists" +
                         "(select '' from v2_Reservation_Line_Ressourcer rs where rs.rnr = r.rnr)";

            SqlCommand com = new SqlCommand(sql,conn);
            com.Connection.Open();
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
            com.Connection.Close();

            
            
                string[] stringArr = new string[5];
                stringArr[0] = "does";
                stringArr[1] = "this";
                stringArr[2] = "work";
                stringArr[3] = "?";
                stringArr[4] = "F";
                stringArr[5] = "G";
                ListViewItem itm = new ListViewItem();
            
            
                listView1.Items.Add(itm);
                
        }

        private void PrintElements(List<RessObj> res)
        {
            foreach (RessObj elm in res) {
                Console.WriteLine("Elements in List "+"\t"+ elm.Navn +"\t"+ elm.PostNr);
            }
        }
    }
}
