using LankMarkAPI.Models;
using LandMarkAPI.Repositories;

namespace LandMarkAPI.Handlers
{
    public class MenuBarHandler
    {
        private readonly ILandmarkRepository _repository;
        public MenuBarHandler(ILandmarkRepository repo)
        {
            _repository = repo;
        }
        public async Task<List<MenuBarModel>> GetMenuBarDataAsync()
        {
            var data =  await _repository.GetMenuBarDataAsync();
            if(data == null || !data.Any())
            {
                throw new Exception("No data found in the table MenuBar!!");
            }
            return data;
        }
    }
}
