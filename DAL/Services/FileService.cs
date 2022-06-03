using System.Configuration;
using System.IO;

namespace DAL.Services
{
    public static class FileService
    {
        private static readonly string _settingsPath = ConfigurationManager.AppSettings["settings-path"];

        public static bool FileExist()
        {
            return File.Exists(_settingsPath);
        }
    }
}
