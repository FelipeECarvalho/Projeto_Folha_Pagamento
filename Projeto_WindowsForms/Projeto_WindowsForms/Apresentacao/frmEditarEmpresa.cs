using Modelo;
using Servico;

namespace Projeto_WindowsForms.Apresentacao
{
    public partial class frmEditarEmpresa : Form
    {
        private Empresa empresaSelecionada;

        public frmEditarEmpresa()
        {
            InitializeComponent();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Empresa empresa = new()
            {
                Id = empresaSelecionada.Id,
                Cnpj = txbCnpj.Text.Trim(),
                NomeFantasia = txbNomeFantasia.Text.Trim(),
                RazaoSocial = txbRazaoSocial.Text.Trim()
            };

            try
            {
                var empresaServico = new EmpresaServico();
                empresaServico.EditarEmpresa(empresa);

                DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEditarEmpresa_Load(object sender, EventArgs e)
        {
            try
            {
                var empresaServico = new EmpresaServico();
                empresaSelecionada = empresaServico.BuscarEmpresa(frmGerarRelatorio.idEmpresa);

                if (empresaSelecionada == null)
                {
                    this.DialogResult = DialogResult.Abort;
                    this.Close();
                }
                else
                {
                    txbCnpj.Text = empresaSelecionada.Cnpj;
                    txbNomeFantasia.Text = empresaSelecionada.NomeFantasia;
                    txbRazaoSocial.Text = empresaSelecionada.RazaoSocial;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.AcceptButton = btnEditar;
        }
    }
}