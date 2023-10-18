using System.Windows.Forms;

namespace Projeto_WindowsForms.Apresentacao
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnColaborador_Click(object sender, EventArgs e)
        {
            var frmCadastroColaborador = new frmCadastroColaborador();
            OpenForm(frmCadastroColaborador);
        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {

            var frmCadastroEmpresa = new frmCadastroEmpresa();
            OpenForm(frmCadastroEmpresa);
        }

        private void btnFolha_Click(object sender, EventArgs e)
        {
            var frmGerarFolhaPagamento = new frmGerarFolhaPagamento();
            OpenForm(frmGerarFolhaPagamento);
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            var frmGerarRelatorio = new frmGerarRelatorio();
            OpenForm(frmGerarRelatorio);
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void OpenForm(Form form)
        {
            this.Hide();

            form.Closed += (s, args) => this.Show();
            form.Show();
        }

        private void lblSair_Click(object sender, EventArgs e)
        {
            var frmLogin = new frmLogin();
            this.Hide();

            frmLogin.Closed += (s, args) => this.Close();
            frmLogin.Show();
        }
    }
}
