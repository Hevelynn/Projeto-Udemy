using Microsoft.AspNetCore.Mvc;

namespace ProjetoUdemy.Controllers
{
    public class SellersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
