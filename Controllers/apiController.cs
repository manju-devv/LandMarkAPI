

using LandMarkAPI.Repositories;
using LankMarkAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace LandMarkAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class apiController : ControllerBase
    {
        private readonly IRepository _repository;

        public apiController(IRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("UserPrivilages")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetUserPrivilages()
        {
            try
            {
                var data = await _repository.GetUserPrivilagesDataAsync();
                if(data == null || !data.Any())
                {
                    return NotFound(new {message = "data of UserPrivilages could not be found!",StatusCode = 400});
                }
                return Ok(data);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Something went wrong & can't get the UserPrivilages data!",error = ex.Message});
            }
        }
        [HttpGet("MenuBar")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetMenuBar()
        {
            try
            {
                var data = await _repository.GetMenuBarDataAsync();
                if (data == null || !data.Any())
                {
                    return NotFound(new { message = "data of MenuBar could not be found!", StatusCode = 400 });
                }
                return Ok(data);
            }
            catch (Exception e)
            {
                return StatusCode(500, $"something went wrong: {e.Message}");
            }
        }
        [HttpGet("HomePage")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetHomePage()
        {
            try
            {
                var data = await _repository.GetHomePageDataAsync();
                if (data == null || !data.Any())
                {
                    return NotFound(new { message = "data of HomePage could not be found!", StatusCode = 400 });
                }
                return Ok(data);
            }
            catch (Exception e)
            {
                return StatusCode(500, $"Internal Server Error: {e.Message}");
            }
        }
        [HttpGet("Features")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetFeatures()
        {
            try
            {
                var data = await _repository.GetFeaturesDataAsyc();
                if (data == null || !data.Any())
                {
                    return NotFound(new { message = "data of Features could not be found!", StatusCode = 400 });
                }
                return Ok(data);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }
        [HttpGet("FeatureTools")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetFeatureTools()
        {
            try
            {
                var data = await _repository.GetFeatureToolsDataAsync();
                if (data == null || !data.Any())
                {
                    return NotFound(new { message = "data of FeatureTools could not be found!", StatusCode = 400 });
                }
                return Ok(data);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }
        [HttpGet("Price")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetPrice()
        {
            try
            {
                var data = await _repository.GetPriceDataAsync();
                if (data == null || !data.Any())
                {
                    return NotFound(new { message = "data of Price could not be found!", StatusCode = 400 });
                }
                return Ok(data);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"internal server error: {ex.Message}");
            }
        }
        [HttpGet("PricePlan")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetPricePlan()
        {
            try
            {
                var data = await _repository.GetPricePlanDataAsync();
                if (data == null || !data.Any())
                {
                    return NotFound(new { message = "data of PricePlan could not be found!", StatusCode = 400 });
                }
                return Ok(data);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpGet("PlanFeatures")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetPlanFeatures()
        {
            try
            {
                var data = await _repository.GetPlanFeaturesDataAsync();
                if (data == null || !data.Any())
                {
                    return NotFound(new { message = "data of PlanFeatures could not be found!", StatusCode = 400 });
                }
                return Ok(data);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
        [HttpGet("Testimonial")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetTestimonial()
        {
            try
            {
                var data = await _repository.GetTestimonialDataAsync();
                if (data == null || !data.Any())
                {
                    return NotFound(new { message = "data of Testimonials could not be found!", StatusCode = 400 });
                }
                return Ok(data);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
        [HttpGet("TestimonialRoles")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetTestimonialRoles()
        {
            try
            {
                var data = await _repository.GetTestimonialRolesDataAsync();
                if (data == null || !data.Any())
                {
                    return NotFound(new { message = "data of TestimonialsRoles could not be found!", StatusCode = 400 });
                }
                return Ok(data);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
        [HttpGet("Footer")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetFooter()
        {
            try
            {
                var data = await _repository.GetFooterDataAsync();
                if (data == null || !data.Any())
                {
                    return NotFound(new { message = "data of Footer could not be found!", StatusCode = 400 });
                }
                return Ok(data);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
        [HttpGet("FooterDetails")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetFooterDetails()
        {
            try
            {
                var data = await _repository.GetFooterDetailsDataAsync();
                if (data == null || !data.Any())
                {
                    return NotFound(new { message = "data of FooterDetails could not be found!", StatusCode = 400 });
                }
                return Ok(data);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
        [HttpGet("CopyWright")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetCopyWright()
        {
            try
            {
                var data = await _repository.GetCopyWrightDataAsync();
                if (data == null || !data.Any())
                {
                    return NotFound(new { message = "data of CopyWrights could not be found!", StatusCode = 400 });
                }
                return Ok(data);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = $"Internal server error: {ex.Message}" });
            }
        }
    }
}
