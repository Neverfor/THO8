using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaxiService.Domain
{
    public class Taxi
    {
        public int Id { get; set; }
        public double PricePerKm { get; set; }
        public string Type { get; set; }
    }
}