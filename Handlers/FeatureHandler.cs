using Dapper;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using LankMarkAPI.Models;
using LandMarkAPI.Database;
using LandMarkAPI.Repositories;

namespace LandMarkAPI.Handlers
{
    public class FeatureHandler
    {
        private readonly IRepository _repository;
        public FeatureHandler(IRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<FeaturesModel>> GetFeaturesDataAsyc()
        {
            var data =  await _repository.GetFeaturesDataAsyc();
            if(data == null || !data.Any())
            {
                throw new Exception("No data found in the table Features!!");
            }
            return data;
        }
    }
}
