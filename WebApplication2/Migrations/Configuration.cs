namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebApplication2.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApplication2.Models.CricketerDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "WebApplication2.Models.CricketerDBContext";
        }

        protected override void Seed(WebApplication2.Models.CricketerDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.Cricketers.AddOrUpdate(i => i.Name,
                new Cricketer
                {
                    Name = "Sachin Tendulkar",
                    ODI = 463,
                    Test = 198,
                    Grade = "A" 
                },
                new Cricketer
                {
                    Name = "Saurav Ganguly",
                    ODI = 311,
                    Test = 113,
                    Grade = "A" 
                }, 
                new Cricketer 
                { 
                    Name = "Rahul Dravid", 
                    ODI = 344, 
                    Test = 164,
                    Grade = "A" 
                },
                new Cricketer 
                { 
                    Name = "Ricky Ponting", 
                    ODI = 375, 
                    Test = 168,
                    Grade = "A" 
                }, 
                new Cricketer 
                { 
                    Name = "Wasim Akram", 
                    ODI = 356, 
                    Test = 104,
                    Grade = "A" 
                }, 
                new Cricketer 
                { 
                    Name = "Jacques Kallis", 
                    ODI = 321, 
                    Test = 162,
                    Grade = "A" 
                }, 
                new Cricketer 
                { 
                    Name = "Sanath Jayasuriya", 
                    ODI = 445, 
                    Test = 110,
                    Grade = "A" 
                });
        }
    }
}
