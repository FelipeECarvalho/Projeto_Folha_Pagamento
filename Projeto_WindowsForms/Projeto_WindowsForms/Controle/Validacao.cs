using Projeto_WindowsForms.Modelo;

namespace Projeto_WindowsForms.Controle
{
    public class Validacao
    {
        // Atributos
        public string mensagem = "";

        //Métodos
        public void validarBuscaColaborador(string idNome)
        {
            this.mensagem = "";

            if (string.IsNullOrEmpty(idNome))
                this.mensagem = "Id ou nome inválido, revise e tente novamente.";
        }

        public void validarBuscaAcesso(string usuario, string senha)
        {
            this.mensagem = "";

            if (string.IsNullOrEmpty(usuario))
                this.mensagem += "Usuário inválido, revise e tente novamente.\n";

            if (string.IsNullOrEmpty(senha))
                this.mensagem += "Senha inválida, revise e tente novamente.\n";
        }

        public void validarCalculo(string horasExtrasText)
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
                this.mensagem += "Empresa obrigatória\n";

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

            if (empresa.Cnpj.Length > 20)
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

        public void validarDadosFolhaPagamento(FolhaPagamento folhaPagamento)
        {
            this.mensagem = "";

            if (folhaPagamento.ValorLiquido == 0)
                this.mensagem += "Valor líquido é obrigatório\n";

            if (folhaPagamento.VencimentosTotais == 0)
                this.mensagem += "Vencimentos totais é obrigatório\n";

            if (folhaPagamento.Colaborador == null || folhaPagamento.Colaborador.Id == 0)
                this.mensagem += "Colaborador é obrigatório\n";
        }
    }
}