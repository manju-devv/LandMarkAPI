using Dapper;
using Microsoft.Data.SqlClient;
using LankMarkAPI.Models;
using LandMarkAPI.Database;


namespace LandMarkAPI.Repositories
{
    public class LandmarkRepository: ILandmarkRepository 
    {
        private readonly DatabaseConnection _DatabaseConnection;
        private readonly ILogger<ILandmarkRepository> _logger;
        public LandmarkRepository(DatabaseConnection databaseConnection, ILogger<ILandmarkRepository> logger)
        {
            _DatabaseConnection = databaseConnection;
            _logger = logger;
        }
        public async Task<List<UserPrivilagesModel>> GetUserPrivilagesDataAsync()
        {
            try
            {
                using (var connection = new SqlConnection(_DatabaseConnection.ConnectionString))
                {
                    
                    var query = "[dbo].[GetUserPrivilages]";
                    var result = await connection.QueryAsync<UserPrivilagesModel>(query, commandType: System.Data.CommandType.StoredProcedure);
                    return result.AsList();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error occured while connecting DB & fetching User Privilages Data. \n error:{ex.Message}");
                throw;
            }
        }
        public async Task<List<MenuBarModel>> GetMenuBarDataAsync()
        {
            try
            {
                using (var connection = new SqlConnection(_DatabaseConnection.ConnectionString))
                {
                    var query = "[dbo].[GetMenuBar]";
                    var result = await connection.QueryAsync<MenuBarModel>(query, commandType: System.Data.CommandType.StoredProcedure);
                    return result.AsList();
                }
            }
            catch(Exception ex)
            {
                _logger.LogError($"Error occured while connecting DB & fetching Menu Bar Data. \n error:{ex.Message}");
                throw;
            }
        }
        public async Task<List<HomePageModel>> GetHomePageDataAsync()
        {
            try
            {
                using (var connection = new SqlConnection(_DatabaseConnection.ConnectionString))
                {
                    var query = "[dbo].[GetHomePage]";
                    var result = await connection.QueryAsync<HomePageModel>(query, commandType: System.Data.CommandType.StoredProcedure);
                    return result.AsList();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error occured while connecting DB & fetching Home Page Data. \n error:{ex.Message}");
                throw;
            }
        }
        public async Task<List<FeaturesModel>> GetFeaturesDataAsyc()
        {
            try
            {
                using (var connection = new SqlConnection(_DatabaseConnection.ConnectionString))
                {
                    var query = "[dbo].[GetFeatures]";
                    var result = await connection.QueryAsync<FeaturesModel>(query, commandType: System.Data.CommandType.StoredProcedure);
                    return result.AsList();
                }
            }
            catch(Exception ex)
            {
                _logger.LogError($"Error occured while connecting DB & fetching Features Data. \n error:{ex.Message}");
                throw;
            }
        }
        public async Task<List<FeatureToolsModel>> GetFeatureToolsDataAsync()
        {
            try
            {
                using (var connection = new SqlConnection(_DatabaseConnection.ConnectionString))
                {
                    var query = "[dbo].[GetFeatureTools]";
                    var result = await connection.QueryAsync<FeatureToolsModel>(query, commandType: System.Data.CommandType.StoredProcedure);
                    return result.AsList();
                }
            }
            catch(Exception ex)
            {
                _logger.LogError($"Error occured while connecting DB & fetching Feature Tools Data. \n error:{ex.Message}");
                throw;
            }
        }
        public async Task<List<PriceModel>> GetPriceDataAsync()
        {
            try
            {
                using (var connection = new SqlConnection(_DatabaseConnection.ConnectionString))
                {
                    var query = "[dbo].[GetPrice]";
                    var result = await connection.QueryAsync<PriceModel>(query, commandType: System.Data.CommandType.StoredProcedure);
                    return result.AsList();
                }
            }
            catch(Exception ex)
            {
                _logger.LogError($"Error occured while connecting DB & fetching Price Data. \n error:{ex.Message}");
                throw;
            }
        }
        public async Task<List<PricePlanModel>> GetPricePlanDataAsync()
        {
            try
            {
                using (var connection = new SqlConnection(_DatabaseConnection.ConnectionString))
                {
                    var query = "[dbo].[GetPricePlan]";
                    var result = await connection.QueryAsync<PricePlanModel>(query, commandType: System.Data.CommandType.StoredProcedure);
                    return result.AsList();
                }
            }
            catch(Exception ex)
            {
                _logger.LogError($"Error occured while connecting DB & fetching Price Plan Data. \n error:{ex.Message}");
                throw;
            }
        }
        public async Task<List<PlanFeaturesModel>> GetPlanFeaturesDataAsync()
        {
            try
            {
                using (var connection = new SqlConnection(_DatabaseConnection.ConnectionString))
                {
                    var query = "[dbo].[GetPlanFeatures]";
                    var result = await connection.QueryAsync<PlanFeaturesModel>(query, commandType: System.Data.CommandType.StoredProcedure);
                    return result.AsList();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error occured while connecting DB & fetching Plan Features Data. \n error:{ex.Message}");
                throw;
            }
        }
        public async Task<List<TestimonialModel>> GetTestimonialDataAsync()
        {
            try
            {
                using (var connection = new SqlConnection(_DatabaseConnection.ConnectionString))
                {
                    var query = "[dbo].[GetTestimonials]";
                    var result = await connection.QueryAsync<TestimonialModel>(query, commandType: System.Data.CommandType.StoredProcedure);
                    return result.AsList();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error occured while connecting DB & fetching Testimonial Data. \n error:{ex.Message}");
                throw;
            }
        }
        public async Task<List<TestimonialRolesModel>> GetTestimonialRolesDataAsync()
        {
            try
            {
                using (var connection = new SqlConnection(_DatabaseConnection.ConnectionString))
                {
                    var query = "[dbo].[GetTestimonialRoles]";
                    var result = await connection.QueryAsync<TestimonialRolesModel>(query, commandType: System.Data.CommandType.StoredProcedure);
                    return result.AsList();
                }
            }
            catch(Exception ex)
            {
                _logger.LogError($"Error occured while connecting DB & fetching Testimonial Roles Data. \n error:{ex.Message}");
                throw;
            }
        }
        public async Task<List<FooterModel>> GetFooterDataAsync()
        {
            try
            {
                using (var connection = new SqlConnection(_DatabaseConnection.ConnectionString))
                {
                    var query = "[dbo].[GetFooter]";
                    var result = await connection.QueryAsync<FooterModel>(query, commandType: System.Data.CommandType.StoredProcedure);
                    return result.AsList();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error occured while connecting DB & fetching Footer Data. \n error:{ex.Message}");
                throw;
            }
        }
        public async Task<List<FooterDetailsModel>> GetFooterDetailsDataAsync()
        {
            try
            {
                using (var connection = new SqlConnection(_DatabaseConnection.ConnectionString))
                {
                    var query = "[dbo].[GetFooterDetails]";
                    var result = await connection.QueryAsync<FooterDetailsModel>(query, commandType: System.Data.CommandType.StoredProcedure);
                    return result.AsList();
                }
            }
            catch(Exception ex)
            {
                _logger.LogError($"Error occured while connecting DB & fetching Footer Details Data. \n error:{ex.Message}");
                throw;
            }
        }
        public async Task<List<CopyWrightModel>> GetCopyWrightDataAsync()
        {
            try
            {
                using (var connection = new SqlConnection(_DatabaseConnection.ConnectionString))
                {
                    var query = "[dbo].[GetCopyWrights]";
                    var result = await connection.QueryAsync<CopyWrightModel>(query, commandType: System.Data.CommandType.StoredProcedure);
                    return result.AsList();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error occured while connecting DB & fetching Copy Wright Data. \n error:{ex.Message}");
                throw;
            }
        }
    }
}
