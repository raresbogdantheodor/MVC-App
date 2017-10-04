namespace MVC_App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RequiredAnoForName : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Trains", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Trains", "Name", c => c.String());
        }
    }
}
