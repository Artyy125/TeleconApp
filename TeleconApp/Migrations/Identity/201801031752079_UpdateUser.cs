namespace TeleconApp.Migrations.Identity
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "TechName", c => c.String(unicode: false));
            AddColumn("dbo.AspNetUsers", "Address", c => c.String(unicode: false));
            AddColumn("dbo.AspNetUsers", "StartDate", c => c.DateTime(nullable: false, precision: 0));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "StartDate");
            DropColumn("dbo.AspNetUsers", "Address");
            DropColumn("dbo.AspNetUsers", "TechName");
        }
    }
}
