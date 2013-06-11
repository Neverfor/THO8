using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaxiService.Domain
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }

        public City() { }
        public City(string name, string country)
        {
            this.Name = name;
            this.Country = country;
        }


        public override string ToString()
        {
            return Name;
        }
    }
}