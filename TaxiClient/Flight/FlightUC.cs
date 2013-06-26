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
                DateTime depDate = new DateTime(departureDate.Value.Year,
                          departureDate.Value.Month,
                          departureDate.Value.Day,
                          departureDate.Value.Hour,
                          departureDate.Value.Minute,
                          0);
                String departureAirportName = departureAirportNameTB.Text;
                String departureAirports = "";
                String destinationAirportName = destinationAirportNameTB.Text;
                String destinationAirports = "";
                String possibleFlights = "Mogelijke vluchten: \n";
                int departureAirportId = 0;
                int destinationAirportId = 0;
                int passengers = 0;

                passengers = Convert.ToInt32(adultsNB.Value.ToString()) 
                    + Convert.ToInt32(childrenNB.Value.ToString()) + Convert.ToInt32(babiesNB.Value.ToString());
                
                TaxiClient.FlightService.AirportDTO arp = new TaxiClient.FlightService.AirportDTO();
                TaxiClient.FlightService.FlightDTO flight = new TaxiClient.FlightService.FlightDTO();
                TaxiClient.FlightService.AirportDTO [] airports = new TaxiClient.FlightService.AirportDTO [2000];
                TaxiClient.FlightService.FlightDTO[] flights = new TaxiClient.FlightService.FlightDTO [2000];

                try
                {
                    airports = client.GetAirports(departureAirportName); 
                    foreach (TaxiClient.FlightService.AirportDTO a in airports)
                    {
                        departureAirports += a.Name.ToString() + " ";
                        departureAirportId = a.AiportId;
                    }
                }
                catch {}
                
                try
                {
                    airports = client.GetAirports(destinationAirportName);
                    foreach (TaxiClient.FlightService.AirportDTO a in airports)
                    {
                        destinationAirports += a.Name.ToString() + " " + a.AiportId.ToString();
                        destinationAirportId = Convert.ToInt32(a.AiportId.ToString());
                    }
                }
                catch { }

                try 
                {
                    flights = client.ShowFlightsByDeparture(departureAirportId, destinationAirportId, depDate, passengers);
                }
                catch { }

                try
                {
                    foreach (TaxiClient.FlightService.FlightDTO f in flights)
                    {
                    possibleFlights += f.DestinationName + " " + f.AirplaneName + "\n";
                    }
                }
                catch { }



                MessageBox.Show("Gevonden airports (vertrek): \n" + departureAirports + "\n"
                    + "Gevonden airports (bestemming): \n" + destinationAirports + "\n"
                    + possibleFlights);


                //TaxiClient.FlightService.FlightDTO fl = new TaxiClient.FlightService.FlightDTO();
                //client.ShowFlightsByDeparture(1, 1, departure, 1);
                //MessageBox.Show("Flights: " + client.ShowFlightsByDeparture(1, 1, departure, 1).ToString());
            }
        }
    }
}
