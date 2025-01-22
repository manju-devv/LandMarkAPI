using Dapper;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using LankMarkAPI.Models;
using LandMarkAPI.Database;
using LandMarkAPI.Repositories;

namespace LandMarkAPI.Handlers
{
    public class TestimonialHandler
    {
        private readonly IRepository _repository;
        public TestimonialHandler(IRepository repository)
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
