using Modelo.Enum;

namespace Modelo
{
    public class Colaborador : ModeloBase
    {
        public string NomeCompleto { get; set; }
        public TipoSexo Sexo { get; set; }
        public TipoCargo Cargo { get; set; }
        public decimal Salario { get; set; }
        public DateTime DataAdmissao { get; set; }
        public Empresa Empresa { get; set; }
    }
}