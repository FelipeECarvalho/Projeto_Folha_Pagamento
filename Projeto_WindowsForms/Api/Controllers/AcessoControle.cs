using Modelo;
using Microsoft.AspNetCore.Mvc;
using Projeto_WindowsForms.DAL;

namespace Api.Controllers
{
    [ApiController]
    [Route("acesso")]
    public class AcessoControle : ControllerBase
    {
        public AcessoControle()
        {
        }

        [HttpGet(Name = "get")]
        public Acesso Get()
        {
            try
            {
                var acessoDAO = new AcessoDAO();

                var senhaCriptografada = GerarHashMd5(senha);
                var acesso = acessoDAO.buscarAcesso(usuario, senhaCriptografada);

                if (acesso == null)
                    mensagem = "Usu�rio ou senha inv�lidos, revise e tente novamente.";

                return acesso;
            }
            catch (Exception e)
            {
                this.mensagem = e.Message;
            }
        }
        }
    }
}