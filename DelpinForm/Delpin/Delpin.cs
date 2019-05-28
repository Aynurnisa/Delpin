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
    public partial class Delpin : Form
    {
        public Delpin()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }


        //
        private void button3_Click(object sender, EventArgs e)
        {
            updateRes reservering = new updateRes();
            reservering.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        //booking
        private void button1_Click(object sender, EventArgs e)
        {
            Booking booking = new Booking();
            booking.ShowDialog();
        }

        //kunde klap
        private void button2_Click(object sender, EventArgs e)
        {
            Kunde kunde = new Kunde();
            kunde.ShowDialog();
        }
    }
}
