using Projeto_WindowsForms.Controle;
using Projeto_WindowsForms.Modelo;
using Projeto_WindowsForms.Modelo.Enum;

namespace Projeto_WindowsForms.Apresentacao
{
    public partial class frmGerarRelatorio : Form
    {
        readonly Colaborador colaboradorLogado;
        private DataGridView dataGridViewSelecionado;

        // Atributos que irão fazer a comunicação entre esse formulário e o formulário de edição
        public static int idEmpresa;
        public static int idColaborador;

        public frmGerarRelatorio()
        {
            InitializeComponent();
            colaboradorLogado = Program.colaboradorLogado;
        }

        private void frmGerarRelatorio_Load(object sender, EventArgs e)
        {
            PopularTabelas();
            MostrarFormularioInicial(sender, e);
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            if (colaboradorLogado.Cargo.Equals(TipoCargo.AnalistaDP))
            {
                MessageBox.Show("Você não tem permissão para acessar essa área", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SetButtonActive(btnRelatorio);
            dgvRelatorio.Show();

            dataGridViewSelecionado = dgvRelatorio;
        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            if (colaboradorLogado.Cargo.Equals(TipoCargo.AnalistaRH) || colaboradorLogado.Cargo.Equals(TipoCargo.AnalistaDP))
            {
                MessageBox.Show("Você não tem permissão para acessar essa área", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SetButtonActive(btnEmpresa);
            dgvEmpresas.Show();

            dataGridViewSelecionado = dgvEmpresas;
        }

        private void btnFolhaPagamento_Click(object sender, EventArgs e)
        {
            if (colaboradorLogado.Cargo.Equals(TipoCargo.AnalistaRH))
            {
                MessageBox.Show("Você não tem permissão para acessar essa área", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SetButtonActive(btnFolhaPagamento);
            dgvFolhaPagamento.Show();

            dataGridViewSelecionado = dgvFolhaPagamento;
        }

        private void SetButtonActive(Button btn)
        {
            dgvRelatorio.Hide();
            dgvEmpresas.Hide();
            dgvFolhaPagamento.Hide();

            var buttonList = new List<Button>
            {
                btnEmpresa, btnFolhaPagamento, btnRelatorio
            };

            foreach (var button in buttonList)
            {
                button.BackColor = SystemColors.Window;
                button.ForeColor = SystemColors.ControlText;
            }

            btn.BackColor = Color.FromArgb(50, 130, 184);
            btn.ForeColor = SystemColors.Window;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarRelatorio();
        }
        private void imgLupa_Click(object sender, EventArgs e)
        {
            BuscarRelatorio();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BuscarRelatorio()
        {
            var valorBuscado = txbID.Text.ToLower().Trim();

            try
            {
                var achou = false;

                foreach (DataGridViewRow row in dataGridViewSelecionado.Rows)
                {
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        dataGridViewSelecionado.Rows[row.Index].Selected = false;

                        var rowCell = row.Cells[i].Value;

                        if (rowCell != null && rowCell.ToString().ToLower().Trim().Equals(valorBuscado))
                        {
                            dataGridViewSelecionado.Rows[row.Index].Selected = true;
                            achou = true;
                            break;
                        }
                    }

                }

                if (!achou)
                {
                    MessageBox.Show("Não foi possível encontrar: " + txbID.Text);
                    return;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void PopularTabelas()
        {
            var colaboradorControle = new ColaboradorControle();
            var empresaControle = new EmpresaControle();
            var folhaPagamentoControle = new FolhaPagamentoControle();

            var listaColaborador = colaboradorControle.listarColaborador();
            var listaEmpresas = empresaControle.listarEmpresas();
            var listaFolhaPagamento = folhaPagamentoControle.listarFolhaPagamento();

            dgvRelatorio.Rows.Clear();
            foreach (var colaborador in listaColaborador)
            {
                dgvRelatorio.Rows.Add(colaborador.Id, colaborador.DataAdmissao.ToShortDateString(), colaborador.NomeCompleto, colaborador.Salario.ToString("c"), colaborador.Cargo, colaborador.Empresa.NomeFantasia);
            }

            dgvEmpresas.Rows.Clear();
            foreach (var empresa in listaEmpresas)
            {
                dgvEmpresas.Rows.Add(empresa.Id, empresa.Cnpj, empresa.RazaoSocial, empresa.NomeFantasia);
            }

            dgvFolhaPagamento.Rows.Clear();
            foreach (var folhaPagamento in listaFolhaPagamento)
            {
                dgvFolhaPagamento.Rows.Add(folhaPagamento.Id, folhaPagamento.Colaborador.Salario.ToString("c"), folhaPagamento.DescontosTotais.ToString("c"), string.Format("{0} (REF: {1})", folhaPagamento.Irrf.ToString("c"), folhaPagamento.AliquotaIrrf), string.Format("{0} (REF: {1})", folhaPagamento.Inss.ToString("c"), folhaPagamento.AliquotaInss), folhaPagamento.ValorLiquido.ToString("c"), folhaPagamento.Colaborador.NomeCompleto);
            }
        }

        private void MostrarFormularioInicial(object sender, EventArgs e)
        {
            if (colaboradorLogado.Cargo.Equals(TipoCargo.AnalistaDP))
            {
                btnFolhaPagamento_Click(sender, e);
                return;
            }

            btnRelatorio_Click(sender, e);
        }

        private void MudarCursorDataGrid(DataGridView dgv, DataGridViewCellEventArgs e)
        {
            var nomeColuna = dgv.Columns[e.ColumnIndex].Name;

            // caso o usuário passe o mouse sobre uma coluna que contenha o nome btn
            dgv.Cursor = nomeColuna.Contains("btn") ? Cursors.Hand : Cursors.Default;
        }

        private void dgvRelatorio_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            MudarCursorDataGrid(dgvRelatorio, e);
        }

        private void dgvEmpresas_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            MudarCursorDataGrid(dgvEmpresas, e);
        }

        private void dgvRelatorio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var colaboradorControle = new ColaboradorControle();
            var coluna = dgvRelatorio.Columns[e.ColumnIndex];

            // Caso o usuário teha clicado em uma imagem do DataGridView
            if (coluna is DataGridViewImageColumn && e.RowIndex >= 0)
            {
                // Pegando o id do colaborador
                idColaborador = (int)dgvRelatorio[0, e.RowIndex].Value;

                // Verificando se é exclusão ou edição
                if (coluna.Name == "btnEditarColaborador")
                {
                    if (colaboradorLogado.Cargo.Equals(TipoCargo.AnalistaDP))
                    {
                        MessageBox.Show("Você não tem permissão para realizar essa ação!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                } 
                else if (MessageBox.Show("Deseja realmente excluir o colaborador?", "Atenção!",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation,
                        MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    if (colaboradorLogado.Cargo.Equals(TipoCargo.AnalistaDP) || colaboradorLogado.Cargo.Equals(TipoCargo.AnalistaRH))
                    {
                        MessageBox.Show("Você não tem permissão para realizar essa ação!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    colaboradorControle.desativarColaborador(idColaborador);
                    MessageBox.Show("Colaborador excluido com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                PopularTabelas();
            }
        }

        private void dgvEmpresas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var empresaControle = new EmpresaControle();
            var coluna = dgvEmpresas.Columns[e.ColumnIndex];

            // Caso o usuário tenha clicado em uma imagem do DataGridView
            if (coluna is DataGridViewImageColumn && e.RowIndex >= 0)
            {
                // Pegando o id da empresa
                idEmpresa = (int)dgvEmpresas[0, e.RowIndex].Value;

                // Verificando se é exclusão ou edição
                if (coluna.Name == "btnEditarEmpresa")
                {
                    // Caso o colaborador não tenha permissão
                    if (colaboradorLogado.Cargo.Equals(TipoCargo.AnalistaDP) || colaboradorLogado.Cargo.Equals(TipoCargo.AnalistaRH))
                    {
                        MessageBox.Show("Você não tem permissão para realizar essa ação!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    var frmEditarEmpresa = new frmEditarEmpresa();

                    var resultadoForm = frmEditarEmpresa.ShowDialog();

                    // É verificado o retorno do form de edição para ver o resultado
                    if (resultadoForm == DialogResult.OK)
                        MessageBox.Show("Empresa atualizada com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else if (resultadoForm == DialogResult.Abort)
                        MessageBox.Show("Não foi possível atualizar a empresa, verifique os dados e tente novamente.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                }
                else if (MessageBox.Show("Deseja realmente excluir a empresa?", "Atenção!",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation,
                        MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    // Caso o colaborador não tenha permissão
                    if (colaboradorLogado.Cargo.Equals(TipoCargo.AnalistaDP) || colaboradorLogado.Cargo.Equals(TipoCargo.AnalistaRH))
                    {
                        MessageBox.Show("Você não tem permissão para realizar essa ação!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    empresaControle.desativarEmpresa(idEmpresa);
                    MessageBox.Show("Empresa excluida com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                PopularTabelas();
            }
        }
    }
}
