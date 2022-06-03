using DAL.Extensions;
using DAL.Properties;

namespace DAL.DataTypes.Enums
{
    public enum Gender
    {
        [LocalizedDescription("Women", typeof(EnumResources))]
        Women,
        [LocalizedDescription("Men", typeof(EnumResources))]
        Men
    }
}
