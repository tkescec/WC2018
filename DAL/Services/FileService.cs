using DAL.Models;
using System;
using System.Configuration;
using System.IO;

namespace DAL.Services
{
    public static class FileService
    {
        private static readonly string _settingsPath = ConfigurationManager.AppSettings["settings-path"];

        public static string GetDirectory(string path)
        {
            string solutionDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            string directory = solutionDirectory + path;


            return directory;
        }

        public static void CopySettingsFile(string srcPath, string destPath)
        {
            var srcDir = GetDirectory(srcPath);
            var destDir = GetDirectory(destPath);

            string[] filePaths = Directory.GetFiles(srcDir, "*.json");

            foreach (var filename in filePaths)
            {
                string file = filename.Substring(srcDir.Length + 1);

                File.Copy(Path.Combine(srcDir, file), Path.Combine(destDir, file), true);
            }
        }

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
