using Servico;

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
            try
            {
                var acessoServico = new AcessoServico();
                var acesso = acessoServico.BuscarAcesso(txbUsuario.Text, txbSenha.Text);

                this.Hide();

                // Setando o colaborador logado
                Program.colaboradorLogado = acesso.Colaborador;

                // Configuração para fechar esse formulário e abrir o menu
                frmMenu frmMenu = new();
                frmMenu.Closed += (s, args) => this.Close();
                frmMenu.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnAcessar;
        }
    }
}