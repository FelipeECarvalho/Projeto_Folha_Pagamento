using Microsoft.AspNetCore.Mvc;

namespace Projeto_Web.Controllers
{
    public class AcessoController : Controller
    {
        public AcessoController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}