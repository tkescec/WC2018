using DAL.Extensions;
using DAL.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DataTypes.Enums
{
    public enum TypeOfPlayerSort
    {
        [LocalizedDescription("Goal", typeof(EnumResources))]
        Goal,
        [LocalizedDescription("YellowCard", typeof(EnumResources))]
        YellowCard
    };
}
