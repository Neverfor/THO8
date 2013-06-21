using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CarRentalService.Domain
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
}
