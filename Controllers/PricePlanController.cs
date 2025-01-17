using Microsoft.AspNetCore.Mvc;
using LankMarkAPI.Database;
namespace LankMarkAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PricePlanController : ControllerBase
    {
        private readonly DatabaseConnection _context;
        public PricePlanController(DatabaseConnection context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> GetPricePlan()
        {
            try
            {
                var data = await _context.GetPricePlanDataAsync();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}
