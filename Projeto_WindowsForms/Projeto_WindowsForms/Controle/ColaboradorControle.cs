using Projeto_WindowsForms.DAL;
using Projeto_WindowsForms.Modelo;

namespace Projeto_WindowsForms.Controle
{
    public class ColaboradorControle : ControleBase
    {
        public Colaborador buscarColaborador(string idNome)
        {
            validacao.validarBuscaColaborador(idNome);

            if (string.IsNullOrEmpty(validacao.mensagem))
            {
                try
                {
                    var colaboradorDAO = new ColaboradorDAO();
                    var colaborador = colaboradorDAO.buscarColaborador(idNome);

                    if (colaborador == null)
                        mensagem = "Colaborador não encontrado.";

                    return colaborador;
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

        public Acesso cadastrarColaborador(Colaborador colaborador)
        {
            validacao.validarDadosColaborador(colaborador);

            if (validacao.mensagem.Equals(""))
            {
                try
                {
                    var colaboradorDAO = new ColaboradorDAO();

                    var acesso = new Acesso
                    {
                        Ativo = true,
                        Colaborador = colaborador,
                        SenhaOriginal = GerarSenha(),
                        Usuario = string.Format("{0}{1}", colaborador.NomeCompleto.Replace(" ", "_").ToLower(), new Random().Next(0, 9))
                    };

                    acesso.Senha = GerarHashMd5(acesso.SenhaOriginal);

                    colaboradorDAO.cadastrarColaborador(colaborador, acesso);

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

        public List<Colaborador> listarColaborador()
        {
            try
            {
                var colaboradorDAO = new ColaboradorDAO();

                return colaboradorDAO.listarColaborador();
            }
            catch (Exception e)
            {
                this.mensagem = e.Message;
            }

            return new List<Colaborador>();
        }

        public void desativarColaborador(int id)
        {
            try
            {
                var colaboradorDAO = new ColaboradorDAO();

                colaboradorDAO.desativarColaborador(id);
            }
            catch (Exception e)
            {
                this.mensagem = e.Message;
            }
        }
    }
}
