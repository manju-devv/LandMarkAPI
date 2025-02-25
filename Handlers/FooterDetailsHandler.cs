using LankMarkAPI.Models;
using LandMarkAPI.Repositories;

namespace LandMarkAPI.Handlers
{
    public class FooterDetailsHandler
    {
        private readonly ILandmarkRepository _repository;
        public FooterDetailsHandler(ILandmarkRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<FooterDetailsModel>> GetFooterDetailsDataAsync()
        {
            var data =  await _repository.GetFooterDetailsDataAsync();
            if(data == null || !data.Any())
            {
                throw new Exception("No data found in the table FooterDetails!!");
            }
            return data;
        }
    }
}
