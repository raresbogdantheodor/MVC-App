namespace MVC_App.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MVC_App.Models.TrainsToDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MVC_App.Models.TrainsToDb context)
        {
            
            //for (int i = 0; i < 100; i++)
            //{
            //    context.Trains.AddOrUpdate(t => t.Name, new Models.Train { Name = "InterRegio", TrainType = Models.Train.TrainCategory.Maglev });
            //}
            
        }
    }
}
