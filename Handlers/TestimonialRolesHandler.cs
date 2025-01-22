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
    public class TestimonialRolesHandler
    {
        private readonly IRepository _repository;
        public TestimonialRolesHandler(IRepository repository)
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
