using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_WindowsForms.Apresentacao
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnColaborador_Click(object sender, EventArgs e)
        {
            var frmCadastroColaborador = new frmCadastroColaborador();
            this.Hide();
            frmCadastroColaborador.ShowDialog();
            this.Show();
            
        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
        }

        private void btnFolha_Click(object sender, EventArgs e)
        {
            var frmGerarFolhaPagamento = new frmGerarFolhaPagamento();
            frmGerarFolhaPagamento.ShowDialog();
            this.Hide();
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            var frmGerarRelatorio = new frmGerarRelatorio();
            frmGerarRelatorio.ShowDialog();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
