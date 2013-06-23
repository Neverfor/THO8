using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleClient.CarRentalService;

namespace ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            using (WebServiceClient client = new WebServiceClient())
            {
                Console.WriteLine("countries:");
                Country[] countries = client.GetCountries();
                Country country = countries[0];
                Console.WriteLine(country.CountryId + " " + country.Name);
                Console.WriteLine("cities:");
                City[] cities = client.GetCities(country);
                foreach (City c in cities)
                    Console.WriteLine(string.Format("nr: {0} name: {1}", c.CityId, c.Name));
                Console.Read();
            }
        }
    }
}
