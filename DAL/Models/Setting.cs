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
        [JsonProperty("SelectedGender")]
        public Gender Gender { get; set; }

        [JsonProperty("SelectedLang")]
        public Lang Lang { get; set; }

        [JsonProperty("SelectedTeam")]
        public string FavoritTeam { get; set; }

        [JsonProperty("FavoritPlayers")]
        public IList<Player> FavoritPlayers { get; set; }
    }
}
