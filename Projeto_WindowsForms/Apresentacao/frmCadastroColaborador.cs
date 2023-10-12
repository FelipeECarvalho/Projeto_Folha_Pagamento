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
            List<string> listaDadosColaborador = new List<string>();
            listaDadosColaborador.Add(txbNomeColaborador.Text);
            listaDadosColaborador.Add(txbCargo.Text);
            listaDadosColaborador.Add(cmbEmpresa.Text);
            listaDadosColaborador.Add(txbSalario.Text);
            //listaDadosColaborador.Add(dtbDataAdmissao.Text);
            ControleBase controle = new ControleBase();
            controle.cadastrarColaborador(listaDadosColaborador);
            txbNomeColaborador.Clear();
            txbCargo.Clear();
            txbSalario.Clear();
            MessageBox.Show(controle.mensagem);
        }

        private void frmCadastroColaborador_Load(object sender, EventArgs e)
        {
            ControleBase controle = new ControleBase();
            List<Empresa> listaEmpresa = controle.listarEmpresas();
            foreach (Empresa empresa in listaEmpresa)
            {
                cmbEmpresa.Items.Add(empresa.NomeFantasia);
            }
        }

    }
}
}