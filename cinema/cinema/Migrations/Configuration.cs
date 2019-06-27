namespace cinema.Migrations
{
    using cinema.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<cinema.Contexts.FilmDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "cinema.Contexts.FilmDBContext";
        }

        protected override void Seed(cinema.Contexts.FilmDBContext context)
        {
            context.Films.AddOrUpdate(i => i.Title,
            new Film
            {
                Code = "AQTV1906",
                Title = "Annabelle Part3",
                Author = "Gary Dauberman",
                Actor = "Madison Iseman, Mckenna Grace, Vera Farmiga",
                PublicationDate = new DateTime(2019, 06, 26),
                Content = "Content of Annalbell film",
                Image = "annabelle.jpg"

            },
            new Film
            {
                Code = "CCDC1906",
                Title = "Toy Story",
                Author = "Josh Cooley",
                Actor = "Tom Hanks, Tim Allen",
                PublicationDate =  new DateTime(2019,06,21),
                Content = "Bonnie brings all toys to trvel with family",
                Image = "toystory.jpg"

            },
            new Film
            {
                Code = "AQTV0000",
                Title = "Annabelle Part000",
                Author = "xxx",
                Actor = "aa and bb",
                PublicationDate = new DateTime(2019,06,12),
                Content = "Content of Annalbell film",
                Image = "xxx.jpg"

            }


        );
        }
    }
}
