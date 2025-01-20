using Microsoft.Extensions.Configuration;

namespace LandMarkAPI.Database
{
    public class DatabaseConnection
    {
        private readonly IConfiguration _configuration;
        public string ConnectionString { get; }

        public DatabaseConnection(IConfiguration configuration)
        {
            _configuration = configuration;
            ConnectionString = _configuration.GetConnectionString("DefaultConnection");
        }
    }
}


