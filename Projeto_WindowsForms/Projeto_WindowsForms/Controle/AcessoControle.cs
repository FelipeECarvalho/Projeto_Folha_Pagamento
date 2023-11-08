using Projeto_WindowsForms.DAL;
using Projeto_WindowsForms.Modelo;

namespace Projeto_WindowsForms.Controle
{
    public class AcessoControle : ControleBase
    {
        public Acesso buscarAcesso(string usuario, string senha)
        {
            validacao.validarBuscaAcesso(usuario, senha);

            if (string.IsNullOrEmpty(validacao.mensagem))
            {
                try
                {
                    var acessoDAO = new AcessoDAO();

                    var senhaCriptografada = GerarHashMd5(senha);
                    var acesso = acessoDAO.buscarAcesso(usuario, senhaCriptografada);

                    if (acesso == null)
                        mensagem = "Usuário ou senha inválidos, revise e tente novamente.";

                    return acesso;
                }
                catch (Exception e)
                {
                    this.mensagem = e.Message;
                }
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }

            return null;
        }
    }
}
