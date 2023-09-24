namespace CadastroEmpresas
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
            txbCnpj = new TextBox();
            txbNomeFantasia = new TextBox();
            txbRazaoSocial = new TextBox();
            lblCnpj = new Label();
            lblNomeFantasia = new Label();
            lblRazaoSocial = new Label();
            btnCadastrar = new Button();
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txbCnpj
            // 
            txbCnpj.Location = new Point(83, 194);
            txbCnpj.Name = "txbCnpj";
            txbCnpj.Size = new Size(306, 23);
            txbCnpj.TabIndex = 0;
            // 
            // txbNomeFantasia
            // 
            txbNomeFantasia.Location = new Point(408, 194);
            txbNomeFantasia.Name = "txbNomeFantasia";
            txbNomeFantasia.Size = new Size(306, 23);
            txbNomeFantasia.TabIndex = 1;
            // 
            // txbRazaoSocial
            // 
            txbRazaoSocial.Location = new Point(83, 266);
            txbRazaoSocial.Name = "txbRazaoSocial";
            txbRazaoSocial.Size = new Size(306, 23);
            txbRazaoSocial.TabIndex = 2;
            // 
            // lblCnpj
            // 
            lblCnpj.AutoSize = true;
            lblCnpj.Location = new Point(83, 176);
            lblCnpj.Name = "lblCnpj";
            lblCnpj.Size = new Size(34, 15);
            lblCnpj.TabIndex = 3;
            lblCnpj.Text = "CNPJ";
            // 
            // lblNomeFantasia
            // 
            lblNomeFantasia.AutoSize = true;
            lblNomeFantasia.Location = new Point(408, 176);
            lblNomeFantasia.Name = "lblNomeFantasia";
            lblNomeFantasia.Size = new Size(84, 15);
            lblNomeFantasia.TabIndex = 4;
            lblNomeFantasia.Text = "Nome fantasia";
            // 
            // lblRazaoSocial
            // 
            lblRazaoSocial.AutoSize = true;
            lblRazaoSocial.Location = new Point(83, 248);
            lblRazaoSocial.Name = "lblRazaoSocial";
            lblRazaoSocial.Size = new Size(71, 15);
            lblRazaoSocial.TabIndex = 5;
            lblRazaoSocial.Text = "Razão social";
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.FromArgb(92, 198, 186);
            btnCadastrar.Cursor = Cursors.Hand;
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnCadastrar.ForeColor = SystemColors.ButtonHighlight;
            btnCadastrar.Location = new Point(608, 342);
            btnCadastrar.Margin = new Padding(0);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(145, 34);
            btnCadastrar.TabIndex = 6;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(251, 40);
            label1.Name = "label1";
            label1.Size = new Size(307, 41);
            label1.TabIndex = 7;
            label1.Text = "Cadastro de empresa";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(217, 217, 217);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label2);
            panel1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(50, 111);
            panel1.Name = "panel1";
            panel1.Size = new Size(703, 40);
            panel1.TabIndex = 8;
            panel1.Paint += panel1_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(33, 10);
            label2.Name = "label2";
            label2.Size = new Size(130, 19);
            label2.TabIndex = 0;
            label2.Text = "Dados empresariais";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Location = new Point(50, 149);
            panel2.Name = "panel2";
            panel2.Size = new Size(703, 180);
            panel2.TabIndex = 9;
            panel2.Paint += panel2_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 447);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(btnCadastrar);
            Controls.Add(lblRazaoSocial);
            Controls.Add(lblNomeFantasia);
            Controls.Add(lblCnpj);
            Controls.Add(txbRazaoSocial);
            Controls.Add(txbNomeFantasia);
            Controls.Add(txbCnpj);
            Controls.Add(panel2);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Form1";
            Text = "Cadastro de empresas";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txbCnpj;
        private TextBox txbNomeFantasia;
        private TextBox txbRazaoSocial;
        private Label lblCnpj;
        private Label lblNomeFantasia;
        private Label lblRazaoSocial;
        private Button btnCadastrar;
        private Label label1;
        private Panel panel1;
        private Label label2;
        private Panel panel2;
    }
}