using System.Collections;
using System.Collections.Generic;
using FoodFight.Models;

namespace FoodFight.Domain.Models
{
    public class BlockedUsers : DomainObject
    {
        /// <summary>
        /// Join Table for Blocked Contacts
        /// </summary>
        public virtual Users Users { get; set; }
        public virtual ICollection<Users> User { get; set; }
    }
}