namespace RoboboKitchenProject.DAL.Impl.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mgrFinalFix : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OrderEntities",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        NameOfDish = c.String(),
                        OrderTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.OrderEntities");
        }
    }
}
