using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FoodFight.Domain.Models
{
    public class ConnectedUser : DomainObject
    {
        /// <summary>
        /// Many to Many Table for Connected Users
        /// </summary>

        public ConnectedUser()
        {
            MatchSessions = new HashSet<MatchSession>();
        }

        [Key]
        [Column("ConnectedUserID")]
        public Guid ConnectedUserId { get; set; }
        [Column("BaseUserID")]
        public Guid BaseUserId { get; set; }
        [Column("FriendUserID")]
        public Guid FriendUserId { get; set; }


        public virtual User BaseUser { get; set; }

        public virtual User FriendUser { get; set; }

        public virtual ICollection<MatchSession> MatchSessions { get; set; }
    }
}
