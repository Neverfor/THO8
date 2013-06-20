using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxiClient.Hotel
{
    public partial class HotelUC : UserControl
    {
        Form parentForm;
        public HotelUC(Form parentForm)
        {
            this.parentForm = parentForm;
            InitializeComponent();
            
        }

        private void searchBTN_Click(object sender, EventArgs e)
        {
            HotelService.Hotel[] hotels;

            using (HotelService.HotelBookingServiceClient client = new HotelService.HotelBookingServiceClient())
            {
                String name = nameTB.Text;
                String location = locationTB.Text;

                if (name == "" || name == " ")
                    name = null;
                if (location == "" || location == " ")
                    location = null;

                if (hotelsCB.Items.Count > 0)
                    hotelsCB.DataSource = null;

                if ((hotels = client.getHotels(name, location)).Count() > 0)
                {
                    var dict = new Dictionary<int, string>();
                    foreach (HotelService.Hotel hot in hotels)
                    {
                        dict.Add(hot.HotelId, hot.Name);
                    }
                    hotelsCB.DataSource = new BindingSource(dict, null);
                    hotelsCB.DisplayMember = "Value";
                    hotelsCB.ValueMember = "Key";
                    hotelsCB.Visible = true;
                }
                else
                {
                    MessageBox.Show("Er zijn geen hotels gevonden", "Geen hotels gevonden", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void bookBTN_Click(object sender, EventArgs e)
        {

        }

        private void hotelsCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            numPersons.Visible = true;
            roomTypeCB.Visible = true;
            arrivalDate.Visible = true;
            departureDate.Visible = true;

            if (roomTypeCB.Items.Count > 0)
                roomTypeCB.Items.Clear();

            HotelService.RoomType[] rooms;

            using (HotelService.HotelBookingServiceClient client = new HotelService.HotelBookingServiceClient())
            {
                short HotID = 1; //Convert.ToInt16(comboBox1.ValueMember.Trim());
                short aantalPersons = 1; // Convert.ToInt16(numericUpDown1.ToString());

                DateTime arrival = new DateTime(arrivalDate.Value.Year,
                           arrivalDate.Value.Month,
                           arrivalDate.Value.Day,
                           arrivalDate.Value.Hour,
                           arrivalDate.Value.Minute,
                           0);
                DateTime departure = new DateTime(departureDate.Value.Year,
                           departureDate.Value.Month,
                           departureDate.Value.Day,
                           departureDate.Value.Hour,
                           departureDate.Value.Minute,
                           0);
                rooms = client.getRoomTypesFromHotel(HotID, arrival, departure, aantalPersons);

                /*
               hotels = client.getHotels(name, location);
               comboBox1.Items.Clear();
                 * */
                foreach (HotelService.RoomType rom in rooms)
                {
                    roomTypeCB.Items.Add("[" + rom.Name + "] in " + rom);
                }

                roomTypeCB.DisplayMember = "Name";
                //comboBox1.ValueMember = "HotelId";
                hotelsCB.Visible = true;
            }
        }
    }
}
