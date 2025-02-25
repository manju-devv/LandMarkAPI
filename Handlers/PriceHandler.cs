using LankMarkAPI.Models;
using LandMarkAPI.Repositories;

namespace LandMarkAPI.Handlers
{
    public class PriceHandler
    {
        private readonly ILandmarkRepository _repository;
        public PriceHandler(ILandmarkRepository repository)
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
