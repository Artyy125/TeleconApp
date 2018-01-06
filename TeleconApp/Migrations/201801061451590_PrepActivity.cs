namespace TeleconApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PrepActivity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SplicerCableActivity", "SplicerPrepActivityId", c => c.Int(nullable: false));
            AddColumn("dbo.SplicerCableActivity", "SplicerPrepped", c => c.Boolean(nullable: false));
            AddColumn("dbo.SplicerCableActivity", "SplicerDeRebonized", c => c.Boolean(nullable: false));
            AddColumn("dbo.SplicerCableActivity", "SplicerRibbon", c => c.Boolean(nullable: false));
            AddColumn("dbo.SplicerCableActivity", "SplicerSingle", c => c.Boolean(nullable: false));
            AddColumn("dbo.SplicerCableActivity", "SplicerMissing", c => c.Boolean(nullable: false));
            AddColumn("dbo.SplicerPrepActivity", "OnDutyTime", c => c.DateTime(nullable: false, precision: 0));
            AddColumn("dbo.SplicerPrepActivity", "TodayJobDoneDate", c => c.DateTime(nullable: false, precision: 0));
            AddColumn("dbo.SplicerPrepActivity", "PreparationTime", c => c.DateTime(nullable: false, precision: 0));
            DropColumn("dbo.SplicerCableActivity", "SplcerPrepActivityId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SplicerCableActivity", "SplcerPrepActivityId", c => c.Int(nullable: false));
            DropColumn("dbo.SplicerPrepActivity", "PreparationTime");
            DropColumn("dbo.SplicerPrepActivity", "TodayJobDoneDate");
            DropColumn("dbo.SplicerPrepActivity", "OnDutyTime");
            DropColumn("dbo.SplicerCableActivity", "SplicerMissing");
            DropColumn("dbo.SplicerCableActivity", "SplicerSingle");
            DropColumn("dbo.SplicerCableActivity", "SplicerRibbon");
            DropColumn("dbo.SplicerCableActivity", "SplicerDeRebonized");
            DropColumn("dbo.SplicerCableActivity", "SplicerPrepped");
            DropColumn("dbo.SplicerCableActivity", "SplicerPrepActivityId");
        }
    }
}
