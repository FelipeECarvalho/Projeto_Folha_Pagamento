using Projeto_WindowsForms.Controle;

namespace Projeto_WindowsForms.Apresentacao
{
    public partial class frmCadastroEmpresa : Form
    {
        public frmCadastroEmpresa()
        {
            InitializeComponent();
        }


        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            List<string> listaDadosEmpresa = new()
            {
                txbCnpj.Text.Trim(),
                txbRazaoSocial.Text.Trim(),
                txbNomeFantasia.Text.Trim()
            };

            var controle = new ControleBase();
            controle.cadastrarEmpresa(listaDadosEmpresa);

            txbCnpj.Clear();
            txbNomeFantasia.Clear();
            txbRazaoSocial.Clear();

            MessageBox.Show(controle.mensagem);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCadastroEmpresa_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnCadastrar;
        }
    }
}