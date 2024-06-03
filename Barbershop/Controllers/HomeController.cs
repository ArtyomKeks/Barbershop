using Microsoft.AspNetCore.Mvc;

namespace Barbershop.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        [HttpGet, Route("")]
        public ActionResult Index()
        {
            return View();
        }
    }
}
