using Projeto_WindowsForms.Modelo;

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
                //new Colaborador(1, "José", "Gerente", "Pardal & Cia Ltda.", "300", DateTime.Now.ToString()),
                //new Colaborador(2, "Maria", "Analista", "Pardal & Cia Ltda.", "4000", DateTime.Now.ToString()),
                //new Colaborador(3, "Pedro", "Desenvolvedor", "Águia Incorporações Ltda.", "4100", DateTime.Now.ToString()),
                //new Colaborador(4, "Ana", "Designer", "Águia Incorporações Ltda.", "4200", DateTime.Now.ToString()),
                //new Colaborador(5, "Carlos", "Analista de Vendas", "Colibri Engenharia S.A.", "4300", DateTime.Now.ToString()),
                //new Colaborador(6, "Isabel", "Engenheiro de Software", "Colibri Engenharia S.A.", "4400", DateTime.Now.ToString()),
                //new Colaborador(7, "Paulo", "Analista de Marketing", "Falcão Comércio de Tecnologia Ltda.", "4500", DateTime.Now.ToString()),
                //new Colaborador(8, "Letícia","Contadora", "Falcão Comércio de Tecnologia Ltda.", "4600",  DateTime.Now.ToString()),
                //new Colaborador(9, "Ricardo", "Analista Financeiro", "Terra Elementar Consultoria Ambiental Ltda.", "4700", DateTime.Now.ToString()),
                //new Colaborador(10, "Juliana", "Engenheiro de Produção", "Terra Elementar Consultoria Ambiental Ltda.", "4800", DateTime.Now.ToString())
            };

            foreach (var colaborador in listaColaboradores)
            {
                var item = new ListViewItem(colaborador.Id.ToString());
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
