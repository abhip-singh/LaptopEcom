namespace ELaptop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dboOrders : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Product_Name = c.String(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Customer_Name = c.String(nullable: false, maxLength: 255),
                        Cusomer_Address = c.String(nullable: false),
                        Customer_Phone = c.String(nullable: false),
                        Created = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Orders");
        }
    }
}
