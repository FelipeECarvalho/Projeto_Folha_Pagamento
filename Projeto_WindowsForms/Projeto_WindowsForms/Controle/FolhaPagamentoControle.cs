using Projeto_WindowsForms.DAL;
using Projeto_WindowsForms.Modelo;

namespace Projeto_WindowsForms.Controle
{
    public class FolhaPagamentoControle : ControleBase
    {
        public void cadastrarFolhaPagamento(FolhaPagamento folhaPagamento)
        {
            validacao.validarDadosFolhaPagamento(folhaPagamento);

            if (string.IsNullOrEmpty(validacao.mensagem))
            {
                try
                {
                    var folhaPagamentoDAO = new FolhaPagamentoDAO();
                    folhaPagamentoDAO.cadastrarFolhaPagamento(folhaPagamento);
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
        }

        public List<FolhaPagamento> listarFolhaPagamento()
        {
            try
            {
                var folhaPagamentoDAO = new FolhaPagamentoDAO();

                return folhaPagamentoDAO.listarFolhaPagamento();
            }
            catch (Exception e)
            {
                this.mensagem = e.Message;
            }

            return new List<FolhaPagamento>();
        }

        public FolhaPagamento buscarFolhaPagamentoPorColaborador(Colaborador colaborador)
        {
            try
            {
                var folhaPagamentoDAO = new FolhaPagamentoDAO();

                return folhaPagamentoDAO.buscarPorColaborador(colaborador);
            }
            catch (Exception e)
            {
                this.mensagem = e.Message;
            }

            return null;
        }
    }
}
