using System;
using System.Collections.Generic;
using System.Collections;
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
                    ArrayList hotelCollections = new ArrayList();

                    foreach (HotelService.Hotel hot in hotels)
                    {
                        hotelCollections.Add(hot);
                        
                    }
                    hotelsCB.DataSource = hotelCollections;
                    hotelsCB.DisplayMember = "Name";
                    hotelsCB.ValueMember = "HotelId";
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
            String Token = Session.UserToken.ToString();
            string hotelStringID = hotelsCB.SelectedValue.ToString();
            MessageBox.Show("Hotel ID is: " + hotelStringID);
            short hotID = Convert.ToInt16(hotelStringID);
            String perNumb = numPersons.Value.ToString();
            short aantalPersons = Convert.ToInt16(perNumb);
            
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

            /*
            Team2.UserService usrClient = new Team2.UserServiceClient();
            var usr = usrClient.GetUser(Token);
            int userID = Convert.ToInt32(usr.UserId.ToString());
             */
            HotelService.HotelBookingServiceClient client = new HotelService.HotelBookingServiceClient();
            HotelService.BookingRow br = new HotelService.BookingRow();
            HotelService.BookingRow[] row = new HotelService.BookingRow[1];

            short x = 1;
            br.Amount = x;


            br.RoomType = roomTypeItem;
            //br.RoomType.Amount = x;
            String roomTypeNaam = roomTypeCB.SelectedValue.ToString();
            MessageBox.Show("De selected room is: " + roomTypeNaam + "\n De selected room description is: " + roomTypeItem.Description);
            //br.RoomType.Name = roomTypeNaam;//roomTypeCB.SelectedValue.ToString();
            br.RoomType.MaxPersons = aantalPersons;
            row[0] = br;

            client.bookRoom(hotID, row, arrival, departure, aantalPersons, Token);
        }

        private void hotelsCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            numPersons.Visible = true;
            roomTypeCB.Visible = true;
            arrivalDate.Visible = true;
            departureDate.Visible = true;

            ArrayList roomies = new ArrayList();
            String hotID = hotelsCB.SelectedValue.ToString();
            short HotID = 0;
           
            

            int Num;
            bool isNum = int.TryParse(hotID.ToString(), out Num); 

            if (isNum) 
            {
                MessageBox.Show("Changed hotel ID: " + hotID);
                HotID = Convert.ToInt16(hotID); 
            }
            else       
            {
                HotID = 0; 
            }

            String perNumb = numPersons.Value.ToString();
            short aantalPersons = Convert.ToInt16(perNumb);

            HotelService.RoomType[] rooms;

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

            if (roomTypeCB.Items.Count > 0)
            {
                roomTypeCB.Items.Clear();
            }


            using (HotelService.HotelBookingServiceClient client = new HotelService.HotelBookingServiceClient())
            {
                if (HotID > 0)
                {
                    rooms = client.getRoomTypesFromHotel(HotID, arrival, departure, aantalPersons);
                    String roomTypeOut = "Following rooms are available: ";
                    foreach (HotelService.RoomType rom in rooms)
                    {
                        roomies.Add(rom);
                        roomTypeOut += " \n" + rom.Name.ToString() + " heeft ID: " + rom.RoomTypeId.ToString();
                    }

                    MessageBox.Show(roomTypeOut);

                    roomTypeCB.DataSource = roomies;
                    roomTypeCB.DisplayMember = "Name";
                    roomTypeCB.ValueMember = "Name";
                    roomTypeCB.Visible = true;
                }
                else {}
            }
        }

        private void HotelUC_Load(object sender, EventArgs e)
        {

        }

        private void numPersons_ValueChanged(object sender, EventArgs e)
        {

        }

        HotelService.RoomType roomTypeItem;

        private void roomTypeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (roomTypeCB.SelectedIndex >= 0 && roomTypeCB.SelectedItem != null)
            {
                roomTypeItem = roomTypeCB.Items[roomTypeCB.SelectedIndex] as HotelService.RoomType;
                MessageBox.Show("Gekozen kamer: " + roomTypeCB.SelectedValue.ToString());
            }
        }
    }
}
