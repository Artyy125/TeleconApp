namespace TeleconApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatesplicerTestActivity2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.SplicerTestActivity", "SplicerTestName", c => c.String(unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.SplicerTestActivity", "SplicerTestName", c => c.Boolean(nullable: false));
        }
    }
}
