namespace Projeto_WindowsForms.Apresentacao
{
    partial class frmGerarRelatorio
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
            ListViewItem listViewItem1 = new ListViewItem("");
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            label2 = new Label();
            panel5 = new Panel();
            label3 = new Label();
            panel6 = new Panel();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(383, 23);
            label1.Name = "label1";
            label1.Size = new Size(147, 33);
            label1.TabIndex = 0;
            label1.Text = "Relatórios";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Location = new Point(2, 72);
            panel1.Name = "panel1";
            panel1.Size = new Size(912, 1);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.Location = new Point(2, 148);
            panel2.Name = "panel2";
            panel2.Size = new Size(912, 1);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightGray;
            panel3.Location = new Point(2, 222);
            panel3.Name = "panel3";
            panel3.Size = new Size(912, 1);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label2);
            panel4.Location = new Point(12, 91);
            panel4.Name = "panel4";
            panel4.Size = new Size(269, 38);
            panel4.TabIndex = 3;
            panel4.Click += panel4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(29, 11);
            label2.Name = "label2";
            label2.Size = new Size(206, 18);
            label2.TabIndex = 0;
            label2.Text = "Relatórios de colaboradores";
            label2.Click += label2_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(label3);
            panel5.Location = new Point(311, 91);
            panel5.Name = "panel5";
            panel5.Size = new Size(292, 38);
            panel5.TabIndex = 4;
            panel5.Click += panel5_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(58, 11);
            label3.Name = "label3";
            label3.Size = new Size(175, 18);
            label3.TabIndex = 1;
            label3.Text = "Relatórios de empresas";
            label3.Click += label3_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(label4);
            panel6.Location = new Point(626, 91);
            panel6.Name = "panel6";
            panel6.Size = new Size(276, 38);
            panel6.TabIndex = 4;
            panel6.Click += panel6_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(14, 11);
            label4.Name = "label4";
            label4.Size = new Size(243, 18);
            label4.TabIndex = 2;
            label4.Text = "Relatórios de folha de pagamento";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 176);
            label5.Name = "label5";
            label5.Size = new Size(179, 18);
            label5.TabIndex = 5;
            label5.Text = "Selecionar colaborador: ";
            label5.Click += label5_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ScrollBar;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(269, 174);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(404, 26);
            textBox1.TabIndex = 6;
            textBox1.Text = "    Nome ou Id";
            // 
            // listView1
            // 
            listView1.BorderStyle = BorderStyle.FixedSingle;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listView1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listView1.GridLines = true;
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1 });
            listView1.Location = new Point(55, 238);
            listView1.Name = "listView1";
            listView1.Size = new Size(814, 321);
            listView1.TabIndex = 7;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Data";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Nome";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 300;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Relatórios";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            columnHeader4.Width = 300;
            // 
            // frmGerarRelatorio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(914, 571);
            Controls.Add(listView1);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "frmGerarRelatorio";
            Text = "frmGerarRelatorio";
            Load += frmGerarRelatorio_Load;
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
    }
}