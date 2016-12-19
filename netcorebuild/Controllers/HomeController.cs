using Microsoft.AspNetCore.Mvc;

namespace netcorebuild.Controllers
{
    [Route("api/[controller]")]
    public class HomeController : Controller
    {
        // GET api/home/
        [HttpGet]
        public string Get()
        {
            return "Hello world demo";
        }
    }
}
