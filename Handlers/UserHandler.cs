using Dapper;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using LankMarkAPI.Models;
using LandMarkAPI.Database;
using LandMarkAPI.Repositories;
using Microsoft.AspNetCore.Http.HttpResults;

namespace LandMarkAPI.Handlers
{
    public class UserHandler
    {
        private readonly IRepository _repository;
        public UserHandler(IRepository repo)
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
