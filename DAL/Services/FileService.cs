using DAL.Models;
using System;
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

        public static void CreateFile(object obj)
        {
            try
            {
                JsonUtils.WriteToFile(obj, _settingsPath);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static Setting ReadSettingsFile()
        {
            try
            {
                return JsonUtils.ReadFromFile<Setting>(_settingsPath);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
