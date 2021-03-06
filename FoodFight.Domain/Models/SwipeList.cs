﻿using System.Collections.Generic;

namespace FoodFight.Domain.Models
{
    public class SwipeList : DomainObject
    {
        public int SessionId { get; set; }
        public virtual Session Session { get; set; }

        public int RestaurantId { get; set; }
        public virtual ICollection<Restaurant> Restaurant { get; set; }
    }
}