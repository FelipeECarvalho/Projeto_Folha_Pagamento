namespace ProjetoPim
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            lblLogin.Location = new Point(931, 242);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(65, 27);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "Login";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(730, 300);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(59, 20);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Usuario";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(730, 364);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(49, 20);
            lblSenha.TabIndex = 2;
            lblSenha.Text = "Senha";
            // 
            // txbUsuario
            // 
            txbUsuario.Location = new Point(795, 293);
            txbUsuario.Name = "txbUsuario";
            txbUsuario.Size = new Size(402, 27);
            txbUsuario.TabIndex = 3;
            // 
            // txbSenha
            // 
            txbSenha.Location = new Point(795, 361);
            txbSenha.Name = "txbSenha";
            txbSenha.PasswordChar = '*';
            txbSenha.Size = new Size(402, 27);
            txbSenha.TabIndex = 4;
            // 
            // btnAcessar
            // 
            btnAcessar.Location = new Point(874, 412);
            btnAcessar.Name = "btnAcessar";
            btnAcessar.Size = new Size(182, 50);
            btnAcessar.TabIndex = 5;
            btnAcessar.Text = "Acessar";
            btnAcessar.UseVisualStyleBackColor = true;
            btnAcessar.Click += btnAcessar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(855, 90);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(225, 149);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1522, 888);
            Controls.Add(pictureBox1);
            Controls.Add(btnAcessar);
            Controls.Add(txbSenha);
            Controls.Add(txbUsuario);
            Controls.Add(lblSenha);
            Controls.Add(lblUsuario);
            Controls.Add(lblLogin);
            Name = "Form1";
            Text = "Form1";
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