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


        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Empresa empresa = new()
            {
                Ativo = true,
                Cnpj = txbCnpj.Text.Trim(),
                NomeFantasia = txbNomeFantasia.Text.Trim(),
                RazaoSocial = txbRazaoSocial.Text.Trim()
            };

            var empresaControle = new EmpresaControle();
            empresaControle.cadastrarEmpresa(empresa);

            if (string.IsNullOrEmpty(empresaControle.mensagem))
            {
                MessageBox.Show("Empresa cadastrada com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txbCnpj.Clear();
                txbNomeFantasia.Clear();
                txbRazaoSocial.Clear();
            }
            else
            {
                MessageBox.Show(empresaControle.mensagem, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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