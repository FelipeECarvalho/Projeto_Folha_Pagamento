namespace ProjetoPim
{
    public partial class Form1 : Form
    {
        public Form1()
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