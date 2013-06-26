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
            FillDataGrid();

        }

        private void FillDataGrid()
        {

            Team2.UserService usrClient = new Team2.UserServiceClient();
            String Token = Session.UserToken.ToString();

            using (HotelService.HotelBookingServiceClient client = new HotelService.HotelBookingServiceClient())
            {
                try
                {
                    userBookings.DataSource = client.GetBookingsFromUser(Token);
                    userBookings.Columns[5].Visible = false;
                }
                catch { }
            }

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

                try
                {
                    hotels = client.getHotels(name, location);
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
                catch
                {
                    MessageBox.Show("Er zijn geen hotels gevonden", "Geen hotels gevonden", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void bookBTN_Click(object sender, EventArgs e)
        {
            try
            {
                String Token = Session.UserToken.ToString();
                string hotelStringID = hotelsCB.SelectedValue.ToString();
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

                HotelService.HotelBookingServiceClient client = new HotelService.HotelBookingServiceClient();
                HotelService.BookingRow br = new HotelService.BookingRow();
                HotelService.BookingRow[] row = new HotelService.BookingRow[1];

                short x = 1;
                br.Amount = x;
                br.RoomType = roomTypeItem;

                String roomTypeNaam = roomTypeCB.SelectedValue.ToString();
                MessageBox.Show("U heeft gekozen een " + roomTypeNaam + " kamer." 
                    + "\n De service verlener beschrijft kamers als volgt: "
                    + " \n" + roomTypeItem.Description);

                br.RoomType.MaxPersons = aantalPersons;
                row[0] = br;

                client.bookRoom(hotID, row, arrival, departure, aantalPersons, Token);
                FillDataGrid();
            }
            catch 
            { 
                FillDataGrid();
                MessageBox.Show("Niet alle velden zijn ingevuld");
            }
        }

        private void hotelsCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            numPersons.Visible = true;
            roomTypeCB.Visible = true;
            arrivalDate.Visible = true;
            departureDate.Visible = true;

            ArrayList roomies = new ArrayList();
            bool isNum = false;
            short HotID = 0;

            try
            {
                String hotID = hotelsCB.SelectedValue.ToString();
                int Num;
                isNum = int.TryParse(hotID.ToString(), out Num);
                if (isNum)
                {
                    HotID = Convert.ToInt16(hotID);
                }

                else
                {
                    HotID = 0;
                }
            }
            catch { }

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
                try
                {
                    roomTypeCB.Items.Clear();
                }
                catch { }
            }


            using (HotelService.HotelBookingServiceClient client = new HotelService.HotelBookingServiceClient())
            {
                String roomMsg = null;
                if (HotID > 0)
                {
                    try
                    {
                        rooms = client.getRoomTypesFromHotel(HotID, arrival, departure, aantalPersons);
                        foreach (HotelService.RoomType rom in rooms)
                        {
                            roomies.Add(rom);
                        }

                        if (roomies.Count > 0) { roomMsg = "Found rooms!"; }
                        roomTypeCB.DataSource = roomies;
                        roomTypeCB.DisplayMember = "Name";
                        roomTypeCB.ValueMember = "Name";
                        roomTypeCB.Visible = true;
                    }
                    catch 
                    { 
                        if(roomMsg == null)
                        {
                            MessageBox.Show("Dit hotel heeft geen vrije kamers.");
                        }
                    }
                }
                else { }
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
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CancelBoekingBTN_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bent u zeker dat u wilt geselecteerde boeking annuleren?", 
                "Annuleer Boeking", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    int selectedRow = userBookings.SelectedRows[0].Index;
                    int selectedId = Convert.ToInt32(userBookings.Rows[selectedRow].Cells[1].Value.ToString());
                    short hottieID = 0;
                    using (HotelService.HotelBookingServiceClient client = new HotelService.HotelBookingServiceClient())
                    {
                        try { hottieID = Convert.ToInt16(selectedId); }
                        catch { }
                        client.CancelBooking(hottieID);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                FillDataGrid();
            }
        }
    }
}
