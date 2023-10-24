using Projeto_WindowsForms.Modelo;
using Projeto_WindowsForms.Modelo.Enum;
using System.Windows.Forms;

namespace Projeto_WindowsForms.Apresentacao
{
    public partial class frmMenu : Form
    {
        readonly Colaborador colaboradorLogado;

        public frmMenu()
        {
            colaboradorLogado = Program.colaboradorLogado;
            InitializeComponent();
        }

        private void btnColaborador_Click(object sender, EventArgs e)
        {
            if (colaboradorLogado.Cargo.Equals(TipoCargo.AnalistaDP))
            {
                MessageBox.Show("Você não tem permissão para acessar essa área", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var frmCadastroColaborador = new frmCadastroColaborador();
            OpenForm(frmCadastroColaborador);
        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            if (colaboradorLogado.Cargo.Equals(TipoCargo.AnalistaDP) || colaboradorLogado.Cargo.Equals(TipoCargo.AnalistaRH))
            {
                MessageBox.Show("Você não tem permissão para acessar essa área", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            var frmCadastroEmpresa = new frmCadastroEmpresa();
            OpenForm(frmCadastroEmpresa);
        }

        private void btnFolha_Click(object sender, EventArgs e)
        {
            if (colaboradorLogado.Cargo.Equals(TipoCargo.AnalistaRH))
            {
                MessageBox.Show("Você não tem permissão para acessar essa área", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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

        private void frmMenu_Load(object sender, EventArgs e)
        {
            lblMenu.Text = $"Olá, {Program.colaboradorLogado.NomeCompleto}! Seja Bem-vindo.";
        }
    }
}
