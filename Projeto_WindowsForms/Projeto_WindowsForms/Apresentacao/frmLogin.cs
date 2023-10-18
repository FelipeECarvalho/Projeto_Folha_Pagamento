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
            if (txbUsuario.Text == "admin" && txbSenha.Text == "admin")
            {
                this.Hide();
                frmMenu frmMenu = new();
                frmMenu.Closed += (s, args) => this.Close();
                frmMenu.Show();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnAcessar;
        }
    }
}