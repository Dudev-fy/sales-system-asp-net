using Microsoft.AspNetCore.Mvc;

namespace sales_system.Controllers
{
    public class SellersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
