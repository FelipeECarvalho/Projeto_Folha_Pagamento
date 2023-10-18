using Projeto_WindowsForms.Controle;
using Projeto_WindowsForms.Modelo;

namespace Projeto_WindowsForms.Apresentacao
{
    public partial class frmGerarFolhaPagamento : Form
    {
        private Colaborador colaboradorBusca;

        public frmGerarFolhaPagamento()
        {
            InitializeComponent();
        }

        private void frmGerarFolhaPagamento_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarColaborador();
        }

        private void imgLupa_Click(object sender, EventArgs e)
        {
            BuscarColaborador();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (colaboradorBusca == null)
            {
                MessageBox.Show("Selecione um colaborador e tente novamente.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var salarioBase = colaboradorBusca.Salario;
            var HorasExtras = int.Parse(cbxHorasExtras.Text);

            var folhaPagamento = new FolhaPagamento
            {
                Colaborador = colaboradorBusca
            };
            // Instancia a Classe calculo e atribui os valores dos calculos para as labels
            var calculo = new Calculo();
            calculo.CalcularSalarioLiquido(salarioBase, HorasExtras);

            lblHorasExtrasVencimentos.Text = calculo.ResultadoHorasExtras.ToString();
            lblIRPFDesconto.Text = calculo.Irpf.ToString();
            lblINSSDesconto.Text = calculo.Inss.ToString();
            lblResultadoVencimentosTotais.Text = calculo.VencimentosTotais.ToString();
            lblResultadoDescontosTotais.Text = calculo.DescontosTotais.ToString();
            lblResultadoValorLiquido.Text = calculo.ValorLiquido.ToString();
            lblMensagemCalculo.Text = "";
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tblDadosFolhaPagamento_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            ColorirCabecalho(e);
        }

        private void tblResultadoFolhaPagamento_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            ColorirCabecalho(e);
        }

        private void btnGerarFolha_Click(object sender, EventArgs e)
        {

        }

        private void ColorirCabecalho(TableLayoutCellPaintEventArgs e)
        {
            if (e.Row == 0)
            {
                using SolidBrush brush = new(Color.FromArgb(50, 130, 184));
                e.Graphics.FillRectangle(brush, e.CellBounds);
            }
        }

        private void BuscarColaborador()
        {
            var idNomeColaborador = txbNomeID.Text.ToString().Trim();

            var controle = new ControleBase();
            var colaborador = controle.buscarColaborador(idNomeColaborador);

            if (colaborador != null)
            {
                lblResultadoCNPJ.Text = colaborador.Empresa.Cnpj;
                lblResultadoFuncao.Text = colaborador.Cargo.ToString();
                lblResultadoNomeColaborador.Text = colaborador.NomeCompleto;
                lblResultadoNomeEmpresa.Text = colaborador.Empresa.NomeFantasia;
                lblSalarioBaseVencimentos.Text = colaborador.Salario.ToString();

                colaboradorBusca = colaborador;
            }
            else
            {
                lblResultadoCNPJ.Text = "";
                lblResultadoFuncao.Text = "";
                lblResultadoNomeEmpresa.Text = "";
                lblSalarioBaseVencimentos.Text = "0";
                lblMensagem.Text = controle.mensagem;
                lblResultadoNomeColaborador.Text = "";

                colaboradorBusca = null;
            }

            lblIRPFDesconto.Text = "";
            lblINSSDesconto.Text = "";
            lblResultadoValorLiquido.Text = "";
            lblResultadoDescontosTotais.Text = "";
            lblResultadoVencimentosTotais.Text = "";
        }
    }
}