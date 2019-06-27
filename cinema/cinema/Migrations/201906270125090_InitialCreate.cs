namespace cinema.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Films",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Code = c.String(maxLength: 60),
                        Title = c.String(maxLength: 60),
                        Author = c.String(maxLength: 60),
                        Actor = c.String(maxLength: 60),
                        PublicationDate = c.DateTime(nullable: false),
                        Content = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Films");
        }
    }
}
