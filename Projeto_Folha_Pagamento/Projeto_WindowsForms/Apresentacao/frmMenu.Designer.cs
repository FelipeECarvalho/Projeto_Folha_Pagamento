namespace Projeto_WindowsForms.Apresentacao
{
    partial class frmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnColaborador = new Button();
            label5 = new Label();
            panel5 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            btnEmpresa = new Button();
            label6 = new Label();
            panel3 = new Panel();
            btnFolha = new Button();
            label7 = new Label();
            panel4 = new Panel();
            btnRelatorio = new Button();
            label8 = new Label();
            panel8 = new Panel();
            pictureBox4 = new PictureBox();
            label4 = new Label();
            panel6 = new Panel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            panel7 = new Panel();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            label9 = new Label();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnColaborador);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(panel5);
            panel1.Location = new Point(99, 98);
            panel1.Name = "panel1";
            panel1.Size = new Size(333, 200);
            panel1.TabIndex = 0;
            // 
            // btnColaborador
            // 
            btnColaborador.BackColor = Color.FromArgb(50, 130, 184);
            btnColaborador.FlatStyle = FlatStyle.Flat;
            btnColaborador.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnColaborador.ForeColor = Color.White;
            btnColaborador.Location = new Point(214, 153);
            btnColaborador.Name = "btnColaborador";
            btnColaborador.Size = new Size(103, 33);
            btnColaborador.TabIndex = 2;
            btnColaborador.Text = "Acessar";
            btnColaborador.UseVisualStyleBackColor = false;
            btnColaborador.Click += btnColaborador_Click;
            // 
            // label5
            // 
            label5.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(3, 83);
            label5.Name = "label5";
            label5.Padding = new Padding(3);
            label5.Size = new Size(314, 58);
            label5.TabIndex = 1;
            label5.Text = "Permite inserir informações sobre um novo colaborador, como nome, CPF, cargo, salário, entre outros.";
            label5.Click += label5_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(27, 38, 44);
            panel5.Controls.Add(pictureBox1);
            panel5.Controls.Add(label1);
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(332, 70);
            panel5.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.usuario;
            pictureBox1.Location = new Point(13, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Padding = new Padding(3);
            pictureBox1.Size = new Size(43, 55);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(66, 25);
            label1.Name = "label1";
            label1.Size = new Size(251, 25);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de colaboradores";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnEmpresa);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(536, 98);
            panel2.Name = "panel2";
            panel2.Size = new Size(333, 200);
            panel2.TabIndex = 1;
            // 
            // btnEmpresa
            // 
            btnEmpresa.BackColor = Color.FromArgb(50, 130, 184);
            btnEmpresa.FlatStyle = FlatStyle.Flat;
            btnEmpresa.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnEmpresa.ForeColor = Color.White;
            btnEmpresa.Location = new Point(210, 153);
            btnEmpresa.Name = "btnEmpresa";
            btnEmpresa.Size = new Size(103, 33);
            btnEmpresa.TabIndex = 3;
            btnEmpresa.Text = "Acessar";
            btnEmpresa.UseVisualStyleBackColor = false;
            btnEmpresa.Click += btnEmpresa_Click;
            // 
            // label6
            // 
            label6.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(-1, 83);
            label6.Name = "label6";
            label6.Padding = new Padding(3);
            label6.Size = new Size(314, 58);
            label6.TabIndex = 2;
            label6.Text = "Permite registrar informações sobre uma nova empresa, como nome, CNPJ, endereço, entre outros.";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(btnFolha);
            panel3.Controls.Add(label7);
            panel3.Location = new Point(99, 350);
            panel3.Name = "panel3";
            panel3.Size = new Size(333, 200);
            panel3.TabIndex = 1;
            // 
            // btnFolha
            // 
            btnFolha.BackColor = Color.FromArgb(50, 130, 184);
            btnFolha.FlatStyle = FlatStyle.Flat;
            btnFolha.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnFolha.ForeColor = Color.White;
            btnFolha.Location = new Point(213, 153);
            btnFolha.Name = "btnFolha";
            btnFolha.Size = new Size(103, 33);
            btnFolha.TabIndex = 3;
            btnFolha.Text = "Acessar";
            btnFolha.UseVisualStyleBackColor = false;
            btnFolha.Click += btnFolha_Click;
            // 
            // label7
            // 
            label7.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(2, 84);
            label7.Name = "label7";
            label7.Padding = new Padding(3);
            label7.Size = new Size(314, 86);
            label7.TabIndex = 3;
            label7.Text = "Permite inserir os dados dos colaboradores e seus respectivos salários para calcular o valor final a ser pago aos funcionários no período selecionado.";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(btnRelatorio);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(panel8);
            panel4.Location = new Point(536, 350);
            panel4.Name = "panel4";
            panel4.Size = new Size(333, 200);
            panel4.TabIndex = 1;
            // 
            // btnRelatorio
            // 
            btnRelatorio.BackColor = Color.FromArgb(50, 130, 184);
            btnRelatorio.FlatStyle = FlatStyle.Flat;
            btnRelatorio.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnRelatorio.ForeColor = Color.White;
            btnRelatorio.Location = new Point(210, 153);
            btnRelatorio.Name = "btnRelatorio";
            btnRelatorio.Size = new Size(103, 33);
            btnRelatorio.TabIndex = 4;
            btnRelatorio.Text = "Acessar";
            btnRelatorio.UseVisualStyleBackColor = false;
            btnRelatorio.Click += btnRelatorio_Click;
            // 
            // label8
            // 
            label8.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(-1, 84);
            label8.Name = "label8";
            label8.Padding = new Padding(3);
            label8.Size = new Size(314, 86);
            label8.TabIndex = 4;
            label8.Text = "Gera informações sobre a empresa e seus colaboradores, como folha de pagamento mensal, resumo de imposto, folha de pontos, entre outros.";
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(187, 225, 250);
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Controls.Add(pictureBox4);
            panel8.Controls.Add(label4);
            panel8.Location = new Point(-1, -1);
            panel8.Name = "panel8";
            panel8.Size = new Size(332, 70);
            panel8.TabIndex = 3;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.relatorio1;
            pictureBox4.Location = new Point(14, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(53, 62);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(127, 23);
            label4.Name = "label4";
            label4.Size = new Size(101, 25);
            label4.TabIndex = 3;
            label4.Text = "Relatórios";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(15, 76, 117);
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(pictureBox2);
            panel6.Controls.Add(label2);
            panel6.Location = new Point(536, 98);
            panel6.Name = "panel6";
            panel6.Size = new Size(332, 70);
            panel6.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.empresa;
            pictureBox2.Location = new Point(14, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Padding = new Padding(3);
            pictureBox2.Size = new Size(53, 63);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(84, 26);
            label2.Name = "label2";
            label2.Size = new Size(206, 25);
            label2.TabIndex = 1;
            label2.Text = "Cadastro de empresas";
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(50, 130, 184);
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(pictureBox3);
            panel7.Controls.Add(label3);
            panel7.Location = new Point(99, 350);
            panel7.Name = "panel7";
            panel7.Size = new Size(333, 70);
            panel7.TabIndex = 2;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.pagamento;
            pictureBox3.Location = new Point(14, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Padding = new Padding(3);
            pictureBox3.Size = new Size(53, 63);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(62, 23);
            label3.Name = "label3";
            label3.Size = new Size(267, 25);
            label3.TabIndex = 2;
            label3.Text = "Calcular folha de pagamento";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Narrow", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(272, 9);
            label9.Name = "label9";
            label9.Size = new Size(446, 33);
            label9.TabIndex = 3;
            label9.Text = "Menu Sistema de folha de pagamento";
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(962, 585);
            Controls.Add(label9);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmMenu";
            Text = "frmMenu";
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel5;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel8;
        private Panel panel6;
        private Panel panel7;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Button btnColaborador;
        private Button btnEmpresa;
        private Button btnFolha;
        private Button btnRelatorio;
        private Label label9;
    }
}