using LankMarkAPI.Models;

namespace LandMarkAPI.Repositories
{
    public interface ILandmarkRepository
    {
        Task<List<UserPrivilagesModel>> GetUserPrivilagesDataAsync();
        Task<List<MenuBarModel>> GetMenuBarDataAsync();
        Task<List<HomePageModel>> GetHomePageDataAsync();
        Task<List<FeaturesModel>> GetFeaturesDataAsyc();
        Task<List<FeatureToolsModel>> GetFeatureToolsDataAsync();
        Task<List<PriceModel>> GetPriceDataAsync();
        Task<List<PricePlanModel>> GetPricePlanDataAsync();
        Task<List<PlanFeaturesModel>> GetPlanFeaturesDataAsync();
        Task<List<TestimonialModel>> GetTestimonialDataAsync();
        Task<List<TestimonialRolesModel>> GetTestimonialRolesDataAsync();
        Task<List<FooterModel>> GetFooterDataAsync();
        Task<List<FooterDetailsModel>> GetFooterDetailsDataAsync();
        Task<List<CopyWrightModel>> GetCopyWrightDataAsync();
    }
}
