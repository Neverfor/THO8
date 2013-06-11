namespace TaxiService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Password = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Country = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.TaxiBookings", "User_Id", c => c.Int());
            AddForeignKey("dbo.TaxiBookings", "User_Id", "dbo.Users", "Id");
            CreateIndex("dbo.TaxiBookings", "User_Id");
            DropColumn("dbo.TaxiBookings", "UserToken");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TaxiBookings", "UserToken", c => c.String());
            DropIndex("dbo.TaxiBookings", new[] { "User_Id" });
            DropForeignKey("dbo.TaxiBookings", "User_Id", "dbo.Users");
            DropColumn("dbo.TaxiBookings", "User_Id");
            DropTable("dbo.Cities");
            DropTable("dbo.Users");
        }
    }
}
