using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace CarRentalService.Domain.Contracts
{
    [DataContract]
    public class Car
    {
        [DataMember]
        public int CarId { get; set; }
        [DataMember]
        public string Brand { get; set; }
        [DataMember]
        public CarType CarType { get; set; }
        [DataMember]
        public DateTime DateOfPurchase { get; set; }
        [DataMember]
        public Dealer Dealer { get; set; }
        [DataMember]
        public string Licence { get; set; }
    }

    [DataContract]
    public class CarBooking
    {
        [DataMember]
        public int CarBookingId { get; set; }
        [DataMember]
        public Car Car { get; set; }
        [DataMember]
        public double Price { get; set; }
        [DataMember]
        public DateTime StartDate { get; set; }
        [DataMember]
        public DateTime EndDate { get; set; }
        [DataMember]
        public int UserId { get; set; }
    }

    [DataContract]
    public class CarType
    {
        [DataMember]
        public int CarTypeId { get; set; }
        [DataMember]
        public int Maxpersons { get; set; }
        [DataMember]
        public double PricePerDay { get; set; }
        [DataMember]
        public string Type { get; set; }
    }

    [DataContract]
    public class City
    {
        [DataMember]
        public int CityId { get; set; }
        [DataMember]
        public Country Country { get; set; }
        [DataMember]
        public string Name { get; set; }
    }

    [DataContract]
    public class Country
    {
        [DataMember]
        public int CountryId { get; set; }
        [DataMember]
        public string Name { get; set; }
    }

    [DataContract]
    public class Dealer
    {
        [DataMember]
        public int DealerId { get; set; }
        [DataMember]
        public City City { get; set; }
        [DataMember]
        public string Name { get; set; }
    }
}
