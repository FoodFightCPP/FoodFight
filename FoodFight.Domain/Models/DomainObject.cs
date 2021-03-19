using System;
using System.Collections.Generic;
using System.Text;

namespace FoodFight.Domain.Models
{
    public class DomainObject
    {
        /// <summary>
        /// Model to ensure all POCO's have an Id field
        /// </summary>
        public int Id { get; set; }
    }
}
