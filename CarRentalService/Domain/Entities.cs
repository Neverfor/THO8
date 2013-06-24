using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CarRentalService.Entities
{
    public class WebServiceContext : DbContext
    {
        public WebServiceContext()
            : base("Azure")
        { }

        public DbSet<Car> Cars { get; set; }
        public DbSet<CarBooking> CarBookings { get; set; }
        public DbSet<CarType> CarTypes { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Dealer> Dealers { get; set; }
    }

    public class Car
    {
        public int CarId { get; set; }
        public string Brand { get; set; }
        public virtual CarType CarType { get; set; }
        public DateTime DateOfPurchase { get; set; }
        public virtual Dealer Dealer { get; set; }
        public string Licence { get; set; }
    }

    public class CarBooking
    {
        public int CarBookingId { get; set; }
        public virtual Car Car { get; set; }
        public double Price { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int UserId { get; set; }
    }

    public class CarType
    {
        public int CarTypeId { get; set; }
        public int Maxpersons { get; set; }
        public double PricePerDay { get; set; }
        public string Type { get; set; }
    }

    public class City
    {
        public int CityId { get; set; }
        public virtual Country Country { get; set; }
        public string Name { get; set; }
    }

    public class Country
    {
        public int CountryId { get; set; }
        public string Name { get; set; }
    }

    public class Dealer
    {
        public int DealerId { get; set; }
        public virtual City City { get; set; }
        public string Name { get; set; }
    }
}
