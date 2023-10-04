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
            txtNomeColaborador = new TextBox();
            txtEmpresa = new TextBox();
            lblCargo = new Label();
            txtCargo = new TextBox();
            lblEmpresa = new Label();
            txtSalario = new TextBox();
            lblSalario = new Label();
            txtDataAdmissao = new TextBox();
            lblDataAdmissao = new Label();
            btnCadastrar = new Button();
            lblCadastroDeColaborador = new Label();
            SuspendLayout();
            // 
            // lblNomeColaborador
            // 
            lblNomeColaborador.AutoSize = true;
            lblNomeColaborador.Location = new Point(19, 77);
            lblNomeColaborador.Name = "lblNomeColaborador";
            lblNomeColaborador.Size = new Size(107, 15);
            lblNomeColaborador.TabIndex = 0;
            lblNomeColaborador.Text = "Nome colaborador";
            // 
            // txtNomeColaborador
            // 
            txtNomeColaborador.Location = new Point(19, 95);
            txtNomeColaborador.Name = "txtNomeColaborador";
            txtNomeColaborador.Size = new Size(274, 23);
            txtNomeColaborador.TabIndex = 1;
            // 
            // txtEmpresa
            // 
            txtEmpresa.Location = new Point(378, 95);
            txtEmpresa.Name = "txtEmpresa";
            txtEmpresa.Size = new Size(274, 23);
            txtEmpresa.TabIndex = 3;
            // 
            // lblCargo
            // 
            lblCargo.AutoSize = true;
            lblCargo.Location = new Point(19, 134);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new Size(39, 15);
            lblCargo.TabIndex = 2;
            lblCargo.Text = "Cargo";
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(19, 152);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(274, 23);
            txtCargo.TabIndex = 5;
            // 
            // lblEmpresa
            // 
            lblEmpresa.AutoSize = true;
            lblEmpresa.Location = new Point(378, 74);
            lblEmpresa.Name = "lblEmpresa";
            lblEmpresa.Size = new Size(52, 15);
            lblEmpresa.TabIndex = 4;
            lblEmpresa.Text = "Empresa";
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(378, 152);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(274, 23);
            txtSalario.TabIndex = 7;
            // 
            // lblSalario
            // 
            lblSalario.AutoSize = true;
            lblSalario.Location = new Point(378, 134);
            lblSalario.Name = "lblSalario";
            lblSalario.Size = new Size(42, 15);
            lblSalario.TabIndex = 6;
            lblSalario.Text = "Salário";
            // 
            // txtDataAdmissao
            // 
            txtDataAdmissao.Location = new Point(378, 210);
            txtDataAdmissao.Name = "txtDataAdmissao";
            txtDataAdmissao.Size = new Size(274, 23);
            txtDataAdmissao.TabIndex = 9;
            // 
            // lblDataAdmissao
            // 
            lblDataAdmissao.AutoSize = true;
            lblDataAdmissao.Location = new Point(378, 192);
            lblDataAdmissao.Name = "lblDataAdmissao";
            lblDataAdmissao.Size = new Size(100, 15);
            lblDataAdmissao.TabIndex = 8;
            lblDataAdmissao.Text = "Data de admissão";
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = SystemColors.Control;
            btnCadastrar.Location = new Point(270, 278);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(150, 32);
            btnCadastrar.TabIndex = 10;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click_1;
            // 
            // lblCadastroDeColaborador
            // 
            lblCadastroDeColaborador.AutoSize = true;
            lblCadastroDeColaborador.Font = new Font("Segoe UI Semibold", 22F, FontStyle.Bold, GraphicsUnit.Point);
            lblCadastroDeColaborador.Location = new Point(173, 18);
            lblCadastroDeColaborador.Name = "lblCadastroDeColaborador";
            lblCadastroDeColaborador.Size = new Size(356, 41);
            lblCadastroDeColaborador.TabIndex = 11;
            lblCadastroDeColaborador.Text = "Cadastro de colaborador";
            // 
            // frmCadastroColaborador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(675, 351);
            Controls.Add(lblCadastroDeColaborador);
            Controls.Add(btnCadastrar);
            Controls.Add(txtDataAdmissao);
            Controls.Add(lblDataAdmissao);
            Controls.Add(txtSalario);
            Controls.Add(lblSalario);
            Controls.Add(txtCargo);
            Controls.Add(lblEmpresa);
            Controls.Add(txtEmpresa);
            Controls.Add(lblCargo);
            Controls.Add(txtNomeColaborador);
            Controls.Add(lblNomeColaborador);
            Name = "frmCadastroColaborador";
            Text = "Cadastro de colaborador";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNomeColaborador;
        private TextBox txtNomeColaborador;
        private TextBox txtEmpresa;
        private Label lblCargo;
        private TextBox txtCargo;
        private Label lblEmpresa;
        private TextBox txtSalario;
        private Label lblSalario;
        private TextBox txtDataAdmissao;
        private Label lblDataAdmissao;
        private Button btnCadastrar;
        private Label lblCadastroDeColaborador;
    }
}