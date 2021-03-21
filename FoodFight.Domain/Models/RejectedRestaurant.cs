using System;
using System.Collections.Generic;
using System.Text;

namespace FoodFight.Domain.Models
{
    public class RejectedRestaurant : DomainObject
    {
        /// <summary>
        /// Join Table for Rejected Restaurants
        /// </summary>
        public virtual User User { get; set; }
        public virtual Restaurant Restaurant { get; set; }
    }
}
