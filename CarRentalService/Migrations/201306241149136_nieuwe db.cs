namespace CarRentalService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nieuwedb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        CarId = c.Int(nullable: false, identity: true),
                        Brand = c.String(),
                        DateOfPurchase = c.DateTime(nullable: false),
                        Licence = c.String(),
                        CarType_CarTypeId = c.Int(),
                        Dealer_DealerId = c.Int(),
                    })
                .PrimaryKey(t => t.CarId)
                .ForeignKey("dbo.CarTypes", t => t.CarType_CarTypeId)
                .ForeignKey("dbo.Dealers", t => t.Dealer_DealerId)
                .Index(t => t.CarType_CarTypeId)
                .Index(t => t.Dealer_DealerId);
            
            CreateTable(
                "dbo.CarTypes",
                c => new
                    {
                        CarTypeId = c.Int(nullable: false, identity: true),
                        Maxpersons = c.Int(nullable: false),
                        PricePerDay = c.Double(nullable: false),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.CarTypeId);
            
            CreateTable(
                "dbo.Dealers",
                c => new
                    {
                        DealerId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        City_CityId = c.Int(),
                    })
                .PrimaryKey(t => t.DealerId)
                .ForeignKey("dbo.Cities", t => t.City_CityId)
                .Index(t => t.City_CityId);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        CityId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Country_CountryId = c.Int(),
                    })
                .PrimaryKey(t => t.CityId)
                .ForeignKey("dbo.Countries", t => t.Country_CountryId)
                .Index(t => t.Country_CountryId);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        CountryId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.CountryId);
            
            CreateTable(
                "dbo.CarBookings",
                c => new
                    {
                        CarBookingId = c.Int(nullable: false, identity: true),
                        Price = c.Double(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        UserId = c.Int(nullable: false),
                        Car_CarId = c.Int(),
                    })
                .PrimaryKey(t => t.CarBookingId)
                .ForeignKey("dbo.Cars", t => t.Car_CarId)
                .Index(t => t.Car_CarId);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.CarBookings", new[] { "Car_CarId" });
            DropIndex("dbo.Cities", new[] { "Country_CountryId" });
            DropIndex("dbo.Dealers", new[] { "City_CityId" });
            DropIndex("dbo.Cars", new[] { "Dealer_DealerId" });
            DropIndex("dbo.Cars", new[] { "CarType_CarTypeId" });
            DropForeignKey("dbo.CarBookings", "Car_CarId", "dbo.Cars");
            DropForeignKey("dbo.Cities", "Country_CountryId", "dbo.Countries");
            DropForeignKey("dbo.Dealers", "City_CityId", "dbo.Cities");
            DropForeignKey("dbo.Cars", "Dealer_DealerId", "dbo.Dealers");
            DropForeignKey("dbo.Cars", "CarType_CarTypeId", "dbo.CarTypes");
            DropTable("dbo.CarBookings");
            DropTable("dbo.Countries");
            DropTable("dbo.Cities");
            DropTable("dbo.Dealers");
            DropTable("dbo.CarTypes");
            DropTable("dbo.Cars");
        }
    }
}
