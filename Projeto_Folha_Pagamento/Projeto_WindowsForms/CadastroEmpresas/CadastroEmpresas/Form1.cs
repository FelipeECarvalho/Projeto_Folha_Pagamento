namespace CadastroEmpresas
{
    public partial class Form1 : Form
    {
        private List<Empresa> empresas = new List<Empresa>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string cnpj = txbCnpj.Text.Trim();
            string razaoSocial = txbRazaoSocial.Text.Trim();
            string nomeFantasia = txbNomeFantasia.Text.Trim();

            if (string.IsNullOrEmpty(cnpj) || string.IsNullOrEmpty(razaoSocial) || string.IsNullOrEmpty(nomeFantasia))
            {
                MessageBox.Show("Preencha todos os campos antes de cadastrar a empresa.");
                return;
            }

            if (cnpj.Length != 14 || !cnpj.All(char.IsDigit))
            {
                MessageBox.Show("O CNPJ deve conter exatamente 14 digitos numéricos.");
                return;
            }

            if (razaoSocial.Length > 50)
            {
                MessageBox.Show("A Razão Social não pode exceder 100 caracteres.");
                return;
            }

            if (nomeFantasia.Length > 50)
            {
                MessageBox.Show("O Nome Fantasia não pode exceder 50 caracteres.");
                return;
            }

            Empresa novaEmpresa = new Empresa(cnpj, razaoSocial, nomeFantasia);
            empresas.Add(novaEmpresa);

            txbCnpj.Clear();
            txbNomeFantasia.Clear();
            txbRazaoSocial.Clear();

            MessageBox.Show("Empresa cadastrada com sucesso!");
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}