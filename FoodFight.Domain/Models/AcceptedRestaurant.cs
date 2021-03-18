

namespace FoodFight.Domain.Models
{
    public class AcceptedRestaurant : DomainObject
    {
        /// <summary>
        /// Join Table for Accepted Restaurants
        /// </summary>

        public int UserId { get; set; }
        public virtual User User { get; set; }

        public int RestaurantId { get; set; }
        public virtual Restaurant Restaurant { get; set; }
    }
}