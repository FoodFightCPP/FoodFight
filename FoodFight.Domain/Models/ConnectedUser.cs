using System;
using System.Collections.Generic;
using System.Text;

namespace FoodFight.Domain.Models
{
    public class ConnectedUser : DomainObject
    {
        /// <summary>
        /// Many to Many Table for Connected Users
        /// </summary>

        public int UserId { get; set; }
        public virtual User User { get; set; }


        public int ContactId { get; set; }
        public virtual User Contact { get; set; }

        public DateTime ConnectedDate { get; set; }
    }
}
