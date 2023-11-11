using Microsoft.AspNetCore.Mvc;
using Modelo;
using Servico;

namespace Projeto_Web.Controllers
{
    public class AcessoController : Controller
    {
        public IActionResult Index()
        {
            var acesso = new Acesso();
            return View(acesso);
        }

        [HttpGet]
        public IActionResult Acessar(Acesso acesso)
        {
            try
            {
                var acessoServico = new AcessoServico();
                var acessoBd = acessoServico.BuscarAcesso(acesso.Usuario, acesso.SenhaOriginal);

                return RedirectToAction("Index", "Menu", new { id = acessoBd.Colaborador.Id });
            }
            catch (Exception ex)
            {
                ViewBag.Mensagem = ex.Message;

                return View("Index");
            }
        }
    }
}