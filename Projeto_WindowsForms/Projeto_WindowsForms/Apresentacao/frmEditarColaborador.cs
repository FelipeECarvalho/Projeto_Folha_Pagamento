using Modelo;
using Modelo.Enum;
using Servico;

namespace Projeto_WindowsForms.Apresentacao
{
    public partial class frmEditarColaborador : Form
    {
        private Colaborador colaboradorSelecionado;
        private Acesso acessoSelecionado;

        public frmEditarColaborador()
        {
            InitializeComponent();
        }

        private void frmEditarColaborador_Load(object sender, EventArgs e)
        {
            AcceptButton = btnEditar;
            cmbEmpresa.DisplayMember = "Text";
            cmbEmpresa.ValueMember = "Value";

            carregarComboBox();

            var colaboradorServico = new ColaboradorServico();
            var acessoServico = new AcessoServico();

            try
            {
                colaboradorSelecionado = colaboradorServico.BuscarColaborador(frmGerarRelatorio.idColaborador);
                acessoSelecionado = acessoServico.BuscarAcesso(colaboradorSelecionado.Id);

                if (colaboradorSelecionado == null || acessoSelecionado == null)
                {
                    this.DialogResult = DialogResult.Abort;
                    this.Close();
                }
                else
                {
                    txbSalario.Text = colaboradorSelecionado.Salario.ToString();
                    txbNomeColaborador.Text = colaboradorSelecionado.NomeCompleto;
                    dtpDataAdmissao.Text = colaboradorSelecionado.DataAdmissao.ToString();

                    cmbEmpresa.SelectedIndex = cmbEmpresa.FindStringExact(colaboradorSelecionado.Empresa.NomeFantasia);
                    cmbCargo.SelectedIndex = cmbCargo.FindStringExact(colaboradorSelecionado.Cargo.ToString());
                    cmbSexo.SelectedIndex = cmbSexo.FindStringExact(colaboradorSelecionado.Sexo.ToString());

                    txbUsuario.Text = acessoSelecionado.Usuario;
                    txbSenha.Text = acessoSelecionado.Senha;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Enum.TryParse<TipoSexo>(cmbSexo.SelectedValue.ToString(), out var sexo);
            Enum.TryParse<TipoCargo>(cmbCargo.SelectedValue.ToString(), out var cargo);

            var colaborador = new Colaborador
            {
                Id = colaboradorSelecionado.Id,
                Sexo = sexo,
                Cargo = cargo,
                NomeCompleto = txbNomeColaborador.Text,
                Salario = decimal.Parse(txbSalario.Text.Replace("R$", "")),
                DataAdmissao = DateTime.Parse(dtpDataAdmissao.Text),
                Empresa = new Empresa
                {
                    Id = (int)(cmbEmpresa.SelectedItem as dynamic).Value
                }
            };

            var acesso = new Acesso
            {
                Id = acessoSelecionado.Id,
                SenhaOriginal = txbSenha.Text
            };

            try
            {
                var colaboradorServico = new ColaboradorServico();
                colaboradorServico.EditarColaborador(colaborador, acesso);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void carregarComboBox()
        {
            try
            {
                var empresaServico = new EmpresaServico();
                var listaEmpresa = empresaServico.ListarEmpresa();

                foreach (var empresa in listaEmpresa)
                {
                    cmbEmpresa.Items.Add(new { Text = empresa.NomeFantasia, Value = empresa.Id });
                }

                cmbCargo.DataSource = Enum.GetValues(typeof(TipoCargo));
                cmbSexo.DataSource = Enum.GetValues(typeof(TipoSexo));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}