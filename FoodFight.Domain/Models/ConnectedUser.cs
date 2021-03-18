using System.Collections;
using System.Collections.Generic;
using FoodFight.Models;

namespace FoodFight.Domain.Models
{
    public class ConnectedUsers : DomainObject
    {
        /// <summary>
        /// Join Table for connected users
        /// </summary>
        public virtual Users Users { get; set; }
        public virtual ICollection<Users> User { get; set; }
    }
}