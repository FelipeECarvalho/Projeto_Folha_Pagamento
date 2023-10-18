using Projeto_WindowsForms.DAL;
using Projeto_WindowsForms.Modelo;

namespace Projeto_WindowsForms.Controle
{
    public class ControleBase
    {
        // Atributos
        public int i;

        public string mensagem = "";

        //Construtor
        public ControleBase() 
        {
            mensagem = "";
        }

        //Métodos

        public void ValidarCalculos(string horasExtrasText)
        {
            // Instancie a classe Validacao e chama o método ValidarCalculo da classe Validacao
            Validacao validacao = new Validacao();
            validacao.ValidarCalculo(horasExtrasText);

            // Pega o resultado da mensagem da validação
            this.mensagem = validacao.mensagem;
        }

        public Colaborador buscarColaborador(string idNome)
        {
            var validacao = new Validacao();
            validacao.ValidarBuscaColaborador(idNome);

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

        public void cadastrarColaborador(Colaborador colaborador)
        {
            var validacao = new Validacao();
            validacao.validarDadosColaborador(colaborador);

            if (validacao.mensagem.Equals(""))
            {
                try
                {
                    var colaboradorDAO = new ColaboradorDAO();
                    colaboradorDAO.cadastrarColaborador(colaborador);
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
    }
}