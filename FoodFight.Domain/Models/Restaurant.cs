using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Newtonsoft.Json;

namespace FoodFight.Domain.Models
{
    public class Restaurant : DomainObject
    {
        /// <summary>
        /// Model for returned restaurant from Google Places API
        /// </summary>

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("street")]
        public string Street { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("lat")]
        public string Lat { get; set; }

        [JsonProperty("lng")]
        public string Lng { get; set; }

        [JsonProperty("openNow")]
        public string OpenNow { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("rating")]
        public long Rating { get; set; }

        [JsonProperty("zipCode")]
        public string ZipCode { get; set; }

        [JsonProperty("photo")]
        public string Photo { get; set; }
        
        [JsonProperty("blockedRestaurants")]
        public object[] BlockedRestaurants { get; set; }

        [JsonProperty("favoriteRestaurants")]
        public object[] FavoriteRestaurants { get; set; }

        [JsonProperty("swipeLists")]
        public object[] SwipeLists { get; set; }
    }
}
