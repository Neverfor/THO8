namespace TaxiService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class idweggehaald : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TaxiBookings", "User_Id", "dbo.Users");
            DropIndex("dbo.TaxiBookings", new[] { "User_Id" });
            RenameColumn(table: "dbo.TaxiBookings", name: "User_Id", newName: "User_UserName");
            AlterColumn("dbo.Users", "UserName", c => c.String(nullable: false, maxLength: 128));
            DropPrimaryKey("dbo.Users", new[] { "Id" });
            AddPrimaryKey("dbo.Users", "UserName");
            AddForeignKey("dbo.TaxiBookings", "User_UserName", "dbo.Users", "UserName");
            CreateIndex("dbo.TaxiBookings", "User_UserName");
            DropColumn("dbo.Users", "Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Id", c => c.Int(nullable: false, identity: true));
            DropIndex("dbo.TaxiBookings", new[] { "User_UserName" });
            DropForeignKey("dbo.TaxiBookings", "User_UserName", "dbo.Users");
            DropPrimaryKey("dbo.Users", new[] { "UserName" });
            AddPrimaryKey("dbo.Users", "Id");
            AlterColumn("dbo.Users", "UserName", c => c.String());
            RenameColumn(table: "dbo.TaxiBookings", name: "User_UserName", newName: "User_Id");
            CreateIndex("dbo.TaxiBookings", "User_Id");
            AddForeignKey("dbo.TaxiBookings", "User_Id", "dbo.Users", "Id");
        }
    }
}
