namespace Projeto_WindowsForms.Apresentacao
{
    partial class frmGerarRelatorio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panel2 = new Panel();
            label5 = new Label();
            btnRelatorio = new Button();
            btnEmpresa = new Button();
            btnFolhaPagamento = new Button();
            panel3 = new Panel();
            imgLupa = new PictureBox();
            txbID = new TextBox();
            btnBuscar = new Button();
            dgvRelatorio = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            data_admissao = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Sexo = new DataGridViewTextBoxColumn();
            salario = new DataGridViewTextBoxColumn();
            cargo = new DataGridViewTextBoxColumn();
            Empresa = new DataGridViewTextBoxColumn();
            panel9 = new Panel();
            label9 = new Label();
            btnVoltar = new PictureBox();
            dgvEmpresas = new DataGridView();
            id_empresa = new DataGridViewTextBoxColumn();
            Cnpj = new DataGridViewTextBoxColumn();
            razao_social = new DataGridViewTextBoxColumn();
            nome_fantasia = new DataGridViewTextBoxColumn();
            dgvFolhaPagamento = new DataGridView();
            id_folha = new DataGridViewTextBoxColumn();
            salario_folha = new DataGridViewTextBoxColumn();
            desconto = new DataGridViewTextBoxColumn();
            irrf = new DataGridViewTextBoxColumn();
            inss = new DataGridViewTextBoxColumn();
            subtotal = new DataGridViewTextBoxColumn();
            colaborador = new DataGridViewTextBoxColumn();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgLupa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRelatorio).BeginInit();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnVoltar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEmpresas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvFolhaPagamento).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.Location = new Point(2, 148);
            panel2.Name = "panel2";
            panel2.Size = new Size(912, 1);
            panel2.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 176);
            label5.Name = "label5";
            label5.Size = new Size(87, 18);
            label5.TabIndex = 5;
            label5.Text = "Pesquisar: ";
            // 
            // btnRelatorio
            // 
            btnRelatorio.BackColor = Color.FromArgb(50, 130, 184);
            btnRelatorio.FlatAppearance.BorderColor = Color.FromArgb(255, 255, 192);
            btnRelatorio.FlatAppearance.BorderSize = 0;
            btnRelatorio.FlatStyle = FlatStyle.Flat;
            btnRelatorio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRelatorio.ForeColor = SystemColors.Window;
            btnRelatorio.Location = new Point(12, 91);
            btnRelatorio.Name = "btnRelatorio";
            btnRelatorio.Size = new Size(269, 39);
            btnRelatorio.TabIndex = 27;
            btnRelatorio.Text = "Relatórios de colaboradores";
            btnRelatorio.UseVisualStyleBackColor = false;
            btnRelatorio.Click += btnRelatorio_Click;
            // 
            // btnEmpresa
            // 
            btnEmpresa.BackColor = SystemColors.Window;
            btnEmpresa.FlatAppearance.BorderSize = 0;
            btnEmpresa.FlatStyle = FlatStyle.Flat;
            btnEmpresa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEmpresa.ForeColor = SystemColors.ControlText;
            btnEmpresa.Location = new Point(308, 90);
            btnEmpresa.Name = "btnEmpresa";
            btnEmpresa.Size = new Size(269, 39);
            btnEmpresa.TabIndex = 28;
            btnEmpresa.Text = "Relatórios de empresas";
            btnEmpresa.UseVisualStyleBackColor = false;
            btnEmpresa.Click += btnEmpresa_Click;
            // 
            // btnFolhaPagamento
            // 
            btnFolhaPagamento.BackColor = SystemColors.Window;
            btnFolhaPagamento.FlatAppearance.BorderSize = 0;
            btnFolhaPagamento.FlatStyle = FlatStyle.Flat;
            btnFolhaPagamento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnFolhaPagamento.ForeColor = SystemColors.ControlText;
            btnFolhaPagamento.Location = new Point(615, 90);
            btnFolhaPagamento.Name = "btnFolhaPagamento";
            btnFolhaPagamento.Size = new Size(269, 39);
            btnFolhaPagamento.TabIndex = 29;
            btnFolhaPagamento.Text = "Relatórios de folha de pagamento";
            btnFolhaPagamento.UseVisualStyleBackColor = false;
            btnFolhaPagamento.Click += btnFolhaPagamento_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Window;
            panel3.Controls.Add(imgLupa);
            panel3.Controls.Add(txbID);
            panel3.Location = new Point(108, 171);
            panel3.Name = "panel3";
            panel3.Size = new Size(345, 30);
            panel3.TabIndex = 31;
            // 
            // imgLupa
            // 
            imgLupa.Cursor = Cursors.Hand;
            imgLupa.Image = Properties.Resources.search_button;
            imgLupa.Location = new Point(308, 3);
            imgLupa.Name = "imgLupa";
            imgLupa.Size = new Size(36, 25);
            imgLupa.SizeMode = PictureBoxSizeMode.Zoom;
            imgLupa.TabIndex = 4;
            imgLupa.TabStop = false;
            imgLupa.Click += imgLupa_Click;
            // 
            // txbID
            // 
            txbID.BorderStyle = BorderStyle.None;
            txbID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txbID.Location = new Point(3, 3);
            txbID.Margin = new Padding(3, 2, 3, 2);
            txbID.MinimumSize = new Size(100, 25);
            txbID.Name = "txbID";
            txbID.Size = new Size(299, 25);
            txbID.TabIndex = 3;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(50, 130, 184);
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscar.ForeColor = SystemColors.ButtonHighlight;
            btnBuscar.Location = new Point(479, 170);
            btnBuscar.Margin = new Padding(0);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(98, 31);
            btnBuscar.TabIndex = 30;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dgvRelatorio
            // 
            dgvRelatorio.AllowUserToAddRows = false;
            dgvRelatorio.AllowUserToDeleteRows = false;
            dgvRelatorio.AllowUserToResizeColumns = false;
            dgvRelatorio.AllowUserToResizeRows = false;
            dgvRelatorio.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvRelatorio.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRelatorio.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvRelatorio.BackgroundColor = SystemColors.Window;
            dgvRelatorio.BorderStyle = BorderStyle.None;
            dgvRelatorio.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvRelatorio.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(50, 130, 184);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvRelatorio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvRelatorio.ColumnHeadersHeight = 40;
            dgvRelatorio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvRelatorio.Columns.AddRange(new DataGridViewColumn[] { ID, data_admissao, Nome, Sexo, salario, cargo, Empresa });
            dgvRelatorio.EnableHeadersVisualStyles = false;
            dgvRelatorio.GridColor = Color.FromArgb(50, 130, 184);
            dgvRelatorio.Location = new Point(11, 252);
            dgvRelatorio.Name = "dgvRelatorio";
            dgvRelatorio.ReadOnly = true;
            dgvRelatorio.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(50, 130, 184);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dgvRelatorio.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvRelatorio.RowTemplate.Height = 25;
            dgvRelatorio.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRelatorio.Size = new Size(890, 307);
            dgvRelatorio.TabIndex = 32;
            // 
            // ID
            // 
            ID.FillWeight = 30F;
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Resizable = DataGridViewTriState.False;
            // 
            // data_admissao
            // 
            data_admissao.FillWeight = 70F;
            data_admissao.HeaderText = "Data Admissão";
            data_admissao.Name = "data_admissao";
            data_admissao.ReadOnly = true;
            // 
            // Nome
            // 
            Nome.FillWeight = 101.725891F;
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            // 
            // Sexo
            // 
            Sexo.FillWeight = 50F;
            Sexo.HeaderText = "Sexo";
            Sexo.Name = "Sexo";
            Sexo.ReadOnly = true;
            // 
            // salario
            // 
            salario.FillWeight = 75F;
            salario.HeaderText = "Salario";
            salario.Name = "salario";
            salario.ReadOnly = true;
            // 
            // cargo
            // 
            cargo.HeaderText = "Cargo";
            cargo.Name = "cargo";
            cargo.ReadOnly = true;
            // 
            // Empresa
            // 
            Empresa.FillWeight = 101.725891F;
            Empresa.HeaderText = "Empresa";
            Empresa.Name = "Empresa";
            Empresa.ReadOnly = true;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(50, 130, 184);
            panel9.Controls.Add(label9);
            panel9.Controls.Add(btnVoltar);
            panel9.Location = new Point(2, 1);
            panel9.Name = "panel9";
            panel9.Size = new Size(912, 57);
            panel9.TabIndex = 33;
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.Window;
            label9.Location = new Point(387, 10);
            label9.Name = "label9";
            label9.Size = new Size(111, 43);
            label9.TabIndex = 8;
            label9.Text = "Relatórios";
            label9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnVoltar
            // 
            btnVoltar.Cursor = Cursors.Hand;
            btnVoltar.Image = Properties.Resources.botao_voltar;
            btnVoltar.Location = new Point(11, 10);
            btnVoltar.Margin = new Padding(3, 2, 3, 2);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(45, 39);
            btnVoltar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnVoltar.TabIndex = 21;
            btnVoltar.TabStop = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // dgvEmpresas
            // 
            dgvEmpresas.AllowUserToAddRows = false;
            dgvEmpresas.AllowUserToDeleteRows = false;
            dgvEmpresas.AllowUserToResizeColumns = false;
            dgvEmpresas.AllowUserToResizeRows = false;
            dgvEmpresas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvEmpresas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmpresas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvEmpresas.BackgroundColor = SystemColors.Window;
            dgvEmpresas.BorderStyle = BorderStyle.None;
            dgvEmpresas.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvEmpresas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(50, 130, 184);
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvEmpresas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvEmpresas.ColumnHeadersHeight = 40;
            dgvEmpresas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvEmpresas.Columns.AddRange(new DataGridViewColumn[] { id_empresa, Cnpj, razao_social, nome_fantasia });
            dgvEmpresas.EnableHeadersVisualStyles = false;
            dgvEmpresas.GridColor = Color.FromArgb(50, 130, 184);
            dgvEmpresas.Location = new Point(11, 252);
            dgvEmpresas.Name = "dgvEmpresas";
            dgvEmpresas.ReadOnly = true;
            dgvEmpresas.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(50, 130, 184);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dgvEmpresas.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvEmpresas.RowTemplate.Height = 25;
            dgvEmpresas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmpresas.Size = new Size(890, 307);
            dgvEmpresas.TabIndex = 34;
            // 
            // id_empresa
            // 
            id_empresa.FillWeight = 30F;
            id_empresa.HeaderText = "ID";
            id_empresa.Name = "id_empresa";
            id_empresa.ReadOnly = true;
            id_empresa.Resizable = DataGridViewTriState.False;
            // 
            // Cnpj
            // 
            Cnpj.FillWeight = 75F;
            Cnpj.HeaderText = "CNPJ";
            Cnpj.Name = "Cnpj";
            Cnpj.ReadOnly = true;
            // 
            // razao_social
            // 
            razao_social.HeaderText = "Razão social";
            razao_social.Name = "razao_social";
            razao_social.ReadOnly = true;
            // 
            // nome_fantasia
            // 
            nome_fantasia.FillWeight = 101.725891F;
            nome_fantasia.HeaderText = "Nome fantasia";
            nome_fantasia.Name = "nome_fantasia";
            nome_fantasia.ReadOnly = true;
            // 
            // dgvFolhaPagamento
            // 
            dgvFolhaPagamento.AllowUserToAddRows = false;
            dgvFolhaPagamento.AllowUserToDeleteRows = false;
            dgvFolhaPagamento.AllowUserToResizeColumns = false;
            dgvFolhaPagamento.AllowUserToResizeRows = false;
            dgvFolhaPagamento.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvFolhaPagamento.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFolhaPagamento.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvFolhaPagamento.BackgroundColor = SystemColors.Window;
            dgvFolhaPagamento.BorderStyle = BorderStyle.None;
            dgvFolhaPagamento.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvFolhaPagamento.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(50, 130, 184);
            dataGridViewCellStyle5.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.Window;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvFolhaPagamento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvFolhaPagamento.ColumnHeadersHeight = 40;
            dgvFolhaPagamento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvFolhaPagamento.Columns.AddRange(new DataGridViewColumn[] { id_folha, salario_folha, desconto, irrf, inss, subtotal, colaborador });
            dgvFolhaPagamento.EnableHeadersVisualStyles = false;
            dgvFolhaPagamento.GridColor = Color.FromArgb(50, 130, 184);
            dgvFolhaPagamento.Location = new Point(11, 252);
            dgvFolhaPagamento.Name = "dgvFolhaPagamento";
            dgvFolhaPagamento.ReadOnly = true;
            dgvFolhaPagamento.RowHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(50, 130, 184);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dgvFolhaPagamento.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvFolhaPagamento.RowTemplate.Height = 25;
            dgvFolhaPagamento.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFolhaPagamento.Size = new Size(890, 307);
            dgvFolhaPagamento.TabIndex = 35;
            // 
            // id_folha
            // 
            id_folha.FillWeight = 30F;
            id_folha.HeaderText = "ID";
            id_folha.Name = "id_folha";
            id_folha.ReadOnly = true;
            id_folha.Resizable = DataGridViewTriState.False;
            // 
            // salario_folha
            // 
            salario_folha.FillWeight = 75F;
            salario_folha.HeaderText = "Salário (=)";
            salario_folha.Name = "salario_folha";
            salario_folha.ReadOnly = true;
            // 
            // desconto
            // 
            desconto.HeaderText = "Desconto (-)";
            desconto.Name = "desconto";
            desconto.ReadOnly = true;
            // 
            // irrf
            // 
            irrf.FillWeight = 101.725891F;
            irrf.HeaderText = "IRRF (-)";
            irrf.Name = "irrf";
            irrf.ReadOnly = true;
            // 
            // inss
            // 
            inss.HeaderText = "INSS (-)";
            inss.Name = "inss";
            inss.ReadOnly = true;
            // 
            // subtotal
            // 
            subtotal.HeaderText = "Subtotal (=)";
            subtotal.Name = "subtotal";
            subtotal.ReadOnly = true;
            // 
            // colaborador
            // 
            colaborador.HeaderText = "Colaborador";
            colaborador.Name = "colaborador";
            colaborador.ReadOnly = true;
            // 
            // frmGerarRelatorio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(914, 571);
            Controls.Add(dgvFolhaPagamento);
            Controls.Add(dgvEmpresas);
            Controls.Add(panel9);
            Controls.Add(dgvRelatorio);
            Controls.Add(panel3);
            Controls.Add(btnBuscar);
            Controls.Add(btnFolhaPagamento);
            Controls.Add(btnEmpresa);
            Controls.Add(btnRelatorio);
            Controls.Add(label5);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmGerarRelatorio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Relatórios";
            Load += frmGerarRelatorio_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgLupa).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRelatorio).EndInit();
            panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnVoltar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEmpresas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvFolhaPagamento).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel2;
        private Label label5;
        private TextBox textBox1;
        private Button btnRelatorio;
        private Button btnEmpresa;
        private Button btnFolhaPagamento;
        private Panel panel3;
        private PictureBox imgLupa;
        private TextBox txbID;
        private Button btnBuscar;
        private DataGridView dgvRelatorio;
        private Panel panel9;
        private Label label9;
        private PictureBox btnVoltar;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn data_admissao;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Sexo;
        private DataGridViewTextBoxColumn salario;
        private DataGridViewTextBoxColumn Empresa;
        private DataGridViewTextBoxColumn cargo;
        private DataGridView dgvEmpresas;
        private DataGridViewTextBoxColumn id_empresa;
        private DataGridViewTextBoxColumn Cnpj;
        private DataGridViewTextBoxColumn razao_social;
        private DataGridViewTextBoxColumn nome_fantasia;
        private DataGridView dgvFolhaPagamento;
        private DataGridViewTextBoxColumn id_folha;
        private DataGridViewTextBoxColumn salario_folha;
        private DataGridViewTextBoxColumn desconto;
        private DataGridViewTextBoxColumn irrf;
        private DataGridViewTextBoxColumn inss;
        private DataGridViewTextBoxColumn subtotal;
        private DataGridViewTextBoxColumn colaborador;
    }
}