namespace Projeto_WindowsForms.Apresentacao
{
    partial class frmSelecionarColaborador
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btnSelecionar = new Button();
            panel9 = new Panel();
            label9 = new Label();
            btnVoltar = new PictureBox();
            dgvRelatorio = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            data_admissao = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            salario = new DataGridViewTextBoxColumn();
            cargo = new DataGridViewTextBoxColumn();
            Empresa = new DataGridViewTextBoxColumn();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnVoltar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRelatorio).BeginInit();
            SuspendLayout();
            // 
            // btnSelecionar
            // 
            btnSelecionar.BackColor = Color.FromArgb(50, 130, 184);
            btnSelecionar.Cursor = Cursors.Hand;
            btnSelecionar.FlatAppearance.BorderSize = 0;
            btnSelecionar.FlatStyle = FlatStyle.Flat;
            btnSelecionar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnSelecionar.ForeColor = SystemColors.ButtonHighlight;
            btnSelecionar.Location = new Point(622, 410);
            btnSelecionar.Name = "btnSelecionar";
            btnSelecionar.Size = new Size(148, 35);
            btnSelecionar.TabIndex = 0;
            btnSelecionar.Text = "Selecionar";
            btnSelecionar.UseVisualStyleBackColor = false;
            btnSelecionar.Click += btnSelecionar_Click;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(50, 130, 184);
            panel9.Controls.Add(label9);
            panel9.Controls.Add(btnVoltar);
            panel9.Location = new Point(0, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(801, 57);
            panel9.TabIndex = 28;
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.Window;
            label9.Location = new Point(267, 9);
            label9.Name = "label9";
            label9.Size = new Size(253, 43);
            label9.TabIndex = 8;
            label9.Text = "Selecionar colaborador";
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
            dgvRelatorio.Columns.AddRange(new DataGridViewColumn[] { ID, data_admissao, Nome, salario, cargo, Empresa });
            dgvRelatorio.EnableHeadersVisualStyles = false;
            dgvRelatorio.GridColor = Color.FromArgb(50, 130, 184);
            dgvRelatorio.Location = new Point(12, 81);
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
            dgvRelatorio.Size = new Size(775, 307);
            dgvRelatorio.TabIndex = 33;
            dgvRelatorio.CellContentDoubleClick += dgvRelatorio_CellContentDoubleClick;
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
            // frmSelecionarColaborador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 467);
            Controls.Add(dgvRelatorio);
            Controls.Add(panel9);
            Controls.Add(btnSelecionar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmSelecionarColaborador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de colaborador";
            Load += frmCadastroColaborador_Load;
            panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnVoltar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRelatorio).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnSelecionar;
        private Panel panel9;
        private Label label9;
        private PictureBox btnVoltar;
        private DataGridView dgvRelatorio;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn data_admissao;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn salario;
        private DataGridViewTextBoxColumn cargo;
        private DataGridViewTextBoxColumn Empresa;
    }
}