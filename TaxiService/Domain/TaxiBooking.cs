using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace TaxiService.Domain
{
    public class TaxiBooking
    {
        public int Id { get; set; }
        public string UserToken { get; set; }
        public Taxi Taxi { get; set; }
        public double Price { get; set; }
        public Address DepartureAddress  { get; set; }
        public Address DestinationAddress { get; set; }
        public DateTime DateTime { get; set; }
        public bool IsDepartureTimen { get; set; }
        public int AmountOfPassengers { get; set; }
    }
}
