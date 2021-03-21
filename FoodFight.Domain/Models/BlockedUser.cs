using System;
using System.Collections.Generic;
using System.Text;

namespace FoodFight.Domain.Models
{
    public class BlockedUser : DomainObject
    {
        /// <summary>
        /// Many to Many Table for Blocked Users
        /// </summary>


        public int UserId { get; set; }
        public virtual User User { get; set; }

        public int BlockedId { get; set; }
        public virtual User Blocked { get; set; }

        public DateTime BlockedDate { get; set; }
    }
}
