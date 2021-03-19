using System;
using System.Collections.Generic;
using System.Text;

namespace FoodFight.Domain.Models
{
    public class Restaurant : DomainObject
    {
        /// <summary>
        /// Model for returned restaurant from Google Places API
        /// </summary>
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
