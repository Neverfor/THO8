using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
using GUI.TaxiService;

namespace GUI
{
    public partial class FormGetTaxiPriceInfo : Form
    {
        public FormGetTaxiPriceInfo()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            TaxiServiceClient taxiServiceProxy = new TaxiServiceClient();

            Address departurePoint = new Address();
            departurePoint.Street = tfAddress1.Text;
            departurePoint.Number = Convert.ToInt32(tfNumber1.Text);
            departurePoint.ZipCode = tfZipCode1.Text;
            departurePoint.City = tfCity1.Text;
            departurePoint.Country = tfCountry1.Text;

            Address destination = new Address();
            destination.Street = tfAddress2.Text;
            destination.Number = Convert.ToInt32(tfNumber2.Text);
            destination.ZipCode = tfZipCode2.Text;
            destination.City = tfCity2.Text;
            destination.Country = tfCountry2.Text;



            string[] sDate = tfDate.Text.Split('-');
            int[] date = new int[sDate.Length];
            for (int i = 0; i < sDate.Length; i++)
                date[i] = Convert.ToInt32(sDate[i]);

            string[] sTime = tfTime.Text.Split(':');
            int[] time = new int[sDate.Length];
            for (int i = 0; i < sTime.Length; i++)
                time[i] = Convert.ToInt32(sTime[i]);


            DateTime dateAndTime = new DateTime(date[0], date[1], date [2], time[0], time[1], 0);

            
            string s;

            TaxiPriceInfoRequest parameters = new TaxiPriceInfoRequest();
            parameters.DepartureAddress = departurePoint;
            parameters.DestinationAddress = destination;
            parameters.DateTime = dateAndTime;
            if (rbDepartureTime.Checked)
            {
                parameters.IsDepartureTime = true;
                s = "Vertrektijd";
            }
            else
            {
                parameters.IsDepartureTime = false;
                s = "Aankomsttijd";
            }
            parameters.AmountOfPassengers = Convert.ToInt32(tfPassengers.Text);


            TaxiPriceInfo tpf = taxiServiceProxy.GetTaxiPriceInfo(parameters);

            string text = string.Format("Taxi id.: {0}\nTaxi type: {1}\nPrijs: {2}\n\nVan:\n   {3} {4}\n   {5}\n   {6}\n   {7}\n\nVan:\n   {8} {9}\n   {10}\n   {11}\n   {12}\n\n{13}: {14}", 
                tpf.TaxiId, tpf.TaxiType, tpf.Price, 
                tpf.DepartureAddress.Street, tpf.DepartureAddress.Number, tpf.DepartureAddress.ZipCode, tpf.DepartureAddress.City, tpf.DepartureAddress.Country, 
                tpf.DestinationAddress.Street, tpf.DestinationAddress.Number, tpf.DestinationAddress.ZipCode, tpf.DestinationAddress.City, tpf.DestinationAddress.Country,
                s, tpf.DateTime.ToString()
                );

            lblTaxiInfo.Text = text;
        }
    }
}
