namespace TeleconApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class makeDatesNullable2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.SplicerPrepActivity", "ArriveAtShop", c => c.DateTime(precision: 0));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.SplicerPrepActivity", "ArriveAtShop", c => c.DateTime(nullable: false, precision: 0));
        }
    }
}
