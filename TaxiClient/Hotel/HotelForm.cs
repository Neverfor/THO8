using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaxiClient.HotelService;

namespace TaxiClient
{
    public partial class HotelForm : Form
    {
        public HotelForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           Hotel[] hotels;
             
            using (HotelBookingServiceClient client = new HotelBookingServiceClient())
            {
                String name = null;//textBox1.ToString();
                String location = null;//textBox2.ToString();

                /*
                if (textBox1.ToString() == "" || textBox1.ToString() == null)
                {
                    name = null;
                }
                if (textBox2.ToString() == "" || textBox2.ToString() == null)
                {
                    location = null;
                }
                */
                
                hotels = client.getHotels(name, location);
               // hotels = client.getHotelsAsync(name, location);
                String hotelList = "List of hotels:";
                foreach(Hotel hotel in hotels) 
                {
                    hotelList += "\n" + hotel.Location.ToString() +
                    " " + hotel.Name.ToString();
                }
                MessageBox.Show("The following hotels were found: " + hotelList);

            }
            
        }

        private void flightBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not avaible YET.");
        }

        private void hotelBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            HotelForm hm = new HotelForm();
            hm.Show();
        }

        private void taxiBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            TaxiForm tx = new TaxiForm();
            tx.Show();
        }
    }
}
