namespace EntityFrameworkDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Extension : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderId = c.Int(nullable: false, identity: true),
                        CustomerId = c.String(maxLength: 128),
                        Notes = c.String(maxLength: 256),
                        OrderedDateTime = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.OrderId)
                .ForeignKey("dbo.Customers", t => t.CustomerId)
                .Index(t => t.CustomerId);
            
            CreateTable(
                "dbo.OrderProducts",
                c => new
                    {
                        Order_OrderId = c.Int(nullable: false),
                        Product_ProductId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Order_OrderId, t.Product_ProductId })
                .ForeignKey("dbo.Orders", t => t.Order_OrderId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.Product_ProductId, cascadeDelete: true)
                .Index(t => t.Order_OrderId)
                .Index(t => t.Product_ProductId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderProducts", "Product_ProductId", "dbo.Products");
            DropForeignKey("dbo.OrderProducts", "Order_OrderId", "dbo.Orders");
            DropForeignKey("dbo.Orders", "CustomerId", "dbo.Customers");
            DropIndex("dbo.OrderProducts", new[] { "Product_ProductId" });
            DropIndex("dbo.OrderProducts", new[] { "Order_OrderId" });
            DropIndex("dbo.Orders", new[] { "CustomerId" });
            DropTable("dbo.OrderProducts");
            DropTable("dbo.Orders");
        }
    }
}
