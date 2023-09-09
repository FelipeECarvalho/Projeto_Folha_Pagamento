using Tela_Gerar_Folha_de_Pagamento.Modelo;

namespace Tela_Gerar_Folha_de_Pagamento
{
    public partial class frmGerarFolha : Form
    {
        private List<Colaborador> listaColaboradores; // Uma lista fictícia de colaboradores

        public frmGerarFolha() // Construtor
        {
            InitializeComponent();
            listaColaboradores = new List<Colaborador>
            {
                new Colaborador("", 0, "", "", "", 0),
                new Colaborador("José", 1, "Pardal & Cia Ltda.", "12345678901234", "Gerente", 5000),
                new Colaborador("Maria", 2, "Pardal & Cia Ltda.", "12345678901234", "Analista", 3500),
                new Colaborador("Pedro", 3, "Águia Incorporações Ltda.", "98765432109876", "Desenvolvedor", 4500),
                new Colaborador("Ana", 4, "Águia Incorporações Ltda.", "98765432109876", "Designer", 4000),
                new Colaborador("Carlos", 5, "Colibri Engenharia S.A.", "56789012345678", "Analista de Vendas", 3800),
                new Colaborador("Isabel", 6, "Colibri Engenharia S.A.", "56789012345678", "Engenheiro de Software", 5500),
                new Colaborador("Paulo", 7, "Falcão Comércio de Tecnologia Ltda.", "13579246802468", "Analista de Marketing", 4200),
                new Colaborador("Letícia", 8, "Falcão Comércio de Tecnologia Ltda.", "13579246802468", "Contadora", 4700),
                new Colaborador("Ricardo", 9, "Terra Elementar Consultoria Ambiental Ltda.", "98765432101234", "Analista Financeiro", 4800),
                new Colaborador("Juliana", 10, "Terra Elementar Consultoria Ambiental Ltda.", "98765432101234", "Engenheiro de Produção", 5200)
        };


        }

        // Métodos
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            List<string> nomesColaboradores = new List<string>(); // Cria uma lista com o conteúdo o TextBox 'Nome ou ID'
            {
                nomesColaboradores.Add(txbNomeID.Text);

                // Instancia a Classe Controle que irá validar se o valor inserido corresponde com o nome ou o ID da lista de Colaboradores
                Controle controle = new Controle();
                controle.ValidarColaboradores(this.listaColaboradores, nomesColaboradores);

                // Pega a mensagem da classe controle após a validação do valor inserido
                lblMensagem.Text = controle.mensagem;
                int i = controle.i;

                // Pega o índice correspondido e atribui às labels
                if (i != -1 && i != 0)
                {
                    lblResultadoNomeColaborador.Text = listaColaboradores[i].Nome;
                    lblResultadoFuncao.Text = listaColaboradores[i].Funcao;
                    lblResultadoNomeEmpresa.Text = listaColaboradores[i].NomeEmpresa;
                    lblResultadoCNPJ.Text = listaColaboradores[i].CNPJEmpresa;
                    lblSalarioBaseVencimentos.Text = listaColaboradores[i].Salario.ToString();
                    lblIRPFDesconto.Text = "";
                    lblINSSDesconto.Text = "";
                    lblResultadoVencimentosTotais.Text = "";
                    lblResultadoDescontosTotais.Text = "";
                    lblResultadoValorLiquido.Text = "";

                }
                else
                {
                    lblMensagem.Text = "Colaborador não encontrado!";
                    lblResultadoNomeColaborador.Text = "";
                    lblResultadoFuncao.Text = "";
                    lblResultadoNomeEmpresa.Text = "";
                    lblResultadoCNPJ.Text = "";
                    lblSalarioBaseVencimentos.Text = "0";
                    lblIRPFDesconto.Text = "";
                    lblINSSDesconto.Text = "";
                    lblResultadoVencimentosTotais.Text = "";
                    lblResultadoDescontosTotais.Text = "";
                    lblResultadoValorLiquido.Text = "";
                }
            }

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string horasExtrasText = txbHorasExtrasVencimentos.Text; // Pega o valor do TextBox Horas Extras

