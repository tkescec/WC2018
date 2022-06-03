using DAL.DataTypes.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    [Serializable]
    public class Setting
    {
        [JsonProperty("gender")]
        public Gender Gender { get; set; }

        [JsonProperty("language")]
        public Lang Lang { get; set; }

        [JsonProperty("favorit_team")]
        public string FavoritTeam { get; set; }
    }
}
