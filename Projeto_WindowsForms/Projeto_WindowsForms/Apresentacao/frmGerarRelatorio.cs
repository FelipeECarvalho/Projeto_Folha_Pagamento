using Projeto_WindowsForms.Controle;
using Projeto_WindowsForms.Modelo;
using Projeto_WindowsForms.Modelo.Enum;

namespace Projeto_WindowsForms.Apresentacao
{
    public partial class frmGerarRelatorio : Form
    {
        readonly Colaborador colaboradorLogado;

        public frmGerarRelatorio()
        {
            InitializeComponent();
            colaboradorLogado = Program.colaboradorLogado;
        }

        private void frmGerarRelatorio_Load(object sender, EventArgs e)
        {
            var controle = new ControleBase();
            var listaColaborador = controle.listarColaborador();
            var listaEmpresas = controle.listarEmpresas();
            var listaFolhaPagamento = controle.listarFolhaPagamento();

            foreach (var colaborador in listaColaborador)
            {
                dgvRelatorio.Rows.Add(colaborador.Id, colaborador.DataAdmissao.ToShortDateString(), colaborador.NomeCompleto, colaborador.Sexo, colaborador.Salario.ToString("c"), colaborador.Cargo, colaborador.Empresa.NomeFantasia);
            }

            foreach (var empresa in listaEmpresas)
            {
                dgvEmpresas.Rows.Add(empresa.Id, empresa.Cnpj, empresa.RazaoSocial, empresa.NomeFantasia);
            }

            foreach (var folhaPagamento in listaFolhaPagamento)
            {
                dgvFolhaPagamento.Rows.Add(folhaPagamento.Id, folhaPagamento.Colaborador.Salario.ToString("c"), folhaPagamento.DescontosTotais.ToString("c"), string.Format("{0} (REF: {1})", folhaPagamento.Irrf.ToString("c"), folhaPagamento.AliquotaIrrf), string.Format("{0} (REF: {1})", folhaPagamento.Inss.ToString("c"), folhaPagamento.AliquotaInss), folhaPagamento.ValorLiquido.ToString("c"), folhaPagamento.Colaborador.NomeCompleto);
            }

            btnRelatorio_Click(sender, e);
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
            DataGridView dgv = null;

            if (btnRelatorio.ForeColor == SystemColors.Window)
                dgv = dgvRelatorio;

            if (btnEmpresa.ForeColor == SystemColors.Window)
                dgv = dgvEmpresas;

            if (btnFolhaPagamento.ForeColor == SystemColors.Window)
                dgv = dgvEmpresas;

            string searchValue = txbID.Text.ToLower().Trim();
            try
            {
                bool valueResult = false;
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        dgv.Rows[row.Index].Selected = false;

                        var rowCell = row.Cells[i].Value;

                        if (rowCell != null && rowCell.ToString().ToLower().Trim().Equals(searchValue))
                        {
                            dgv.Rows[row.Index].Selected = true;
                            valueResult = true;
                            break;
                        }
                    }

                }
                if (!valueResult)
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
    }
}
