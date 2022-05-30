namespace ELaptop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProductFields : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Storage", c => c.Int(nullable: false));
            AddColumn("dbo.Products", "CPU", c => c.String(nullable: false));
            AddColumn("dbo.Products", "RAM", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "RAM");
            DropColumn("dbo.Products", "CPU");
            DropColumn("dbo.Products", "Storage");
        }
    }
}
