using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FoodFight.Domain.Models
{
    public class Setting : DomainObject
    {
        public Setting()
        {
            UserSettings = new HashSet<UserSetting>();
        }

        [Key]
        [Column("SettingsID")]
        public Guid SettingsId { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public bool Enabled { get; set; }

        [InverseProperty(nameof(UserSetting.Settings))]
        public virtual ICollection<UserSetting> UserSettings { get; set; }
    }
}
