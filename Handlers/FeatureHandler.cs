using LankMarkAPI.Models;
using LandMarkAPI.Repositories;

namespace LandMarkAPI.Handlers
{
    public class FeatureHandler
    {
        private readonly ILandmarkRepository _repository;
        public FeatureHandler(ILandmarkRepository repository)
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
