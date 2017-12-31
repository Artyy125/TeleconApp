namespace TeleconApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AllTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CableType",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50, storeType: "nvarchar"),
                        FibreCount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CivilTask",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Division",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Drill",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Enclosure",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Network",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BellNetworkNumber = c.String(maxLength: 50, storeType: "nvarchar"),
                        MaxARB = c.String(maxLength: 3, storeType: "nvarchar"),
                        UtilityCutPermit = c.String(maxLength: 20, storeType: "nvarchar"),
                        PermitTypeStream = c.String(maxLength: 20, storeType: "nvarchar"),
                        LocationName = c.String(maxLength: 50, storeType: "nvarchar"),
                        District = c.String(maxLength: 20, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SplicerCableActivity",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SplcerPrepActivityId = c.Int(nullable: false),
                        CableId = c.String(unicode: false),
                        FibreCount = c.Int(nullable: false),
                        Action = c.String(unicode: false),
                        CompletedTime = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SplicerPrepActivity",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmployeeId = c.Int(nullable: false),
                        Foreman = c.Int(nullable: false),
                        Leader = c.Int(nullable: false),
                        EnclosureId = c.Int(nullable: false),
                        ARB = c.String(unicode: false),
                        JobStart = c.DateTime(nullable: false, precision: 0),
                        JobFinishAtSite = c.DateTime(nullable: false, precision: 0),
                        ArriveAtShop = c.DateTime(nullable: false, precision: 0),
                        JobFinish = c.DateTime(nullable: false, precision: 0),
                        Odometer = c.String(unicode: false),
                        Comment = c.String(unicode: false),
                        PartnerName = c.String(unicode: false),
                        BellNetworkNumber = c.String(unicode: false),
                        VehiclePlateNumber = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SplicingPrep",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SplicingTest",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.VacTruck",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Vehicle",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PlateNumber = c.String(maxLength: 50, storeType: "nvarchar"),
                        UnitId = c.String(maxLength: 50, storeType: "nvarchar"),
                        Type = c.String(maxLength: 50, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Vehicle");
            DropTable("dbo.VacTruck");
            DropTable("dbo.SplicingTest");
            DropTable("dbo.SplicingPrep");
            DropTable("dbo.SplicerPrepActivity");
            DropTable("dbo.SplicerCableActivity");
            DropTable("dbo.Network");
            DropTable("dbo.Enclosure");
            DropTable("dbo.Drill");
            DropTable("dbo.Division");
            DropTable("dbo.CivilTask");
            DropTable("dbo.CableType");
        }
    }
}
