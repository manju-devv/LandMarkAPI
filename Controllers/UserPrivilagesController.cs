using Microsoft.AspNetCore.Mvc;
using LankMarkAPI.Database;
namespace LankMarkAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserPrivilagesController : ControllerBase
    {
        private readonly DatabaseConnection _context;
        public UserPrivilagesController(DatabaseConnection context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> GetUserPrivilages()
        {
            try
            {
                var data = await _context.GetUserPrivilagesDataAsync();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"internal server error: {ex.Message}");
            }
        }
    }
}
