namespace RoboboKitchenProject.DAL.Impl.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mgrDB : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.CookSpecializationEntities", "CookID", "dbo.CookEntities");
            DropForeignKey("dbo.CookSpecializationEntities", "SpecializationID", "dbo.SpecializationEntities");
            DropIndex("dbo.CookSpecializationEntities", new[] { "CookID" });
            DropIndex("dbo.CookSpecializationEntities", new[] { "SpecializationID" });
            AlterColumn("dbo.CookSpecializationEntities", "CookID", c => c.Int(nullable: false));
            AlterColumn("dbo.CookSpecializationEntities", "SpecializationID", c => c.Int(nullable: false));
            CreateIndex("dbo.CookSpecializationEntities", "CookID");
            CreateIndex("dbo.CookSpecializationEntities", "SpecializationID");
            AddForeignKey("dbo.CookSpecializationEntities", "CookID", "dbo.CookEntities", "ID", cascadeDelete: true);
            AddForeignKey("dbo.CookSpecializationEntities", "SpecializationID", "dbo.SpecializationEntities", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CookSpecializationEntities", "SpecializationID", "dbo.SpecializationEntities");
            DropForeignKey("dbo.CookSpecializationEntities", "CookID", "dbo.CookEntities");
            DropIndex("dbo.CookSpecializationEntities", new[] { "SpecializationID" });
            DropIndex("dbo.CookSpecializationEntities", new[] { "CookID" });
            AlterColumn("dbo.CookSpecializationEntities", "SpecializationID", c => c.Int());
            AlterColumn("dbo.CookSpecializationEntities", "CookID", c => c.Int());
            CreateIndex("dbo.CookSpecializationEntities", "SpecializationID");
            CreateIndex("dbo.CookSpecializationEntities", "CookID");
            AddForeignKey("dbo.CookSpecializationEntities", "SpecializationID", "dbo.SpecializationEntities", "ID");
            AddForeignKey("dbo.CookSpecializationEntities", "CookID", "dbo.CookEntities", "ID");
        }
    }
}
