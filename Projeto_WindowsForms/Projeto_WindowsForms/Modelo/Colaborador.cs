namespace Projeto_WindowsForms.Modelo
{
    public class Colaborador
    {
        // Atributos
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public Empresa Empresa { get; set; }
        public string Salario { get; set; }
        public DateTime DataAdmissao { get; set; }

    }
}