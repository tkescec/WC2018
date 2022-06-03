using DAL.Extensions;
using DAL.Properties;

namespace DAL.DataTypes.Enums
{
    public enum Messages
    {
        [LocalizedDescription("ErrorTitle", typeof(EnumResources))]
        ErrorTitle,
        [LocalizedDescription("WarrningTitle", typeof(EnumResources))]
        WarrningTitle,
        [LocalizedDescription("ExitTitle", typeof(EnumResources))]
        ExitTitle,
        [LocalizedDescription("ErrorMessage", typeof(EnumResources))]
        ErrorMessage,
        [LocalizedDescription("WarrningMessage", typeof(EnumResources))]
        WarrningMessage,
        [LocalizedDescription("ExitMessage", typeof(EnumResources))]
        ExitMessage
    }
}
