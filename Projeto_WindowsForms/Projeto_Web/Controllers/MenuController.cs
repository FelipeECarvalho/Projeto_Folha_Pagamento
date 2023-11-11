using Microsoft.AspNetCore.Mvc;

namespace Projeto_Web.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}