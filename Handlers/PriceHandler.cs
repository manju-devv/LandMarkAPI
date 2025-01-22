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
    public class PriceHandler
    {
        private readonly IRepository _repository;
        public PriceHandler(IRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<PriceModel>> GetPriceDataAsync()
        {
            var data =  await _repository.GetPriceDataAsync();
            if(data == null || !data.Any())
            {
                throw new Exception("No data found in the table Price!!");
            }
            return data;
        }
    }
}
