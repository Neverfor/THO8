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
            this.parentContainer = parentContainer;
            InitializeComponent();
            using (WebServiceClient client = new WebServiceClient())
            {
                List<Country> countries = client.GetCountries().ToList();
                cbCountry.DataSource = countries;
                cbCountry.DisplayMember = "Name";
                lblCarType.Text = "";
            }
        }

        private void cbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (WebServiceClient client = new WebServiceClient())
            {
                Country country = cbCountry.Items[cbCountry.SelectedIndex] as Country;
                List<City> cities = client.GetCities(country).ToList();
                cbCity.DataSource = cities;
                cbCity.DisplayMember = "Name";
                lblCarType.Text = "";
                MessageBox.Show("Countries: " + cities.ToString());
            }
        }

        private void cbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (WebServiceClient client = new WebServiceClient())
            {
                City city = cbCity.Items[cbCity.SelectedIndex] as City;
                List<Dealer> dealers = client.GetDealers(city).ToList();
                cbDealer.DataSource = dealers;
                cbDealer.DisplayMember = "Name";
                lblCarType.Text = "";
            }
        }

        private void cbDealer_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (WebServiceClient client = new WebServiceClient())
            {
                Dealer dealer = cbDealer.Items[cbDealer.SelectedIndex] as Dealer;
                List<Car> cars = client.GetCars(dealer).ToList();
                cbCar.DataSource = cars;
                cbCar.DisplayMember = "Brand";
                lblCarType.Text = "";
            }
        }

        private void cbCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (WebServiceClient client = new WebServiceClient())
            {
                Car car = cbCar.Items[cbCar.SelectedIndex] as Car;
                lblCarType.Text = car.CarType.Type;
            }
        }

        private void try1(object sender, QueryAccessibilityHelpEventArgs e)
        {
            using (WebServiceClient client = new WebServiceClient())
            {
                Country country = cbCountry.Items[cbCountry.SelectedIndex] as Country;
                List<City> cities = client.GetCities(country).ToList();
                cbCity.DataSource = cities;
                cbCity.DisplayMember = "Name";
                lblCarType.Text = "";
                MessageBox.Show("Countries: " + cities.ToString());
            }
        }
    }
}
