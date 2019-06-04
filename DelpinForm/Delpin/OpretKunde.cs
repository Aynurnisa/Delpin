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
    public partial class OpretKunde : Form
    {
        private const string username = "User Id=delpin1;";
        private const string server = "Data Source=den1.mssql7.gear.host;";
        private const string pwd = "Password=Ju67eM1Z!?q1";
        private const string db = "Initial Catalog=delpin1;";
        SqlConnection conn = new SqlConnection(server + db + username + pwd);

        public OpretKunde()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlCmdText = $"insert into v2_Debitor ( Navn, Adresse, Postnr, [By], manr, Kundetype, TLF, Kundenr) " +
            $"values ('{textBox1.Text}'," +
                   $" '{textBox2.Text}'," +
                   $" {textBox4.Text}," +
                   $" '{textBox3.Text}'," +
                   $" {textBox5.Text}," +
                   $" '{textBox6.Text}'," +
                   $" {textBox8.Text}," +
                   $" '{textBox7.Text}')";

            SqlCommand com = new SqlCommand(sqlCmdText, conn);
            com.Connection.Open();
            com.ExecuteNonQuery();
            com.Connection.Close();

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
        }
        
    }
}
