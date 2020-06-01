namespace RoboboKitchenProject.DAL.Impl.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DBmigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CookEntities", "Qualification", c => c.String());
            DropColumn("dbo.CookEntities", "Specialization");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CookEntities", "Specialization", c => c.String());
            DropColumn("dbo.CookEntities", "Qualification");
        }
    }
}
