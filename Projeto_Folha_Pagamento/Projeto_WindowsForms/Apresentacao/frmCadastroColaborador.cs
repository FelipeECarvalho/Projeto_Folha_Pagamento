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
            listaDadosColaborador.Add(txtNomeColaborador.Text);
            listaDadosColaborador.Add(txtCargo.Text);
            listaDadosColaborador.Add(txtEmpresa.Text);
            listaDadosColaborador.Add(txtSalario.Text);
            listaDadosColaborador.Add(txtDataAdmissao.Text);
            ControleBase controle = new ControleBase();
            controle.cadastrarColaborador(listaDadosColaborador);
            MessageBox.Show(controle.mensagem);
            this.Close();
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmCadastroColaborador cancelar = new frmCadastroColaborador();
            cancelar.Close();
        }
    }
}