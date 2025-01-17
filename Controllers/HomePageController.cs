using Microsoft.AspNetCore.Mvc;
using LankMarkAPI.Database;

namespace LankMarkAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomePageController : ControllerBase
    {
        private readonly DatabaseConnection _context;
        public HomePageController(DatabaseConnection context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> GetHomePage()
        {
            try
            {
                var data = await _context.GetHomePageDataAsync();
                return Ok(data);
            }
            catch (Exception e)
            {
                return StatusCode(500, $"Internal Server Error: {e.Message}");
            }
        }
    }
}
