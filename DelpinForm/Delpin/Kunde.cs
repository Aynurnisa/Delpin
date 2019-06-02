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
    public partial class Kunde : Form
    {
        public Kunde()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Vil du slette kunden", "Sletning af kunde", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                //slet kunde
            }
            else if (dialogResult == DialogResult.No)
            {
                //gør ingenting
                
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Oversigt oversigt = new Oversigt();
            oversigt.ShowDialog();
        }
    }
}
