﻿namespace Projeto_WindowsForms.Apresentacao
{
    partial class frmEditarEmpresa
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
            txbNomeFantasia = new TextBox();
            txbRazaoSocial = new TextBox();
            lblCnpj = new Label();
            lblNomeFantasia = new Label();
            lblRazaoSocial = new Label();
            btnEditar = new Button();
            panel1 = new Panel();
            label2 = new Label();
            panel2 = new Panel();
            txbCnpj = new MaskedTextBox();
            panel9 = new Panel();
            label9 = new Label();
            btnVoltar = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnVoltar).BeginInit();
            SuspendLayout();
            // 
            // txbNomeFantasia
            // 
            txbNomeFantasia.Location = new Point(408, 194);
            txbNomeFantasia.Name = "txbNomeFantasia";
            txbNomeFantasia.Size = new Size(306, 23);
            txbNomeFantasia.TabIndex = 2;
            // 
            // txbRazaoSocial
            // 
            txbRazaoSocial.Location = new Point(83, 266);
            txbRazaoSocial.Name = "txbRazaoSocial";
            txbRazaoSocial.Size = new Size(306, 23);
            txbRazaoSocial.TabIndex = 3;
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
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(50, 130, 184);
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditar.ForeColor = SystemColors.ButtonHighlight;
            btnEditar.Location = new Point(569, 361);
            btnEditar.Margin = new Padding(0);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(145, 34);
            btnEditar.TabIndex = 4;
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
            panel1.Location = new Point(50, 111);
            panel1.Name = "panel1";
            panel1.Size = new Size(703, 40);
            panel1.TabIndex = 8;
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
            panel2.Controls.Add(txbCnpj);
            panel2.Location = new Point(50, 149);
            panel2.Name = "panel2";
            panel2.Size = new Size(703, 180);
            panel2.TabIndex = 0;
            // 
            // txbCnpj
            // 
            txbCnpj.Location = new Point(32, 44);
            txbCnpj.Mask = "00\\.000\\.000\\/0000\\-00";
            txbCnpj.Name = "txbCnpj";
            txbCnpj.Size = new Size(306, 23);
            txbCnpj.TabIndex = 0;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(50, 130, 184);
            panel9.Controls.Add(label9);
            panel9.Controls.Add(btnVoltar);
            panel9.Location = new Point(1, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(801, 57);
            panel9.TabIndex = 29;
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.Window;
            label9.Location = new Point(260, 9);
            label9.Name = "label9";
            label9.Size = new Size(218, 43);
            label9.TabIndex = 8;
            label9.Text = "Editar Empresa";
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
            // frmEditarEmpresa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 447);
            Controls.Add(panel9);
            Controls.Add(panel1);
            Controls.Add(btnEditar);
            Controls.Add(lblRazaoSocial);
            Controls.Add(lblNomeFantasia);
            Controls.Add(lblCnpj);
            Controls.Add(txbRazaoSocial);
            Controls.Add(txbNomeFantasia);
            Controls.Add(panel2);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmEditarEmpresa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de empresa";
            Load += frmEditarEmpresa_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnVoltar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txbNomeFantasia;
        private TextBox txbRazaoSocial;
        private Label lblCnpj;
        private Label lblNomeFantasia;
        private Label lblRazaoSocial;
        private Button btnEditar;
        private Panel panel1;
        private Label label2;
        private Panel panel2;
        private Panel panel9;
        private Label label9;
        private PictureBox btnVoltar;
        private MaskedTextBox txbCnpj;
    }
}