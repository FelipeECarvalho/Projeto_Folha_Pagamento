namespace Projeto_WindowsForms.Apresentacao
{
    public partial class frmLogin : Form
    {
        public String mensagemRotuloBox = "Atenção!";
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            if (txbUsuario.Text == "admin" && txbSenha.Text == "admin")
            {
                frmMenu frmMenu = new frmMenu();
                frmMenu.ShowDialog();
                this.Hide();
            }
            //if (txbUsuario.Text == "")
            //    MessageBox.Show("Digite o usuario");
            else
            {
                MessageBox.Show("Usuario ou senha incorreto", mensagemRotuloBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
    }
}