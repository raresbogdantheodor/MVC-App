using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_App.Models
{
    public class Train
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public TrainCategory? TrainType { get; set; }

        public enum TrainCategory
        {
            HighSpeed,
            Maglev,
            InterCity,
            ShortDistance
        }
    }
}