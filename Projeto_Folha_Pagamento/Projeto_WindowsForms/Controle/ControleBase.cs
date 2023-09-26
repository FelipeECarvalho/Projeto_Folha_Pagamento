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
                this.mensagem = "Cadastro com sucesso";
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
        }

    }
}