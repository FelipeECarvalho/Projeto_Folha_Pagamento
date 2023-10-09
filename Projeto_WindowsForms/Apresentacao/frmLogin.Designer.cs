namespace Projeto_WindowsForms.Apresentacao
{
    partial class frmLogin
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
            lblLogin = new Label();
            lblUsuario = new Label();
            lblSenha = new Label();
            txbUsuario = new TextBox();
            txbSenha = new TextBox();
            btnAcessar = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblLogin.Location = new Point(209, 210);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(54, 23);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "Login";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(33, 253);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(47, 15);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Usuario";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(33, 301);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(39, 15);
            lblSenha.TabIndex = 2;
            lblSenha.Text = "Senha";
            // 
            // txbUsuario
            // 
            txbUsuario.Location = new Point(90, 248);
            txbUsuario.Margin = new Padding(3, 2, 3, 2);
            txbUsuario.Name = "txbUsuario";
            txbUsuario.Size = new Size(352, 23);
            txbUsuario.TabIndex = 3;
            // 
            // txbSenha
            // 
            txbSenha.Location = new Point(90, 299);
            txbSenha.Margin = new Padding(3, 2, 3, 2);
            txbSenha.Name = "txbSenha";
            txbSenha.PasswordChar = '*';
            txbSenha.Size = new Size(352, 23);
            txbSenha.TabIndex = 4;
            // 
            // btnAcessar
            // 
            btnAcessar.Location = new Point(163, 360);
            btnAcessar.Margin = new Padding(3, 2, 3, 2);
            btnAcessar.Name = "btnAcessar";
            btnAcessar.Size = new Size(159, 38);
            btnAcessar.TabIndex = 5;
            btnAcessar.Text = "Acessar";
            btnAcessar.UseVisualStyleBackColor = true;
            btnAcessar.Click += btnAcessar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo_empresa;
            pictureBox1.Location = new Point(146, 33);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(197, 164);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // frmLogin
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(512, 431);
            Controls.Add(pictureBox1);
            Controls.Add(btnAcessar);
            Controls.Add(txbSenha);
            Controls.Add(txbUsuario);
            Controls.Add(lblSenha);
            Controls.Add(lblUsuario);
            Controls.Add(lblLogin);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmLogin";
            Text = "Login Sistema";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLogin;
        private Label lblUsuario;
        private Label lblSenha;
        private TextBox txbUsuario;
        private TextBox txbSenha;
        private Button btnAcessar;
        private PictureBox pictureBox1;
    }
}