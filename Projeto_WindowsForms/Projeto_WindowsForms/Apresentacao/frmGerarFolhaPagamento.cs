using Projeto_WindowsForms.Controle;
using Projeto_WindowsForms.Modelo;

namespace Projeto_WindowsForms.Apresentacao
{
    public partial class frmGerarFolhaPagamento : Form
    {
        private Colaborador colaboradorBusca;
        private FolhaPagamento folhaPagamentoCalculo;

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

            var folhaPagamento = new FolhaPagamento
            {
                Colaborador = colaboradorBusca,
                HorasExtras = int.Parse(cbxHorasExtras.Text)
            };

            folhaPagamento.CalcularSalarioLiquido();

            lblMensagemCalculo.Text = "";

            lblIRPFDesconto.Text = folhaPagamento.Irrf.ToString();
            lblINSSDesconto.Text = folhaPagamento.Inss.ToString();

            lblRefIrrf.Text = folhaPagamento.AliquotaIrrf.ToString();
            lblRefInss.Text = folhaPagamento.AliquotaInss.ToString();

            lblResultadoValorLiquido.Text = folhaPagamento.ValorLiquido.ToString();
            lblResultadoDescontosTotais.Text = folhaPagamento.DescontosTotais.ToString();
            lblResultadoVencimentosTotais.Text = folhaPagamento.VencimentosTotais.ToString();
            lblHorasExtrasVencimentos.Text = folhaPagamento.ValorHorasExtras.ToString();

            folhaPagamentoCalculo = folhaPagamento;
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
            if (colaboradorBusca == null)
            {
                MessageBox.Show("Selecione um colaborador e tente novamente.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (folhaPagamentoCalculo == null)
            {
                MessageBox.Show("Faça o cálculo da folha de pagamento primeiro e tente novamente.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var controle = new ControleBase();
            controle.cadastrarFolhaPagamento(folhaPagamentoCalculo);

            if (string.IsNullOrEmpty(controle.mensagem))
            {
                MessageBox.Show("Folha de pagamento gerada com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                lblMensagemCalculo.Text = "";

                lblIRPFDesconto.Text = "";
                lblINSSDesconto.Text = "";

                lblRefIrrf.Text = "";
                lblRefInss.Text = "";

                lblResultadoValorLiquido.Text = "";
                lblResultadoDescontosTotais.Text = "";
                lblResultadoVencimentosTotais.Text = "";
                lblHorasExtrasVencimentos.Text = "";

                folhaPagamentoCalculo = null;
            } 
            else
            {
                MessageBox.Show(controle.mensagem, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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