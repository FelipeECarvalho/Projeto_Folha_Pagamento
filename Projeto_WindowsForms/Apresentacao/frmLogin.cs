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
                Hide();

                frmMenu frmM = new();
                frmM.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuario ou senha invalidos!!!");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}