using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Repositories;
using DAL.DataTypes.Enums;

namespace DAL
{
    public static class RepositoryFactory
    {
        private static readonly string _dataSource = ConfigurationManager.AppSettings["data-source"];
        private static IRepository _repository;

        public static IRepository GetRepository(Gender gender)
        {
            switch (_dataSource)
            {
                case "API":
                    _repository = new ApiRepository(gender);
                    break;
                case "JSON":
                    _repository = new JsonRepository(gender);
                    break;
                default:
                    _repository = new ApiRepository(gender);
                    break;
            }

            return _repository;

        }
    }
}
