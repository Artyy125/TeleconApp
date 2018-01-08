namespace TeleconApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class telegram : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SplicerPrepActivity", "Telegram", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.SplicerPrepActivity", "Telegram");
        }
    }
}
