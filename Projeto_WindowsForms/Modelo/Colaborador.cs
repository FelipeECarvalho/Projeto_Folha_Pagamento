namespace Projeto_WindowsForms.Modelo
{
    public class Colaborador
    {
        // Atributos
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public string Empresa { get; set; }
        public string Salario { get; set; }
        public string DataAdmissao { get; set; }

        // Construtor
        public Colaborador(int id, string nome, string cargo, string empresa, string salario, string dataAdmissao)
        {
            this.Id= id;
            this.Nome = nome;
            this.Cargo = cargo;
            this.Empresa = empresa;
            this.Salario = salario;
            this.DataAdmissao = dataAdmissao;
        }
    }
}