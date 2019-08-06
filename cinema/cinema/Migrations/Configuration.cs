namespace cinema.Migrations
{
    using cinema.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<cinema.Contexts.DBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(cinema.Contexts.DBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Films.AddOrUpdate(x => x.ID,
            new Film() { ID = 1, Code = "Film01", Title = "Lion King",
                Author = "Author1", Actor = "Actor1",
                PublicationDate = new DateTime(2019,07,02),
                ContentFilm = "A cute lion...", IsEnable = true},
            new Film() { ID = 2, Code = "Film02", Title = "Lion King P2",
                Author = "Author2", Actor = "Actor1",
                PublicationDate = new DateTime(2019, 07, 02),
                ContentFilm = "A cute lion...", IsEnable = true }
              
            );

            context.Timeslots.AddOrUpdate(x => x.ID,
            new Timeslot() { ID = 1,
                BeginTime = new DateTime(2019,07,21,13,30,00),
                EndTime = new DateTime(2019, 07, 21, 15, 30, 00),
                IsEnable = true },

             new Timeslot() { ID = 2,
                 BeginTime = new DateTime(2019, 07, 22, 13, 30, 00),
                 EndTime = new DateTime(2019, 07, 22, 15, 30, 00),
                 IsEnable = true }
            );

            context.Rooms.AddOrUpdate(x => x.ID,
                new Room() { ID = 1, Code = "Ro01", Name= "Room01",
                    ColumnQuantity =12, RowQuantity = 7, IsEnable = true},

                new Room() { ID = 2, Code = "Ro02", Name = "Room02",
                    ColumnQuantity = 12, RowQuantity = 7, IsEnable = true }
            );

            context.Roles.AddOrUpdate(x => x.ID,
                new Role() { ID = 1, Code = "admin", Name= "admimmm", IsEnable = true},
                new Role() { ID = 2, Code = "user", Name = "common user", IsEnable = true }
            );

            context.Users.AddOrUpdate(x => x.ID,
                new User() { ID = 1, Username = "khanhntn", Password = "12345",
                    Fullname = "KhanhNTN", Gender = false,
                    Birthdate = new DateTime(1999, 01, 01),
                    Phone = "0123456789", RoleID = 1, IsEnable = true },

                new User() { ID = 2, Username = "khanhntn2", Password = "12345",
                    Fullname = "KhanhNTN2", Gender = false,
                    Birthdate = new DateTime(1999, 01, 01),
                    Phone = "0123456789", RoleID = 2, IsEnable = true }
            );

        }
    }
}
