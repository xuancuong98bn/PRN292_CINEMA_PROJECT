namespace cinema.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Films", "Image", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Films", "Image");
        }
    }
}
