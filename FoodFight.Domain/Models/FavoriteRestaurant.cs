using System;
using System.Collections.Generic;
using System.Text;

namespace FoodFight.Domain.Models
{
    public class FavoriteRestaurant : DomainObject
    {
        /// <summary>
        /// Join Table for favorite restaurants
        /// </summary>
        public virtual User User { get; set; }
        public virtual Restaurant Restaurant { get; set; }
    }
}
