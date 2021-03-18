using System;
using System.Collections.Generic;
using System.Text;

namespace FoodFight.Models
{
    public class Restaurant
    {
        public int RestId { get; set; }
        public string FormattedAddress { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Name { get; set; }
        public string OpenNow { get; set; }
        public string Photo { get; set; }
        public double Rating { get; set; }
        public long Phone { get; set; }
        public string Website { get; set; }
    }
}
