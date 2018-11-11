namespace EntityFrameworkDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UniqueFields : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Categories", "Name", c => c.String(maxLength: 450));
            AlterColumn("dbo.Products", "Name", c => c.String(maxLength: 450));
            CreateIndex("dbo.Categories", "Name", unique: true);
            CreateIndex("dbo.Products", "Name", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Products", new[] { "Name" });
            DropIndex("dbo.Categories", new[] { "Name" });
            AlterColumn("dbo.Products", "Name", c => c.String());
            AlterColumn("dbo.Categories", "Name", c => c.String());
        }
    }
}
