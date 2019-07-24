namespace cinema.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Seats", "SeattypeID", c => c.Int(nullable: false));
            AddColumn("dbo.Seattypes", "PlusPrice", c => c.Int(nullable: false));
            AddColumn("dbo.Showtimes", "OriginPrice", c => c.Int(nullable: false));
            AddColumn("dbo.Tickets", "Price", c => c.Int(nullable: false));
            DropTable("dbo.PriceTables");
            DropTable("dbo.Room_Seattype");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Room_Seattype",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        RoomID = c.Int(nullable: false),
                        Rowth = c.Int(nullable: false),
                        SeattypeID = c.Int(nullable: false),
                        IsEnable = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.PriceTables",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ShowtimeID = c.Int(nullable: false),
                        SeattypeID = c.Int(nullable: false),
                        Price = c.Double(nullable: false),
                        IsEnable = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            DropColumn("dbo.Tickets", "Price");
            DropColumn("dbo.Showtimes", "OriginPrice");
            DropColumn("dbo.Seattypes", "PlusPrice");
            DropColumn("dbo.Seats", "SeattypeID");
        }
    }
}
