using DAL.Extensions;
using DAL.Properties;

namespace DAL.DataTypes.Enums
{
    public enum Lang
    {
        [LocalizedDescription("English", typeof(EnumResources))]
        English,
        [LocalizedDescription("Croatian", typeof(EnumResources))]
        Croatian
    }
}
