using Projeto_WindowsForms.Controle;
using Projeto_WindowsForms.Modelo;
using Projeto_WindowsForms.Modelo.Enum;

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

            var colaboradorControle = new ColaboradorControle();
            var acessoControle = new AcessoControle();

            colaboradorSelecionado = colaboradorControle.buscarColaborador(frmGerarRelatorio.idColaborador);
            acessoSelecionado = acessoControle.buscarAcesso(colaboradorSelecionado.Id);

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

            var colaboradorControle = new ColaboradorControle();
            colaboradorControle.editarColaborador(colaborador, acesso);

            if (string.IsNullOrEmpty(colaboradorControle.mensagem))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(colaboradorControle.mensagem, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void carregarComboBox()
        {
            var empresaControle = new EmpresaControle();
            var listaEmpresa = empresaControle.listarEmpresas();

            foreach (var empresa in listaEmpresa)
            {
                cmbEmpresa.Items.Add(new { Text = empresa.NomeFantasia, Value = empresa.Id });
            }

            cmbCargo.DataSource = Enum.GetValues(typeof(TipoCargo));
            cmbSexo.DataSource = Enum.GetValues(typeof(TipoSexo));
        }
    }
}