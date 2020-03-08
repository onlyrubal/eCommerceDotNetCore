using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace eCommerceDotNetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> GetString()
        {
            return new string[] { "this", "is", "for", "practice" };
        }
    }
}