using DAL.Converters;
using DAL.DataTypes.Constants;
using DAL.DataTypes.Enums;
using DAL.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class ApiRepository : IRepository
    {
        private readonly string _apiUrl;
        public ApiRepository(Gender gender)
        {
            switch (gender)
            {
                case Gender.Women:
                    _apiUrl = Api.WOMEN_ENDPOINT;
                    break;
                case Gender.Men:
                    _apiUrl = Api.MEN_ENDPOINT;
                    break;
                default:
                    throw new Exception("Undefined gender.");
            }
        }
        public Task<List<Team>> GetTeamData()
        {
            string endpoint = $"{_apiUrl}{Api.RESULTS}";

            return RunTask<List<Team>>(endpoint, Converter.Settings);

        }
        public Task<List<Match>> GetTeamMatchesData()
        {
            string endpoint = $"{_apiUrl}{Api.MATCHES}";

            return RunTask<List<Match>>(endpoint, MatchesConverter.Settings);

        }

        private Task<T> RunTask<T>(string endpoint, JsonSerializerSettings settings)
        {
            return Task.Run(async () =>
            {
                var apiClient = new RestClient(endpoint);
                var apiResult = await apiClient.ExecuteAsync<T>(new RestRequest());

                return JsonConvert.DeserializeObject<T>(apiResult.Content, settings);
            });
        }
    }
}
