using Microsoft.AspNetCore.Mvc;
using LankMarkAPI.Database;
namespace LankMarkAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CopyWrightController : ControllerBase
    {
        private readonly DatabaseConnection _context;
        public CopyWrightController(DatabaseConnection context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> GetCopyWright()
        {
            try
            {
                var data = await _context.GetCopyWrightDataAsync();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = $"Internal server error: {ex.Message}"});
            }
        }
    }
}
