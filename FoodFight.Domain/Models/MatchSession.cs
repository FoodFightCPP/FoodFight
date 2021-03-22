using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FoodFight.Domain.Models
{
    public class MatchSession : DomainObject 
    {
        /// <summary>
        /// Join Table for Session Data
        /// </summary>
        public MatchSession()
        {
            SwipeLists = new HashSet<SwipeList>();
        }

        [Key]
        [Column("MatchSessionID")]
        public Guid MatchSessionId { get; set; }
        [Column("ConnectedUserID")]
        public Guid ConnectedUserId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateTime { get; set; }
        [StringLength(50)]
        public string Lat { get; set; }
        [StringLength(50)]
        public string Lng { get; set; }

        [ForeignKey(nameof(ConnectedUserId))]
        [InverseProperty("MatchSessions")]
        public virtual ConnectedUser ConnectedUser { get; set; }
        [InverseProperty(nameof(SwipeList.MatchSession))]
        public virtual ICollection<SwipeList> SwipeLists { get; set; }
    }
}
