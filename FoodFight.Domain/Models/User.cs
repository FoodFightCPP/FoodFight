using System;
using System.Collections.Generic;
using System.Text;
using FoodFight.Domain.Models;

namespace FoodFight.Models
{
    public class User : DomainObject
    {
        /// <summary>
        /// Model for the user
        /// </summary>
        public string Email { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public string Country { get; set; }
        public string Bio { get; set; }
        public string Facebook { get; set; }
        public string Instagram { get; set; }
        public string Twitter { get; set; }
        public string Website { get; set; }
        public string ProfilePic { get; set; }
    }
}
