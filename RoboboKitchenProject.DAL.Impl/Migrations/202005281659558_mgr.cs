namespace RoboboKitchenProject.DAL.Impl.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mgr : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CookEntities",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Specialization = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.CookSpecializationEntities",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CookID = c.Int(),
                        SpecializationID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.CookEntities", t => t.CookID)
                .ForeignKey("dbo.SpecializationEntities", t => t.SpecializationID)
                .Index(t => t.CookID)
                .Index(t => t.SpecializationID);
            
            CreateTable(
                "dbo.SpecializationEntities",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.DishEntities",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Indgradients = c.String(),
                        CookingTime = c.Double(nullable: false),
                        Type = c.String(),
                        Weight = c.Double(nullable: false),
                        Cost = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CookSpecializationEntities", "SpecializationID", "dbo.SpecializationEntities");
            DropForeignKey("dbo.CookSpecializationEntities", "CookID", "dbo.CookEntities");
            DropIndex("dbo.CookSpecializationEntities", new[] { "SpecializationID" });
            DropIndex("dbo.CookSpecializationEntities", new[] { "CookID" });
            DropTable("dbo.DishEntities");
            DropTable("dbo.SpecializationEntities");
            DropTable("dbo.CookSpecializationEntities");
            DropTable("dbo.CookEntities");
        }
    }
}
