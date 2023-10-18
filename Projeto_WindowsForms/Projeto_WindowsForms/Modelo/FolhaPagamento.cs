namespace Projeto_WindowsForms.Modelo
{
    public class FolhaPagamento
    {
        public decimal Inss { get; set; }
        public decimal Irpf { get; set; }
        public decimal VencimentosTotais { get; set; }
        public decimal DescontosTotais { get; set; }
        public decimal ValorLiquido { get; set; }
        public decimal HorasExtras { get; set; }
        public decimal SalarioHora { get; set; }
        public Colaborador Colaborador { get; set; }
    }
}
