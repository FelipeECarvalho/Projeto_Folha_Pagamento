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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txbUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void lblSenha_Click(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnAcessar;
        }
    }
}