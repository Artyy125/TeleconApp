namespace TeleconApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatePrepTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SplicerPrepActivity", "TimeSheetComment", c => c.String(unicode: false));
            AddColumn("dbo.SplicerPrepActivity", "TestSubmitDate", c => c.DateTime(nullable: false, precision: 0));
            AddColumn("dbo.SplicerPrepActivity", "TestComment", c => c.String(unicode: false));
            AddColumn("dbo.SplicerPrepActivity", "TestPartnerName", c => c.String(unicode: false));
            AddColumn("dbo.SplicerPrepActivity", "TestBellNetworkNumber", c => c.String(unicode: false));
            AddColumn("dbo.SplicerPrepActivity", "TestCompletedTime", c => c.DateTime(nullable: false, precision: 0));
            AddColumn("dbo.SplicerPrepActivity", "TestTodayJobDoneDate", c => c.DateTime(nullable: false, precision: 0));
            AddColumn("dbo.SplicerPrepActivity", "TestOnDutyTime", c => c.DateTime(nullable: false, precision: 0));
            AddColumn("dbo.SplicerPrepActivity", "CableCompletedTime", c => c.DateTime(nullable: false, precision: 0));
            AddColumn("dbo.SplicerPrepActivity", "CableTodayJobDoneDate", c => c.DateTime(nullable: false, precision: 0));
            AddColumn("dbo.SplicerPrepActivity", "CableOnDutyTime", c => c.DateTime(nullable: false, precision: 0));
            AddColumn("dbo.SplicerPrepActivity", "CablePartnerName", c => c.String(unicode: false));
            AddColumn("dbo.SplicerPrepActivity", "CableBellNetworkNumber", c => c.String(unicode: false));
            DropColumn("dbo.SplicerCableActivity", "Action");
            DropColumn("dbo.SplicerCableActivity", "CompletedTime");
            DropColumn("dbo.SplicerCableActivity", "TodayJobDoneDate");
            DropColumn("dbo.SplicerCableActivity", "OnDutyTime");
            DropColumn("dbo.SplicerCableActivity", "PartnerName");
            DropColumn("dbo.SplicerCableActivity", "BellNetworkNumber");
            DropColumn("dbo.SplicerPrepActivity", "Comment");
            DropColumn("dbo.SplicerTestActivity", "PartnerName");
            DropColumn("dbo.SplicerTestActivity", "BellNetworkNumber");
            DropColumn("dbo.SplicerTestActivity", "CompletedTime");
            DropColumn("dbo.SplicerTestActivity", "TodayJobDoneDate");
            DropColumn("dbo.SplicerTestActivity", "OnDutyTime");
            DropColumn("dbo.SplicerTestActivity", "SubmitDate");
            DropColumn("dbo.SplicerTestActivity", "Comment");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SplicerTestActivity", "Comment", c => c.String(unicode: false));
            AddColumn("dbo.SplicerTestActivity", "SubmitDate", c => c.DateTime(nullable: false, precision: 0));
            AddColumn("dbo.SplicerTestActivity", "OnDutyTime", c => c.DateTime(nullable: false, precision: 0));
            AddColumn("dbo.SplicerTestActivity", "TodayJobDoneDate", c => c.DateTime(nullable: false, precision: 0));
            AddColumn("dbo.SplicerTestActivity", "CompletedTime", c => c.DateTime(nullable: false, precision: 0));
            AddColumn("dbo.SplicerTestActivity", "BellNetworkNumber", c => c.String(unicode: false));
            AddColumn("dbo.SplicerTestActivity", "PartnerName", c => c.String(unicode: false));
            AddColumn("dbo.SplicerPrepActivity", "Comment", c => c.String(unicode: false));
            AddColumn("dbo.SplicerCableActivity", "BellNetworkNumber", c => c.String(unicode: false));
            AddColumn("dbo.SplicerCableActivity", "PartnerName", c => c.String(unicode: false));
            AddColumn("dbo.SplicerCableActivity", "OnDutyTime", c => c.DateTime(nullable: false, precision: 0));
            AddColumn("dbo.SplicerCableActivity", "TodayJobDoneDate", c => c.DateTime(nullable: false, precision: 0));
            AddColumn("dbo.SplicerCableActivity", "CompletedTime", c => c.DateTime(nullable: false, precision: 0));
            AddColumn("dbo.SplicerCableActivity", "Action", c => c.String(unicode: false));
            DropColumn("dbo.SplicerPrepActivity", "CableBellNetworkNumber");
            DropColumn("dbo.SplicerPrepActivity", "CablePartnerName");
            DropColumn("dbo.SplicerPrepActivity", "CableOnDutyTime");
            DropColumn("dbo.SplicerPrepActivity", "CableTodayJobDoneDate");
            DropColumn("dbo.SplicerPrepActivity", "CableCompletedTime");
            DropColumn("dbo.SplicerPrepActivity", "TestOnDutyTime");
            DropColumn("dbo.SplicerPrepActivity", "TestTodayJobDoneDate");
            DropColumn("dbo.SplicerPrepActivity", "TestCompletedTime");
            DropColumn("dbo.SplicerPrepActivity", "TestBellNetworkNumber");
            DropColumn("dbo.SplicerPrepActivity", "TestPartnerName");
            DropColumn("dbo.SplicerPrepActivity", "TestComment");
            DropColumn("dbo.SplicerPrepActivity", "TestSubmitDate");
            DropColumn("dbo.SplicerPrepActivity", "TimeSheetComment");
        }
    }
}
