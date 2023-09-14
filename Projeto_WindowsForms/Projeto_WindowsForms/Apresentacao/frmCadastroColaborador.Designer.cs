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
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblNomeColaborador
            // 
            lblNomeColaborador.AutoSize = true;
            lblNomeColaborador.Location = new Point(17, 101);
            lblNomeColaborador.Name = "lblNomeColaborador";
            lblNomeColaborador.Size = new Size(107, 15);
            lblNomeColaborador.TabIndex = 0;
            lblNomeColaborador.Text = "Nome colaborador";
            // 
            // txtNomeColaborador
            // 
            txtNomeColaborador.Location = new Point(130, 98);
            txtNomeColaborador.Name = "txtNomeColaborador";
            txtNomeColaborador.Size = new Size(207, 23);
            txtNomeColaborador.TabIndex = 1;
            // 
            // txtEmpresa
            // 
            txtEmpresa.Location = new Point(426, 98);
            txtEmpresa.Name = "txtEmpresa";
            txtEmpresa.Size = new Size(259, 23);
            txtEmpresa.TabIndex = 3;
            // 
            // lblCargo
            // 
            lblCargo.AutoSize = true;
            lblCargo.Location = new Point(19, 143);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new Size(39, 15);
            lblCargo.TabIndex = 2;
            lblCargo.Text = "Cargo";
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(63, 140);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(274, 23);
            txtCargo.TabIndex = 5;
            // 
            // lblEmpresa
            // 
            lblEmpresa.AutoSize = true;
            lblEmpresa.Location = new Point(368, 103);
            lblEmpresa.Name = "lblEmpresa";
            lblEmpresa.Size = new Size(52, 15);
            lblEmpresa.TabIndex = 4;
            lblEmpresa.Text = "Empresa";
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(426, 143);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(259, 23);
            txtSalario.TabIndex = 7;
            // 
            // lblSalario
            // 
            lblSalario.AutoSize = true;
            lblSalario.Location = new Point(378, 143);
            lblSalario.Name = "lblSalario";
            lblSalario.Size = new Size(42, 15);
            lblSalario.TabIndex = 6;
            lblSalario.Text = "Salário";
            // 
            // txtDataAdmissao
            // 
            txtDataAdmissao.Location = new Point(426, 188);
            txtDataAdmissao.Name = "txtDataAdmissao";
            txtDataAdmissao.Size = new Size(259, 23);
            txtDataAdmissao.TabIndex = 9;
            // 
            // lblDataAdmissao
            // 
            lblDataAdmissao.AutoSize = true;
            lblDataAdmissao.Location = new Point(320, 191);
            lblDataAdmissao.Name = "lblDataAdmissao";
            lblDataAdmissao.Size = new Size(100, 15);
            lblDataAdmissao.TabIndex = 8;
            lblDataAdmissao.Text = "Data de admissão";
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(426, 251);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(150, 32);
            btnCadastrar.TabIndex = 10;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // lblCadastroDeColaborador
            // 
            lblCadastroDeColaborador.AutoSize = true;
            lblCadastroDeColaborador.Location = new Point(283, 27);
            lblCadastroDeColaborador.Name = "lblCadastroDeColaborador";
            lblCadastroDeColaborador.Size = new Size(137, 15);
            lblCadastroDeColaborador.TabIndex = 11;
            lblCadastroDeColaborador.Text = "Cadastro de colaborador";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(130, 251);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(150, 32);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // frmCadastroColaborador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(711, 314);
            Controls.Add(btnCancelar);
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
        private Button btnCancelar;
    }
}