using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FoodFight.Domain.Models
{
    public class AcceptedRestaurant : DomainObject
    {
        /// <summary>
        /// Join Table for Accepted Restaurants
        /// </summary>

        public AcceptedRestaurant()
        {
            MatchedRestaurants = new HashSet<MatchedRestaurant>();
        }

        [Key]
        [Column("AcceptedRestaurantID")]
        public Guid AcceptedRestaurantId { get; set; }
        [Column("SwipeListID")]
        public Guid SwipeListId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateTime { get; set; }
        [Required]
        [Column("UserID")]
        [StringLength(50)]
        public string UserId { get; set; }

        [ForeignKey(nameof(SwipeListId))]
        [InverseProperty("AcceptedRestaurants")]
        public virtual SwipeList SwipeList { get; set; }
        [InverseProperty(nameof(MatchedRestaurant.AcceptedRestaurant))]
        public virtual ICollection<MatchedRestaurant> MatchedRestaurants { get; set; }
    }
}
