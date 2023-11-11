using DAL;
using Microsoft.AspNetCore.Mvc;
using Modelo;
using Projeto_Api.Utils;
using Projeto_Api.ViewModels;

namespace Projeto_Api.Controllers
{
    [ApiController]
    [Route("acesso")]
    public class AcessoControle : BaseControle
    {
        /// <summary>
        /// Método resposável por buscar o acesso por meio do usuario e senha
        /// </summary>
        /// <param name="usuario">Usuario</param>
        /// <param name="senha">Senha</param>
        [HttpGet]
        public ActionResult Get([FromHeader] string usuario, [FromHeader] string senha)
        {
            validacao.ValidarBuscaAcesso(usuario, senha);

            if (string.IsNullOrEmpty(validacao.Mensagem))
            {
                try
                {
                    var acessoDAO = new AcessoDAO();

                    var senhaCriptografada = Senha.GerarHashMd5(senha);
                    var acesso = acessoDAO.BuscarAcesso(usuario, senhaCriptografada);

                    if (acesso == null)
                        return StatusCode(500, new ResultadoViewModel<Acesso>("Usuário ou senha inválidos, revise e tente novamente."));

                    return Ok(new ResultadoViewModel<Acesso>(acesso));
                }
                catch (Exception e)
                {
                    return StatusCode(500, new ResultadoViewModel<Colaborador>(e.Message));
                }
            }
            else
            {
                return StatusCode(500, new ResultadoViewModel<Acesso>(validacao.Mensagem));
            }
        }

        /// <summary>
        /// Método resposável por buscar o acesso por meio do ID de um colaborador
        /// </summary>
        /// <param name="id">ID do colaborador</param>
        [HttpGet("{idColaborador:int}")]
        public ActionResult Get([FromRoute] int idColaborador)
        {
            try
            {
                var acessoDAO = new AcessoDAO();

                var acesso = acessoDAO.BuscarAcesso(idColaborador);

                if (acesso == null)
                    return StatusCode(500, new ResultadoViewModel<Acesso>("Acesso não encontrado, revise e tente novamente."));

                return Ok(new ResultadoViewModel<Acesso>(acesso));
            }
            catch (Exception e)
            {
                return StatusCode(500, new ResultadoViewModel<Colaborador>(e.Message));
            }
        }
    }
}