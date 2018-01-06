namespace TeleconApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addCommentField : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SplicerTestActivity", "Comment", c => c.String(unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.SplicerTestActivity", "Comment");
        }
    }
}
