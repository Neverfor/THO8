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
                //TaxiClient.FlightService.FlightDTO fl = new TaxiClient.FlightService.FlightDTO();
                //client.ShowFlightsByDeparture(1, 1, departure, 1);
                MessageBox.Show("Flights: " + client.ShowFlightsByDeparture(1, 1, departure, 1).ToString());


                /*var window = new FoundFlightsForm();
                window.Show();
                 * */
            }
        }
    }
}
