using Modelo;
using Servico;

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
            try
            {
                var colaboradorServico = new ColaboradorServico();
                colaboradorSelecionado = colaboradorServico.BuscarColaborador(id);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}