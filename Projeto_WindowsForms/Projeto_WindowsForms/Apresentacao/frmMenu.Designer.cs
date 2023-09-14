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
            flowLayoutPanel2 = new FlowLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            flowLayoutPanel4 = new FlowLayoutPanel();
            flowLayoutPanel5 = new FlowLayoutPanel();
            label1 = new Label();
            flowLayoutPanel6 = new FlowLayoutPanel();
            flowLayoutPanel7 = new FlowLayoutPanel();
            flowLayoutPanel8 = new FlowLayoutPanel();
            flowLayoutPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = SystemColors.ControlLightLight;
            flowLayoutPanel2.Location = new Point(519, 394);
            flowLayoutPanel2.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(354, 186);
            flowLayoutPanel2.TabIndex = 3;
            flowLayoutPanel2.Paint += flowLayoutPanel2_Paint;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.ControlLightLight;
            flowLayoutPanel1.Location = new Point(85, 394);
            flowLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(354, 186);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.BackColor = SystemColors.ControlLightLight;
            flowLayoutPanel3.Location = new Point(85, 149);
            flowLayoutPanel3.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(354, 186);
            flowLayoutPanel3.TabIndex = 4;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.BackColor = SystemColors.ControlLightLight;
            flowLayoutPanel4.Location = new Point(519, 149);
            flowLayoutPanel4.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(354, 186);
            flowLayoutPanel4.TabIndex = 4;
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.BackColor = Color.MediumAquamarine;
            flowLayoutPanel5.Controls.Add(label1);
            flowLayoutPanel5.Location = new Point(85, 149);
            flowLayoutPanel5.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Size = new Size(354, 63);
            flowLayoutPanel5.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(298, 32);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de colaboradores";
            // 
            // flowLayoutPanel6
            // 
            flowLayoutPanel6.BackColor = Color.RoyalBlue;
            flowLayoutPanel6.Location = new Point(519, 149);
            flowLayoutPanel6.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel6.Name = "flowLayoutPanel6";
            flowLayoutPanel6.Size = new Size(354, 63);
            flowLayoutPanel6.TabIndex = 6;
            // 
            // flowLayoutPanel7
            // 
            flowLayoutPanel7.BackColor = Color.Orange;
            flowLayoutPanel7.Location = new Point(519, 394);
            flowLayoutPanel7.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel7.Name = "flowLayoutPanel7";
            flowLayoutPanel7.Size = new Size(354, 63);
            flowLayoutPanel7.TabIndex = 6;
            // 
            // flowLayoutPanel8
            // 
            flowLayoutPanel8.BackColor = Color.MediumOrchid;
            flowLayoutPanel8.Location = new Point(85, 394);
            flowLayoutPanel8.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel8.Name = "flowLayoutPanel8";
            flowLayoutPanel8.Size = new Size(354, 63);
            flowLayoutPanel8.TabIndex = 6;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(997, 630);
            Controls.Add(flowLayoutPanel5);
            Controls.Add(flowLayoutPanel8);
            Controls.Add(flowLayoutPanel7);
            Controls.Add(flowLayoutPanel6);
            Controls.Add(flowLayoutPanel4);
            Controls.Add(flowLayoutPanel3);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(flowLayoutPanel2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmMenu";
            Text = "frmMenu";
            flowLayoutPanel5.ResumeLayout(false);
            flowLayoutPanel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel3;
        private FlowLayoutPanel flowLayoutPanel4;
        private FlowLayoutPanel flowLayoutPanel5;
        private FlowLayoutPanel flowLayoutPanel6;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel7;
        private FlowLayoutPanel flowLayoutPanel8;
    }
}