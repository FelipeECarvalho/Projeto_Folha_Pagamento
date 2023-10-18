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
                    if (colaboradores[i].NomeCompleto.Equals(nome, StringComparison.OrdinalIgnoreCase))
                    {
                        this.mensagem = "Colaborador encontrado!";
                        this.indice = i;
                        return indice; // Retorna o índice do colaborador encontrado
                    }
                    else if (colaboradores[i].Id.ToString().Equals(nome, StringComparison.OrdinalIgnoreCase))
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

        public void validarDadosColaborador(Colaborador colaborador)
        {
            this.mensagem = "";

            if (string.IsNullOrEmpty(colaborador.NomeCompleto))
                this.mensagem += "Nome do colaborador obrigatório\n";

            if (colaborador.NomeCompleto.Length > 50)
                this.mensagem += "Nome do colaborador não pode exceder de 50 caracteres\n";

            if (colaborador.Empresa == null || colaborador.Empresa.Id == 0)
                this.mensagem += "Empresa obrigatório\n";

            if (colaborador.Salario == default)
                this.mensagem += "Salário obrigatório\n";

            if (colaborador.DataAdmissao == default)
                this.mensagem += "Data de admissão obrigatório\n";
        }

        public void validarDadosEmpresa(Empresa empresa)
        {
            this.mensagem = "";

            if (string.IsNullOrEmpty(empresa.Cnpj))
                this.mensagem += "O Cnpj é obrigatório\n";

            if (empresa.Cnpj.Length > 15)
                this.mensagem += "O CNPJ não pode exceder de 14 caracteres\n";

            if (string.IsNullOrEmpty(empresa.RazaoSocial))
                this.mensagem += "A Razão social é obrigatória\n";

            if (empresa.RazaoSocial.Length > 50)
                this.mensagem += "A Razão Social não pode exceder 50 caracteres.\n";

            if (string.IsNullOrEmpty(empresa.NomeFantasia))
                this.mensagem += "O Nome Fantasia é obrigatório.\n";

            if (empresa.NomeFantasia.Length > 50)
                this.mensagem += "O Nome Fantasia não pode exceder 50 caracteres.\n";
        }
    }
}