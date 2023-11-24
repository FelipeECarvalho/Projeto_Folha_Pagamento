using Microsoft.AspNetCore.Mvc;
using Modelo.Enum;
using Projeto_Web.ViewModel;
using Servico;

namespace Projeto_Web.Controllers
{
    public class RelatorioController : Controller
    {
        public IActionResult RelatorioColaborador(int id)
        {
            var colaboradorServico = new ColaboradorServico();

            var colaborador = colaboradorServico.BuscarColaborador(id);
            var listaColaborador = colaboradorServico.ListarColaborador();

            // Caso o colaborador não seja adiministrador, só poderá ver o próprio relátório
            if (colaborador.Cargo != TipoCargo.Administrador)
                listaColaborador = listaColaborador.Where(x => x.Id == colaborador.Id).ToList();

            var viewModel = new RelatorioViewModel()
            {
                Colaborador = colaborador,
                Colaboradores = listaColaborador
            };

            ViewBag.Id = id;
            ViewBag.Cargo = colaborador.Cargo;

            return View(viewModel);
        }

        public IActionResult RelatorioEmpresa(int id)
        {
            var colaboradorServico = new ColaboradorServico();
            var empresaServico = new EmpresaServico();

            var colaborador = colaboradorServico.BuscarColaborador(id);
            var listaEmpresa = empresaServico.ListarEmpresa();

            var viewModel = new RelatorioViewModel()
            {
                Colaborador = colaborador,
                Empresas = listaEmpresa
            };

            ViewBag.Id = id;
            ViewBag.Cargo = colaborador.Cargo;

            return View(viewModel);
        }

        public IActionResult RelatorioFolhaPagamento(int id)
        {
            var colaboradorServico = new ColaboradorServico();
            var folhaPagametoServico = new FolhaPagamentoServico();

            var colaborador = colaboradorServico.BuscarColaborador(id);
            var listaFolhaPagamento = folhaPagametoServico.ListarFolhaPagamento();

            if (colaborador.Cargo != TipoCargo.Administrador)
                listaFolhaPagamento = listaFolhaPagamento.Where(x => x.Colaborador.Id == colaborador.Id).ToList();

            var viewModel = new RelatorioViewModel()
            {
                Colaborador = colaborador,
                FolhasPagamento = listaFolhaPagamento
            };

            ViewBag.Id = id;
            ViewBag.Cargo = colaborador.Cargo;

            return View(viewModel);
        }
    }
}
