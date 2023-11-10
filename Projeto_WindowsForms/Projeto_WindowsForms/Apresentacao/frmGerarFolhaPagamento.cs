using Modelo;

namespace Projeto_WindowsForms.Apresentacao
{
    public partial class frmGerarFolhaPagamento : Form
    {
        private Colaborador colaboradorBusca;
        private FolhaPagamento folhaPagamentoCalculo;
        public static List<Colaborador> listaColaboradorSelecionar;

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
                Ativo = true,
                DataCriacao = DateTime.Now,
                Colaborador = colaboradorBusca,
                HorasExtras = int.Parse(txbHorasExtras.Text)
            };

            folhaPagamento.CalcularSalarioLiquido();

            lblMensagemCalculo.Text = "";

            lblTblUserIRRF.Text = folhaPagamento.Irrf.ToString();
            lblTblUserINSS.Text = folhaPagamento.Inss.ToString();

            lblTblUserTotal.Text = folhaPagamento.ValorLiquido.ToString();
            lblTblUserHorasExtras.Text = folhaPagamento.ValorHorasExtras.ToString();

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

            var folhaPagamentoControle = new FolhaPagamentoControle();
            folhaPagamentoControle.cadastrarFolhaPagamento(folhaPagamentoCalculo);

            if (string.IsNullOrEmpty(folhaPagamentoControle.mensagem))
            {
                MessageBox.Show("Folha de pagamento gerada com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                lblMensagemCalculo.Text = "";

                lblTblUserIRRF.Text = "";
                lblTblUserINSS.Text = "";

                lblTblUserTotal.Text = "";
                lblTblUserHorasExtras.Text = "";

                txbHorasExtras.Text = "";

                folhaPagamentoCalculo = null;
            }
            else
            {
                MessageBox.Show(folhaPagamentoControle.mensagem, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            var idNomeColaborador = txbNomeID.Text.Trim();

            var colaboradorControle = new ColaboradorControle();
            var listaColaborador = new List<Colaborador>();

            // Verificando se foi digitado um ID ou um nome
            if (int.TryParse(idNomeColaborador, out var id))
                listaColaborador.Add(colaboradorControle.buscarColaborador(id));
            else
                listaColaborador = colaboradorControle.buscarColaborador(idNomeColaborador);

            // Caso tenha encontrado apenas um colaborador
            if (listaColaborador != null && listaColaborador.Count == 1)
            {
                var colaborador = listaColaborador[0];

                SelecionarColaborador(colaborador);
            }
            // Caso tenha encontrado mais de um colaborador com o mesmo nome
            else if (listaColaborador != null && listaColaborador.Count > 1)
            {
                listaColaboradorSelecionar = listaColaborador;

                var frmSelecionarColaborador = new frmSelecionarColaborador();
                var resultado = frmSelecionarColaborador.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    SelecionarColaborador(frmSelecionarColaborador.colaboradorSelecionado);
                }
            }
            // Caso não tenha encontrado nenhum colaborador
            else
            {
                lblResultadoCNPJ.Text = "";
                lblResultadoFuncao.Text = "";
                lblResultadoNomeEmpresa.Text = "";
                lblTblUserSalarioBase.Text = "0";
                lblResultadoNomeColaborador.Text = "";
                lblMensagem.Text = colaboradorControle.mensagem;

                colaboradorBusca = null;
            }

            lblTblUserIRRF.Text = "";
            lblTblUserINSS.Text = "";
            lblTblUserTotal.Text = "";
        }

        private void SelecionarColaborador(Colaborador colaborador)
        {
            lblResultadoCNPJ.Text = colaborador.Empresa.Cnpj;
            lblResultadoFuncao.Text = colaborador.Cargo.ToString();
            lblResultadoNomeColaborador.Text = colaborador.NomeCompleto;
            lblResultadoNomeEmpresa.Text = colaborador.Empresa.NomeFantasia;
            lblTblUserSalarioBase.Text = colaborador.Salario.ToString();

            lblResultadoSalarioBase.Text = colaborador.Salario.ToString();

            lblTblUserNome.Text = colaborador.NomeCompleto;
            lblTblUserID.Text = colaborador.Id.ToString();

            lblMensagem.Text = "";

            colaboradorBusca = colaborador;
        }
    }
}