using Microsoft.AspNetCore.Mvc;
using LankMarkAPI.Database;
namespace LankMarkAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FooterController : ControllerBase
    {
        private readonly DatabaseConnection _context;
        public FooterController(DatabaseConnection context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> GetFooter()
        {
            try
            {
                var data = await _context.GetFooterDataAsync();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}
