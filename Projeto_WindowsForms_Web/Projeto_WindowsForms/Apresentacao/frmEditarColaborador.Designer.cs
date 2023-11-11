namespace Projeto_WindowsForms.Apresentacao
{
    partial class frmEditarColaborador
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
            btnEditar = new Button();
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
            panel3 = new Panel();
            label1 = new Label();
            label7 = new Label();
            txbUsuario = new TextBox();
            label5 = new Label();
            panel4 = new Panel();
            txbSenha = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnVoltar).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
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
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(50, 130, 184);
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditar.ForeColor = SystemColors.ButtonHighlight;
            btnEditar.Location = new Point(565, 607);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(148, 35);
            btnEditar.TabIndex = 0;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
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
            label9.Location = new Point(247, 6);
            label9.Name = "label9";
            label9.Size = new Size(253, 43);
            label9.TabIndex = 8;
            label9.Text = "Editar colaborador";
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
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(217, 217, 217);
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label1);
            panel3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            panel3.Location = new Point(49, 426);
            panel3.Name = "panel3";
            panel3.Size = new Size(703, 40);
            panel3.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(33, 10);
            label1.Name = "label1";
            label1.Size = new Size(112, 19);
            label1.TabIndex = 0;
            label1.Text = "Dados de acesso";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(389, 28);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 4;
            label7.Text = "Senha";
            // 
            // txbUsuario
            // 
            txbUsuario.Location = new Point(30, 49);
            txbUsuario.Name = "txbUsuario";
            txbUsuario.ReadOnly = true;
            txbUsuario.Size = new Size(274, 23);
            txbUsuario.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 31);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 0;
            label5.Text = "Usuário";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(txbSenha);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(txbUsuario);
            panel4.Controls.Add(label7);
            panel4.Location = new Point(49, 463);
            panel4.Name = "panel4";
            panel4.Size = new Size(703, 103);
            panel4.TabIndex = 13;
            // 
            // txbSenha
            // 
            txbSenha.Location = new Point(389, 49);
            txbSenha.Name = "txbSenha";
            txbSenha.PasswordChar = '*';
            txbSenha.Size = new Size(274, 23);
            txbSenha.TabIndex = 5;
            // 
            // frmEditarColaborador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 686);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel9);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(btnEditar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmEditarColaborador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de colaborador";
            Load += frmEditarColaborador_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnVoltar).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblNomeColaborador;
        private TextBox txbNomeColaborador;
        private Label lblEmpresa;
        private Label lblSalario;
        private Label lblDataAdmissao;
        private Button btnEditar;
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
        private Panel panel3;
        private Label label1;
        private Label label7;
        private TextBox txbUsuario;
        private Label label5;
        private Panel panel4;
        private TextBox txbSenha;
    }
}