            // Valide se o valor inserido em txbHorasExtrasVencimentos é um número
            // Instancia a Classe Controle para fazer a valor inserido corresponde com um número válido
            Controle controle = new Controle();
            controle.ValidarCalculos(horasExtrasText);

            // Verifica se a mensagem resultante da validação de cálculos é vazio
            if (string.IsNullOrEmpty(controle.mensagem))
            {
                // Se a mensagem estiver vazia, significa que a validação foi bem-sucedido
                // Atualize as labels com os valores calculados
                // Instancia a Classe calculo e atribui os valores dos calculos para as labels
                Calculo calculo = new Calculo();
                string salarioBase = lblSalarioBaseVencimentos.Text;
                string txbHorasExtras = txbHorasExtrasVencimentos.Text;

                calculo.CalcularSalarioLiquido(Convert.ToDouble(salarioBase), Convert.ToDouble(txbHorasExtras));

                lblIRPFDesconto.Text = calculo.irpf.ToString();
                lblINSSDesconto.Text = calculo.inss.ToString();
                lblResultadoVencimentosTotais.Text = calculo.vencimentosTotais.ToString();
                lblResultadoDescontosTotais.Text = calculo.descontosTotais.ToString();
                lblResultadoValorLiquido.Text = calculo.valorLiquido.ToString();

                lblMensagemCalculo.Text = "";
            }
            else
            {
                lblMensagemCalculo.Text = "Número inserido é inválido! \n Se for vazio insira 0";
                lblIRPFDesconto.Text = "";
                lblINSSDesconto.Text = "";
                lblResultadoVencimentosTotais.Text = "";
                lblResultadoDescontosTotais.Text = "";
                lblResultadoValorLiquido.Text = "";
            }



        }

        private void imgLupa_Click(object sender, EventArgs e)
        {
            List<string> nomesColaboradores = new List<string>(); // Cria uma lista com o conteúdo o TextBox 'Nome ou ID'
            {
                nomesColaboradores.Add(txbNomeID.Text);

                // Instancia a Classe Controle que irá validar se o valor inserido corresponde com o nome ou o ID da lista de Colaboradores
                Controle controle = new Controle();
                controle.ValidarColaboradores(this.listaColaboradores, nomesColaboradores);

                // Pega a mensagem da classe controle após a validação do valor inserido
                lblMensagem.Text = controle.mensagem;
                int i = controle.i;

                // Pega o índice correspondido e atribui às labels
                if (i != -1 && i != 0)
                {
                    lblResultadoNomeColaborador.Text = listaColaboradores[i].Nome;
                    lblResultadoFuncao.Text = listaColaboradores[i].Funcao;
                    lblResultadoNomeEmpresa.Text = listaColaboradores[i].NomeEmpresa;
                    lblResultadoCNPJ.Text = listaColaboradores[i].CNPJEmpresa;
                    lblSalarioBaseVencimentos.Text = listaColaboradores[i].Salario.ToString();
                    lblIRPFDesconto.Text = "";
                    lblINSSDesconto.Text = "";
                    lblResultadoVencimentosTotais.Text = "";
                    lblResultadoDescontosTotais.Text = "";
                    lblResultadoValorLiquido.Text = "";

                }
                else
                {
                    lblMensagem.Text = "Colaborador não encontrado!";
                    lblResultadoNomeColaborador.Text = "";
                    lblResultadoFuncao.Text = "";
                    lblResultadoNomeEmpresa.Text = "";
                    lblResultadoCNPJ.Text = "";
                    lblSalarioBaseVencimentos.Text = "0";
                    lblIRPFDesconto.Text = "";
                    lblINSSDesconto.Text = "";
                    lblResultadoVencimentosTotais.Text = "";
                    lblResultadoDescontosTotais.Text = "";
                    lblResultadoValorLiquido.Text = "";
                }
            }
        }

        private void imgLupa_MouseEnter(object sender, EventArgs e)
        {
            imgLupa.Width = (int)(imgLupa.Width * 1.2);
            imgLupa.Height = (int)(imgLupa.Height * 1.2);
        }

        private void imgLupa_MouseLeave(object sender, EventArgs e)
        {
            imgLupa.Width = (int)(imgLupa.Width / 1.2);
            imgLupa.Height = (int)(imgLupa.Height / 1.2);
        }
    }
}