namespace cinema.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial4 : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Films", "Code", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Films", new[] { "Code" });
        }
    }
}
