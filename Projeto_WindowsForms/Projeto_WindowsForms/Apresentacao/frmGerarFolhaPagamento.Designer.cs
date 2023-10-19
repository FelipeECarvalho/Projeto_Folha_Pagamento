using System.Windows.Forms;

namespace Projeto_WindowsForms.Apresentacao
{
    partial class frmGerarFolhaPagamento
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
            components = new System.ComponentModel.Container();
            imageList1 = new ImageList(components);
            lblSelecionarColaborador = new Label();
            lblNomeEmpresa = new Label();
            lblResultadoNomeEmpresa = new Label();
            lblCNPJ = new Label();
            lblResultadoCNPJ = new Label();
            lblNomeColaborador = new Label();
            lblResultadoNomeColaborador = new Label();
            lblFuncao = new Label();
            lblResultadoFuncao = new Label();
            tblDadosFolhaPagamento = new TableLayoutPanel();
            lblTblUserNome = new Label();
            lblTblUserID = new Label();
            lblTblnome = new Label();
            lblTblID = new Label();
            lblTblTotal = new Label();
            lblTblUserTotal = new Label();
            lblTblIRRF = new Label();
            lblTblUserIRRF = new Label();
            lblTblINSS = new Label();
            lblTblUserINSS = new Label();
            lblTblHorasExtras = new Label();
            lblTblUserHorasExtras = new Label();
            lblTblSalarioBaseMensal = new Label();
            lblTblUserSalarioBase = new Label();
            lblSalarioBase = new Label();
            lblHorasExtras = new Label();
            cbxHorasExtras = new ComboBox();
            lblMensagem = new Label();
            lblMensagemCalculo = new Label();
            gpbLinha = new GroupBox();
            btnVoltar = new PictureBox();
            btnBuscar = new Button();
            btnCalcular = new Button();
            btnGerarFolha = new Button();
            panel3 = new Panel();
            imgLupa = new PictureBox();
            txbNomeID = new TextBox();
            panel9 = new Panel();
            label9 = new Label();
            groupBox1 = new GroupBox();
            lblDadosColaborador = new Label();
            lblResultadoSalarioBase = new Label();
            tblDadosFolhaPagamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnVoltar).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgLupa).BeginInit();
            panel9.SuspendLayout();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // lblSelecionarColaborador
            // 
            lblSelecionarColaborador.AutoSize = true;
            lblSelecionarColaborador.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblSelecionarColaborador.Location = new Point(83, 73);
            lblSelecionarColaborador.Name = "lblSelecionarColaborador";
            lblSelecionarColaborador.Size = new Size(159, 20);
            lblSelecionarColaborador.TabIndex = 2;
            lblSelecionarColaborador.Text = "Pesquisar colaborador:";
            // 
            // lblNomeEmpresa
            // 
            lblNomeEmpresa.AutoSize = true;
            lblNomeEmpresa.Location = new Point(479, 163);
            lblNomeEmpresa.Name = "lblNomeEmpresa";
            lblNomeEmpresa.Size = new Size(107, 15);
            lblNomeEmpresa.TabIndex = 5;
            lblNomeEmpresa.Text = "Nome da Empresa:";
            // 
            // lblResultadoNomeEmpresa
            // 
            lblResultadoNomeEmpresa.AutoSize = true;
            lblResultadoNomeEmpresa.Location = new Point(592, 163);
            lblResultadoNomeEmpresa.Name = "lblResultadoNomeEmpresa";
            lblResultadoNomeEmpresa.Size = new Size(12, 15);
            lblResultadoNomeEmpresa.TabIndex = 6;
            lblResultadoNomeEmpresa.Text = "-";
            // 
            // lblCNPJ
            // 
            lblCNPJ.AutoSize = true;
            lblCNPJ.Location = new Point(479, 184);
            lblCNPJ.Name = "lblCNPJ";
            lblCNPJ.Size = new Size(37, 15);
            lblCNPJ.TabIndex = 7;
            lblCNPJ.Text = "CNPJ:";
            // 
            // lblResultadoCNPJ
            // 
            lblResultadoCNPJ.AutoSize = true;
            lblResultadoCNPJ.Location = new Point(522, 184);
            lblResultadoCNPJ.Name = "lblResultadoCNPJ";
            lblResultadoCNPJ.Size = new Size(12, 15);
            lblResultadoCNPJ.TabIndex = 8;
            lblResultadoCNPJ.Text = "-";
            // 
            // lblNomeColaborador
            // 
            lblNomeColaborador.AutoSize = true;
            lblNomeColaborador.Location = new Point(86, 163);
            lblNomeColaborador.Name = "lblNomeColaborador";
            lblNomeColaborador.Size = new Size(129, 15);
            lblNomeColaborador.TabIndex = 12;
            lblNomeColaborador.Text = "Nome do Colaborador:";
            // 
            // lblResultadoNomeColaborador
            // 
            lblResultadoNomeColaborador.AutoSize = true;
            lblResultadoNomeColaborador.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblResultadoNomeColaborador.Location = new Point(221, 163);
            lblResultadoNomeColaborador.Name = "lblResultadoNomeColaborador";
            lblResultadoNomeColaborador.Size = new Size(12, 15);
            lblResultadoNomeColaborador.TabIndex = 11;
            lblResultadoNomeColaborador.Text = "-";
            // 
            // lblFuncao
            // 
            lblFuncao.AutoSize = true;
            lblFuncao.Location = new Point(86, 187);
            lblFuncao.Name = "lblFuncao";
            lblFuncao.Size = new Size(49, 15);
            lblFuncao.TabIndex = 10;
            lblFuncao.Text = "Função:";
            // 
            // lblResultadoFuncao
            // 
            lblResultadoFuncao.AutoSize = true;
            lblResultadoFuncao.Location = new Point(141, 187);
            lblResultadoFuncao.Name = "lblResultadoFuncao";
            lblResultadoFuncao.Size = new Size(12, 15);
            lblResultadoFuncao.TabIndex = 9;
            lblResultadoFuncao.Text = "-";
            // 
            // tblDadosFolhaPagamento
            // 
            tblDadosFolhaPagamento.BackColor = SystemColors.Window;
            tblDadosFolhaPagamento.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tblDadosFolhaPagamento.ColumnCount = 7;
            tblDadosFolhaPagamento.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.2435226F));
            tblDadosFolhaPagamento.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 78.75648F));
            tblDadosFolhaPagamento.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 139F));
            tblDadosFolhaPagamento.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 138F));
            tblDadosFolhaPagamento.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tblDadosFolhaPagamento.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 83F));
            tblDadosFolhaPagamento.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 84F));
            tblDadosFolhaPagamento.Controls.Add(lblTblUserNome, 1, 1);
            tblDadosFolhaPagamento.Controls.Add(lblTblUserID, 0, 1);
            tblDadosFolhaPagamento.Controls.Add(lblTblnome, 1, 0);
            tblDadosFolhaPagamento.Controls.Add(lblTblID, 0, 0);
            tblDadosFolhaPagamento.Controls.Add(lblTblTotal, 6, 0);
            tblDadosFolhaPagamento.Controls.Add(lblTblUserTotal, 6, 1);
            tblDadosFolhaPagamento.Controls.Add(lblTblIRRF, 5, 0);
            tblDadosFolhaPagamento.Controls.Add(lblTblUserIRRF, 5, 1);
            tblDadosFolhaPagamento.Controls.Add(lblTblINSS, 4, 0);
            tblDadosFolhaPagamento.Controls.Add(lblTblUserINSS, 4, 1);
            tblDadosFolhaPagamento.Controls.Add(lblTblHorasExtras, 3, 0);
            tblDadosFolhaPagamento.Controls.Add(lblTblUserHorasExtras, 3, 1);
            tblDadosFolhaPagamento.Controls.Add(lblTblSalarioBaseMensal, 2, 0);
            tblDadosFolhaPagamento.Controls.Add(lblTblUserSalarioBase, 2, 1);
            tblDadosFolhaPagamento.Location = new Point(46, 319);
            tblDadosFolhaPagamento.Name = "tblDadosFolhaPagamento";
            tblDadosFolhaPagamento.RowCount = 3;
            tblDadosFolhaPagamento.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tblDadosFolhaPagamento.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblDadosFolhaPagamento.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tblDadosFolhaPagamento.Size = new Size(771, 62);
            tblDadosFolhaPagamento.TabIndex = 13;
            tblDadosFolhaPagamento.CellPaint += tblDadosFolhaPagamento_CellPaint;
            // 
            // lblTblUserNome
            // 
            lblTblUserNome.AutoSize = true;
            lblTblUserNome.Location = new Point(55, 34);
            lblTblUserNome.Name = "lblTblUserNome";
            lblTblUserNome.Size = new Size(12, 15);
            lblTblUserNome.TabIndex = 46;
            lblTblUserNome.Text = "-";
            // 
            // lblTblUserID
            // 
            lblTblUserID.AutoSize = true;
            lblTblUserID.Location = new Point(4, 34);
            lblTblUserID.Name = "lblTblUserID";
            lblTblUserID.Size = new Size(12, 15);
            lblTblUserID.TabIndex = 45;
            lblTblUserID.Text = "-";
            // 
            // lblTblnome
            // 
            lblTblnome.AutoSize = true;
            lblTblnome.BackColor = Color.Transparent;
            lblTblnome.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTblnome.ForeColor = SystemColors.Window;
            lblTblnome.Location = new Point(55, 1);
            lblTblnome.Name = "lblTblnome";
            lblTblnome.Size = new Size(57, 21);
            lblTblnome.TabIndex = 44;
            lblTblnome.Text = "Nome";
            // 
            // lblTblID
            // 
            lblTblID.AutoSize = true;
            lblTblID.BackColor = Color.Transparent;
            lblTblID.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTblID.ForeColor = SystemColors.Window;
            lblTblID.Location = new Point(4, 1);
            lblTblID.Name = "lblTblID";
            lblTblID.Size = new Size(27, 21);
            lblTblID.TabIndex = 14;
            lblTblID.Text = "ID";
            // 
            // lblTblTotal
            // 
            lblTblTotal.AutoSize = true;
            lblTblTotal.BackColor = Color.Transparent;
            lblTblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTblTotal.ForeColor = SystemColors.Window;
            lblTblTotal.Location = new Point(688, 1);
            lblTblTotal.Name = "lblTblTotal";
            lblTblTotal.Size = new Size(75, 21);
            lblTblTotal.TabIndex = 43;
            lblTblTotal.Text = "Total (=)";
            // 
            // lblTblUserTotal
            // 
            lblTblUserTotal.AutoSize = true;
            lblTblUserTotal.Location = new Point(688, 34);
            lblTblUserTotal.Name = "lblTblUserTotal";
            lblTblUserTotal.Size = new Size(12, 15);
            lblTblUserTotal.TabIndex = 28;
            lblTblUserTotal.Text = "-";
            // 
            // lblTblIRRF
            // 
            lblTblIRRF.AutoSize = true;
            lblTblIRRF.BackColor = Color.Transparent;
            lblTblIRRF.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTblIRRF.ForeColor = SystemColors.Window;
            lblTblIRRF.Location = new Point(604, 1);
            lblTblIRRF.Name = "lblTblIRRF";
            lblTblIRRF.Size = new Size(65, 21);
            lblTblIRRF.TabIndex = 18;
            lblTblIRRF.Text = "IRRF (-)";
            // 
            // lblTblUserIRRF
            // 
            lblTblUserIRRF.AutoSize = true;
            lblTblUserIRRF.Location = new Point(604, 34);
            lblTblUserIRRF.Name = "lblTblUserIRRF";
            lblTblUserIRRF.Size = new Size(12, 15);
            lblTblUserIRRF.TabIndex = 41;
            lblTblUserIRRF.Text = "-";
            // 
            // lblTblINSS
            // 
            lblTblINSS.AutoSize = true;
            lblTblINSS.BackColor = Color.Transparent;
            lblTblINSS.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTblINSS.ForeColor = SystemColors.Window;
            lblTblINSS.Location = new Point(523, 1);
            lblTblINSS.Name = "lblTblINSS";
            lblTblINSS.Size = new Size(68, 21);
            lblTblINSS.TabIndex = 17;
            lblTblINSS.Text = "INSS (-)";
            // 
            // lblTblUserINSS
            // 
            lblTblUserINSS.AutoSize = true;
            lblTblUserINSS.Location = new Point(523, 34);
            lblTblUserINSS.Name = "lblTblUserINSS";
            lblTblUserINSS.Size = new Size(12, 15);
            lblTblUserINSS.TabIndex = 40;
            lblTblUserINSS.Text = "-";
            // 
            // lblTblHorasExtras
            // 
            lblTblHorasExtras.AutoSize = true;
            lblTblHorasExtras.BackColor = Color.Transparent;
            lblTblHorasExtras.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTblHorasExtras.ForeColor = SystemColors.Window;
            lblTblHorasExtras.Location = new Point(384, 1);
            lblTblHorasExtras.Name = "lblTblHorasExtras";
            lblTblHorasExtras.Size = new Size(131, 21);
            lblTblHorasExtras.TabIndex = 16;
            lblTblHorasExtras.Text = "Horas Extras (+)";
            // 
            // lblTblUserHorasExtras
            // 
            lblTblUserHorasExtras.AutoSize = true;
            lblTblUserHorasExtras.Location = new Point(384, 34);
            lblTblUserHorasExtras.Name = "lblTblUserHorasExtras";
            lblTblUserHorasExtras.Size = new Size(13, 15);
            lblTblUserHorasExtras.TabIndex = 42;
            lblTblUserHorasExtras.Text = "0";
            // 
            // lblTblSalarioBaseMensal
            // 
            lblTblSalarioBaseMensal.AutoSize = true;
            lblTblSalarioBaseMensal.BackColor = Color.Transparent;
            lblTblSalarioBaseMensal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTblSalarioBaseMensal.ForeColor = SystemColors.Window;
            lblTblSalarioBaseMensal.Location = new Point(244, 1);
            lblTblSalarioBaseMensal.Name = "lblTblSalarioBaseMensal";
            lblTblSalarioBaseMensal.Size = new Size(129, 21);
            lblTblSalarioBaseMensal.TabIndex = 15;
            lblTblSalarioBaseMensal.Text = "Salário Base (+)";
            // 
            // lblTblUserSalarioBase
            // 
            lblTblUserSalarioBase.AutoSize = true;
            lblTblUserSalarioBase.Location = new Point(244, 34);
            lblTblUserSalarioBase.Name = "lblTblUserSalarioBase";
            lblTblUserSalarioBase.Size = new Size(13, 15);
            lblTblUserSalarioBase.TabIndex = 39;
            lblTblUserSalarioBase.Text = "0";
            // 
            // lblSalarioBase
            // 
            lblSalarioBase.AutoSize = true;
            lblSalarioBase.Location = new Point(86, 211);
            lblSalarioBase.Name = "lblSalarioBase";
            lblSalarioBase.Size = new Size(72, 15);
            lblSalarioBase.TabIndex = 20;
            lblSalarioBase.Text = "Salário Base:";
            // 
            // lblHorasExtras
            // 
            lblHorasExtras.AutoSize = true;
            lblHorasExtras.Location = new Point(86, 235);
            lblHorasExtras.Name = "lblHorasExtras";
            lblHorasExtras.Size = new Size(75, 15);
            lblHorasExtras.TabIndex = 23;
            lblHorasExtras.Text = "Horas Extras:";
            // 
            // cbxHorasExtras
            // 
            cbxHorasExtras.FormattingEnabled = true;
            cbxHorasExtras.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60" });
            cbxHorasExtras.Location = new Point(165, 233);
            cbxHorasExtras.Name = "cbxHorasExtras";
            cbxHorasExtras.Size = new Size(40, 23);
            cbxHorasExtras.TabIndex = 1;
            cbxHorasExtras.Text = "0";
            // 
            // lblMensagem
            // 
            lblMensagem.AutoSize = true;
            lblMensagem.ForeColor = Color.Red;
            lblMensagem.Location = new Point(268, 148);
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Size = new Size(0, 15);
            lblMensagem.TabIndex = 16;
            // 
            // lblMensagemCalculo
            // 
            lblMensagemCalculo.AutoSize = true;
            lblMensagemCalculo.Location = new Point(485, 449);
            lblMensagemCalculo.Name = "lblMensagemCalculo";
            lblMensagemCalculo.Size = new Size(0, 15);
            lblMensagemCalculo.TabIndex = 19;
            // 
            // gpbLinha
            // 
            gpbLinha.BackColor = SystemColors.Control;
            gpbLinha.ForeColor = SystemColors.ControlLight;
            gpbLinha.Location = new Point(82, 273);
            gpbLinha.Name = "gpbLinha";
            gpbLinha.Size = new Size(709, 11);
            gpbLinha.TabIndex = 20;
            gpbLinha.TabStop = false;
            // 
            // btnVoltar
            // 
            btnVoltar.Cursor = Cursors.Hand;
            btnVoltar.Image = Properties.Resources.botao_voltar;
            btnVoltar.Location = new Point(11, 8);
            btnVoltar.Margin = new Padding(3, 2, 3, 2);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(45, 39);
            btnVoltar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnVoltar.TabIndex = 21;
            btnVoltar.TabStop = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(50, 130, 184);
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscar.ForeColor = SystemColors.ButtonHighlight;
            btnBuscar.Location = new Point(620, 68);
            btnBuscar.Margin = new Padding(0);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(98, 31);
            btnBuscar.TabIndex = 22;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.FromArgb(50, 130, 184);
            btnCalcular.Cursor = Cursors.Hand;
            btnCalcular.FlatAppearance.BorderSize = 0;
            btnCalcular.FlatStyle = FlatStyle.Flat;
            btnCalcular.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCalcular.ForeColor = SystemColors.ButtonHighlight;
            btnCalcular.Location = new Point(221, 233);
            btnCalcular.Margin = new Padding(0);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(69, 23);
            btnCalcular.TabIndex = 22;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnGerarFolha
            // 
            btnGerarFolha.BackColor = Color.FromArgb(50, 130, 184);
            btnGerarFolha.Cursor = Cursors.Hand;
            btnGerarFolha.FlatAppearance.BorderSize = 0;
            btnGerarFolha.FlatStyle = FlatStyle.Flat;
            btnGerarFolha.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnGerarFolha.ForeColor = SystemColors.ButtonHighlight;
            btnGerarFolha.Location = new Point(701, 430);
            btnGerarFolha.Margin = new Padding(0);
            btnGerarFolha.Name = "btnGerarFolha";
            btnGerarFolha.Size = new Size(116, 34);
            btnGerarFolha.TabIndex = 24;
            btnGerarFolha.Text = "Gerar folha";
            btnGerarFolha.UseVisualStyleBackColor = false;
            btnGerarFolha.Click += btnGerarFolha_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Window;
            panel3.Controls.Add(imgLupa);
            panel3.Controls.Add(txbNomeID);
            panel3.Location = new Point(249, 69);
            panel3.Name = "panel3";
            panel3.Size = new Size(345, 30);
            panel3.TabIndex = 26;
            // 
            // imgLupa
            // 
            imgLupa.Cursor = Cursors.Hand;
            imgLupa.Image = Properties.Resources.search_button;
            imgLupa.Location = new Point(308, 3);
            imgLupa.Name = "imgLupa";
            imgLupa.Size = new Size(36, 25);
            imgLupa.SizeMode = PictureBoxSizeMode.Zoom;
            imgLupa.TabIndex = 4;
            imgLupa.TabStop = false;
            imgLupa.Click += imgLupa_Click;
            // 
            // txbNomeID
            // 
            txbNomeID.BorderStyle = BorderStyle.None;
            txbNomeID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txbNomeID.Location = new Point(3, 3);
            txbNomeID.Margin = new Padding(3, 2, 3, 2);
            txbNomeID.MinimumSize = new Size(100, 25);
            txbNomeID.Name = "txbNomeID";
            txbNomeID.PlaceholderText = "Nome ou ID";
            txbNomeID.Size = new Size(299, 25);
            txbNomeID.TabIndex = 3;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(50, 130, 184);
            panel9.Controls.Add(label9);
            panel9.Controls.Add(btnVoltar);
            panel9.Location = new Point(1, 1);
            panel9.Name = "panel9";
            panel9.Size = new Size(874, 57);
            panel9.TabIndex = 27;
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.Window;
            label9.Location = new Point(283, 8);
            label9.Name = "label9";
            label9.Size = new Size(267, 43);
            label9.TabIndex = 8;
            label9.Text = "Gerar folha de pagamento";
            label9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.ForeColor = SystemColors.ControlLight;
            groupBox1.Location = new Point(82, 108);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(709, 11);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            // 
            // lblDadosColaborador
            // 
            lblDadosColaborador.AutoSize = true;
            lblDadosColaborador.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblDadosColaborador.Location = new Point(83, 122);
            lblDadosColaborador.Name = "lblDadosColaborador";
            lblDadosColaborador.Size = new Size(162, 20);
            lblDadosColaborador.TabIndex = 28;
            lblDadosColaborador.Text = "Dados do Colaborador";
            // 
            // lblResultadoSalarioBase
            // 
            lblResultadoSalarioBase.AutoSize = true;
            lblResultadoSalarioBase.Location = new Point(164, 211);
            lblResultadoSalarioBase.Name = "lblResultadoSalarioBase";
            lblResultadoSalarioBase.Size = new Size(12, 15);
            lblResultadoSalarioBase.TabIndex = 29;
            lblResultadoSalarioBase.Text = "-";
            // 
            // frmGerarFolhaPagamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(876, 541);
            Controls.Add(lblResultadoSalarioBase);
            Controls.Add(cbxHorasExtras);
            Controls.Add(lblDadosColaborador);
            Controls.Add(groupBox1);
            Controls.Add(panel9);
            Controls.Add(panel3);
            Controls.Add(btnGerarFolha);
            Controls.Add(btnCalcular);
            Controls.Add(btnBuscar);
            Controls.Add(gpbLinha);
            Controls.Add(lblSalarioBase);
            Controls.Add(lblMensagemCalculo);
            Controls.Add(lblHorasExtras);
            Controls.Add(lblMensagem);
            Controls.Add(tblDadosFolhaPagamento);
            Controls.Add(lblNomeColaborador);
            Controls.Add(lblResultadoNomeColaborador);
            Controls.Add(lblFuncao);
            Controls.Add(lblResultadoFuncao);
            Controls.Add(lblResultadoCNPJ);
            Controls.Add(lblCNPJ);
            Controls.Add(lblResultadoNomeEmpresa);
            Controls.Add(lblNomeEmpresa);
            Controls.Add(lblSelecionarColaborador);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmGerarFolhaPagamento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gerar Folha de Pagamento";
            Load += frmGerarFolhaPagamento_Load;
            tblDadosFolhaPagamento.ResumeLayout(false);
            tblDadosFolhaPagamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnVoltar).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgLupa).EndInit();
            panel9.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ImageList imageList1;
        private Label lblSelecionarColaborador;
        private Label lblNomeEmpresa;
        private Label lblResultadoNomeEmpresa;
        private Label lblCNPJ;
        private Label lblResultadoCNPJ;
        private Label lblNomeColaborador;
        private Label lblResultadoNomeColaborador;
        private Label lblFuncao;
        private Label lblResultadoFuncao;
        private TableLayoutPanel tblDadosFolhaPagamento;
        private Label lblCOD04;
        private Label lblCOD01;
        private Label lblSalarioBase;
        private Label lblRefSalario;
        private Label lblCOD02;
        private Label lblHorasExtras;
        private Label lblCOD03;
        private Label lblINSS;
        private Label lblIRPF;
        private Label lblTblUserTotal;
        private Button btnGerarFolha;
        private Label lblTblUserSalarioBase;
        private Label lblMensagem;
        private Label lblTblUserINSS;
        private Label lblTblUserIRRF;
        private Label lblMensagemCalculo;
        private GroupBox gpbLinha;
        private PictureBox btnVoltar;
        private ComboBox cbxHorasExtras;
        private Button btnBuscar;
        private Button btnCalcular;
        private Button button1;
        private Label lblTblINSS;
        private Label lblTblHorasExtras;
        private Label lblTblID;
        private Label lblTblSalarioBaseMensal;
        private Label lblTblIRRF;
        private Panel panel3;
        private PictureBox imgLupa;
        private TextBox txbNomeID;
        private Panel panel9;
        private Label label9;
        private Label lblTblUserHorasExtras;
        private GroupBox groupBox1;
        private Label lblDadosColaborador;
        private Label lblTblTotal;
        private Label lblTblnome;
        private Label lblTblUserNome;
        private Label lblTblUserID;
        private Label lblResultadoSalarioBase;
    }
}