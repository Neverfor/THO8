namespace TaxiService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Taxiupdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Taxis", "maxPassengers", c => c.Int(nullable: false));
            AddColumn("dbo.TaxiBookings", "DepartureTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.TaxiBookings", "ArrivalTime", c => c.DateTime(nullable: false));
            DropColumn("dbo.TaxiBookings", "DateTime");
            DropColumn("dbo.TaxiBookings", "IsDepartureTimen");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TaxiBookings", "IsDepartureTimen", c => c.Boolean(nullable: false));
            AddColumn("dbo.TaxiBookings", "DateTime", c => c.DateTime(nullable: false));
            DropColumn("dbo.TaxiBookings", "ArrivalTime");
            DropColumn("dbo.TaxiBookings", "DepartureTime");
            DropColumn("dbo.Taxis", "maxPassengers");
        }
    }
}
