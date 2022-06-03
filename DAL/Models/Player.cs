using DAL.DataTypes.Enums;
using Newtonsoft.Json;

namespace DAL.Models
{
    public partial class Player
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("captain")]
        public bool Captain { get; set; }

        [JsonProperty("shirt_number")]
        public long? ShirtNumber { get; set; }

        [JsonProperty("position")]
        public Position Position { get; set; }
    }
}
