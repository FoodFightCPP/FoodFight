using System.Runtime;
using FoodFight.Domain.Models;

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