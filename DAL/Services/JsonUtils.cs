using DAL.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Services
{
    public static class JsonUtils
    {
        public static void WriteToFile(object obj, string fileName)
        {
            var jsonString = JsonConvert.SerializeObject(obj, Converter.Settings);
            File.WriteAllText(fileName, jsonString);
        }

        public static T ReadFromFile<T>(string file)
        {
            string json = File.ReadAllText(file);

            return DeserializeJson<T>(json);
        }

        public static async Task<string> ReadFromFileAsync(object source)
        {
            using (var memoryStream = new MemoryStream((byte[])source))
            {
                using (var streamReader = new StreamReader(memoryStream))
                {
                    string data = await streamReader.ReadToEndAsync().ConfigureAwait(false);
                    streamReader.Close();
                    memoryStream.Close();

                    return data;
                }

            }
        }

        public static T DeserializeJson<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}
