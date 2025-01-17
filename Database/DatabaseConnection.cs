
using Microsoft.EntityFrameworkCore;
using LankMarkAPI.Controllers;
using LankMarkAPI.Models;

namespace LankMarkAPI.Database
{
    public class DatabaseConnection :DbContext
    {
        public DatabaseConnection(DbContextOptions<DatabaseConnection> options) : base(options)
        {
        }
        public async Task<List<UserPrivilagesModel>> GetUserPrivilagesDataAsync()
        {
            return await Privilages.FromSqlRaw("[dbo].[GetUserPrivilages]").ToListAsync();
        }
        public DbSet<UserPrivilagesModel> Privilages { get; set; }

        public async Task<List<MenuBarModel>> GetMenuBarDataAsync()
        {
            return await MenuBars.FromSqlRaw("[dbo].[GetMenuBar]").ToListAsync();
        }
        public DbSet<MenuBarModel> MenuBars { get; set; }

        public async Task<List<HomePageModel>> GetHomePageDataAsync()
        {
            return await HomePages.FromSqlRaw("[dbo].[GetHomePage]").ToListAsync();
        }
        public DbSet<HomePageModel> HomePages { get; set; }

        public async Task<List<FeaturesModel>> GetFeaturesDataAsyc()
        {
            return await Features.FromSqlRaw("[dbo].[GetFeatures]").ToListAsync();
        }
        public DbSet<FeaturesModel> Features { get; set; }

        public async Task<List<FeatureToolsModel>> GetFeatureToolsDataAsync()
        {
            return await tools.FromSqlRaw("[dbo].[GetFeatureTools]").ToListAsync();
        }
        public DbSet<FeatureToolsModel> tools { get; set; }

        public async Task<List<PriceModel>> GetPriceDataAsync()
        {
            return await prices.FromSqlRaw("[dbo].[GetPrice]").ToListAsync();
        }
        public DbSet<PriceModel> prices { get; set; }

        public async Task<List<PricePlanModel>> GetPricePlanDataAsync()
        {
            return await plans.FromSqlRaw("[dbo].[GetPricePlan]").ToListAsync();
        }
        public DbSet<PricePlanModel> plans { get; set; }

        public async Task<List<PlanFeaturesModel>> GetPlanFeaturesDataAsync()
        {
            return await PlanFeatures.FromSqlRaw("[dbo].[GetPlanFeatures]").ToListAsync();
        }
        public DbSet<PlanFeaturesModel> PlanFeatures { get; set; }

        public async Task<List<TestimonialModel>> GetTestimonialDataAsync()
        {
            return await testimonials.FromSqlRaw("[dbo].[GetTestimonials]").ToListAsync();
        }
        public DbSet<TestimonialModel> testimonials { get; set; }

        public async Task<List<TestimonialRolesModel>> GetTestimonialRolesDataAsync()
        {
            return await Roles.FromSqlRaw("[dbo].[GetTestimonialRoles]").ToListAsync();
        }
        public DbSet<TestimonialRolesModel> Roles { get; set; }


        public async Task<List<FooterModel>> GetFooterDataAsync()
        {
            return await foot.FromSqlRaw("[dbo].[GetFooter]").ToListAsync();
        }
        public DbSet<FooterModel> foot { get; set; }


        public async Task<List<FooterDetailsModel>> GetFooterDetailsDataAsync()
        {
            return await FootDetails.FromSqlRaw("[dbo].[GetFooterDetails]").ToListAsync();
        }
        public DbSet<FooterDetailsModel> FootDetails { get; set; }


        public async Task<List<CopyWrightModel>> GetCopyWrightDataAsync()
        {
           return await copywrights.FromSqlRaw("[dbo].[GetCopyWrights]").ToListAsync();
        }
        public DbSet<CopyWrightModel> copywrights { get; set; }
    }
}


