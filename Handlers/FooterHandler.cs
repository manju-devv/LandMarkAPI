using LankMarkAPI.Models;
using LandMarkAPI.Database;
using LandMarkAPI.Repositories;

namespace LandMarkAPI.Handlers
{
    public class FooterHandler
    {
        private readonly ILandmarkRepository _repository;
        public FooterHandler(ILandmarkRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<FooterModel>> GetFooterDataAsync()
        {
            var data =  await _repository.GetFooterDataAsync();
            if (data == null || !data.Any())
            {
                throw new Exception("No data found in the table Footer!!");
            }
            return data;
        }
    }
}
