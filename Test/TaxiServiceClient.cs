using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using Test.TaxiService;

namespace TaxiServiceClient
{
    class TaxiServiceClient
    {
        static void Main(string[] args)
        {
            TaxiServiceClient taxiServiceProxy = new TaxiServiceClient();

            Address departurePoint = new Address();
            departurePoint.Street = "Kastanjehof";
            departurePoint.Number = 2;
            departurePoint.ZipCode = "4231ED";
            departurePoint.City = "Meerkerk";
            departurePoint.Country = "Nederland";

            Address destination = new Address();
            destination.Street = "Neijenoord";
            destination.Number = 1;
            destination.ZipCode = "3552AS";
            destination.City = "Utrecht";
            destination.Country = "Nederland";

            DateTime dateAndTime = new DateTime(2013, 7, 5, 9, 30, 0);

            TaxiPriceInfoRequest parameters = new TaxiPriceInfoRequest();
            parameters.DepartureAddress = departurePoint;
            parameters.DestinationAddress = destination;
            parameters.DateTime = dateAndTime;
            parameters.IsDepartureTime = true;
            parameters.AmountOfPassengers = 2;


            TaxiPriceInfo result = taxiServiceProxy.GetTaxiPriceInfo(parameters);

            Console.WriteLine("TaxiID : {0}\n TaxiType : {1}\n Price : {2}\n Date : {3}\n ", result.TaxiId, result.TaxiType, result.Price, result.DateTime.ToString());
            Console.ReadLine();
            
        }
    }
}
