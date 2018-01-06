namespace TeleconApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatePrepTable2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SplicerPrepActivity", "TechName", c => c.String(unicode: false));
            AlterColumn("dbo.SplicerPrepActivity", "Foreman", c => c.String(unicode: false));
            AlterColumn("dbo.SplicerPrepActivity", "Leader", c => c.String(unicode: false));
            AlterColumn("dbo.SplicerPrepActivity", "EnclosureId", c => c.String(unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.SplicerPrepActivity", "EnclosureId", c => c.Int(nullable: false));
            AlterColumn("dbo.SplicerPrepActivity", "Leader", c => c.Int(nullable: false));
            AlterColumn("dbo.SplicerPrepActivity", "Foreman", c => c.Int(nullable: false));
            DropColumn("dbo.SplicerPrepActivity", "TechName");
        }
    }
}
