using LandMarkAPI.Handlers;
using LandMarkAPI.Models;
using LankMarkAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace LandMarkAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class apiController : ControllerBase
    {
        private readonly UserHandler _UserHandler;
        private readonly MenuBarHandler _menuBarHandler;
        private readonly HomePageHandler _HomePageHandler;
        private readonly FeatureHandler _featureHandler;
        private readonly FeatureToolsHandler _featureToolsHandler;
        private readonly PriceHandler _priceHandler;
        private readonly PricePlanHandler _pricePlanHandler;
        private readonly PlanFeaturesHandler _planFeaturesHandler;
        private readonly TestimonialHandler _testimonialHandler;
        private readonly TestimonialRolesHandler _testimonialRolesHandler;
        private readonly FooterHandler _footerHandler;
        private readonly FooterDetailsHandler _footerDetailsHandler;
        private readonly CopyWrightHandler _copyWrightHandler;

        public apiController(UserHandler userHandler,
               MenuBarHandler menuBarHandler,
               HomePageHandler homePageHandler,
               FeatureHandler featureHandler,
               FeatureToolsHandler featureToolsHandler,
               PriceHandler priceHandler,
               PricePlanHandler pricePlanHandler,
               PlanFeaturesHandler planFeaturesHandler,
               TestimonialHandler testimonialHandler,
               TestimonialRolesHandler testimonialRolesHandler,
               FooterHandler footerHandler,
               FooterDetailsHandler footerDetailsHandler,
               CopyWrightHandler copyWrightHandler
            )
        {
            _UserHandler = userHandler;
            _menuBarHandler = menuBarHandler;
            _HomePageHandler = homePageHandler;
            _featureHandler = featureHandler;
            _featureToolsHandler = featureToolsHandler;
            _priceHandler = priceHandler;
            _pricePlanHandler = pricePlanHandler;
            _planFeaturesHandler = planFeaturesHandler;
            _testimonialHandler = testimonialHandler;
            _testimonialRolesHandler = testimonialRolesHandler;
            _footerHandler = footerHandler;
            _footerDetailsHandler = footerDetailsHandler;
            _copyWrightHandler = copyWrightHandler;
        }

        [HttpGet("UserPrivilages")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<UserPrivilagesModel>))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorModel))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorModel))]
        public async Task<IActionResult> GetUserPrivilages()
        {
            var user = await _UserHandler.GetUserPrivilagesDataAsync();
            return Ok(user);
        }


        [HttpGet("MenuBar")]
        [ProducesResponseType(StatusCodes.Status200OK,Type = typeof(List<MenuBarModel>))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorModel))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorModel))]
        public async Task<IActionResult> GetMenuBar()
        {
            var data = await _menuBarHandler.GetMenuBarDataAsync();
            return Ok(data);
        }


        [HttpGet("HomePage")]
        [ProducesResponseType(StatusCodes.Status200OK,Type = typeof(List<HomePageModel>))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorModel))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorModel))]
        public async Task<IActionResult> GetHomePage()
        { 
            var data = await _HomePageHandler.GetHomePageDataAsync();
            return Ok(data);
        }


        [HttpGet("Features")]
        [ProducesResponseType(StatusCodes.Status200OK,Type = typeof(List<FeaturesModel>))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorModel))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorModel))]
        public async Task<IActionResult> GetFeatures()
        {
            var data = await _featureHandler.GetFeaturesDataAsyc();
            return Ok(data);
        }


        [HttpGet("FeatureTools")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<FeatureToolsModel>))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorModel))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorModel))]
        public async Task<IActionResult> GetFeatureTools()
        {
            var data = await _featureToolsHandler.GetFeatureToolsDataAsync();
            return Ok(data);
        }


        [HttpGet("Price")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<PriceModel>))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorModel))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorModel))]
        public async Task<IActionResult> GetPrice()
        {
            var data = await _priceHandler.GetPriceDataAsync();
            return Ok(data);

        }


        [HttpGet("PricePlan")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<PricePlanModel>))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorModel))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorModel))]
        public async Task<IActionResult> GetPricePlan()
        {
            var data = await _pricePlanHandler.GetPricePlanDataAsync();
            return Ok(data);
        }

        [HttpGet("PlanFeatures")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<PlanFeaturesModel>))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorModel))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorModel))]
        public async Task<IActionResult> GetPlanFeatures()
        {
            var data = await _planFeaturesHandler.GetPlanFeaturesDataAsync();
            return Ok(data);
        }


        [HttpGet("Testimonial")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<TestimonialModel>))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorModel))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorModel))]
        public async Task<IActionResult> GetTestimonial()
        {
            var data = await _testimonialHandler.GetTestimonialDataAsync();
            return Ok(data);

        }


        [HttpGet("TestimonialRoles")]
        [ProducesResponseType(StatusCodes.Status200OK,Type = typeof(List<TestimonialRolesModel>))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorModel))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorModel))]
        public async Task<IActionResult> GetTestimonialRoles()
        {
            var data = await _testimonialRolesHandler.GetTestimonialRolesDataAsync();
            return Ok(data);
        }


        [HttpGet("Footer")]
        [ProducesResponseType(StatusCodes.Status200OK,Type = typeof(List<FooterModel>))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorModel))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorModel))]
        public async Task<IActionResult> GetFooter()
        {
            var data = await _footerHandler.GetFooterDataAsync();
            return Ok(data);
        }


        [HttpGet("FooterDetails")]
        [ProducesResponseType(StatusCodes.Status200OK,Type = typeof(List<FooterDetailsModel>))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorModel))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorModel))]
        public async Task<IActionResult> GetFooterDetails()
        {
            var data = await _footerDetailsHandler.GetFooterDetailsDataAsync();
            return Ok(data);
        }


        [HttpGet("CopyWright")]
        [ProducesResponseType(StatusCodes.Status200OK,Type = typeof(List<CopyWrightModel>))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorModel))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorModel))]
        public async Task<IActionResult> GetCopyWright()
        {
            var data = await _copyWrightHandler.GetCopyWrightDataAsync();
            return Ok(data);
        }
    }
}
