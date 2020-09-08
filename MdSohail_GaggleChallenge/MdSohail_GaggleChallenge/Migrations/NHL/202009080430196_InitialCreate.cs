namespace MdSohail_GaggleChallenge.Migrations.NHL
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Products");
            AlterColumn("dbo.Products", "GUID", c => c.String(nullable: false, maxLength: 60));
            AddPrimaryKey("dbo.Products", "GUID");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Products");
            AlterColumn("dbo.Products", "GUID", c => c.String(nullable: false, maxLength: 30));
            AddPrimaryKey("dbo.Products", "GUID");
        }
    }
}
