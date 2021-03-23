using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Newtonsoft.Json;

namespace FoodFight.Domain.Models
{
    public class FavoriteRestaurant : DomainObject
    {
        /// <summary>
        /// Join Table for favorite restaurants
        /// </summary>

        [JsonProperty("favoriteRestaurantId")]
        public Guid FavoriteRestaurantId { get; set; }
        [JsonProperty("restaurantId")]
        public string RestaurantId { get; set; }
        [JsonProperty("userId")]
        public Guid UserId { get; set; }

        [JsonProperty("restaurant")]
        public virtual Restaurant Restaurant { get; set; }

        [JsonProperty("user")]
        public virtual User User { get; set; }
    }
}
