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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void flightBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not yet implemented!");
        }

        private void hotelBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.mainPanel.Controls.Clear();
            this.mainPanel.Controls.Add(new Hotel.HotelUC(this));

        }

        private void taxiBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.mainPanel.Controls.Clear();
            this.mainPanel.Controls.Add(new Taxi.TaxiUC(this));
        }
    }
}