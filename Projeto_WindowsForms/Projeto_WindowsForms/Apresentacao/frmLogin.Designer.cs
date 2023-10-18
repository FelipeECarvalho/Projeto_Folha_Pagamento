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
            txbUsuario = new TextBox();
            txbSenha = new TextBox();
            btnAcessar = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label3 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            pictureBox4 = new PictureBox();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txbUsuario
            // 
            txbUsuario.BorderStyle = BorderStyle.None;
            txbUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txbUsuario.Location = new Point(53, 3);
            txbUsuario.Margin = new Padding(3, 2, 3, 2);
            txbUsuario.MinimumSize = new Size(400, 25);
            txbUsuario.Name = "txbUsuario";
            txbUsuario.Size = new Size(402, 25);
            txbUsuario.TabIndex = 0;
            // 
            // txbSenha
            // 
            txbSenha.Anchor = AnchorStyles.Left;
            txbSenha.BorderStyle = BorderStyle.None;
            txbSenha.Location = new Point(53, 3);
            txbSenha.Margin = new Padding(3, 2, 3, 2);
            txbSenha.MinimumSize = new Size(400, 25);
            txbSenha.Name = "txbSenha";
            txbSenha.PasswordChar = '*';
            txbSenha.Size = new Size(402, 25);
            txbSenha.TabIndex = 1;
            // 
            // btnAcessar
            // 
            btnAcessar.BackColor = Color.FromArgb(50, 130, 184);
            btnAcessar.FlatStyle = FlatStyle.Flat;
            btnAcessar.ForeColor = SystemColors.Window;
            btnAcessar.Location = new Point(377, 293);
            btnAcessar.Margin = new Padding(3, 2, 3, 2);
            btnAcessar.Name = "btnAcessar";
            btnAcessar.Size = new Size(159, 38);
            btnAcessar.TabIndex = 2;
            btnAcessar.Text = "Acessar";
            btnAcessar.UseVisualStyleBackColor = false;
            btnAcessar.Click += btnAcessar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo_empresa;
            pictureBox1.Location = new Point(117, 11);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(143, 121);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(50, 130, 184);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(357, 440);
            panel1.TabIndex = 7;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Window;
            label3.Location = new Point(157, 396);
            label3.Name = "label3";
            label3.Size = new Size(188, 35);
            label3.TabIndex = 8;
            label3.Text = "Desenvolvido pelo grupo PIM. Versão v1.0";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(79, 150);
            label1.Name = "label1";
            label1.Size = new Size(235, 151);
            label1.TabIndex = 7;
            label1.Text = "Bem-vindo ao sistema gerenciador de folha de pagamento";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Window;
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(txbSenha);
            panel2.Location = new Point(377, 224);
            panel2.Name = "panel2";
            panel2.Size = new Size(458, 30);
            panel2.TabIndex = 1;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources._lock;
            pictureBox4.Location = new Point(3, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(36, 25);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Window;
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(txbUsuario);
            panel3.Location = new Point(377, 188);
            panel3.Name = "panel3";
            panel3.Size = new Size(458, 30);
            panel3.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.user;
            pictureBox2.Location = new Point(3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(36, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(50, 130, 184);
            label2.Location = new Point(416, 85);
            label2.Name = "label2";
            label2.Size = new Size(173, 30);
            label2.TabIndex = 10;
            label2.Text = "Acesse sua conta";
            // 
            // frmLogin
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(872, 440);
            Controls.Add(label2);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnAcessar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += frmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txbUsuario;
        private TextBox txbSenha;
        private Button btnAcessar;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox4;
    }
}