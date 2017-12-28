namespace TeleconApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Employee : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employee",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TechName = c.String(maxLength: 100, storeType: "nvarchar"),
                        PhoneNumber = c.String(maxLength: 12, storeType: "nvarchar"),
                        Address = c.String(maxLength: 500, storeType: "nvarchar"),
                        StartDate = c.DateTime(nullable: false, precision: 0),
                        DivisionId = c.Int(nullable: false),
                        BirthDate = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Employee");
        }
    }
}
