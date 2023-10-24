using Projeto_WindowsForms.DAL;
using Projeto_WindowsForms.Modelo;
using System.Security.Cryptography;
using System.Text;

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

        public void cadastrarFolhaPagamento(FolhaPagamento folhaPagamento)
        {
            var validacao = new Validacao();
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

        /// <summary>
        /// Método responsável por gerar uma nova senha númerica de seis digitos
        /// </summary>
        /// <returns></returns>
        private static string GerarSenha()
        {
            var rnd = new Random();
            
            // Instanciação de um array de int
            var randomNumbers = new int[6];

            for (int i = 0; i < randomNumbers.Length; i++)
            {
                // É gerado aleatoriamente um número inteiro e inserido no array
                randomNumbers[i] = rnd.Next(0, 9);
            }

            // É convertido o array de inteiro em uma string
            var randomString = string.Join("", randomNumbers);

            return randomString;
        }

        public static string GerarHashMd5(string input)
        {
            var md5Hash = MD5.Create();

            // Converter a String para array de bytes, que é como a biblioteca trabalha.
            var data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Cria-se um StringBuilder para recompôr a string.
            var sBuilder = new StringBuilder();

            // Loop para formatar cada byte como uma String em hexadecimal
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }
    }
}