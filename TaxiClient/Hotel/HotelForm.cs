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
                // Hotels: Barcelona Blaza en Barcelona Caledonian
                
                hotels = client.getHotels(name, location);
                comboBox1.Items.Clear();
                foreach (Hotel hot in hotels)
                {
                    comboBox1.Items.Add("[" + hot.Name + "] in " + hot.Location);
                }

                comboBox1.DisplayMember = "Name";
                comboBox1.ValueMember = "HotelId";
                comboBox1.Visible = true;

                /*
                String hotelList = "List of hotels:";
                foreach(Hotel hotel in hotels) 
                {
                    hotelList += "\n" + hotel.Location.ToString() +
                    " " + hotel.Name.ToString(); 
                }
                MessageBox.Show("The following hotels were found: " + hotelList);
                 * */

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            numericUpDown1.Visible = true;
            comboBox3.Visible = true;
            dateTimePicker1.Visible = true;
            dateTimePicker2.Visible = true;

            RoomType[] rooms;

            using (HotelBookingServiceClient client = new HotelBookingServiceClient())
            {
                short HotID = 1;
                short aantalPersons = 1;
                DateTime arrival = new DateTime(dateTimePicker1.Value.Year,
                           dateTimePicker1.Value.Month,
                           dateTimePicker1.Value.Day,
                           dateTimePicker1.Value.Hour,
                           dateTimePicker1.Value.Minute,
                           0);
                DateTime departure = new DateTime(dateTimePicker2.Value.Year,
                           dateTimePicker2.Value.Month,
                           dateTimePicker2.Value.Day,
                           dateTimePicker2.Value.Hour,
                           dateTimePicker2.Value.Minute,
                           0);
                rooms = client.getRoomTypesFromHotel(HotID, arrival, departure, aantalPersons);

                /*
               hotels = client.getHotels(name, location);
               comboBox1.Items.Clear();
                 * */
                foreach (RoomType rom in rooms)
                {
                    comboBox3.Items.Add("[" + rom.Name + "] in " + rom);
                }

                comboBox3.DisplayMember = "Name";
                //comboBox1.ValueMember = "HotelId";
                comboBox1.Visible = true;
            }
             
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You can't Bookie, bookie yet!");
        }
    }
}
