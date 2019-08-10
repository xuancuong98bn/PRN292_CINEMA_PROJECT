namespace cinema.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Slots", "Description", c => c.String());
            CreateIndex("dbo.Films", "Code", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Films", new[] { "Code" });
            DropColumn("dbo.Slots", "Description");
        }
    }
}
