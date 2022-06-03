using DAL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public interface IRepository
    {
        Task<List<Team>> GetTeamData();
        Task<List<Match>> GetTeamMatchesData();
    }
}
