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
    public class PricePlanHandler
    {
        private readonly IRepository _repository;
        public PricePlanHandler(IRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<PricePlanModel>> GetPricePlanDataAsync()
        {
            var data = await _repository.GetPricePlanDataAsync();
            if (data == null || !data.Any())
            {
                throw new Exception("No data found in the table PricePlan!!");
            }
            return data;
        }
    }
}
