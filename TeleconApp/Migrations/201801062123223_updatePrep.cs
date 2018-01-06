namespace TeleconApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatePrep : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SplicerPrepActivity", "TimeSheetDate", c => c.DateTime(nullable: false, precision: 0));
        }
        
        public override void Down()
        {
            DropColumn("dbo.SplicerPrepActivity", "TimeSheetDate");
        }
    }
}
