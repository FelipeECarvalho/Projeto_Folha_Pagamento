using Projeto_WindowsForms.Modelo;
using System.Windows.Forms;

namespace Projeto_WindowsForms.Apresentacao
{
    public partial class frmGerarRelatorio : Form
    {
        public frmGerarRelatorio()
        {
            InitializeComponent();
        }

        private void frmGerarRelatorio_Load(object sender, EventArgs e)
        {
            dgvRelatorio.Rows.Add(("qwe", "qwe"));
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            SetButtonActive(btnRelatorio);
        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            SetButtonActive(btnEmpresa);
        }

        private void btnFolhaPagamento_Click(object sender, EventArgs e)
        {
            SetButtonActive(btnFolhaPagamento);
        }

        private void SetButtonActive(Button btn)
        {
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

        }

        private void imgLupa_Click(object sender, EventArgs e)
        {

        }

        private void frmGerarRelatorio_Load_1(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
