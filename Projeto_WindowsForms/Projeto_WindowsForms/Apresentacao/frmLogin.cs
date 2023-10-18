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
            var controleBase = new ControleBase();
            var acesso = controleBase.buscarAcesso(txbUsuario.Text, txbSenha.Text);

            if (string.IsNullOrEmpty(controleBase.mensagem))
            {
                this.Hide();

                Program.colaboradorLogado = acesso.Colaborador;

                frmMenu frmMenu = new();
                frmMenu.Closed += (s, args) => this.Close();
                frmMenu.Show();
            } 
            else
            {
                MessageBox.Show(controleBase.mensagem, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnAcessar;
        }
    }
}