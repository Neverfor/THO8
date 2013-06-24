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

                lblBrand.Text = car.Brand;
                lblCarType.Text = "Auto type: " + car.CarType.Type;
                lblMaxPersons.Text = "Zitruimte: " + car.CarType.Maxpersons + " pers.";
                lblDateOfPurchase.Text = "Dag van aankoop: " + car.DateOfPurchase.ToString();
                lblLicense.Text = "Kenteken: " + car.Licence;
                lblPricePerDay.Text = "Prijs per dag: " + car.CarType.PricePerDay;
                btnBookCar.Enabled = true;
                
            }
        }

        private void ClearCarInfo()
        {
            lblBrand.Text = "";
            lblDateOfPurchase.Text = "";
            lblLicense.Text = "";
            lblMaxPersons.Text = "";
            lblPricePerDay.Text = "";
            lblCarType.Text = "";
            btnBookCar.Enabled = false;
        }
            

        private void btnBookCar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("something is working");
        }
    }
}
