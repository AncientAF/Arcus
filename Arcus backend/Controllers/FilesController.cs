using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Arcus_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilesController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get(string filePath)
        {
            try
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
