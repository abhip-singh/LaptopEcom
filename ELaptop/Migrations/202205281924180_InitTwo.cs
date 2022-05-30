﻿namespace ELaptop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitTwo : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "ImagePath", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "ImagePath", c => c.String(nullable: false));
        }
    }
}
