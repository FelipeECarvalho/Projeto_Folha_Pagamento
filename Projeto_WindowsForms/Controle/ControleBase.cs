using Projeto_WindowsForms.DAL;
using Projeto_WindowsForms.Modelo;

namespace Projeto_WindowsForms.Controle
{
    public class ControleBase
    {
        // Atributos
        public string? mensagem = default;
        public int i;

        //Construtor

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
                //colaboradorDAO.cadastrarColaborador();
                this.mensagem = "Cadastro com sucesso";
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
        }

        public void cadastrarEmpresa(List<string> listaDadosEmpresa)
        {
            Validacao validacao = new Validacao();

            validacao.validarDadosEmpresa(listaDadosEmpresa);
            if (validacao.mensagem.Equals(""))
            {
                Empresa empresa = new Empresa(listaDadosEmpresa[0], listaDadosEmpresa[1], listaDadosEmpresa[2]);

                this.mensagem = "Cadastro com sucesso";
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
        }

    }
}