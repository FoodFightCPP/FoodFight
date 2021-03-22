using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FoodFight.Domain.Models
{
    public class MatchedRestaurant : DomainObject
    {
        /// <summary>
        /// Join Table for Matched Restaurants during matching session
        /// </summary>

        [Key]
        [Column("MatchRestaurantID")]
        public Guid MatchRestaurantId { get; set; }
        [Column("DateTIme", TypeName = "datetime")]
        public DateTime DateTime { get; set; }
        [Column("AcceptedRestaurantID")]
        public Guid AcceptedRestaurantId { get; set; }

        [ForeignKey(nameof(AcceptedRestaurantId))]
        [InverseProperty("MatchedRestaurants")]
        public virtual AcceptedRestaurant AcceptedRestaurant { get; set; }
    }
}
