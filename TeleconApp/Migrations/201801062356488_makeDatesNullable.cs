namespace TeleconApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class makeDatesNullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.SplicerPrepActivity", "JobStart", c => c.DateTime(precision: 0));
            AlterColumn("dbo.SplicerPrepActivity", "JobFinishAtSite", c => c.DateTime(precision: 0));
            AlterColumn("dbo.SplicerPrepActivity", "JobFinish", c => c.DateTime(precision: 0));
            AlterColumn("dbo.SplicerPrepActivity", "TimeSheetDate", c => c.DateTime(precision: 0));
            AlterColumn("dbo.SplicerPrepActivity", "PreparationTime", c => c.DateTime(precision: 0));
            AlterColumn("dbo.SplicerPrepActivity", "PrepSubmitDate", c => c.DateTime(precision: 0));
            AlterColumn("dbo.SplicerPrepActivity", "TimeSheetSubmitDate", c => c.DateTime(precision: 0));
            AlterColumn("dbo.SplicerPrepActivity", "TestSubmitDate", c => c.DateTime(precision: 0));
            AlterColumn("dbo.SplicerPrepActivity", "TestCompletedTime", c => c.DateTime(precision: 0));
            AlterColumn("dbo.SplicerPrepActivity", "TestTodayJobDoneDate", c => c.DateTime(precision: 0));
            AlterColumn("dbo.SplicerPrepActivity", "TestOnDutyTime", c => c.DateTime(precision: 0));
            AlterColumn("dbo.SplicerPrepActivity", "CableCompletedTime", c => c.DateTime(precision: 0));
            AlterColumn("dbo.SplicerPrepActivity", "CableTodayJobDoneDate", c => c.DateTime(precision: 0));
            AlterColumn("dbo.SplicerPrepActivity", "CableOnDutyTime", c => c.DateTime(precision: 0));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.SplicerPrepActivity", "CableOnDutyTime", c => c.DateTime(nullable: false, precision: 0));
            AlterColumn("dbo.SplicerPrepActivity", "CableTodayJobDoneDate", c => c.DateTime(nullable: false, precision: 0));
            AlterColumn("dbo.SplicerPrepActivity", "CableCompletedTime", c => c.DateTime(nullable: false, precision: 0));
            AlterColumn("dbo.SplicerPrepActivity", "TestOnDutyTime", c => c.DateTime(nullable: false, precision: 0));
            AlterColumn("dbo.SplicerPrepActivity", "TestTodayJobDoneDate", c => c.DateTime(nullable: false, precision: 0));
            AlterColumn("dbo.SplicerPrepActivity", "TestCompletedTime", c => c.DateTime(nullable: false, precision: 0));
            AlterColumn("dbo.SplicerPrepActivity", "TestSubmitDate", c => c.DateTime(nullable: false, precision: 0));
            AlterColumn("dbo.SplicerPrepActivity", "TimeSheetSubmitDate", c => c.DateTime(nullable: false, precision: 0));
            AlterColumn("dbo.SplicerPrepActivity", "PrepSubmitDate", c => c.DateTime(nullable: false, precision: 0));
            AlterColumn("dbo.SplicerPrepActivity", "PreparationTime", c => c.DateTime(nullable: false, precision: 0));
            AlterColumn("dbo.SplicerPrepActivity", "TimeSheetDate", c => c.DateTime(nullable: false, precision: 0));
            AlterColumn("dbo.SplicerPrepActivity", "JobFinish", c => c.DateTime(nullable: false, precision: 0));
            AlterColumn("dbo.SplicerPrepActivity", "JobFinishAtSite", c => c.DateTime(nullable: false, precision: 0));
            AlterColumn("dbo.SplicerPrepActivity", "JobStart", c => c.DateTime(nullable: false, precision: 0));
        }
    }
}
