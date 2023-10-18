using Projeto_WindowsForms.Controle;
using Projeto_WindowsForms.Modelo;

namespace Projeto_WindowsForms.Apresentacao
{
    public partial class frmGerarFolhaPagamento : Form
    {
        private List<Colaborador> listaColaboradores; // Uma lista fict�cia de colaboradores

        public frmGerarFolhaPagamento() // Construtor
        {
            InitializeComponent();
            listaColaboradores = new List<Colaborador>
            {
                //new Colaborador(0, "", "", "", "", ""),
                //new Colaborador(1, "Jos�", "Gerente", "Pardal & Cia Ltda.", "3000", DateTime.Now.ToString()),
                //new Colaborador(2, "Maria", "Analista", "Pardal & Cia Ltda.", "4000", DateTime.Now.ToString()),
                //new Colaborador(3, "Pedro", "Desenvolvedor", "�guia Incorpora��es Ltda.", "3200", DateTime.Now.ToString()),
                //new Colaborador(4, "Ana", "Designer", "�guia Incorpora��es Ltda.", "2200", DateTime.Now.ToString()),
                //new Colaborador(5, "Carlos", "Analista de Vendas", "Colibri Engenharia S.A.", "3500", DateTime.Now.ToString()),
                //new Colaborador(6, "Isabel", "Engenheiro de Software", "Colibri Engenharia S.A.", "4400", DateTime.Now.ToString()),
                //new Colaborador(7, "Paulo", "Analista de Marketing", "Falc�o Com�rcio de Tecnologia Ltda.", "2500", DateTime.Now.ToString()),
                //new Colaborador(8, "Let�cia","Contadora", "Falc�o Com�rcio de Tecnologia Ltda.", "2400",  DateTime.Now.ToString()),
                //new Colaborador(9, "Ricardo", "Analista Financeiro", "Terra Elementar Consultoria Ambiental Ltda.", "4700", DateTime.Now.ToString()),
                //new Colaborador(10, "Juliana", "Engenheiro de Produ��o", "Terra Elementar Consultoria Ambiental Ltda.", "5000", DateTime.Now.ToString())
            };
        }

        // M�todos
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Cria uma lista com o conte�do o TextBox 'Nome ou ID'
            List<string> nomesColaboradores = new()
            {
                txbNomeID.Text
            };

            // Instancia a Classe Controle que ir� validar se o valor inserido corresponde com o nome ou o ID da lista de Colaboradores
            ControleBase controle = new();
            controle.ValidarColaboradores(this.listaColaboradores, nomesColaboradores);

            // Pega a mensagem da classe controle ap�s a valida��o do valor inserido
            lblMensagem.Text = controle.mensagem;
            int i = controle.i;

            // Pega o �ndice correspondido e atribui �s labels
            if (i != -1 && i != 0)
            {
                lblResultadoNomeColaborador.Text = listaColaboradores[i].Nome;
                lblSalarioBaseVencimentos.Text = listaColaboradores[i].Salario.ToString();
                lblHorasExtrasVencimentos.Text = "0";
                lblIRPFDesconto.Text = "";
                lblINSSDesconto.Text = "";
                lblResultadoVencimentosTotais.Text = "";
                lblResultadoDescontosTotais.Text = "";
                lblResultadoValorLiquido.Text = "";

            }
            else
            {
                lblMensagem.Text = "Colaborador n�o encontrado!";
                lblResultadoNomeColaborador.Text = "";
                lblResultadoFuncao.Text = "";
                lblResultadoNomeEmpresa.Text = "";
                lblResultadoCNPJ.Text = "";
                lblSalarioBaseVencimentos.Text = "0";
                lblHorasExtrasVencimentos.Text = "0";
                lblIRPFDesconto.Text = "";
                lblINSSDesconto.Text = "";
                lblResultadoVencimentosTotais.Text = "";
                lblResultadoDescontosTotais.Text = "";
                lblResultadoValorLiquido.Text = "";
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            // Instancia a Classe calculo e atribui os valores dos calculos para as labels
            Calculo calculo = new Calculo();
            string salarioBase = lblSalarioBaseVencimentos.Text;
            string HorasExtras = cbxHorasExtras.Text;

            calculo.CalcularSalarioLiquido(Convert.ToDouble(salarioBase), Convert.ToDouble(HorasExtras));

            lblHorasExtrasVencimentos.Text = calculo.ResultadoHorasExtras.ToString();
            lblIRPFDesconto.Text = calculo.Irpf.ToString();
            lblINSSDesconto.Text = calculo.Inss.ToString();
            lblResultadoVencimentosTotais.Text = calculo.VencimentosTotais.ToString();
            lblResultadoDescontosTotais.Text = calculo.DescontosTotais.ToString();
            lblResultadoValorLiquido.Text = calculo.ValorLiquido.ToString();

            lblMensagemCalculo.Text = "";

        }

        private void imgLupa_Click(object sender, EventArgs e)
        {
            // Cria uma lista com o conte�do o TextBox 'Nome ou ID'
            List<string> nomesColaboradores = new()
            {
                txbNomeID.Text
            };

            // Instancia a Classe Controle que ir� validar se o valor inserido corresponde com o nome ou o ID da lista de Colaboradores
            ControleBase controle = new();
            controle.ValidarColaboradores(this.listaColaboradores, nomesColaboradores);

            // Pega a mensagem da classe controle ap�s a valida��o do valor inserido
            lblMensagem.Text = controle.mensagem;
            int i = controle.i;

            // Pega o �ndice correspondido e atribui �s labels
            if (i != -1 && i != 0)
            {
                lblResultadoNomeColaborador.Text = listaColaboradores[i].Nome;
                //lblResultadoFuncao.Text = listaColaboradores[i].Funcao;
                //lblResultadoNomeEmpresa.Text = listaColaboradores[i].NomeEmpresa;
                //lblResultadoCNPJ.Text = listaColaboradores[i].CNPJEmpresa;
                lblSalarioBaseVencimentos.Text = listaColaboradores[i].Salario.ToString();
                lblHorasExtrasVencimentos.Text = "0";
                lblIRPFDesconto.Text = "";
                lblINSSDesconto.Text = "";
                lblResultadoVencimentosTotais.Text = "";
                lblResultadoDescontosTotais.Text = "";
                lblResultadoValorLiquido.Text = "";

            }
            else
            {
                lblMensagem.Text = "Colaborador n�o encontrado!";
                lblResultadoNomeColaborador.Text = "";
                lblResultadoFuncao.Text = "";
                lblResultadoNomeEmpresa.Text = "";
                lblResultadoCNPJ.Text = "";
                lblSalarioBaseVencimentos.Text = "0";
                lblHorasExtrasVencimentos.Text = "0";
                lblIRPFDesconto.Text = "";
                lblINSSDesconto.Text = "";
                lblResultadoVencimentosTotais.Text = "";
                lblResultadoDescontosTotais.Text = "";
                lblResultadoValorLiquido.Text = "";
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

        private void frmGerarFolhaPagamento_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxHorasExtras_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedOption = cbxHorasExtras.SelectedItem.ToString();
        }

        private void tblDadosFolhaPagamento_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            if (e.Row == 0)
            {
                using SolidBrush brush = new(Color.FromArgb(50, 130, 184));
                e.Graphics.FillRectangle(brush, e.CellBounds);
            }
        }

        private void tblResultadoFolhaPagamento_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            if (e.Row == 0)
            {
                using SolidBrush brush = new(Color.FromArgb(50, 130, 184));
                e.Graphics.FillRectangle(brush, e.CellBounds);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}