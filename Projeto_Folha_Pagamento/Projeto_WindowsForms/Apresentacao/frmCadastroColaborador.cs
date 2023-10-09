using Projeto_WindowsForms.Controle;

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
            List<string> listaDadosColaborador = new List<string>();
            listaDadosColaborador.Add(txbNomeColaborador.Text);
            listaDadosColaborador.Add(txbCargo.Text);
            listaDadosColaborador.Add(txbEmpresa.Text);
            listaDadosColaborador.Add(txbSalario.Text);
            listaDadosColaborador.Add(txbDataAdmissao.Text);
            ControleBase controle = new ControleBase();
            controle.cadastrarColaborador(listaDadosColaborador);
            txbNomeColaborador.Clear();
            txbCargo.Clear();
            txbEmpresa.Clear();
            txbSalario.Clear();
            txbDataAdmissao.Clear();
            MessageBox.Show(controle.mensagem);
        }

    }
}