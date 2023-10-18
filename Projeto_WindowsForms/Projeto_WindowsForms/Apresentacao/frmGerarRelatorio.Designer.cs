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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
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
            data = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Relatórios = new DataGridViewTextBoxColumn();
            panel9 = new Panel();
            label9 = new Label();
            btnVoltar = new PictureBox();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgLupa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRelatorio).BeginInit();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnVoltar).BeginInit();
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
            txbID.PlaceholderText = "ID";
            txbID.Size = new Size(299, 25);
            txbID.TabIndex = 3;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(50, 130, 184);
            btnBuscar.Cursor = Cursors.Hand;
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
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(50, 130, 184);
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvRelatorio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvRelatorio.ColumnHeadersHeight = 35;
            dgvRelatorio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvRelatorio.Columns.AddRange(new DataGridViewColumn[] { ID, data, Nome, Relatórios });
            dgvRelatorio.EnableHeadersVisualStyles = false;
            dgvRelatorio.GridColor = Color.FromArgb(50, 130, 184);
            dgvRelatorio.Location = new Point(11, 252);
            dgvRelatorio.Name = "dgvRelatorio";
            dgvRelatorio.ReadOnly = true;
            dgvRelatorio.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(50, 130, 184);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dgvRelatorio.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvRelatorio.RowTemplate.Height = 25;
            dgvRelatorio.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRelatorio.Size = new Size(890, 307);
            dgvRelatorio.TabIndex = 32;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Resizable = DataGridViewTriState.False;
            // 
            // data
            // 
            data.HeaderText = "Data";
            data.Name = "data";
            data.ReadOnly = true;
            // 
            // Nome
            // 
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            // 
            // Relatórios
            // 
            Relatórios.HeaderText = "Relatórios";
            Relatórios.Name = "Relatórios";
            Relatórios.ReadOnly = true;
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
            btnVoltar.Image = Properties.Resources.voltar1;
            btnVoltar.Location = new Point(11, 10);
            btnVoltar.Margin = new Padding(3, 2, 3, 2);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(45, 39);
            btnVoltar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnVoltar.TabIndex = 21;
            btnVoltar.TabStop = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // frmGerarRelatorio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(914, 571);
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
            Load += frmGerarRelatorio_Load_1;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgLupa).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRelatorio).EndInit();
            panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnVoltar).EndInit();
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
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn data;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Relatórios;
        private Panel panel9;
        private Label label9;
        private PictureBox btnVoltar;
    }
}