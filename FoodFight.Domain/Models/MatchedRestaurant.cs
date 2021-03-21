using System;
using System.Collections.Generic;
using System.Text;

namespace FoodFight.Domain.Models
{
    public class MatchedRestaurant : DomainObject
    {
        /// <summary>
        /// Join Table for Matched Restaurants during matching session
        /// </summary>

        public int SessionId { get; set; }
        public virtual Session Session { get; set; }

        public int RestuarantId { get; set; }
        public virtual Restaurant Restaurant { get; set; }
    }
}
