using LankMarkAPI.Models;
using LandMarkAPI.Repositories;

namespace LandMarkAPI.Handlers
{
    public class TestimonialRolesHandler
    {
        private readonly ILandmarkRepository _repository;
        public TestimonialRolesHandler(ILandmarkRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<TestimonialRolesModel>> GetTestimonialRolesDataAsync()
        {
            var data = await _repository.GetTestimonialRolesDataAsync();
            if (data == null || !data.Any())
            {
                throw new Exception("No data found in the table TestimonialRoles!!");
            }
            return data;
        }
    }
}
