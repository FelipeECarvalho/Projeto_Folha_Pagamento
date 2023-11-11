using DAL;
using Microsoft.AspNetCore.Mvc;
using Modelo;
using Projeto_Api.ViewModels;

namespace Projeto_Api.Controllers
{
    [ApiController]
    [Route("folha-pagamento")]
    public class FolhaPagamentoControle : BaseControle
    {
        /// <summary>
        /// Método responsável por cadastrar uma folha de pagamento
        /// </summary>
        /// <param name="folhaPagamento"></param>
        [HttpPost]
        public ActionResult Post([FromBody] FolhaPagamento folhaPagamento)
        {
            validacao.ValidarDadosFolhaPagamento(folhaPagamento);

            if (string.IsNullOrEmpty(validacao.Mensagem))
            {
                try
                {
                    var folhaPagamentoDAO = new FolhaPagamentoDAO();
                    folhaPagamentoDAO.CadastrarFolhaPagamento(folhaPagamento);

                    return Ok();
                }
                catch (Exception e)
                {
                    return StatusCode(500, new ResultadoViewModel<FolhaPagamento>(e.Message));
                }
            }
            else
            {
                return StatusCode(500, new ResultadoViewModel<FolhaPagamento>(validacao.Mensagem));
            }
        }

        /// <summary>
        /// Método responsável por listar todas as folhas de pagamento
        /// </summary>
        /// <returns></returns>
        [HttpGet("listar")]
        public ActionResult Get()
        {
            try
            {
                var folhaPagamentoDAO = new FolhaPagamentoDAO();
                var listaFolhaPagamento = folhaPagamentoDAO.ListarFolhaPagamento();

                return Ok(new ResultadoViewModel<List<FolhaPagamento>>(listaFolhaPagamento));
            }
            catch (Exception e)
            {
                return StatusCode(500, new ResultadoViewModel<FolhaPagamento>(e.Message));
            }
        }
    }
}
