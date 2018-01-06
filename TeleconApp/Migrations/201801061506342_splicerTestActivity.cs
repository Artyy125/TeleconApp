namespace TeleconApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class splicerTestActivity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SplicerTestActivity",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SplicerPrepActivityId = c.Int(nullable: false),
                        ARB = c.String(unicode: false),
                        GLB = c.Boolean(nullable: false),
                        AerialRoadSide = c.Boolean(nullable: false),
                        AerialBackyard = c.Boolean(nullable: false),
                        Pedestal = c.Boolean(nullable: false),
                        ReBurn = c.Boolean(nullable: false),
                        PartnerName = c.String(unicode: false),
                        BellNetworkNumber = c.String(unicode: false),
                        CompletedTime = c.DateTime(nullable: false, precision: 0),
                        TodayJobDoneDate = c.DateTime(nullable: false, precision: 0),
                        OnDutyTime = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SplicerTestActivity");
        }
    }
}
