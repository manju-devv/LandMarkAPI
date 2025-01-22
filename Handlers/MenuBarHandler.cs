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
    public class MenuBarHandler
    {
        private readonly IRepository _repository;
        public MenuBarHandler(IRepository repo)
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
