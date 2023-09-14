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
            if (txbUsuario.Text == "Luiz" && txbSenha.Text == "1234")
            {
                frmMenu frmM = new frmMenu();
                this.Visible = false;
                frmM.ShowDialog();
                this.Visible = true;
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