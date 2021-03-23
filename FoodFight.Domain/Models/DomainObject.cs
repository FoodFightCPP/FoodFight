using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodFight.Domain.Models
{
    public class DomainObject
    {
        [JsonProperty("userId")]
        public Guid Id { get; set; }
    }
}
