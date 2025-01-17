using Microsoft.AspNetCore.Mvc;

namespace LankMarkAPI.Controllers
{
    [ApiController]
    [Route("api/{*url}")]
    public class NotFoundController : ControllerBase
    {
        [HttpGet]
        public ActionResult HandleUndefinedRoutes()
        {
            return NotFound(new {messsage = "page not found Maybe dont exist!!"});
        }
    }
}
