﻿using Dapper;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using LankMarkAPI.Models;
using LandMarkAPI.Repositories;

namespace LandMarkAPI.Handlers
{
    public class HomePageHandler
    {
        private readonly ILandmarkRepository _repository;
        public HomePageHandler(ILandmarkRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<HomePageModel>> GetHomePageDataAsync()
        {
            var data =  await _repository.GetHomePageDataAsync();
            if (data == null || !data.Any())
            {
                throw new Exception("No data found in the table HomePage!!");
            }
            return data;
        }
    }
}
