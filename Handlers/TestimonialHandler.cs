using LankMarkAPI.Models;
using LandMarkAPI.Repositories;

namespace LandMarkAPI.Handlers
{
    public class TestimonialHandler
    {
        private readonly ILandmarkRepository _repository;
        public TestimonialHandler(ILandmarkRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<TestimonialModel>> GetTestimonialDataAsync()
        {
            var data =  await _repository.GetTestimonialDataAsync();
            if(data == null|| !data.Any()){
                throw new Exception("No data found in the table Testimonial handler!!");
            }
            return data;
        }
    }
}
