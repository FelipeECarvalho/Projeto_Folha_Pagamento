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
        public int ValidarColaboradores(List<Colaborador> colaboradores, List<string> nomesColaboradores)
        {
            // Instancia a classe Validacao e chama o método ValidarColaboradores
            // Pega o resultado da mensagem da validação e o índice do colaborador (se houver)
            Validacao validacao = new Validacao();
            validacao.ValidarColaboradores(colaboradores, nomesColaboradores);
            this.mensagem = validacao.mensagem;
            return this.i = validacao.indice;

        }

        public void ValidarCalculos(string horasExtrasText)
        {
            // Instancie a classe Validacao e chama o método ValidarCalculo da classe Validacao
            Validacao validacao = new Validacao();
            validacao.ValidarCalculo(horasExtrasText);

            // Pega o resultado da mensagem da validação
            this.mensagem = validacao.mensagem;
        }

        public void cadastrarColaborador(List<string> listaDadosColaborador)
        {
            Validacao validacao = new Validacao();
            validacao.validarDadosColaborador(listaDadosColaborador);
            if (validacao.mensagem.Equals(""))
            {
                //Colaborador colaborador = new Colaborador();
                //colaborador.Nome = listaDadosColaborador[0];
                //colaborador.Cargo = listaDadosColaborador[1];
                //colaborador.Empresa = listaDadosColaborador[2];
                //colaborador.Salario = listaDadosColaborador[3];
                //colaborador.DataAdmissao = listaDadosColaborador[4];
                //ColaboradorDAO colaboradorDAO = new ColaboradorDAO();
                //colaboradorDAO.cadastrarColaborador(colaborador);
                this.mensagem = "Cadastro com sucesso";
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
            EmpresaDAO empresaDao = new EmpresaDAO();
            var listaEmpresa = empresaDao.listarEmpresa();

            return listaEmpresa;
        }


    }
}