namespace TaxiService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Taxis",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PricePerKm = c.Double(nullable: false),
                        Type = c.String(),
                        maxPassengers = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TaxiBookings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Price = c.Double(nullable: false),
                        DepartureAddress_Street = c.String(),
                        DepartureAddress_Number = c.Int(nullable: false),
                        DepartureAddress_City = c.String(),
                        DepartureAddress_Country = c.String(),
                        DepartureAddress_ZipCode = c.String(),
                        DestinationAddress_Street = c.String(),
                        DestinationAddress_Number = c.Int(nullable: false),
                        DestinationAddress_City = c.String(),
                        DestinationAddress_Country = c.String(),
                        DestinationAddress_ZipCode = c.String(),
                        DepartureTime = c.DateTime(nullable: false),
                        ArrivalTime = c.DateTime(nullable: false),
                        AmountOfPassengers = c.Int(nullable: false),
                        Taxi_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Taxis", t => t.Taxi_Id)
                .Index(t => t.Taxi_Id);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Country = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.TaxiBookings", new[] { "Taxi_Id" });
            DropForeignKey("dbo.TaxiBookings", "Taxi_Id", "dbo.Taxis");
            DropTable("dbo.Cities");
            DropTable("dbo.TaxiBookings");
            DropTable("dbo.Taxis");
        }
    }
}
