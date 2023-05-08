using Microsoft.AspNetCore.Mvc;

namespace Vishalmsc.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            return Content ("Vishal is a good boy");
        }
    }
}
 