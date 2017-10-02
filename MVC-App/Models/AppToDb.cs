using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC_App.Models
{
    public class AppToDb : DbContext
    {
        public AppToDb() : base("name = TrainsConnection")
        {

        }
        public DbSet<Train> Trains { get; set; }

    }
}