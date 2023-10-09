namespace Projeto_WindowsForms.Modelo
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
            this.ResultadoHorasExtras = CalcularHorasExtras(salarioBase, horasExtras);
            this.Inss = CalcularINSS(salarioBase);
            this.Irpf = CalcularIRPF(salarioBase, this.ResultadoHorasExtras);

            this.VencimentosTotais = salarioBase + this.ResultadoHorasExtras;
            this.VencimentosTotais = Math.Round(VencimentosTotais, 2);
            this.DescontosTotais = this.Inss + this.Irpf;
            this.DescontosTotais = Math.Round(DescontosTotais, 2);
            this.ValorLiquido = VencimentosTotais - DescontosTotais;
            this.ValorLiquido = Math.Round(ValorLiquido, 2);
            this.Salario = salarioBase;
        }

        private double CalcularINSS(double salarioBase)
        {
            this.Inss = salarioBase * 0.1; // 10% de desconto fictício
            this.Inss = Math.Round(Inss, 2);
            return Inss;
        }

        private double CalcularIRPF(double salarioBase, double horasExtras)
        {
            this.Irpf = (salarioBase + horasExtras) * 0.05; // 5% de desconto fictício
            this.Irpf = Math.Round(Irpf, 2);
            return Irpf;
        }
        private double CalcularHorasExtras(double salariobase,double horasExtras)
        {
            this.SalarioHora = salariobase / 30 / 8;
            this.HorasExtras = SalarioHora + (SalarioHora * 0.5);
            this.ResultadoHorasExtras = HorasExtras * horasExtras;
            this.ResultadoHorasExtras = Math.Round(ResultadoHorasExtras, 2);
            return this.ResultadoHorasExtras;
        }
    }
}