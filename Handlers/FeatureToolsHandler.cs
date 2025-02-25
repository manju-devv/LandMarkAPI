using LankMarkAPI.Models;
using LandMarkAPI.Repositories;

namespace LandMarkAPI.Handlers
{
    public class FeatureToolsHandler
    {
        private readonly ILandmarkRepository _repository;
        public FeatureToolsHandler(ILandmarkRepository repository)
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
