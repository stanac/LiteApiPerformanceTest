using Microsoft.AspNetCore.Mvc;

namespace MvcCoreSample.Controllers
{
    [Route("api/[controller]")]
    public class AddController : Controller
    {
        [HttpGet]
        public int Add(int a, int b) => a + b;
    }
}
