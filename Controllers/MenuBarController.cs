using Microsoft.AspNetCore.Mvc;
using LankMarkAPI.Database;


namespace LankMarkAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class MenuBarController : ControllerBase
    {
        private readonly DatabaseConnection _context;
        public MenuBarController(DatabaseConnection context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> GetMenuBar()
        {
            try
            {
                var data = await _context.GetMenuBarDataAsync();
                return Ok(data);
            }
            catch (Exception e)
            {
                return StatusCode(500, $"something went wrong: {e.Message}");
            }
        }
    }
}
