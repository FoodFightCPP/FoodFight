using System;
using System.Collections.Generic;
using System.Text;

namespace FoodFight.Domain.Models
{
    public class Session : DomainObject 
    {
        /// <summary>
        /// Join Table for Session Data
        /// </summary>
        public int ConnectionId { get; set; }
        public virtual ConnectedUser ConnectedUsers { get; set; }
        public DateTime SessionDate { get; set; }
        public int Lat { get; set; }
        public int Lng { get; set; }
    }
}
