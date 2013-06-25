using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxiClient.Flight
{
    public partial class FlightUC : UserControl
    {
        Form parentForm;

        public FlightUC(Form parentForm)
        {
            this.parentForm = parentForm;
            InitializeComponent();
        }

        private void ZoekButton_Click(object sender, EventArgs e)
        {
            using (FlightService.FlightServiceClient client = new FlightService.FlightServiceClient())
            {
                DateTime departure = new DateTime(departureDate.Value.Year,
                          departureDate.Value.Month,
                          departureDate.Value.Day,
                          departureDate.Value.Hour,
                          departureDate.Value.Minute,
                          0);
                String vertrekPunt = vertrekTextBox.Text;
                String rst = "";
                TaxiClient.FlightService.AirportDTO arp = new TaxiClient.FlightService.AirportDTO();
                TaxiClient.FlightService.AirportDTO [] airports = new TaxiClient.FlightService.AirportDTO [2000];

                try
                {
                    airports = client.GetAirports(vertrekPunt);
                    foreach (TaxiClient.FlightService.AirportDTO a in airports)
                    {
                        rst += a.Name.ToString() + " ";
                    }
                }
                catch {}

                
                MessageBox.Show("Gevonden airports: \n" + rst);
                //TaxiClient.FlightService.FlightDTO fl = new TaxiClient.FlightService.FlightDTO();
                //client.ShowFlightsByDeparture(1, 1, departure, 1);
                //MessageBox.Show("Flights: " + client.ShowFlightsByDeparture(1, 1, departure, 1).ToString());
            }
        }
    }
}
