using Projeto_WindowsForms.Controle;
using Projeto_WindowsForms.Modelo;

namespace Projeto_WindowsForms.Apresentacao
{
    public partial class frmCadastroEmpresa : Form
    {
        public frmCadastroEmpresa()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            txbCnpj.Text.Trim();
            txbRazaoSocial.Text.Trim();
            txbNomeFantasia.Text.Trim();

            List<string> listaDadosEmpresa = new List<string>();
            ControleBase controle = new ControleBase();
            listaDadosEmpresa.Add(txbCnpj.Text);
            listaDadosEmpresa.Add(txbRazaoSocial.Text);
            listaDadosEmpresa.Add(txbNomeFantasia.Text);
            controle.cadastrarEmpresa(listaDadosEmpresa);
            txbCnpj.Clear();
            txbNomeFantasia.Clear();
            txbRazaoSocial.Clear();
            MessageBox.Show(controle.mensagem);
        }
    }
}