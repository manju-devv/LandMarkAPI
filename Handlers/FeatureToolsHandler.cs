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
    public class FeatureToolsHandler
    {
        private readonly IRepository _repository;
        public FeatureToolsHandler(IRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<FeatureToolsModel>> GetFeatureToolsDataAsync()
        {
            var data =  await _repository.GetFeatureToolsDataAsync();
            if (data == null || !data.Any())
            {
                throw new Exception("No data found in the table FeatureTools!!");
            }
            return data;
        }
    }
}
