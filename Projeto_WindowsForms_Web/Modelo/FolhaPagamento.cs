namespace Modelo
{
    public class FolhaPagamento : ModeloBase
    {
        public decimal Inss { get; set; }
        public decimal Irrf { get; set; }
        public int HorasExtras { get; set; }
        public decimal ValorHorasExtras { get; set; }
        public decimal ValorLiquido { get; set; }
        public decimal DescontosTotais { get; set; }
        public decimal VencimentosTotais { get; set; }
        public decimal AliquotaInss { get; set; }
        public decimal AliquotaIrrf { get; set; }
        public DateTime DataCriacao { get; set; }
        public Colaborador Colaborador { get; set; }

        public void CalcularSalarioLiquido()
        {
            CalcularINSS();
            CalcularIRPF();
            CalcularHorasExtras();
            CalcularVencimentosTotais();
            CalcularDescontosTotais();

            ValorLiquido = VencimentosTotais - DescontosTotais;
            ValorLiquido = Math.Round(ValorLiquido, 2);
        }

        private void CalcularINSS()
        {
            var salario = Colaborador.Salario;

            // Calcula a alíquota do INSS
            if (salario <= 1320)
                AliquotaInss = 7.5m;
            else if (salario <= 2571)
                AliquotaInss = 9.0m;
            else if (salario <= 3865)
                AliquotaInss = 12m;
            else
                AliquotaInss = 14m;

            Inss = Colaborador.Salario * (AliquotaInss / 100);
            Inss = Math.Round(Inss, 2);
        }

        private void CalcularIRPF()
        {
            var salario = Colaborador.Salario;

            // Calcula a alíquota do IRRF
            if (salario <= 1903)
                AliquotaIrrf = 0.01m;
            else if (salario <= 2826)
                AliquotaIrrf = 7.5m;
            else if (salario <= 3751)
                AliquotaIrrf = 15m;
            else if (salario <= 4664)
                AliquotaIrrf = 22.5m;
            else
                AliquotaIrrf = 27.5m;

            Irrf = Colaborador.Salario * (AliquotaIrrf / 100); // 5% de desconto fictício
            Irrf = Math.Round(Irrf, 2);
        }

        private void CalcularHorasExtras()
        {
            var salarioHora = Colaborador.Salario / 30 / 8;
            var valorHorasExtras = salarioHora + salarioHora * 0.5m;

            ValorHorasExtras = Math.Round(HorasExtras * valorHorasExtras, 2);
        }

        private void CalcularVencimentosTotais()
        {
            VencimentosTotais = Colaborador.Salario + ValorHorasExtras;
            VencimentosTotais = Math.Round(VencimentosTotais, 2);
        }

        private void CalcularDescontosTotais()
        {
            DescontosTotais = Inss + Irrf;
            DescontosTotais = Math.Round(DescontosTotais, 2);
        }
    }
}
