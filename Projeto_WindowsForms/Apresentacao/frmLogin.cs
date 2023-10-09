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
            else
            {
                MessageBox.Show("Usuario ou senha incorreto", mensagemRotuloBox);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}