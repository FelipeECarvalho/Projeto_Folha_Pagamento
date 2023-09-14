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

        // Métodos
        public void CalcularSalarioLiquido(double salarioBase, double horasExtras)
        {
            this.Inss = CalcularINSS(salarioBase);
            this.Irpf = CalcularIRPF(salarioBase, horasExtras);

            this.VencimentosTotais = salarioBase + horasExtras;
            this.DescontosTotais = this.Inss + this.Irpf;
            this.ValorLiquido = VencimentosTotais - DescontosTotais;
            this.Salario = salarioBase;
        }

        private double CalcularINSS(double salarioBase)
        {
            this.Inss = salarioBase * 0.1; // 10% de desconto fictício
            return Inss;
        }

        private double CalcularIRPF(double salarioBase, double horasExtras)
        {
            this.Irpf = (salarioBase + horasExtras) * 0.05; // 5% de desconto fictício
            return Irpf;
        }
    }
}