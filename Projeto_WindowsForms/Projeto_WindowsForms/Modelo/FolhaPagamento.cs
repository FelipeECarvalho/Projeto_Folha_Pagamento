namespace Projeto_WindowsForms.Modelo
{
    public class FolhaPagamento
    {
        public decimal Inss { get; set; }
        public decimal Irrf { get; set; }
        public int HorasExtras { get; set; }
        public decimal ValorTotalHorasExtras { get; set; }
        public decimal ValorLiquido { get; set; }
        public decimal DescontosTotais { get; set; }
        public decimal VencimentosTotais { get; set; }
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
            decimal aliquota;
            if (salario <= 1320) 
                aliquota = 7.5m;
            else if (salario <=  2571) 
                aliquota = 9.0m;
            else if (salario <= 3865) 
                aliquota = 12m;
            else
                aliquota = 14m;

            Inss = Colaborador.Salario * (aliquota / 100);
            Inss = Math.Round(Inss, 2);
        }

        private void CalcularIRPF()
        {
            var salario = Colaborador.Salario;

            // Calcula a alíquota do IRRF
            decimal aliquota;

            if (salario <= 1903)
                aliquota = 0.01m;
            else if (salario <= 2826)
                aliquota = 7.5m;
            else if (salario <= 3751)
                aliquota = 15m;
            else if (salario <= 4664)
                aliquota = 22.5m;
            else
                aliquota = 27.5m;

            Irrf = (Colaborador.Salario * (aliquota / 100)); // 5% de desconto fictício
            Irrf = Math.Round(Irrf, 2);
        }

        private void CalcularHorasExtras()
        {
            var salarioHora = Colaborador.Salario / 30 / 8;
            var valorHorasExtras = salarioHora + (salarioHora * 0.5m);

            ValorTotalHorasExtras = Math.Round(HorasExtras * valorHorasExtras, 2);
        }

        private void CalcularVencimentosTotais()
        {
            VencimentosTotais = Colaborador.Salario + ValorTotalHorasExtras;
            VencimentosTotais = Math.Round(VencimentosTotais, 2);
        }

        private void CalcularDescontosTotais()
        {
            DescontosTotais = Inss + Irrf;
            DescontosTotais = Math.Round(DescontosTotais, 2);
        }
    }
}
