using LankMarkAPI.Models;
using LandMarkAPI.Repositories;


namespace LandMarkAPI.Handlers
{
    public class UserHandler
    {
        private readonly ILandmarkRepository _repository;
        public UserHandler(ILandmarkRepository repo)
        {
            _repository = repo;
        }
        public async Task<List<UserPrivilagesModel>> GetUserPrivilagesDataAsync()
        {
            var data =  await _repository.GetUserPrivilagesDataAsync();
            if(data == null || !data.Any())
            {
                throw new Exception("No data found in the table UserPrivilages!!");
            }
            return data;
        }
    }
}
