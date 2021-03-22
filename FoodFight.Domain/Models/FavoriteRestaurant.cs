using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FoodFight.Domain.Models
{
    public class FavoriteRestaurant : DomainObject
    {
        /// <summary>
        /// Join Table for favorite restaurants
        /// </summary>

        [Key]
        [Column("FavoriteRestaurantID")]
        public Guid FavoriteRestaurantId { get; set; }
        [Required]
        [Column("RestaurantID")]
        [StringLength(255)]
        public string RestaurantId { get; set; }
        [Column("UserID")]
        public Guid UserId { get; set; }

        [ForeignKey(nameof(RestaurantId))]
        [InverseProperty("FavoriteRestaurants")]
        public virtual Restaurant Restaurant { get; set; }
        [ForeignKey(nameof(UserId))]
        [InverseProperty("FavoriteRestaurants")]
        public virtual User User { get; set; }
    }
}
