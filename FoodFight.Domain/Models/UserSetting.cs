using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Internal;


namespace FoodFight.Domain.Models
{
    public class UserSetting : DomainObject
    {
            [Key]
            [Column("UserSettingsID")]
            public Guid UserSettingsId { get; set; }
            [Column("SettingsID")]
            public Guid SettingsId { get; set; }
            [Column("UserID")]
            public Guid UserId { get; set; }

            [ForeignKey(nameof(SettingsId))]
            [InverseProperty(nameof(Setting.UserSettings))]
            public virtual Setting Settings { get; set; }
            [ForeignKey(nameof(UserId))]
            [InverseProperty("UserSettings")]
            public virtual User User { get; set; }
        }
}
