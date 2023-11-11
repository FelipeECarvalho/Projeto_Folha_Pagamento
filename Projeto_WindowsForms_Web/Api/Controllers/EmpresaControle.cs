using DAL;
using Microsoft.AspNetCore.Mvc;
using Modelo;
using Projeto_Api.ViewModels;

namespace Projeto_Api.Controllers
{
    [Route("empresa")]
    [ApiController]
    public class EmpresaControle : BaseControle
    {
        /// <summary>
        /// Método responsável por cadastrar uma empresa
        /// </summary>
        /// <param name="empresa"></param>
        [HttpPost]
        public ActionResult Post([FromBody] Empresa empresa)
        {
            validacao.ValidarDadosEmpresa(empresa);

            if (string.IsNullOrEmpty(validacao.Mensagem))
            {
                try
                {
                    var empresaDAO = new EmpresaDAO();
                    empresaDAO.CadastrarEmpresa(empresa);

                    return Ok();
                }
                catch (Exception e)
                {
                    return StatusCode(500, new ResultadoViewModel<Empresa>(e.Message));
                }
            }
            else
            {
                return StatusCode(500, new ResultadoViewModel<Empresa>(validacao.Mensagem));
            }
        }

        /// <summary>
        /// Método responsável por editar uma empresa
        /// </summary>
        /// <param name="empresa"></param>
        /// <returns></returns>
        [HttpPut]
        public ActionResult Put(Empresa empresa)
        {
            validacao.ValidarDadosEmpresa(empresa);

            if (string.IsNullOrEmpty(validacao.Mensagem))
            {
                try
                {
                    var empresaDAO = new EmpresaDAO();
                    empresaDAO.EditarEmpresa(empresa);

                    return Ok();
                }
                catch (Exception e)
                {
                    return StatusCode(500, new ResultadoViewModel<Empresa>(e.Message));
                }
            }
            else
            {
                return StatusCode(500, new ResultadoViewModel<Empresa>(validacao.Mensagem));
            }
        }

        /// <summary>
        /// Método responsável por listar todas as empresas
        /// </summary>
        /// <returns></returns>
        [HttpGet("listar")]
        public ActionResult Get()
        {
            try
            {
                var empresaDao = new EmpresaDAO();
                var listaEmpresas = empresaDao.ListarEmpresa();

                return Ok(new ResultadoViewModel<List<Empresa>>(listaEmpresas));
            }
            catch (Exception e)
            {
                return StatusCode(500, new ResultadoViewModel<Empresa>(e.Message));
            }
        }

        /// <summary>
        /// Método responsável por desativar uma empresa
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        public ActionResult Delete(int id)
        {
            try
            {
                var empresaDao = new EmpresaDAO();
                empresaDao.DesativarEmpresa(id);

                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500, new ResultadoViewModel<Empresa>(e.Message));
            }
        }

        /// <summary>
        /// Método responsável por buscar uma empresa pelo ID
        /// </summary>
        /// <param name="id">id da empresa</param>
        /// <returns></returns>
        [HttpGet("{id:int}")]
        public ActionResult Get(int id)
        {
            try
            {
                var empresaDAO = new EmpresaDAO();
                var empresa = empresaDAO.BuscarEmpresa(id);

                return Ok(new ResultadoViewModel<Empresa>(empresa));
            }
            catch (Exception e)
            {
                return StatusCode(500, new ResultadoViewModel<Empresa>(e.Message));
            }
        }
    }
}
