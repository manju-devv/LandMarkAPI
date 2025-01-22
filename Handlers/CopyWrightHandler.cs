using Dapper;
using LankMarkAPI.Models;
using LandMarkAPI.Database;
using LandMarkAPI.Repositories;

namespace LandMarkAPI.Handlers
{
    public class CopyWrightHandler
    {
        private readonly IRepository _repository;
        public CopyWrightHandler(IRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<CopyWrightModel>> GetCopyWrightDataAsync()
        {
            var data =  await _repository.GetCopyWrightDataAsync();
            if(data == null || !data.Any())
            {
                throw new Exception("No data found in the table CopyWright!!");
            }
            return data;
        }
    }
}
