using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using TestingConsole.TaxiService;

namespace TestingConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            TaxiServiceClient client = new TaxiServiceClient();
            ServicesDataContracts.TaxiBookingRequest tbr = new ServicesDataContracts.TaxiBookingRequest();
            tbr.DateTime = new DateTime();
            tbr.IsDepartureTime = true;
            tbr.AmountOfPassengers = 2;
            client.DoTaxiBooking(tbr);
        }
    }
}
