namespace TeleconApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateEmployeeRemoveBirthDate : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Employee", "BirthDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employee", "BirthDate", c => c.DateTime(nullable: false, precision: 0));
        }
    }
}
