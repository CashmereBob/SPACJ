namespace Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Data.DataEntities>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Data.DataEntities context)
        {
            using (var ctx = new DataEntities())
            {

                var linkHammargruppen = new Link {
                    Title = "Hammargruppen",
                    Url = string.Format(@"http://www.hammargruppen.se/")
                };

                var linkGrafford = new Link
                {
                    Title = "Grafford",
                    Url = string.Format(@"http://www.grafford.se/")
                };

                ctx.Links.AddOrUpdate(linkHammargruppen);
                ctx.Links.AddOrUpdate(linkGrafford);
                ctx.SaveChanges();

                var page = new Page {
                    Title = "Hammargruppen",
                    Header = "Crockett & Jones",
                    TitleContent = "Bacon ipsum dolor amet boudin doner meatball, picanha shankle swine t-bone flank bacon andouille sirloin ground round. Pork chop pancetta salami, chicken alcatra doner pig. Shankle boudin chuck tongue pork loin, sausage bresaola capicola turducken alcatra. Swine pork sausage, tail tri-tip andouille flank capicola pork chop shankle prosciutto cupim. Salami hamburger cow short loin bresaola prosciutto corned beef sausage ribeye andouille shank. Capicola picanha alcatra beef ribs. Pork belly meatloaf swine ham, cupim t-bone pig shankle jerky ground round ribeye kevin.",
                    HeaderContent = "Short loin cow swine ham sausage pork belly t-bone. Andouille pork chop tail boudin flank. Rump beef ribs frankfurter pig pork loin bresaola tri-tip salami jerky. Chuck pork loin shank prosciutto. T-bone spare ribs frankfurter, tail alcatra pork ball tip hamburger fatback ground round pork belly kevin sausage. Ground round beef ribs chuck pork belly, corned beef filet mignon leberkas brisket swine pastrami turkey. Picanha jerky beef ribs, bresaola turkey rump prosciutto salami tail sirloin cupim landjaeger.",
                    HeaderImage = string.Format(@"https://pbs.twimg.com/profile_images/526670575981174784/zk_UfeHG.jpeg"),
                    TitleImage = string.Format(@"http://www.hammargruppen.se/images/header_left.png"),
                };

                ctx.Pages.AddOrUpdate(page);
                ctx.SaveChanges();
                page.Links.Add(linkHammargruppen);
                page.Links.Add(linkGrafford);

                var user = new User {
                    Username = "admin",
                    Password = "password"
                };

                ctx.Users.AddOrUpdate(user);
                ctx.SaveChanges();

            };

        }
    }
}
