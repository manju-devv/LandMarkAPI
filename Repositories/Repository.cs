using Dapper;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using LankMarkAPI.Models;
using LandMarkAPI.Database;


namespace LandMarkAPI.Repositories
{
    public class Repository: IRepository
    {
        private readonly DatabaseConnection _DatabaseConnection;
        public Repository(DatabaseConnection databaseConnection)
        {
            _DatabaseConnection = databaseConnection;
        }
        public async Task<List<UserPrivilagesModel>> GetUserPrivilagesDataAsync()
        {
            using (var connection = new SqlConnection(_DatabaseConnection.ConnectionString))
            {
                var query = "[dbo].[GetUserPrivilages]";
                var result = await connection.QueryAsync<UserPrivilagesModel>(query, commandType: System.Data.CommandType.StoredProcedure);
                return result.AsList();
            }
        }
        public async Task<List<MenuBarModel>> GetMenuBarDataAsync()
        {
            using (var connection = new SqlConnection(_DatabaseConnection.ConnectionString))
            {
                var query = "[dbo].[GetMenuBar]";
                var result = await connection.QueryAsync<MenuBarModel>(query,commandType:System.Data.CommandType.StoredProcedure);
                return result.AsList();
            }
        }
        public async Task<List<HomePageModel>> GetHomePageDataAsync()
        {
            using (var connection = new SqlConnection(_DatabaseConnection.ConnectionString))
            {
                var query = "[dbo].[GetHomePage]";
                var result = await connection.QueryAsync<HomePageModel>(query, commandType: System.Data.CommandType.StoredProcedure);
                return result.AsList();
            }
        }
        public async Task<List<FeaturesModel>> GetFeaturesDataAsyc()
        {
            using (var connection = new SqlConnection(_DatabaseConnection.ConnectionString))
            {
                var query = "[dbo].[GetFeatures]";
                var result = await connection.QueryAsync<FeaturesModel>(query, commandType: System.Data.CommandType.StoredProcedure);
                return result.AsList();
            }
        }
        public async Task<List<FeatureToolsModel>> GetFeatureToolsDataAsync()
        {
            using (var connection = new SqlConnection(_DatabaseConnection.ConnectionString))
            {
                var query = "[dbo].[GetFeatureTools]";
                var result = await connection.QueryAsync<FeatureToolsModel>(query, commandType: System.Data.CommandType.StoredProcedure);
                return result.AsList();
            }
        }
        public async Task<List<PriceModel>> GetPriceDataAsync()
        {
            using (var connection = new SqlConnection(_DatabaseConnection.ConnectionString))
            {
                var query = "[dbo].[GetPrice]";
                var result = await connection.QueryAsync<PriceModel>(query, commandType: System.Data.CommandType.StoredProcedure);
                return result.AsList();
            }
        }
        public async Task<List<PricePlanModel>> GetPricePlanDataAsync()
        {
            using (var connection = new SqlConnection(_DatabaseConnection.ConnectionString))
            {
                var query = "[dbo].[GetPricePlan]";
                var result = await connection.QueryAsync<PricePlanModel>(query, commandType: System.Data.CommandType.StoredProcedure);
                return result.AsList();
            }
        }
        public async Task<List<PlanFeaturesModel>> GetPlanFeaturesDataAsync()
        {
            using (var connection = new SqlConnection(_DatabaseConnection.ConnectionString))
            {
                var query = "[dbo].[GetPlanFeatures]";
                var result = await connection.QueryAsync<PlanFeaturesModel>(query, commandType: System.Data.CommandType.StoredProcedure);
                return result.AsList();
            }
        }
        public async Task<List<TestimonialModel>> GetTestimonialDataAsync()
        {
            using (var connection = new SqlConnection(_DatabaseConnection.ConnectionString))
            {
                var query = "[dbo].[GetTestimonials]";
                var result = await connection.QueryAsync<TestimonialModel>(query, commandType: System.Data.CommandType.StoredProcedure);
                return result.AsList();
            }
        }
        public async Task<List<TestimonialRolesModel>> GetTestimonialRolesDataAsync()
        {
            using (var connection = new SqlConnection(_DatabaseConnection.ConnectionString))
            {
                var query = "[dbo].[GetTestimonialRoles]";
                var result = await connection.QueryAsync<TestimonialRolesModel>(query, commandType: System.Data.CommandType.StoredProcedure);
                return result.AsList();
            }
        }
        public async Task<List<FooterModel>> GetFooterDataAsync()
        {
            using (var connection = new SqlConnection(_DatabaseConnection.ConnectionString))
            {
                var query = "[dbo].[GetFooter]";
                var result = await connection.QueryAsync<FooterModel>(query, commandType: System.Data.CommandType.StoredProcedure);
                return result.AsList();
            }
        }
        public async Task<List<FooterDetailsModel>> GetFooterDetailsDataAsync()
        {
            using (var connection = new SqlConnection(_DatabaseConnection.ConnectionString))
            {
                var query = "[dbo].[GetFooterDetails]";
                var result = await connection.QueryAsync<FooterDetailsModel>(query, commandType: System.Data.CommandType.StoredProcedure);
                return result.AsList();
            }
        }
        public async Task<List<CopyWrightModel>> GetCopyWrightDataAsync()
        {
            using(var connection = new SqlConnection(_DatabaseConnection.ConnectionString))
            {
                var query = "[dbo].[GetCopyWrights]";
                var result  = await connection.QueryAsync<CopyWrightModel>(query,commandType:System.Data.CommandType.StoredProcedure);
                return result.AsList();
            }
        }
    }
}
