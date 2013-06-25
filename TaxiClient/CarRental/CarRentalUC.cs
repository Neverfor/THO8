using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaxiClient.CarRentalService;

namespace TaxiClient.CarRental
{
    public partial class CarRentalUC : UserControl
    {
        Form parentContainer;
        public CarRentalUC(Form parentContainer)
        {
            InitializeComponent();
            this.parentContainer = parentContainer;
            FillDataGrid();
            using (WebServiceClient client = new WebServiceClient())
            {
                CountryContract[] countries = client.GetCountries();
                cbCountry.Items.AddRange(countries);
                cbCountry.DisplayMember = "Name";
                //cbCountry.SelectedValue = "-selecteer land-";

            }
        }

        private void cbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (WebServiceClient client = new WebServiceClient())
            {
                CountryContract country = cbCountry.Items[cbCountry.SelectedIndex] as CountryContract;
                CityContract[] cities = client.GetCities(country);
                
                cbCity.Items.Clear(); 
                cbDealer.Items.Clear();
                cbCar.Items.Clear();
                ClearCarInfo();

                cbCity.Items.AddRange(cities);
                cbCity.DisplayMember = "Name";
                //cbCity.SelectedValue = "-selecteer stad-";
            }
        }

        private void cbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (WebServiceClient client = new WebServiceClient())
            {
                CityContract city = cbCity.Items[cbCity.SelectedIndex] as CityContract;
                DealerContract[] dealers = client.GetDealers(city);

                cbDealer.Items.Clear(); 
                cbCar.Items.Clear();
                ClearCarInfo();

                cbDealer.Items.AddRange(dealers);
                cbDealer.DisplayMember = "Name";
                //cbDealer.SelectedValue = "-selecteer dealer-";
            }
        }

        private void cbDealer_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (WebServiceClient client = new WebServiceClient())
            {
                DealerContract dealer = cbDealer.Items[cbDealer.SelectedIndex] as DealerContract;
                CarContract[] cars = client.GetCars(dealer);
                
                cbCar.Items.Clear();
                ClearCarInfo();

                cbCar.Items.AddRange(cars);
                cbCar.DisplayMember = "Brand";
                //cbCar.SelectedValue = "-selecteer auto-";
            }
        }

        private void cbCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (WebServiceClient client = new WebServiceClient())
            {
                CarContract car = cbCar.Items[cbCar.SelectedIndex] as CarContract;

                lblBrand.Enabled = true;
                lblDateOfPurchase.Enabled = true;
                lblLicense.Enabled = true;
                lblMaxPersons.Enabled = true;
                lblPricePerDay.Enabled = true;
                lblCarType.Enabled = true;
                lblStartDay.Enabled = true;
                lblEndDay.Enabled = true;

                lblBrand_data.Text = car.Brand;
                lblCarType_data.Text = car.CarType.Type;
                lblMaxPersons_data.Text = car.CarType.Maxpersons + " pers.";
                lblDateOfPurchase_data.Text = car.DateOfPurchase.ToString();
                lblLicense_data.Text = car.Licence;
                lblPricePerDay_data.Text = car.CarType.PricePerDay.ToString(); ;

                dtpEndDay.Enabled = true;
                dtpStartDay.Enabled = true;
                btnBookCar.Enabled = true;
                
            }
        }

        private void ClearCarInfo()
        {
            lblBrand.Enabled = false;
            lblDateOfPurchase.Enabled = false;
            lblLicense.Enabled = false;
            lblMaxPersons.Enabled = false;
            lblPricePerDay.Enabled = false;
            lblCarType.Enabled = false;
            lblStartDay.Enabled = false;
            lblEndDay.Enabled = false;

            lblBrand_data.Text = "";
            lblDateOfPurchase_data.Text = "";
            lblLicense_data.Text = "";
            lblMaxPersons_data.Text = "";
            lblPricePerDay_data.Text = "";
            lblCarType_data.Text = "";

            dtpEndDay.Enabled = false;
            dtpStartDay.Enabled = false;
            btnBookCar.Enabled = false;
        }
            

        private void btnBookCar_Click(object sender, EventArgs e)
        {
            using (WebServiceClient client = new WebServiceClient())
            {
                CarContract car = cbCar.Items[cbCar.SelectedIndex] as CarContract;
                DateTime sd, ed;
                sd = dtpStartDay.Value;
                sd = new DateTime(sd.Year, sd.Month, sd.Day, 0, 0, 0);
                ed = dtpEndDay.Value;
                ed = new DateTime(ed.Year, ed.Month, ed.Day, 23, 59, 59);

                bool carIsAvailable = client.IsAvailable(car, sd, ed);
                if (carIsAvailable)
                {
                    int days = (int)ed.Subtract(sd).TotalDays + 1;
                    double price = days * car.CarType.PricePerDay;
                    DialogResult result = MessageBox.Show(
                        String.Format("Auto:\t{0} \nStart dag:\t{1} \nEind dag\t{2} \nDagen:\t{3} \nPrijs:\t{4} \n\nWilt u deze auto boeken?",
                            car.Brand, sd, ed, days, price),
                        "Auto boeking",
                        MessageBoxButtons.YesNo
                    );
                    if (result == DialogResult.Yes)
                    {
                        CarBookingContract carBooking = new CarBookingContract()
                        {
                            Car = car,
                            StartDate = sd,
                            EndDate = ed,
                            Price = price
                        };
                        client.Book(carBooking, Session.UserToken);
                        tabControl1.SelectedTab = tabPage2;
                        FillDataGrid();
                    }
                }
                else
                {
                    MessageBox.Show("De auto is niet beschikbaar binnen de opgegeven tijd.");
                }
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            FillDataGrid();
        }

        private void FillDataGrid()
        {
            using (WebServiceClient client = new WebServiceClient())
            {
                userBookingsDG.DataSource = client.getUserBookings(Session.UserToken);
            }
        }

        private void btnCancelBooking_Click(object sender, EventArgs e)
        {
            int selectedRow = userBookingsDG.SelectedRows[0].Index;

            try
            {
                using (WebServiceClient client = new WebServiceClient())
                {
                    CarBookingContract booking = userBookingsDG.Rows[selectedRow].DataBoundItem as CarBookingContract;

                    client.CancelBooking(booking, Session.UserToken);
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
