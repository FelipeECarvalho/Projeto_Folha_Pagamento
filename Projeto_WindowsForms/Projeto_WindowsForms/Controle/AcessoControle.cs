using Projeto_WindowsForms.DAL;
using Projeto_WindowsForms.Modelo;

namespace Projeto_WindowsForms.Controle
{
    public class AcessoControle : ControleBase
    {
        /// <summary>
        /// Método responsável por buscar o acesso por meio do login e senha do colaborador
        /// </summary>
        /// <param name="usuario">Usuário</param>
        /// <param name="senha">Senha não criptografada</param>
        /// <returns></returns>
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

        /// <summary>
        /// Método responsável por buscar o acesso por meio do Id do colaborador
        /// </summary>
        /// <param name="idColaborador">Id do colaborador</param>
        /// <returns></returns>
        public Acesso buscarAcesso(int idColaborador)
        {
            try
            {
                var acessoDAO = new AcessoDAO();

                var acesso = acessoDAO.buscarAcesso(idColaborador);

                if (acesso == null)
                    mensagem = "Acesso não encontrado.";

                return acesso;
            }
            catch (Exception e)
            {
                this.mensagem = e.Message;
            }

            return null;
        }
    }
}
