namespace Projeto_WindowsForms.Apresentacao
{
    partial class frmCadastroColaborador
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
            lblNomeColaborador = new Label();
            txbNomeColaborador = new TextBox();
            lblEmpresa = new Label();
            lblSalario = new Label();
            lblDataAdmissao = new Label();
            btnCadastrar = new Button();
            panel1 = new Panel();
            label2 = new Label();
            panel2 = new Panel();
            txbSalario = new MaskedTextBox();
            cmbSexo = new ComboBox();
            lblSexo = new Label();
            cmbCargo = new ComboBox();
            lblCargo = new Label();
            dtpDataAdmissao = new DateTimePicker();
            cmbEmpresa = new ComboBox();
            panel9 = new Panel();
            label9 = new Label();
            btnVoltar = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnVoltar).BeginInit();
            SuspendLayout();
            // 
            // lblNomeColaborador
            // 
            lblNomeColaborador.AutoSize = true;
            lblNomeColaborador.Location = new Point(30, 38);
            lblNomeColaborador.Name = "lblNomeColaborador";
            lblNomeColaborador.Size = new Size(107, 15);
            lblNomeColaborador.TabIndex = 0;
            lblNomeColaborador.Text = "Nome colaborador";
            // 
            // txbNomeColaborador
            // 
            txbNomeColaborador.Location = new Point(30, 56);
            txbNomeColaborador.Name = "txbNomeColaborador";
            txbNomeColaborador.Size = new Size(274, 23);
            txbNomeColaborador.TabIndex = 0;
            // 
            // lblEmpresa
            // 
            lblEmpresa.AutoSize = true;
            lblEmpresa.Location = new Point(389, 35);
            lblEmpresa.Name = "lblEmpresa";
            lblEmpresa.Size = new Size(52, 15);
            lblEmpresa.TabIndex = 4;
            lblEmpresa.Text = "Empresa";
            // 
            // lblSalario
            // 
            lblSalario.AutoSize = true;
            lblSalario.Location = new Point(389, 95);
            lblSalario.Name = "lblSalario";
            lblSalario.Size = new Size(42, 15);
            lblSalario.TabIndex = 6;
            lblSalario.Text = "Salário";
            // 
            // lblDataAdmissao
            // 
            lblDataAdmissao.AutoSize = true;
            lblDataAdmissao.Location = new Point(389, 153);
            lblDataAdmissao.Name = "lblDataAdmissao";
            lblDataAdmissao.Size = new Size(100, 15);
            lblDataAdmissao.TabIndex = 8;
            lblDataAdmissao.Text = "Data de admissão";
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.FromArgb(50, 130, 184);
            btnCadastrar.Cursor = Cursors.Hand;
            btnCadastrar.FlatAppearance.BorderSize = 0;
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnCadastrar.ForeColor = SystemColors.ButtonHighlight;
            btnCadastrar.Location = new Point(565, 404);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(148, 35);
            btnCadastrar.TabIndex = 0;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(217, 217, 217);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label2);
            panel1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(49, 100);
            panel1.Name = "panel1";
            panel1.Size = new Size(703, 40);
            panel1.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(33, 10);
            label2.Name = "label2";
            label2.Size = new Size(147, 19);
            label2.TabIndex = 0;
            label2.Text = "Dados do colaborador";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(txbSalario);
            panel2.Controls.Add(cmbSexo);
            panel2.Controls.Add(lblSexo);
            panel2.Controls.Add(cmbCargo);
            panel2.Controls.Add(lblCargo);
            panel2.Controls.Add(dtpDataAdmissao);
            panel2.Controls.Add(cmbEmpresa);
            panel2.Controls.Add(lblNomeColaborador);
            panel2.Controls.Add(txbNomeColaborador);
            panel2.Controls.Add(lblDataAdmissao);
            panel2.Controls.Add(lblEmpresa);
            panel2.Controls.Add(lblSalario);
            panel2.Location = new Point(49, 137);
            panel2.Name = "panel2";
            panel2.Size = new Size(703, 240);
            panel2.TabIndex = 0;
            // 
            // txbSalario
            // 
            txbSalario.HideSelection = false;
            txbSalario.Location = new Point(389, 113);
            txbSalario.Mask = "$9999,00";
            txbSalario.Name = "txbSalario";
            txbSalario.Size = new Size(274, 23);
            txbSalario.TabIndex = 13;
            txbSalario.ValidatingType = typeof(int);
            // 
            // cmbSexo
            // 
            cmbSexo.FormattingEnabled = true;
            cmbSexo.Location = new Point(30, 171);
            cmbSexo.Name = "cmbSexo";
            cmbSexo.Size = new Size(274, 23);
            cmbSexo.TabIndex = 11;
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.Location = new Point(30, 150);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(32, 15);
            lblSexo.TabIndex = 12;
            lblSexo.Text = "Sexo";
            // 
            // cmbCargo
            // 
            cmbCargo.FormattingEnabled = true;
            cmbCargo.Location = new Point(30, 113);
            cmbCargo.Name = "cmbCargo";
            cmbCargo.Size = new Size(274, 23);
            cmbCargo.TabIndex = 9;
            // 
            // lblCargo
            // 
            lblCargo.AutoSize = true;
            lblCargo.Location = new Point(30, 92);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new Size(39, 15);
            lblCargo.TabIndex = 10;
            lblCargo.Text = "Cargo";
            // 
            // dtpDataAdmissao
            // 
            dtpDataAdmissao.Location = new Point(389, 171);
            dtpDataAdmissao.Name = "dtpDataAdmissao";
            dtpDataAdmissao.Size = new Size(274, 23);
            dtpDataAdmissao.TabIndex = 4;
            // 
            // cmbEmpresa
            // 
            cmbEmpresa.FormattingEnabled = true;
            cmbEmpresa.Location = new Point(389, 56);
            cmbEmpresa.Name = "cmbEmpresa";
            cmbEmpresa.Size = new Size(274, 23);
            cmbEmpresa.TabIndex = 1;
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
            label9.Location = new Point(273, 9);
            label9.Name = "label9";
            label9.Size = new Size(253, 43);
            label9.TabIndex = 8;
            label9.Text = "Cadastro de colaborador";
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
            // frmCadastroColaborador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 467);
            Controls.Add(panel9);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(btnCadastrar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmCadastroColaborador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de colaborador";
            Load += frmCadastroColaborador_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnVoltar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblNomeColaborador;
        private TextBox txbNomeColaborador;
        private Label lblEmpresa;
        private Label lblSalario;
        private Label lblDataAdmissao;
        private Button btnCadastrar;
        private Panel panel1;
        private Label label2;
        private Panel panel2;
        private DateTimePicker dtpDataAdmissao;
        private ComboBox cmbEmpresa;
        private Panel panel9;
        private Label label9;
        private PictureBox btnVoltar;
        private ComboBox cmbCargo;
        private Label lblCargo;
        private ComboBox cmbSexo;
        private Label lblSexo;
        private MaskedTextBox txbSalario;
    }
}