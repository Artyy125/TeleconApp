namespace TeleconApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class spliceractivity3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SplicerPrepActivity", "PrepSubmitDate", c => c.DateTime(nullable: false, precision: 0));
            AddColumn("dbo.SplicerPrepActivity", "TimeSheetSubmitDate", c => c.DateTime(nullable: false, precision: 0));
            AddColumn("dbo.SplicerTestActivity", "SubmitDate", c => c.DateTime(nullable: false, precision: 0));
        }
        
        public override void Down()
        {
            DropColumn("dbo.SplicerTestActivity", "SubmitDate");
            DropColumn("dbo.SplicerPrepActivity", "TimeSheetSubmitDate");
            DropColumn("dbo.SplicerPrepActivity", "PrepSubmitDate");
        }
    }
}
