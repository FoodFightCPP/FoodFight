using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FoodFight.Domain.Models
{
    public class BlockedUser : DomainObject
    {
        /// <summary>
        /// Many to Many Table for Blocked Users
        /// </summary>

        [Key]
        [Column("BlockUserID")]
        public Guid BlockUserId { get; set; }
        [Column("BaseUserID")]
        public Guid BaseUserId { get; set; }
        [Column("BlockedUserID")]
        public Guid BlockedUserId { get; set; }

        [ForeignKey(nameof(BaseUserId))]
        [InverseProperty(nameof(User.BlockedUserBaseUsers))]
        public virtual User BaseUser { get; set; }
        [ForeignKey(nameof(BlockedUserId))]
        [InverseProperty(nameof(User.BlockedUserBlockedUserNavigations))]
        public virtual User BlockedUserNavigation { get; set; }

    }
}
