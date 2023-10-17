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
            lblCargo = new Label();
            txbCargo = new TextBox();
            lblEmpresa = new Label();
            txbSalario = new TextBox();
            lblSalario = new Label();
            lblDataAdmissao = new Label();
            btnCadastrar = new Button();
            lblCadastroDeColaborador = new Label();
            panel1 = new Panel();
            label2 = new Label();
            panel2 = new Panel();
            dtpDataAdmissao = new DateTimePicker();
            cmbEmpresa = new ComboBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
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
            txbNomeColaborador.TabIndex = 1;
            // 
            // lblCargo
            // 
            lblCargo.AutoSize = true;
            lblCargo.Location = new Point(30, 95);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new Size(39, 15);
            lblCargo.TabIndex = 2;
            lblCargo.Text = "Cargo";
            // 
            // txbCargo
            // 
            txbCargo.Location = new Point(30, 113);
            txbCargo.Name = "txbCargo";
            txbCargo.Size = new Size(274, 23);
            txbCargo.TabIndex = 5;
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
            // txbSalario
            // 
            txbSalario.Location = new Point(389, 113);
            txbSalario.Name = "txbSalario";
            txbSalario.Size = new Size(274, 23);
            txbSalario.TabIndex = 7;
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
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnCadastrar.ForeColor = SystemColors.ButtonHighlight;
            btnCadastrar.Location = new Point(566, 385);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(148, 35);
            btnCadastrar.TabIndex = 10;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // lblCadastroDeColaborador
            // 
            lblCadastroDeColaborador.AutoSize = true;
            lblCadastroDeColaborador.Font = new Font("Segoe UI Semibold", 22F, FontStyle.Bold, GraphicsUnit.Point);
            lblCadastroDeColaborador.Location = new Point(226, 18);
            lblCadastroDeColaborador.Name = "lblCadastroDeColaborador";
            lblCadastroDeColaborador.Size = new Size(356, 41);
            lblCadastroDeColaborador.TabIndex = 11;
            lblCadastroDeColaborador.Text = "Cadastro de colaborador";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(217, 217, 217);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label2);
            panel1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(50, 81);
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
            label2.Size = new Size(146, 19);
            label2.TabIndex = 0;
            label2.Text = "Dados do calaborador";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(dtpDataAdmissao);
            panel2.Controls.Add(cmbEmpresa);
            panel2.Controls.Add(txbCargo);
            panel2.Controls.Add(lblNomeColaborador);
            panel2.Controls.Add(txbNomeColaborador);
            panel2.Controls.Add(lblCargo);
            panel2.Controls.Add(lblDataAdmissao);
            panel2.Controls.Add(lblEmpresa);
            panel2.Controls.Add(txbSalario);
            panel2.Controls.Add(lblSalario);
            panel2.Location = new Point(50, 118);
            panel2.Name = "panel2";
            panel2.Size = new Size(703, 240);
            panel2.TabIndex = 13;
            // 
            // dtpDataAdmissao
            // 
            dtpDataAdmissao.Location = new Point(389, 171);
            dtpDataAdmissao.Name = "dtpDataAdmissao";
            dtpDataAdmissao.Size = new Size(274, 23);
            dtpDataAdmissao.TabIndex = 11;
            // 
            // cmbEmpresa
            // 
            cmbEmpresa.FormattingEnabled = true;
            cmbEmpresa.Location = new Point(389, 56);
            cmbEmpresa.Name = "cmbEmpresa";
            cmbEmpresa.Size = new Size(274, 23);
            cmbEmpresa.TabIndex = 10;
            // 
            // frmCadastroColaborador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 467);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(lblCadastroDeColaborador);
            Controls.Add(btnCadastrar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmCadastroColaborador";
            Text = "Cadastro de colaborador";
            Load += frmCadastroColaborador_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNomeColaborador;
        private TextBox txbNomeColaborador;
        private Label lblCargo;
        private TextBox txbCargo;
        private Label lblEmpresa;
        private TextBox txbSalario;
        private Label lblSalario;
        private Label lblDataAdmissao;
        private Button btnCadastrar;
        private Label lblCadastroDeColaborador;
        private Panel panel1;
        private Label label2;
        private Panel panel2;
        private DateTimePicker dtpDataAdmissao;
        private ComboBox cmbEmpresa;
    }
}