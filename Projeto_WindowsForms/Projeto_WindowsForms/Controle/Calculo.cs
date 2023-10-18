namespace Projeto_WindowsForms.Controle
{
    public class Calculo
    {
        // Propriedades
        public decimal Inss { get; private set; }
        public decimal Irpf { get; private set; }
        public decimal Salario { get; private set; }
        public decimal VencimentosTotais { get; private set; }
        public decimal DescontosTotais { get; private set; }
        public decimal ValorLiquido { get; private set; }
        public decimal HorasExtras { get; private set; }
        public decimal SalarioHora { get; private set; }
        public decimal ResultadoHorasExtras { get; private set; }


        // Métodos
        public void CalcularSalarioLiquido(decimal salarioBase, int horasExtras)
        {
            ResultadoHorasExtras = CalcularHorasExtras(salarioBase, horasExtras);
            Inss = CalcularINSS(salarioBase);
            Irpf = CalcularIRPF(salarioBase, ResultadoHorasExtras);

            VencimentosTotais = salarioBase + ResultadoHorasExtras;
            VencimentosTotais = Math.Round(VencimentosTotais, 2);
            DescontosTotais = Inss + Irpf;
            DescontosTotais = Math.Round(DescontosTotais, 2);
            ValorLiquido = VencimentosTotais - DescontosTotais;
            ValorLiquido = Math.Round(ValorLiquido, 2);
            Salario = salarioBase;
        }

        private decimal CalcularINSS(decimal salarioBase)
        {
            Inss = salarioBase * 0.1m; // 10% de desconto fictício
            Inss = Math.Round(Inss, 2);
            return Inss;
        }

        private decimal CalcularIRPF(decimal salarioBase, decimal horasExtras)
        {
            Irpf = (salarioBase + horasExtras) * 0.05m; // 5% de desconto fictício
            Irpf = Math.Round(Irpf, 2);
            return Irpf;
        }
        private decimal CalcularHorasExtras(decimal salariobase, decimal horasExtras)
        {
            SalarioHora = salariobase / 30 / 8;
            HorasExtras = SalarioHora + SalarioHora * 0.5m;
            ResultadoHorasExtras = HorasExtras * horasExtras;
            ResultadoHorasExtras = Math.Round(ResultadoHorasExtras, 2);
            return ResultadoHorasExtras;
        }
    }
}