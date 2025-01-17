using Microsoft.AspNetCore.Mvc;
using LankMarkAPI.Database;
namespace LankMarkAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestimonialRoles : ControllerBase
    {
        private readonly DatabaseConnection _context;
        public TestimonialRoles(DatabaseConnection context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> GetTestimonialRoles()
        {
            try
            {
                var data = await _context.GetTestimonialRolesDataAsync();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}
