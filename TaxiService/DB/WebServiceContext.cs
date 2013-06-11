using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using TaxiService.Domain;

namespace TaxiService.DB
{
    public class WebServiceContext : DbContext
    {
        public WebServiceContext()
            : base("Azure")
        {
            //leeg
        }
        public DbSet<Taxi> Taxis { get; set; }
        public DbSet<TaxiBooking> Bookings { get; set; }
    }
}