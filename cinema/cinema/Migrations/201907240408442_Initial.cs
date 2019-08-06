namespace cinema.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
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
                        ContentFilm = c.String(),
                        Image = c.String(),
                        IsEnable = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Name = c.String(),
                        IsEnable = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Name = c.String(),
                        RowQuantity = c.Int(nullable: false),
                        ColumnQuantity = c.Int(nullable: false),
                        IsEnable = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Seats",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        RoomID = c.Int(nullable: false),
                        SeattypeID = c.Int(nullable: false),
                        Rowth = c.Int(nullable: false),
                        Columnth = c.Int(nullable: false),
                        IsEnable = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Seattypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Name = c.String(),
                        PlusPrice = c.Int(nullable: false),
                        IsEnable = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Showtimes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FilmID = c.Int(nullable: false),
                        SlotID = c.Int(nullable: false),
                        OriginPrice = c.Int(nullable: false),
                        IsEnable = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Slots",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        RoomID = c.Int(nullable: false),
                        TimeslotID = c.Int(nullable: false),
                        Description = c.String(),
                        IsEnable = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Tickets",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ShowtimeID = c.Int(nullable: false),
                        SeatID = c.Int(nullable: false),
                        Price = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Timeslots",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        BeginTime = c.DateTime(nullable: false),
                        EndTime = c.DateTime(nullable: false),
                        IsEnable = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.User_Ticket",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        TicketID = c.Int(nullable: false),
                        Booktime = c.DateTime(nullable: false),
                        IsEnable = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Username = c.String(maxLength: 60),
                        Password = c.String(maxLength: 60),
                        Fullname = c.String(maxLength: 60),
                        Gender = c.Boolean(nullable: false),
                        Birthdate = c.DateTime(nullable: false),
                        Phone = c.String(),
                        RoleID = c.Int(nullable: false),
                        IsEnable = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.User_Ticket");
            DropTable("dbo.Timeslots");
            DropTable("dbo.Tickets");
            DropTable("dbo.Slots");
            DropTable("dbo.Showtimes");
            DropTable("dbo.Seattypes");
            DropTable("dbo.Seats");
            DropTable("dbo.Rooms");
            DropTable("dbo.Roles");
            DropTable("dbo.Films");
        }
    }
}
