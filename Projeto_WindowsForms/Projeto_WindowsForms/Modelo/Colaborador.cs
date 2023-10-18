using Projeto_WindowsForms.Modelo.Enum;

namespace Projeto_WindowsForms.Modelo
{
    public class Colaborador
    {
        // Atributos
        public int Id { get; set; }
        public string NomeCompleto { get; set; }
        public TipoSexo Sexo { get; set; }
        public TipoCargo Cargo { get; set; }
        public decimal Salario { get; set; }
        public DateTime DataAdmissao { get; set; }
        public Empresa Empresa { get; set; }
    }
}