using LankMarkAPI.Models;
using LandMarkAPI.Repositories;

namespace LandMarkAPI.Handlers
{
    public class PlanFeaturesHandler
    {
        private readonly ILandmarkRepository _repository;
        public PlanFeaturesHandler(ILandmarkRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<PlanFeaturesModel>> GetPlanFeaturesDataAsync()
        {
            var data =  await _repository.GetPlanFeaturesDataAsync();
            if(data == null || !data.Any())
            {
                throw new Exception("No data found in the table PlanFeatures!!");
            }
            return data;
        }
    }
}
