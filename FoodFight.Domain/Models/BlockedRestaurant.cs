

namespace FoodFight.Domain.Models
{
    public class BlockedRestaurant : DomainObject
    {
        /// <summary>
        /// Join Table for Blocked Restaurants
        /// </summary>
        public virtual User User { get; set; }
        public virtual Restaurant Restaurant { get; set; }
    }
}