using DAL.Converters;
using DAL.DataTypes.Enums;
using DAL.Models;
using DAL.Properties;
using DAL.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class JsonRepository : IRepository
    {
        private readonly string _sourcePrefix;
        public JsonRepository(Gender gender)
        {
            switch (gender)
            {
                case Gender.Women:
                    _sourcePrefix = "w_";
                    break;
                case Gender.Men:
                    _sourcePrefix = "m_";
                    break;
                default:
                    throw new Exception("Undefined gender.");
            }
        }
        public Task<List<Team>> GetTeamData()
        {
            object source = DataResources.ResourceManager.GetObject($"{_sourcePrefix}results");

            return RunTask<List<Team>>(source, Converter.Settings);
        }
        public Task<List<Match>> GetTeamMatchesData()
        {
            object source = DataResources.ResourceManager.GetObject($"{_sourcePrefix}matches");

            return RunTask<List<Match>>(source, MatchesConverter.Settings);
        }

        private Task<T> RunTask<T>(object source, JsonSerializerSettings settings)
        {
            return Task.Run(async () =>
            {
                var fileResult = await JsonUtils.ReadFromFileAsync(source);

                return JsonConvert.DeserializeObject<T>(fileResult, settings);
            });
        }
    }
}
