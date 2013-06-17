using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxiClient
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void flightBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not yet implemented!");
        }

        private void hotelBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            HotelForm hm = new HotelForm();
            hm.Show();
        }

        private void taxiBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            TaxiForm tx = new TaxiForm();
            tx.Show();
        }
    }
}
