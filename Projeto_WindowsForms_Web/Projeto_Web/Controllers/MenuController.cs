﻿using Microsoft.AspNetCore.Mvc;
using Servico;

namespace Projeto_Web.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult Index(int id)
        {
            var colaboradorServico = new ColaboradorServico();
            var colaborador = colaboradorServico.BuscarColaborador(id);

            ViewBag.Id = id;
            ViewBag.Cargo = colaborador.Cargo;

            return View(colaborador);
        }
    }
}