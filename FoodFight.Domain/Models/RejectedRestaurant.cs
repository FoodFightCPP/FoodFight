using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FoodFight.Domain.Models
{
    public class RejectedRestaurant : DomainObject
    {
/// <summary>
/// Join Table for Rejected Restaurants
/// </summary>
        [Key]
        [Column("RejectedRestaurantID")]
        public Guid RejectedRestaurantId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateTime { get; set; }
        [Column("SwipeListID")]
        public Guid SwipeListId { get; set; }
        [Required]
        [Column("UserID")]
        [StringLength(50)]
        public string UserId { get; set; }

        [ForeignKey(nameof(SwipeListId))]
        [InverseProperty("RejectedRestaurants")]
        public virtual SwipeList SwipeList { get; set; }
    }
}
