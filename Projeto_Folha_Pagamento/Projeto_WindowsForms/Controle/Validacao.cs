using Projeto_WindowsForms.Modelo;

namespace Projeto_WindowsForms.Controle
{
    public class Validacao
    {
        // Atributos
        public string mensagem;
        public int indice;
        public int IndiceColaboradorEncontrado = -1;

        // Construtor

        //Métodos
        public int ValidarColaboradores(List<Colaborador> colaboradores, List<string> nomesColaboradores)
        {
            // Looping para validar a lista de coboradores com o valor inserido na TextBox
            for (int i = 0; i < colaboradores.Count; i++)
            {
                foreach (string nome in nomesColaboradores)
                {
                    // Se o valor for encontrado com o nome ou com o ID..
                    if (colaboradores[i].Nome.Equals(nome, StringComparison.OrdinalIgnoreCase))
                    {
                        this.mensagem = "Colaborador encontrado!";
                        this.indice = i;
                        return indice; // Retorna o índice do colaborador encontrado
                    }
                    else if (colaboradores[i].ID.ToString().Equals(nome, StringComparison.OrdinalIgnoreCase))
                    {
                        this.mensagem = "Colaborador encontrado!";
                        this.indice = i;
                        return indice; // Retorna o índice do colaborador encontrado
                    }
                }
            }

            // Se o valor não corresponder à nenhum colaborador da lista de colaboradores
            this.mensagem = "Colaborador não encontrado!";
            return -1; // Retorna -1 se o colaborador não for encontrado
        }

        public void ValidarCalculo(string horasExtrasText)
        {
            // Validação: Tenta converter o valor inserido em double
            if (double.TryParse(horasExtrasText, out double horasExtras))
            {
                this.mensagem = ""; // Se a conversão der certo, retorna mensagem vazia
            }
            else
            {
                this.mensagem = "Número inserido é inválido!"; // Se a conversão der errado, retorna "Número inserido é inválido!"
            }
        }
        
        public void validarDadosColaborador(List<string>listaDadosColaborador)
        {
            this.mensagem = "";
            if (listaDadosColaborador[0].Length < 3)
                this.mensagem += "Campo nome deve ter mais de 3 caracteres";
        }
    }
}