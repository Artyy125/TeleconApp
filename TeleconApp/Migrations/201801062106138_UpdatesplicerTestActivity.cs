namespace TeleconApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatesplicerTestActivity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SplicerTestActivity", "SplicerTestName", c => c.Boolean(nullable: false));
            DropColumn("dbo.SplicerTestActivity", "GLB");
            DropColumn("dbo.SplicerTestActivity", "AerialRoadSide");
            DropColumn("dbo.SplicerTestActivity", "AerialBackyard");
            DropColumn("dbo.SplicerTestActivity", "Pedestal");
            DropColumn("dbo.SplicerTestActivity", "ReBurn");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SplicerTestActivity", "ReBurn", c => c.Boolean(nullable: false));
            AddColumn("dbo.SplicerTestActivity", "Pedestal", c => c.Boolean(nullable: false));
            AddColumn("dbo.SplicerTestActivity", "AerialBackyard", c => c.Boolean(nullable: false));
            AddColumn("dbo.SplicerTestActivity", "AerialRoadSide", c => c.Boolean(nullable: false));
            AddColumn("dbo.SplicerTestActivity", "GLB", c => c.Boolean(nullable: false));
            DropColumn("dbo.SplicerTestActivity", "SplicerTestName");
        }
    }
}
