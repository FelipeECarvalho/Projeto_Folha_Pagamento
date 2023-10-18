namespace Projeto_WindowsForms.Controle
{
    public class Calculo
    {
        // Propriedades
        public double Inss { get; private set; }
        public double Irpf { get; private set; }
        public double Salario { get; private set; }
        public double VencimentosTotais { get; private set; }
        public double DescontosTotais { get; private set; }
        public double ValorLiquido { get; private set; }
        public double HorasExtras { get; private set; }
        public double SalarioHora { get; private set; }
        public double ResultadoHorasExtras { get; private set; }


        // Métodos
        public void CalcularSalarioLiquido(double salarioBase, double horasExtras)
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

        private double CalcularINSS(double salarioBase)
        {
            Inss = salarioBase * 0.1; // 10% de desconto fictício
            Inss = Math.Round(Inss, 2);
            return Inss;
        }

        private double CalcularIRPF(double salarioBase, double horasExtras)
        {
            Irpf = (salarioBase + horasExtras) * 0.05; // 5% de desconto fictício
            Irpf = Math.Round(Irpf, 2);
            return Irpf;
        }
        private double CalcularHorasExtras(double salariobase, double horasExtras)
        {
            SalarioHora = salariobase / 30 / 8;
            HorasExtras = SalarioHora + SalarioHora * 0.5;
            ResultadoHorasExtras = HorasExtras * horasExtras;
            ResultadoHorasExtras = Math.Round(ResultadoHorasExtras, 2);
            return ResultadoHorasExtras;
        }
    }
}