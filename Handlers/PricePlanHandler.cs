using LankMarkAPI.Models;
using LandMarkAPI.Repositories;


namespace LandMarkAPI.Handlers
{
    public class PricePlanHandler
    {
        private readonly ILandmarkRepository _repository;
        public PricePlanHandler(ILandmarkRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<PricePlanModel>> GetPricePlanDataAsync()
        {
            var data = await _repository.GetPricePlanDataAsync();
            if (data == null || !data.Any())
            {
                //return NotFound(new ErrorModel { Message = "No data found in the table PricePlan!" });
                throw new Exception("No data found in the table PricePlan!");
            }
            return data;
        }
    }
}
