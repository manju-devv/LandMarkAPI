using Microsoft.AspNetCore.Mvc;
using LankMarkAPI.Database;


namespace LankMarkAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PlanFeaturesController : ControllerBase
    {
        private readonly DatabaseConnection _context;
        public PlanFeaturesController(DatabaseConnection context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> GetPlanFeatures()
        {
            try
            {
                var data = await _context.GetPlanFeaturesDataAsync();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}
