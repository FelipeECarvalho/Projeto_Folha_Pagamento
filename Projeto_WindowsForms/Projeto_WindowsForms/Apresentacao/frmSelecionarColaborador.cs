using Projeto_WindowsForms.Controle;
using Projeto_WindowsForms.Modelo;

namespace Projeto_WindowsForms.Apresentacao
{
    public partial class frmSelecionarColaborador : Form
    {
        public static Colaborador colaboradorSelecionado;

        public frmSelecionarColaborador()
        {
            InitializeComponent();
        }

        private void frmCadastroColaborador_Load(object sender, EventArgs e)
        {
            AcceptButton = btnSelecionar;
            dgvRelatorio.Rows.Clear();

            var listaColaborador = frmGerarFolhaPagamento.listaColaboradorSelecionar;

            foreach (var colaborador in listaColaborador)
            {
                dgvRelatorio.Rows.Add(colaborador.Id, colaborador.DataAdmissao.ToShortDateString(), colaborador.NomeCompleto, colaborador.Salario.ToString("c"), colaborador.Cargo, colaborador.Empresa.NomeFantasia);
            }
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            var idColaborador = (int)dgvRelatorio[0, dgvRelatorio.CurrentCell.RowIndex].Value;
            SelecionarColaborador(idColaborador);
        }

        private void dgvRelatorio_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var idColaborador = (int)dgvRelatorio[0, e.RowIndex].Value;
            SelecionarColaborador(idColaborador);
        }

        private void SelecionarColaborador(int id)
        {
            var colaboradorControle = new ColaboradorControle();
            colaboradorSelecionado = colaboradorControle.buscarColaborador(id);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}