namespace TeleconApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PrepActivity2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SplicerCableActivity", "TodayJobDoneDate", c => c.DateTime(nullable: false, precision: 0));
            AddColumn("dbo.SplicerCableActivity", "OnDutyTime", c => c.DateTime(nullable: false, precision: 0));
            AddColumn("dbo.SplicerCableActivity", "PartnerName", c => c.String(unicode: false));
            AddColumn("dbo.SplicerCableActivity", "BellNetworkNumber", c => c.String(unicode: false));
            DropColumn("dbo.SplicerPrepActivity", "OnDutyTime");
            DropColumn("dbo.SplicerPrepActivity", "TodayJobDoneDate");
            DropColumn("dbo.SplicerPrepActivity", "PartnerName");
            DropColumn("dbo.SplicerPrepActivity", "BellNetworkNumber");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SplicerPrepActivity", "BellNetworkNumber", c => c.String(unicode: false));
            AddColumn("dbo.SplicerPrepActivity", "PartnerName", c => c.String(unicode: false));
            AddColumn("dbo.SplicerPrepActivity", "TodayJobDoneDate", c => c.DateTime(nullable: false, precision: 0));
            AddColumn("dbo.SplicerPrepActivity", "OnDutyTime", c => c.DateTime(nullable: false, precision: 0));
            DropColumn("dbo.SplicerCableActivity", "BellNetworkNumber");
            DropColumn("dbo.SplicerCableActivity", "PartnerName");
            DropColumn("dbo.SplicerCableActivity", "OnDutyTime");
            DropColumn("dbo.SplicerCableActivity", "TodayJobDoneDate");
        }
    }
}
