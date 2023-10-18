using Projeto_WindowsForms.DAL;
using Projeto_WindowsForms.Modelo;

namespace Projeto_WindowsForms.Controle
{
    public class ControleBase
    {
        // Atributos
        public string mensagem = "";

        //Métodos
        public void ValidarCalculos(string horasExtrasText)
        {
            // Instancie a classe Validacao e chama o método ValidarCalculo da classe Validacao
            Validacao validacao = new Validacao();
            validacao.validarCalculo(horasExtrasText);

            // Pega o resultado da mensagem da validação
            this.mensagem = validacao.mensagem;
        }

        public Acesso buscarAcesso(string usuario, string senha)
        {
            var validacao = new Validacao();
            validacao.validarBuscaAcesso(usuario, senha);

            if (string.IsNullOrEmpty(validacao.mensagem))
            {
                try
                {
                    var acessoDAO = new AcessoDAO();
                    var acesso = acessoDAO.buscarAcesso(usuario, senha);

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

        public Colaborador buscarColaborador(string idNome)
        {
            var validacao = new Validacao();
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
            var validacao = new Validacao();
            validacao.validarDadosColaborador(colaborador);

            if (validacao.mensagem.Equals(""))
            {
                try
                {
                    var colaboradorDAO = new ColaboradorDAO();

                    var acesso = new Acesso
                    {
                        Usuario = colaborador.NomeCompleto.Replace(" ", "_").ToLower(),
                        Senha = GerarSenha(),
                        Colaborador = colaborador
                    };

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

        public void cadastrarEmpresa(Empresa empresa)
        {
            var validacao = new Validacao();
            validacao.validarDadosEmpresa(empresa);

            if (string.IsNullOrEmpty(validacao.mensagem))
            {
                try
                {
                    var empresaDAO = new EmpresaDAO();
                    empresaDAO.cadastrarEmpresa(empresa);
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

        public List<Empresa> listarEmpresas()
        {
            try
            {
                var empresaDao = new EmpresaDAO();

                return empresaDao.listarEmpresa();
            }
            catch (Exception e)
            {
                this.mensagem = e.Message;
            }

            return new List<Empresa>();
        }

        private static string GerarSenha()
        {
            var rnd = new Random();

            var randomNumbers = new int[6];
            for (int i = 0; i < randomNumbers.Length; i++)
            {
                randomNumbers[i] = rnd.Next(0, 9);
            }

            var randomString = string.Join("", randomNumbers);

            return randomString;
        }
    }
}