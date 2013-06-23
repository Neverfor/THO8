﻿using System;
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

                this.RefreshComboBoxes();
            }
        }

        private void cbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.RefreshComboBoxes();
        }

        private void cbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.RefreshComboBoxes();
        }

        private void cbDealer_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.RefreshComboBoxes();
        }

        private void cbCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.RefreshComboBoxes();
        }

        private void btnBookCar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("something is working");
        }

        private void RefreshComboBoxes()
        {
            using (WebServiceClient client = new WebServiceClient())
            {
                cbCountry.DataSource = client.GetCountries();
                cbCountry.DisplayMember = "Name";

                //Country country = cbCountry.Items[cbCountry.SelectedIndex] as Country;
                //cbCity.DataSource = client.GetCities(country);
                //cbCity.DisplayMember = "Name";

                //City city = cbCity.Items[cbCity.SelectedIndex] as City;
                //cbDealer.DataSource = client.GetDealers(city);
                //cbDealer.DisplayMember = "Name";

                //Dealer dealer = cbDealer.Items[cbDealer.SelectedIndex] as Dealer;
                //cbCar.DataSource = client.GetCars(dealer);
                //cbCar.DisplayMember = "Brand";

                //Car car = cbCar.Items[cbCar.SelectedIndex] as Car;
                //lblCarType.Text = car.CarType.Type;
            }
        }
    }
}
