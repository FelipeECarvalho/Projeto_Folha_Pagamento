using Projeto_WindowsForms.Controle;
using Projeto_WindowsForms.Modelo;
using Projeto_WindowsForms.Modelo.Enum;
using System.Net.NetworkInformation;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Projeto_WindowsForms.Apresentacao
{
    public partial class frmCadastroColaborador : Form
    {
        public frmCadastroColaborador()
        {
            InitializeComponent();
        }

        private void frmCadastroColaborador_Load(object sender, EventArgs e)
        {
            AcceptButton = btnCadastrar;
            cmbEmpresa.DisplayMember = "Text";
            cmbEmpresa.ValueMember = "Value";

            carregarComboBox();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Enum.TryParse<TipoSexo>(cmbSexo.SelectedValue.ToString(), out var sexo);
            Enum.TryParse<TipoCargo>(cmbCargo.SelectedValue.ToString(), out var cargo);

            var colaborador = new Colaborador
            {
                Ativo = true,
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

            var controle = new ControleBase();
            var acesso = controle.cadastrarColaborador(colaborador);

            if (string.IsNullOrEmpty(controle.mensagem))
            {
                txbSalario.Clear();
                txbNomeColaborador.Clear();

                MessageBox.Show($"Colaborador cadastrado com sucesso! \n Importante! anote seus dados de acesso: \n Usuário: {acesso.Usuario}, \n Senha: {acesso.Senha}", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(controle.mensagem, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void carregarComboBox()
        {
            var controle = new ControleBase();
            var listaEmpresa = controle.listarEmpresas();

            foreach (var empresa in listaEmpresa)
            {
                cmbEmpresa.Items.Add(new { Text = empresa.NomeFantasia, Value = empresa.Id });
            }

            cmbCargo.DataSource = Enum.GetValues(typeof(TipoCargo));
            cmbSexo.DataSource = Enum.GetValues(typeof(TipoSexo));
        }
    }
}