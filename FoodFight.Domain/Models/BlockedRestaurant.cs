using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FoodFight.Domain.Models
{
    public class BlockedRestaurant : DomainObject
    {

        [Key]
        [Column("BlockedRestaurantID")]
        public Guid BlockedRestaurantId { get; set; }
        [Required]
        [Column("RestaurantID")]
        [StringLength(255)]
        public string RestaurantId { get; set; }
        [Column("UserID")]
        public Guid UserId { get; set; }

        [ForeignKey(nameof(RestaurantId))]
        [InverseProperty("BlockedRestaurants")]
        public virtual Restaurant Restaurant { get; set; }
        [ForeignKey(nameof(UserId))]
        [InverseProperty("BlockedRestaurants")]
        public virtual User User { get; set; }
    }
}
