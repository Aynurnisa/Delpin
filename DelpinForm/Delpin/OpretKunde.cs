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
    public partial class OpretKunde : Form
    {
        private Delpin del = new Delpin();

        public OpretKunde()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            //tlf
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //navn 
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // vej
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //psnr
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //by
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            //kundetype
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            //manr
        }
    }
}
