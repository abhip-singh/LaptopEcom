namespace ELaptop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dboOrdersElementUpdate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Orders", "Customer_Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Orders", "Customer_Name", c => c.String(nullable: false, maxLength: 255));
        }
    }
}
