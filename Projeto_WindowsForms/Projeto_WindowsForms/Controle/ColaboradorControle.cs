using Projeto_WindowsForms.DAL;
using Projeto_WindowsForms.Modelo;

namespace Projeto_WindowsForms.Controle
{
    public class ColaboradorControle : ControleBase
    {
        public List<Colaborador> buscarColaborador(string nome)
        {
            validacao.validarBuscaColaborador(nome);

            if (string.IsNullOrEmpty(validacao.mensagem))
            {
                try
                {
                    var colaboradorDAO = new ColaboradorDAO();
                    var listaColaborador = colaboradorDAO.buscarColaborador(nome);

                    if (listaColaborador == null || listaColaborador.Count == 0)
                        mensagem = "Colaborador não encontrado.";

                    return listaColaborador;
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

            return new List<Colaborador>();
        }

        public Colaborador buscarColaborador(int id)
        {
            validacao.validarBuscaColaborador(id);

            if (string.IsNullOrEmpty(validacao.mensagem))
            {
                try
                {
                    var colaboradorDAO = new ColaboradorDAO();
                    var colaborador = colaboradorDAO.buscarColaborador(id);

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
                        Usuario = string.Format("{0}{1}", colaborador.NomeCompleto.Replace(" ", "_").ToLower(), new Random().Next(9, 99))
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

        public void editarColaborador(Colaborador colaborador, Acesso acesso)
        {
            validacao.validarDadosColaborador(colaborador, acesso);

            if (validacao.mensagem.Equals(""))
            {
                try
                {
                    var colaboradorDAO = new ColaboradorDAO();

                    acesso.Senha = GerarHashMd5(acesso.SenhaOriginal);

                    colaboradorDAO.editarColaborador(colaborador, acesso);
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
