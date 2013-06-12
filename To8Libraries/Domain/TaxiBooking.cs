using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace To8Libraries.Domain
{
    public class TaxiBooking
    {
        public int Id { get; set; }
        public User User { get; set; }
        public Taxi Taxi { get; set; }
        public double Price { get; set; }
        public Address DepartureAddress  { get; set; }
        public Address DestinationAddress { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public int AmountOfPassengers { get; set; }
    }
}
