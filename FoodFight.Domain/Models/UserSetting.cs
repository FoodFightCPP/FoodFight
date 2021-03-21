using System;
using System.Collections.Generic;
using System.Text;

namespace FoodFight.Domain.Models
{
    public class UserSetting : DomainObject
    {
        public int UserId { get; set; }
        public int SettingId { get; set; }
        public virtual User User { get; set; }
        public virtual Setting Setting { get; set; }
    }
}
