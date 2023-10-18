using Projeto_WindowsForms.Controle;

namespace Projeto_WindowsForms.Apresentacao
{
    public partial class frmGerarRelatorio : Form
    {
        public frmGerarRelatorio()
        {
            InitializeComponent();
        }

        private void frmGerarRelatorio_Load(object sender, EventArgs e)
        {
            var controle = new ControleBase();
            var listaColaborador = controle.listarColaborador();

            foreach (var colaborador in listaColaborador)
            {
                dgvRelatorio.Rows.Add(colaborador.Id, colaborador.DataAdmissao.ToShortDateString(), colaborador.NomeCompleto, colaborador.Sexo, colaborador.Salario.ToString("c"), colaborador.Cargo, colaborador.Empresa.NomeFantasia);
            }
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            SetButtonActive(btnRelatorio);
        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            SetButtonActive(btnEmpresa);
        }

        private void btnFolhaPagamento_Click(object sender, EventArgs e)
        {
            SetButtonActive(btnFolhaPagamento);
        }

        private void SetButtonActive(Button btn)
        {
            var buttonList = new List<Button>
            {
                btnEmpresa, btnFolhaPagamento, btnRelatorio
            };

            foreach (var button in buttonList)
            {
                button.BackColor = SystemColors.Window;
                button.ForeColor = SystemColors.ControlText;
            }

            btn.BackColor = Color.FromArgb(50, 130, 184);
            btn.ForeColor = SystemColors.Window;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void imgLupa_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
