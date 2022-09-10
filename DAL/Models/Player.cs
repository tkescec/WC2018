using DAL.DataTypes.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Player : IComparable<Player>
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("captain")]
        public bool Captain { get; set; }

        [JsonProperty("shirt_number")]
        public long? ShirtNumber { get; set; }

        [JsonProperty("position")]
        public Position Position { get; set; }

        public int Goals { get; set; }
        public int YellowCards { get; set; }

        public int CompareTo(Player other)
        {
            return Name.CompareTo(other.Name);
        }
    }

    public class PlayerGoalComparer : IComparer<Player>
    {
        public int Compare(Player x, Player y)
        {
            if (x.Goals > y.Goals)
            {
                return -1;
            }
            else if (x.Goals < y.Goals)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }

    public class PlayerYellowCardComparer : IComparer<Player>
    {
        public int Compare(Player x, Player y)
        {
            if (x.YellowCards > y.YellowCards)
            {
                return -1;
            }
            else if (x.YellowCards < y.YellowCards)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
