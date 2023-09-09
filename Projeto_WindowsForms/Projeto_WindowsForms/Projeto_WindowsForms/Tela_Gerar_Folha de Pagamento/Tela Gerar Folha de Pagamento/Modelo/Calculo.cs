using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tela_Gerar_Folha_de_Pagamento.Modelo
{
    public class Calculo
    {
        // Atributos
        public double inss;
        public double irpf;
        public double salario;
        public double vencimentosTotais;
        public double descontosTotais;
        public double valorLiquido;

        // Construtor


        // Métodos
        public void CalcularSalarioLiquido(double salarioBase, double horasExtras)
        {
            // Defina aqui as regras para cálculo do INSS e IRPF, por exemplo:
            this.inss = CalcularINSS(salarioBase);
            this.irpf = CalcularIRPF(salarioBase, horasExtras);

            // Calcule os vencimentos totais, descontos totais e valor líquido
            this.vencimentosTotais = salarioBase + horasExtras;
            this.descontosTotais = this.inss + this.irpf;
            this.valorLiquido = vencimentosTotais - descontosTotais;
            this.salario = salarioBase;

            
        }

        private double CalcularINSS(double salarioBase)
        {
            // Implemente aqui o cálculo do INSS
            // Exemplo simplificado:
            this.inss = salarioBase * 0.1; // 10% de desconto fictício
            return inss;
        }

        private double CalcularIRPF(double salarioBase, double horasExtras)
        {
            // Implemente aqui o cálculo do IRPF
            // Exemplo simplificado:
            this.irpf = (salarioBase + horasExtras) * 0.05; // 5% de desconto fictício
            return irpf;
        }
    }
}
