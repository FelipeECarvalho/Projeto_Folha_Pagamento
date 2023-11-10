using Modelo;

namespace Projeto_Api
{
    public class Validacao
    {
        // Atributos
        public string Mensagem = "";

        //Métodos
        public void ValidarBuscaColaborador(string idNome)
        {
            this.Mensagem = "";

            if (string.IsNullOrEmpty(idNome))
                this.Mensagem = "Id ou nome inválido, revise e tente novamente.";
        }

        public void ValidarBuscaColaborador(int id)
        {
            this.Mensagem = "";

            if (id <= 0)
                this.Mensagem = "Id inválido, revise e tente novamente.";
        }

        public void ValidarBuscaAcesso(string usuario, string senha)
        {
            this.Mensagem = "";

            if (string.IsNullOrEmpty(usuario))
                this.Mensagem += "Usuário inválido, revise e tente novamente.\n";

            if (string.IsNullOrEmpty(senha))
                this.Mensagem += "Senha inválida, revise e tente novamente.\n";
        }

        public void ValidarCalculo(string horasExtrasText)
        {
            // Validação: Tenta converter o valor inserido em double
            if (double.TryParse(horasExtrasText, out double horasExtras))
            {
                this.Mensagem = ""; // Se a conversão der certo, retorna mensagem vazia
            }
            else
            {
                this.Mensagem = "Número inserido é inválido!"; // Se a conversão der errado, retorna "Número inserido é inválido!"
            }
        }

        public void ValidarDadosColaborador(Colaborador colaborador, Acesso acesso = null)
        {
            this.Mensagem = "";

            if (string.IsNullOrEmpty(colaborador.NomeCompleto))
                this.Mensagem += "Nome do colaborador obrigatório\n";

            if (colaborador.NomeCompleto.Length > 50)
                this.Mensagem += "Nome do colaborador não pode exceder de 50 caracteres\n";

            if (colaborador.Empresa == null || colaborador.Empresa.Id == 0)
                this.Mensagem += "Empresa obrigatória\n";

            if (colaborador.Salario == default)
                this.Mensagem += "Salário obrigatório\n";

            if (colaborador.DataAdmissao == default)
                this.Mensagem += "Data de admissão obrigatório\n";

            if (acesso != null)
            {
                if (string.IsNullOrEmpty(acesso.SenhaOriginal))
                    this.Mensagem += "Senha obrigatória\n";

                if (acesso.SenhaOriginal.Length > 50)
                    this.Mensagem += "A senha não pode exceder de 50 caracteres\n";
            }
        }

        public void ValidarDadosEmpresa(Empresa empresa)
        {
            this.Mensagem = "";

            if (string.IsNullOrEmpty(empresa.Cnpj))
                this.Mensagem += "O Cnpj é obrigatório\n";

            if (empresa.Cnpj.Length > 20)
                this.Mensagem += "O CNPJ não pode exceder de 14 caracteres\n";

            if (string.IsNullOrEmpty(empresa.RazaoSocial))
                this.Mensagem += "A Razão social é obrigatória\n";

            if (empresa.RazaoSocial.Length > 50)
                this.Mensagem += "A Razão Social não pode exceder 50 caracteres.\n";

            if (string.IsNullOrEmpty(empresa.NomeFantasia))
                this.Mensagem += "O Nome Fantasia é obrigatório.\n";

            if (empresa.NomeFantasia.Length > 50)
                this.Mensagem += "O Nome Fantasia não pode exceder 50 caracteres.\n";
        }

        //public void validarDadosFolhaPagamento(FolhaPagamento folhaPagamento)
        //{
        //    this.mensagem = "";
        //    var folhaPagamentoControle = new FolhaPagamentoControle();

        //    if (folhaPagamento.ValorLiquido == 0)
        //        this.mensagem += "Valor líquido é obrigatório\n";

        //    if (folhaPagamento.VencimentosTotais == 0)
        //        this.mensagem += "Vencimentos totais é obrigatório\n";

        //    if (folhaPagamento.Colaborador == null || folhaPagamento.Colaborador.Id == 0)
        //        this.mensagem += "Colaborador é obrigatório\n";

        //    var folhaPagamentoValidacao = folhaPagamentoControle.buscarFolhaPagamentoPorColaborador(folhaPagamento.Colaborador);

        //    if (folhaPagamentoValidacao != null)
        //        this.mensagem += "Já existe uma folha de pagamento cadastrada para este colaborador nesse mês\n";
        //}
    }
}