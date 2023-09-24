using Projeto_WindowsForms.Modelo;
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
    public partial class frmGerarRelatorio : Form
    {
        public frmGerarRelatorio()
        {
            InitializeComponent();
        }

        private void frmGerarRelatorio_Load(object sender, EventArgs e)
        {
            panel4_Click(sender, e);

            var listaColaboradores = new List<Colaborador>
            {
                new Colaborador("José", 1, "Pardal & Cia Ltda.", "12345678901234", "Gerente", 5000),
                new Colaborador("Maria", 2, "Pardal & Cia Ltda.", "12345678901234", "Analista", 3500),
                new Colaborador("Pedro", 3, "Águia Incorporações Ltda.", "98765432109876", "Desenvolvedor", 4500),
                new Colaborador("Ana", 4, "Águia Incorporações Ltda.", "98765432109876", "Designer", 4000),
                new Colaborador("Carlos", 5, "Colibri Engenharia S.A.", "56789012345678", "Analista de Vendas", 3800),
                new Colaborador("Isabel", 6, "Colibri Engenharia S.A.", "56789012345678", "Engenheiro de Software", 5500),
                new Colaborador("Paulo", 7, "Falcão Comércio de Tecnologia Ltda.", "13579246802468", "Analista de Marketing", 4200),
                new Colaborador("Letícia", 8, "Falcão Comércio de Tecnologia Ltda.", "13579246802468", "Contadora", 4700),
                new Colaborador("Ricardo", 9, "Terra Elementar Consultoria Ambiental Ltda.", "98765432101234", "Analista Financeiro", 4800),
                new Colaborador("Juliana", 10, "Terra Elementar Consultoria Ambiental Ltda.", "98765432101234", "Engenheiro de Produção", 5200)
            };

            foreach (var colaborador in listaColaboradores)
            {
                var item = new ListViewItem(colaborador.ID.ToString());
                item.SubItems.Add(DateTime.Now.Date.ToString("dd/MM/yyyy"));
                item.SubItems.Add(colaborador.Nome.ToString());

                listView1.Items.Add(item);
            }
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            ResetarCorBotao();
            panel4.BackColor = SystemColors.ScrollBar;
            label5.Text = "Selecionar colaborador: ";
            textBox1.Text = "   Nome ou ID";
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            ResetarCorBotao();
            panel5.BackColor = SystemColors.ScrollBar;
            label5.Text = "Selecionar empresas: ";
            textBox1.Text = "   CNPJ ou ID";
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            ResetarCorBotao();
            panel6.BackColor = SystemColors.ScrollBar;
            label5.Text = "Selecionar folha de pagamento: ";
            textBox1.Text = "   ID";
        }

        private void ResetarCorBotao()
        {
            panel4.BackColor = Color.White;
            panel5.BackColor = Color.White;
            panel6.BackColor = Color.White;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            ResetarCorBotao();
            panel4.BackColor = SystemColors.ScrollBar;
            label5.Text = "Selecionar colaborador: ";
            textBox1.Text = "   Nome ou ID";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            ResetarCorBotao();
            panel5.BackColor = SystemColors.ScrollBar;
            label5.Text = "Selecionar empresas: ";
            textBox1.Text = "   CNPJ ou ID";
        }

        private void label4_Click(object sender, EventArgs e)
        {
            ResetarCorBotao();
            panel6.BackColor = SystemColors.ScrollBar;
            label5.Text = "Selecionar folha de pagamento: ";
            textBox1.Text = "   ID";
        }
    }
}
