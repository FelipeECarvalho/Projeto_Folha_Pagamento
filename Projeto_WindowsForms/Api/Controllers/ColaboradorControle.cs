using DAL;
using Modelo;
using Projeto_Api.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Projeto_Api.Utils;

namespace Projeto_Api.Controllers
{
    [ApiController]
    [Route("colaborador")]
    public class ColaboradorControle : BaseControle
    {
        /// <summary>
        /// Método responsável por buscar colaborador(es) pelo nome
        /// </summary>
        /// <param name="nome">nome do colaborador</param>
        /// <returns>Uma lista de colaboradores contendo o nome informado</returns>
        public ActionResult Get([FromHeader] string nome)
        {
            validacao.ValidarBuscaColaborador(nome);

            if (string.IsNullOrEmpty(validacao.Mensagem))
            {
                try
                {
                    var colaboradorDAO = new ColaboradorDAO();
                    var listaColaborador = colaboradorDAO.BuscarColaborador(nome);

                    if (listaColaborador == null || listaColaborador.Count == 0)
                        return StatusCode(500, new ResultadoViewModel<Colaborador>("Colaborador não encontrado."));

                    return Ok(new ResultadoViewModel<IList<Colaborador>>(listaColaborador));
                }
                catch (Exception e)
                {
                    return StatusCode(500, new ResultadoViewModel<Colaborador>(e.Message));
                }
            }
            else
            {
                return StatusCode(500, new ResultadoViewModel<Colaborador>(validacao.Mensagem));
            }
        }

        /// <summary>
        /// Método responsável por buscar um colaborador pelo ID
        /// </summary>
        /// <param name="id">Id do colaborador</param>
        [HttpGet("{id:int}")]
        public ActionResult Get([FromRoute]int id)
        {
            validacao.ValidarBuscaColaborador(id);

            if (string.IsNullOrEmpty(validacao.Mensagem))
            {
                try
                {
                    var colaboradorDAO = new ColaboradorDAO();
                    var colaborador = colaboradorDAO.BuscarColaborador(id);

                    if (colaborador == null)
                        return StatusCode(500, new ResultadoViewModel<Colaborador>("Colaborador não encontrado."));

                    return Ok(new ResultadoViewModel<Colaborador>(colaborador));
                }
                catch (Exception e)
                {
                    return StatusCode(500, new ResultadoViewModel<Colaborador>(e.Message));
                }
            }
            else
            {
                return StatusCode(500, new ResultadoViewModel<Colaborador>(validacao.Mensagem));
            }
        }

        /// <summary>
        /// Método responsável por listar todos os colaboradores cadastrados
        /// </summary>
        /// <returns>Lista contendo todos os colaboradores</returns>
        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                var colaboradorDAO = new ColaboradorDAO();
                var listaColaborador = colaboradorDAO.ListarColaborador();

                return Ok(new ResultadoViewModel<IList<Colaborador>>(listaColaborador));
            }
            catch (Exception e)
            {
                return StatusCode(500, new ResultadoViewModel<Colaborador>(e.Message));
            }
        }

        /// <summary>
        /// Método responsável por cadastrar um colaborador
        /// </summary>
        /// <param name="colaborador"></param>
        /// <returns>Retorna o acesso vinculado ao colaborador</returns>
        [HttpPost]
        public ActionResult Post([FromBody]Colaborador colaborador)
        {
            validacao.ValidarDadosColaborador(colaborador);

            if (string.IsNullOrEmpty(validacao.Mensagem))
            {
                try
                {
                    var acesso = new Acesso
                    {
                        Ativo = true,
                        Colaborador = colaborador,
                        SenhaOriginal = Senha.GerarSenha(),
                        Usuario = string.Format("{0}{1}", colaborador.NomeCompleto.Replace(" ", "_").ToLower(), new Random().Next(9, 99))
                    };

                    acesso.Senha = Senha.GerarHashMd5(acesso.SenhaOriginal);

                    var colaboradorDAO = new ColaboradorDAO();
                    colaboradorDAO.CadastrarColaborador(colaborador, acesso);

                    return Ok(new ResultadoViewModel<Acesso>(acesso));
                }
                catch (Exception e)
                {
                    return StatusCode(500, new ResultadoViewModel<Colaborador>(e.Message));
                }
            }
            else
            {
                return StatusCode(500, new ResultadoViewModel<Colaborador>(validacao.Mensagem));
            }
        }

        /// <summary>
        /// Método responsável por editar um colaborador
        /// </summary>
        /// <param name="colaborador"></param>
        /// <param name="acesso"></param>
        /// <returns></returns>
        [HttpPut]
        public ActionResult Put([FromBody]Colaborador colaborador, [FromBody]Acesso acesso)
        {
            validacao.ValidarDadosColaborador(colaborador, acesso);

            if (string.IsNullOrEmpty(validacao.Mensagem))
            {
                try
                {
                    acesso.Senha = Senha.GerarHashMd5(acesso.SenhaOriginal);
                    
                    var colaboradorDAO = new ColaboradorDAO();
                    colaboradorDAO.EditarColaborador(colaborador, acesso);

                    return Ok();
                }
                catch (Exception e)
                {
                    return StatusCode(500, new ResultadoViewModel<Colaborador>(e.Message));
                }
            }
            else
            {
                return StatusCode(500, new ResultadoViewModel<Colaborador>(validacao.Mensagem));
            }
        }

        /// <summary>
        /// Método responsável por desativar um colaborador
        /// </summary>
        /// <param name="id">Id do colaborador</param>
        [HttpDelete("{id:int}")]
        public ActionResult Delete([FromRoute]int id)
        {
            try
            {
                var colaboradorDAO = new ColaboradorDAO();
                colaboradorDAO.DesativarColaborador(id);

                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500, new ResultadoViewModel<Colaborador>(e.Message));
            }
        }
    }
}
