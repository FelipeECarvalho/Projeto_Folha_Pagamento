using Projeto_WindowsForms.Controle;

namespace Projeto_WindowsForms.Apresentacao
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            var acessoControle = new AcessoControle();
            var acesso = acessoControle.buscarAcesso(txbUsuario.Text, txbSenha.Text);

            if (string.IsNullOrEmpty(acessoControle.mensagem))
            {
                this.Hide();

                Program.colaboradorLogado = acesso.Colaborador;

                frmMenu frmMenu = new();
                frmMenu.Closed += (s, args) => this.Close();
                frmMenu.Show();
            } 
            else
            {
                MessageBox.Show(acessoControle.mensagem, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnAcessar;
        }
    }
}