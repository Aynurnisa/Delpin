using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delpin
{
    public partial class Booking : Form
    {
        public Booking()
        {
            InitializeComponent();
            dateTimePicker1.MinDate = DateTime.Today;
            dateTimePicker2.MinDate = DateTime.Today;
        }

        private void button2_Click(object sender, EventArgs e)
        {
                    }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Booking_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        private void dateTimePicker1_dropdown(object sender, EventArgs e)
        {
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if(dateTimePicker2.Value <= dateTimePicker1.Value)
            {
                string beforeStart = "Slutdatoen skal være efter den valgte startdato";
                MessageBox.Show(beforeStart);
                dateTimePicker2.Value = DateTime.Now;
            }


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void ListView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
