namespace ELaptop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dboOrdersElementUpdate2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Orders", "Product_Name", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Orders", "Product_Name", c => c.String(nullable: false));
        }
    }
}
