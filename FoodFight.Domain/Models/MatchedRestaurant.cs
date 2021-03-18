using FoodFight.Models;

namespace FoodFight.Domain.Models
{
    public class MatchedRestaurants : DomainObject
    {
        /// <summary>
        /// Join Table for Matched Restaurants during matching session
        /// </summary>
        public Users Users { get; set; }
        // This table is for generating the list of matched restaurants
    }
}