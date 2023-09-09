using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tela_Gerar_Folha_de_Pagamento.Modelo
{
    public class Controle
    {
        // Atributos
        public string mensagem;
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

    }
}
