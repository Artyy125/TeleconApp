namespace TeleconApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveDivisionIdEmployee : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Employee", "DivisionId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employee", "DivisionId", c => c.Int(nullable: false));
        }
    }
}
