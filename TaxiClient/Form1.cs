﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaxiClient.TaxiService;

namespace TaxiClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFindTaxi_Click(object sender, EventArgs e)
        {
            TaxiPriceInfoRequest request;
            TaxiPriceInfo response;
            bool isValidated = true;
            string msgs = "";

            //see if there are empty textboxes or unchecked radio buttons
            if ((tbDepStreet.Text == "" ||
                tbDepNumber.Text == "" ||
                tbDepZipCode.Text == "" ||
                tbDepCity.Text == "" ||
                tbDestStreet.Text == "" ||
                tbDestNumber.Text == "" ||
                tbDestZipCode.Text == "" ||
                tbDestCity.Text == "" ||
                tbPassengers.Text == "") ||
                (!rbArrival.Checked && !rbDeparture.Checked))
            {
                isValidated = false;
                msgs += "Sommige velden zijn niet ingevoerd\n";
            }

            //see if certain textbox values are numeric
            try
            {
                Convert.ToInt32(tbDepNumber.Text);
                Convert.ToInt32(tbDestNumber.Text);
                Convert.ToInt32(tbPassengers.Text);
            }
            catch (FormatException fe)
            {
                isValidated = false;
                msgs += "Sommige velden verwachten een numerieke waarde\n";
            }

            //see if time lies 10 or more minutes ahead
            DateTime dateTime = new DateTime(
                        dtpDate.Value.Year,
                        dtpDate.Value.Month,
                        dtpDate.Value.Day,
                        dtpTime.Value.Hour,
                        dtpTime.Value.Minute,
                        0);
            if ((dateTime - DateTime.Now).TotalMinutes < 10)
            {
                isValidated = false;
                msgs += "U dient 10 minuten vooruit te plannen\n";
            }

            if (isValidated)
            {
                Address departureAddress = new Address();
                departureAddress.Street = tbDepStreet.Text;
                departureAddress.Number = Convert.ToInt32(tbDepNumber.Text);
                departureAddress.ZipCode = tbDepZipCode.Text;
                departureAddress.City = tbDepCity.Text;
                departureAddress.Country = tbDepCountry.Text;

                Address destinationAddress = new Address();
                destinationAddress.Street = tbDestStreet.Text;
                destinationAddress.Number = Convert.ToInt32(tbDestNumber.Text);
                destinationAddress.ZipCode = tbDestZipCode.Text;
                destinationAddress.City = tbDestCity.Text;
                destinationAddress.Country = tbDestCountry.Text;

                request = new TaxiPriceInfoRequest();
                request.DepartureAddress = departureAddress;
                request.DestinationAddress = destinationAddress;
                request.DateTime = dateTime;
                if (rbDeparture.Checked) request.IsDepartureTime = true;
                request.AmountOfPassengers = Convert.ToInt32(tbPassengers.Text);

                using (WebServiceClient client = new WebServiceClient())
                {
                    response = client.GetTaxiPriceInfo(request);
                }

                //show message with response; ask to accept or to cancel
                string concerningTime = "Aankomst tijd";
                if (response.IsDepartureTime) concerningTime = "Vertrek tijd";
                Address a1 = response.DepartureAddress;
                Address a2 = response.DestinationAddress;
                string sDepartureAddress = string.Format("{0} {1} {2} {3} {4}", a1.Street, a1.Number, a1.ZipCode, a1.City, a1.Country);
                string sDestinationAddress = string.Format("{0} {1} {2} {3} {4}", a2.Street, a2.Number, a2.ZipCode, a2.City, a2.Country);
                DialogResult result = MessageBox.Show(
                    String.Format("Er is een beschikbare taxi gevonden: \n\nTaxi Id.:\t\t{0} \nTaxi type:\t\t{1} \nPrijs:\t\t{2} \nVan:\t\t{3} \nNaar:\t\t{4} \n{5}:\t{6} \nAantal passagiers:\t{7} \n\nWilt u deze taxi boeken?",
                        response.TaxiId,
                        response.TaxiType,
                        response.Price,
                        sDepartureAddress,
                        sDestinationAddress,
                        concerningTime, response.DateTime,
                        response.AmountOfPassengers),
                    "Mogelijke taxi",
                    MessageBoxButtons.YesNo
                    );
                if (result == DialogResult.Yes)
                {
                    //doTaxiBooking(..);
                }
            }
            else
            {
                //show message with errors; aks to accept
                MessageBox.Show(msgs);
            }
        }
    }
}
