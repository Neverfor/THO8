﻿using System;
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
            
            Hotel hotel = new Hotel();
            Hotel[] hotels;
             
            using (HotelBookingServiceClient client = new HotelBookingServiceClient())
            {
                String name = "";
                String location = "";
                
                hotels = client.getHotels(name, location);

                MessageBox.Show("The following hotels were found: " + hotels.ToString());

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