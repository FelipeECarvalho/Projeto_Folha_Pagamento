using Projeto_WindowsForms.Controle;
using Projeto_WindowsForms.Modelo;

namespace Projeto_WindowsForms.Apresentacao
{
    public partial class frmCadastroColaborador : Form
    {
        public frmCadastroColaborador()
        {
            InitializeComponent();
        }


        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            List<string> listaDadosColaborador = new()
            {
                txbNomeColaborador.Text,
                txbCargo.Text,
                cmbEmpresa.Text,
                txbSalario.Text
            };

            var controle = new ControleBase();
            controle.cadastrarColaborador(listaDadosColaborador);

            txbCargo.Clear();
            txbSalario.Clear();
            txbNomeColaborador.Clear();

            MessageBox.Show(controle.mensagem);
        }

        private void frmCadastroColaborador_Load(object sender, EventArgs e)
        {
            var controle = new ControleBase();
            var listaEmpresa = controle.listarEmpresas();

            foreach (var empresa in listaEmpresa)
            {
                cmbEmpresa.Items.Add(empresa.NomeFantasia);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}