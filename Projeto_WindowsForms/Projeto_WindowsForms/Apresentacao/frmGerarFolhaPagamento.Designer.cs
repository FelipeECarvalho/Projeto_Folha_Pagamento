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
            gbxHorasExtras = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            cbxHorasExtras = new ComboBox();
            lblHorasExtrasVencimentos = new Label();
            lblCOD04 = new Label();
            lblVencimentos = new Label();
            lblREF = new Label();
            lblCOD = new Label();
            lblDescricao = new Label();
            lblDescontos = new Label();
            lblCOD01 = new Label();
            lblSalarioBase = new Label();
            lblREF536 = new Label();
            lblCOD02 = new Label();
            lblHorasExtras = new Label();
            lblREF382 = new Label();
            lblCOD03 = new Label();
            lblINSS = new Label();
            lblREF617 = new Label();
            lblIRPF = new Label();
            lblREF194 = new Label();
            lblSalarioBaseVencimentos = new Label();
            lblINSSDesconto = new Label();
            lblIRPFDesconto = new Label();
            tblResultadoFolhaPagamento = new TableLayoutPanel();
            lblResultadoValorLiquido = new Label();
            lblResultadoDescontosTotais = new Label();
            lblResultadoVencimentosTotais = new Label();
            lblValorLiquido = new Label();
            lblDescontosTotais = new Label();
            lblVencimentosTotais = new Label();
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
            tblDadosFolhaPagamento.SuspendLayout();
            gbxHorasExtras.SuspendLayout();
            tblResultadoFolhaPagamento.SuspendLayout();
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
            lblSelecionarColaborador.Location = new Point(83, 107);
            lblSelecionarColaborador.Name = "lblSelecionarColaborador";
            lblSelecionarColaborador.Size = new Size(159, 20);
            lblSelecionarColaborador.TabIndex = 2;
            lblSelecionarColaborador.Text = "Pesquisar colaborador:";
            // 
            // lblNomeEmpresa
            // 
            lblNomeEmpresa.AutoSize = true;
            lblNomeEmpresa.Location = new Point(82, 169);
            lblNomeEmpresa.Name = "lblNomeEmpresa";
            lblNomeEmpresa.Size = new Size(107, 15);
            lblNomeEmpresa.TabIndex = 5;
            lblNomeEmpresa.Text = "Nome da Empresa:";
            // 
            // lblResultadoNomeEmpresa
            // 
            lblResultadoNomeEmpresa.AutoSize = true;
            lblResultadoNomeEmpresa.Location = new Point(195, 169);
            lblResultadoNomeEmpresa.Name = "lblResultadoNomeEmpresa";
            lblResultadoNomeEmpresa.Size = new Size(12, 15);
            lblResultadoNomeEmpresa.TabIndex = 6;
            lblResultadoNomeEmpresa.Text = "-";
            // 
            // lblCNPJ
            // 
            lblCNPJ.AutoSize = true;
            lblCNPJ.Location = new Point(82, 190);
            lblCNPJ.Name = "lblCNPJ";
            lblCNPJ.Size = new Size(37, 15);
            lblCNPJ.TabIndex = 7;
            lblCNPJ.Text = "CNPJ:";
            // 
            // lblResultadoCNPJ
            // 
            lblResultadoCNPJ.AutoSize = true;
            lblResultadoCNPJ.Location = new Point(125, 190);
            lblResultadoCNPJ.Name = "lblResultadoCNPJ";
            lblResultadoCNPJ.Size = new Size(12, 15);
            lblResultadoCNPJ.TabIndex = 8;
            lblResultadoCNPJ.Text = "-";
            // 
            // lblNomeColaborador
            // 
            lblNomeColaborador.AutoSize = true;
            lblNomeColaborador.Location = new Point(82, 233);
            lblNomeColaborador.Name = "lblNomeColaborador";
            lblNomeColaborador.Size = new Size(129, 15);
            lblNomeColaborador.TabIndex = 12;
            lblNomeColaborador.Text = "Nome do Colaborador:";
            // 
            // lblResultadoNomeColaborador
            // 
            lblResultadoNomeColaborador.AutoSize = true;
            lblResultadoNomeColaborador.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblResultadoNomeColaborador.Location = new Point(217, 233);
            lblResultadoNomeColaborador.Name = "lblResultadoNomeColaborador";
            lblResultadoNomeColaborador.Size = new Size(12, 15);
            lblResultadoNomeColaborador.TabIndex = 11;
            lblResultadoNomeColaborador.Text = "-";
            // 
            // lblFuncao
            // 
            lblFuncao.AutoSize = true;
            lblFuncao.Location = new Point(82, 257);
            lblFuncao.Name = "lblFuncao";
            lblFuncao.Size = new Size(49, 15);
            lblFuncao.TabIndex = 10;
            lblFuncao.Text = "Função:";
            // 
            // lblResultadoFuncao
            // 
            lblResultadoFuncao.AutoSize = true;
            lblResultadoFuncao.Location = new Point(137, 257);
            lblResultadoFuncao.Name = "lblResultadoFuncao";
            lblResultadoFuncao.Size = new Size(12, 15);
            lblResultadoFuncao.TabIndex = 9;
            lblResultadoFuncao.Text = "-";
            // 
            // tblDadosFolhaPagamento
            // 
            tblDadosFolhaPagamento.BackColor = SystemColors.Window;
            tblDadosFolhaPagamento.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tblDadosFolhaPagamento.ColumnCount = 5;
            tblDadosFolhaPagamento.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.7735844F));
            tblDadosFolhaPagamento.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.22642F));
            tblDadosFolhaPagamento.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 63F));
            tblDadosFolhaPagamento.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 202F));
            tblDadosFolhaPagamento.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 128F));
            tblDadosFolhaPagamento.Controls.Add(gbxHorasExtras, 3, 2);
            tblDadosFolhaPagamento.Controls.Add(lblCOD04, 0, 4);
            tblDadosFolhaPagamento.Controls.Add(lblVencimentos, 3, 0);
            tblDadosFolhaPagamento.Controls.Add(lblREF, 2, 0);
            tblDadosFolhaPagamento.Controls.Add(lblCOD, 0, 0);
            tblDadosFolhaPagamento.Controls.Add(lblDescricao, 1, 0);
            tblDadosFolhaPagamento.Controls.Add(lblDescontos, 4, 0);
            tblDadosFolhaPagamento.Controls.Add(lblCOD01, 0, 1);
            tblDadosFolhaPagamento.Controls.Add(lblSalarioBase, 1, 1);
            tblDadosFolhaPagamento.Controls.Add(lblREF536, 2, 1);
            tblDadosFolhaPagamento.Controls.Add(lblCOD02, 0, 2);
            tblDadosFolhaPagamento.Controls.Add(lblHorasExtras, 1, 2);
            tblDadosFolhaPagamento.Controls.Add(lblREF382, 2, 2);
            tblDadosFolhaPagamento.Controls.Add(lblCOD03, 0, 3);
            tblDadosFolhaPagamento.Controls.Add(lblINSS, 1, 3);
            tblDadosFolhaPagamento.Controls.Add(lblREF617, 2, 3);
            tblDadosFolhaPagamento.Controls.Add(lblIRPF, 1, 4);
            tblDadosFolhaPagamento.Controls.Add(lblREF194, 2, 4);
            tblDadosFolhaPagamento.Controls.Add(lblSalarioBaseVencimentos, 3, 1);
            tblDadosFolhaPagamento.Controls.Add(lblINSSDesconto, 4, 3);
            tblDadosFolhaPagamento.Controls.Add(lblIRPFDesconto, 4, 4);
            tblDadosFolhaPagamento.Location = new Point(82, 293);
            tblDadosFolhaPagamento.Name = "tblDadosFolhaPagamento";
            tblDadosFolhaPagamento.RowCount = 5;
            tblDadosFolhaPagamento.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tblDadosFolhaPagamento.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblDadosFolhaPagamento.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblDadosFolhaPagamento.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblDadosFolhaPagamento.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblDadosFolhaPagamento.Size = new Size(690, 152);
            tblDadosFolhaPagamento.TabIndex = 13;
            tblDadosFolhaPagamento.CellPaint += tblDadosFolhaPagamento_CellPaint;
            // 
            // gbxHorasExtras
            // 
            gbxHorasExtras.BackColor = SystemColors.Control;
            gbxHorasExtras.BackgroundImageLayout = ImageLayout.None;
            gbxHorasExtras.Controls.Add(label2);
            gbxHorasExtras.Controls.Add(label1);
            gbxHorasExtras.Controls.Add(cbxHorasExtras);
            gbxHorasExtras.Controls.Add(lblHorasExtrasVencimentos);
            gbxHorasExtras.ForeColor = SystemColors.ControlText;
            gbxHorasExtras.Location = new Point(360, 67);
            gbxHorasExtras.Name = "gbxHorasExtras";
            gbxHorasExtras.Size = new Size(196, 23);
            gbxHorasExtras.TabIndex = 22;
            gbxHorasExtras.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(125, 4);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 3;
            label2.Text = "Valor:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(-4, 5);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 2;
            label1.Text = "Horas extras:";
            // 
            // cbxHorasExtras
            // 
            cbxHorasExtras.FormattingEnabled = true;
            cbxHorasExtras.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24" });
            cbxHorasExtras.Location = new Point(72, 0);
            cbxHorasExtras.Name = "cbxHorasExtras";
            cbxHorasExtras.Size = new Size(40, 23);
            cbxHorasExtras.TabIndex = 1;
            cbxHorasExtras.Text = "0";
            cbxHorasExtras.SelectedIndexChanged += cbxHorasExtras_SelectedIndexChanged;
            // 
            // lblHorasExtrasVencimentos
            // 
            lblHorasExtrasVencimentos.AutoSize = true;
            lblHorasExtrasVencimentos.Location = new Point(160, 5);
            lblHorasExtrasVencimentos.Name = "lblHorasExtrasVencimentos";
            lblHorasExtrasVencimentos.Size = new Size(13, 15);
            lblHorasExtrasVencimentos.TabIndex = 0;
            lblHorasExtrasVencimentos.Text = "0";
            // 
            // lblCOD04
            // 
            lblCOD04.AutoSize = true;
            lblCOD04.Location = new Point(4, 124);
            lblCOD04.Name = "lblCOD04";
            lblCOD04.Size = new Size(27, 15);
            lblCOD04.TabIndex = 28;
            lblCOD04.Text = "[04]";
            // 
            // lblVencimentos
            // 
            lblVencimentos.AutoSize = true;
            lblVencimentos.BackColor = Color.Transparent;
            lblVencimentos.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblVencimentos.ForeColor = SystemColors.Window;
            lblVencimentos.Location = new Point(360, 1);
            lblVencimentos.Name = "lblVencimentos";
            lblVencimentos.Size = new Size(109, 21);
            lblVencimentos.TabIndex = 17;
            lblVencimentos.Text = "Vencimentos";
            // 
            // lblREF
            // 
            lblREF.AutoSize = true;
            lblREF.BackColor = Color.Transparent;
            lblREF.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblREF.ForeColor = SystemColors.Window;
            lblREF.Location = new Point(296, 1);
            lblREF.Name = "lblREF";
            lblREF.Size = new Size(37, 21);
            lblREF.TabIndex = 16;
            lblREF.Text = "REF";
            // 
            // lblCOD
            // 
            lblCOD.AutoSize = true;
            lblCOD.BackColor = Color.Transparent;
            lblCOD.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCOD.ForeColor = SystemColors.Window;
            lblCOD.Location = new Point(4, 1);
            lblCOD.Name = "lblCOD";
            lblCOD.Size = new Size(44, 21);
            lblCOD.TabIndex = 14;
            lblCOD.Text = "COD";
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.BackColor = Color.Transparent;
            lblDescricao.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDescricao.ForeColor = SystemColors.Window;
            lblDescricao.Location = new Point(88, 1);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(84, 21);
            lblDescricao.TabIndex = 15;
            lblDescricao.Text = "Descrição";
            // 
            // lblDescontos
            // 
            lblDescontos.AutoSize = true;
            lblDescontos.BackColor = Color.Transparent;
            lblDescontos.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDescontos.ForeColor = SystemColors.Window;
            lblDescontos.Location = new Point(563, 1);
            lblDescontos.Name = "lblDescontos";
            lblDescontos.Size = new Size(89, 21);
            lblDescontos.TabIndex = 18;
            lblDescontos.Text = "Descontos";
            // 
            // lblCOD01
            // 
            lblCOD01.AutoSize = true;
            lblCOD01.Location = new Point(4, 34);
            lblCOD01.Name = "lblCOD01";
            lblCOD01.Size = new Size(27, 15);
            lblCOD01.TabIndex = 19;
            lblCOD01.Text = "[01]";
            // 
            // lblSalarioBase
            // 
            lblSalarioBase.AutoSize = true;
            lblSalarioBase.Location = new Point(88, 34);
            lblSalarioBase.Name = "lblSalarioBase";
            lblSalarioBase.Size = new Size(69, 15);
            lblSalarioBase.TabIndex = 20;
            lblSalarioBase.Text = "Salário Base";
            // 
            // lblREF536
            // 
            lblREF536.AutoSize = true;
            lblREF536.Location = new Point(296, 34);
            lblREF536.Name = "lblREF536";
            lblREF536.Size = new Size(25, 15);
            lblREF536.TabIndex = 21;
            lblREF536.Text = "536";
            // 
            // lblCOD02
            // 
            lblCOD02.AutoSize = true;
            lblCOD02.Location = new Point(4, 64);
            lblCOD02.Name = "lblCOD02";
            lblCOD02.Size = new Size(27, 15);
            lblCOD02.TabIndex = 22;
            lblCOD02.Text = "[02]";
            // 
            // lblHorasExtras
            // 
            lblHorasExtras.AutoSize = true;
            lblHorasExtras.Location = new Point(88, 64);
            lblHorasExtras.Name = "lblHorasExtras";
            lblHorasExtras.Size = new Size(72, 15);
            lblHorasExtras.TabIndex = 23;
            lblHorasExtras.Text = "Horas Extras";
            // 
            // lblREF382
            // 
            lblREF382.AutoSize = true;
            lblREF382.Location = new Point(296, 64);
            lblREF382.Name = "lblREF382";
            lblREF382.Size = new Size(25, 15);
            lblREF382.TabIndex = 24;
            lblREF382.Text = "382";
            // 
            // lblCOD03
            // 
            lblCOD03.AutoSize = true;
            lblCOD03.Location = new Point(4, 94);
            lblCOD03.Name = "lblCOD03";
            lblCOD03.Size = new Size(27, 15);
            lblCOD03.TabIndex = 25;
            lblCOD03.Text = "[03]";
            // 
            // lblINSS
            // 
            lblINSS.AutoSize = true;
            lblINSS.Location = new Point(88, 94);
            lblINSS.Name = "lblINSS";
            lblINSS.Size = new Size(31, 15);
            lblINSS.TabIndex = 26;
            lblINSS.Text = "INSS";
            // 
            // lblREF617
            // 
            lblREF617.AutoSize = true;
            lblREF617.Location = new Point(296, 94);
            lblREF617.Name = "lblREF617";
            lblREF617.Size = new Size(25, 15);
            lblREF617.TabIndex = 27;
            lblREF617.Text = "617";
            // 
            // lblIRPF
            // 
            lblIRPF.AutoSize = true;
            lblIRPF.Location = new Point(88, 124);
            lblIRPF.Name = "lblIRPF";
            lblIRPF.Size = new Size(29, 15);
            lblIRPF.TabIndex = 29;
            lblIRPF.Text = "IRFF";
            // 
            // lblREF194
            // 
            lblREF194.AutoSize = true;
            lblREF194.Location = new Point(296, 124);
            lblREF194.Name = "lblREF194";
            lblREF194.Size = new Size(25, 15);
            lblREF194.TabIndex = 30;
            lblREF194.Text = "194";
            // 
            // lblSalarioBaseVencimentos
            // 
            lblSalarioBaseVencimentos.AutoSize = true;
            lblSalarioBaseVencimentos.Location = new Point(360, 34);
            lblSalarioBaseVencimentos.Name = "lblSalarioBaseVencimentos";
            lblSalarioBaseVencimentos.Size = new Size(13, 15);
            lblSalarioBaseVencimentos.TabIndex = 39;
            lblSalarioBaseVencimentos.Text = "0";
            // 
            // lblINSSDesconto
            // 
            lblINSSDesconto.AutoSize = true;
            lblINSSDesconto.Location = new Point(563, 94);
            lblINSSDesconto.Name = "lblINSSDesconto";
            lblINSSDesconto.Size = new Size(12, 15);
            lblINSSDesconto.TabIndex = 40;
            lblINSSDesconto.Text = "-";
            // 
            // lblIRPFDesconto
            // 
            lblIRPFDesconto.AutoSize = true;
            lblIRPFDesconto.Location = new Point(563, 124);
            lblIRPFDesconto.Name = "lblIRPFDesconto";
            lblIRPFDesconto.Size = new Size(12, 15);
            lblIRPFDesconto.TabIndex = 41;
            lblIRPFDesconto.Text = "-";
            // 
            // tblResultadoFolhaPagamento
            // 
            tblResultadoFolhaPagamento.BackColor = SystemColors.Window;
            tblResultadoFolhaPagamento.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tblResultadoFolhaPagamento.ColumnCount = 3;
            tblResultadoFolhaPagamento.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 53.9726028F));
            tblResultadoFolhaPagamento.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46.0273972F));
            tblResultadoFolhaPagamento.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 154F));
            tblResultadoFolhaPagamento.Controls.Add(lblResultadoValorLiquido, 2, 1);
            tblResultadoFolhaPagamento.Controls.Add(lblResultadoDescontosTotais, 1, 1);
            tblResultadoFolhaPagamento.Controls.Add(lblResultadoVencimentosTotais, 0, 1);
            tblResultadoFolhaPagamento.Controls.Add(lblValorLiquido, 2, 0);
            tblResultadoFolhaPagamento.Controls.Add(lblDescontosTotais, 1, 0);
            tblResultadoFolhaPagamento.Controls.Add(lblVencimentosTotais, 0, 0);
            tblResultadoFolhaPagamento.Location = new Point(82, 533);
            tblResultadoFolhaPagamento.Name = "tblResultadoFolhaPagamento";
            tblResultadoFolhaPagamento.RowCount = 2;
            tblResultadoFolhaPagamento.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tblResultadoFolhaPagamento.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblResultadoFolhaPagamento.Size = new Size(559, 61);
            tblResultadoFolhaPagamento.TabIndex = 14;
            tblResultadoFolhaPagamento.CellPaint += tblResultadoFolhaPagamento_CellPaint;
            // 
            // lblResultadoValorLiquido
            // 
            lblResultadoValorLiquido.AutoSize = true;
            lblResultadoValorLiquido.Location = new Point(406, 34);
            lblResultadoValorLiquido.Name = "lblResultadoValorLiquido";
            lblResultadoValorLiquido.Size = new Size(12, 15);
            lblResultadoValorLiquido.TabIndex = 28;
            lblResultadoValorLiquido.Text = "-";
            // 
            // lblResultadoDescontosTotais
            // 
            lblResultadoDescontosTotais.AutoSize = true;
            lblResultadoDescontosTotais.Location = new Point(221, 34);
            lblResultadoDescontosTotais.Name = "lblResultadoDescontosTotais";
            lblResultadoDescontosTotais.Size = new Size(12, 15);
            lblResultadoDescontosTotais.TabIndex = 27;
            lblResultadoDescontosTotais.Text = "-";
            // 
            // lblResultadoVencimentosTotais
            // 
            lblResultadoVencimentosTotais.AutoSize = true;
            lblResultadoVencimentosTotais.Location = new Point(4, 34);
            lblResultadoVencimentosTotais.Name = "lblResultadoVencimentosTotais";
            lblResultadoVencimentosTotais.Size = new Size(12, 15);
            lblResultadoVencimentosTotais.TabIndex = 26;
            lblResultadoVencimentosTotais.Text = "-";
            // 
            // lblValorLiquido
            // 
            lblValorLiquido.AutoSize = true;
            lblValorLiquido.BackColor = Color.Transparent;
            lblValorLiquido.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblValorLiquido.ForeColor = SystemColors.Window;
            lblValorLiquido.Location = new Point(406, 1);
            lblValorLiquido.Name = "lblValorLiquido";
            lblValorLiquido.Size = new Size(112, 21);
            lblValorLiquido.TabIndex = 25;
            lblValorLiquido.Text = "Valor Líquido";
            // 
            // lblDescontosTotais
            // 
            lblDescontosTotais.AutoSize = true;
            lblDescontosTotais.BackColor = Color.Transparent;
            lblDescontosTotais.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDescontosTotais.ForeColor = SystemColors.Window;
            lblDescontosTotais.Location = new Point(221, 1);
            lblDescontosTotais.Name = "lblDescontosTotais";
            lblDescontosTotais.Size = new Size(138, 21);
            lblDescontosTotais.TabIndex = 24;
            lblDescontosTotais.Text = "Descontos Totais";
            // 
            // lblVencimentosTotais
            // 
            lblVencimentosTotais.AutoSize = true;
            lblVencimentosTotais.BackColor = Color.Transparent;
            lblVencimentosTotais.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblVencimentosTotais.ForeColor = SystemColors.Window;
            lblVencimentosTotais.Location = new Point(4, 1);
            lblVencimentosTotais.Name = "lblVencimentosTotais";
            lblVencimentosTotais.Size = new Size(158, 21);
            lblVencimentosTotais.TabIndex = 23;
            lblVencimentosTotais.Text = "Vencimentos Totais";
            // 
            // lblMensagem
            // 
            lblMensagem.AutoSize = true;
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
            gpbLinha.Location = new Point(82, 212);
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
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscar.ForeColor = SystemColors.ButtonHighlight;
            btnBuscar.Location = new Point(620, 102);
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
            btnCalcular.FlatStyle = FlatStyle.Flat;
            btnCalcular.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnCalcular.ForeColor = SystemColors.ButtonHighlight;
            btnCalcular.Location = new Point(656, 460);
            btnCalcular.Margin = new Padding(0);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(116, 32);
            btnCalcular.TabIndex = 23;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnGerarFolha
            // 
            btnGerarFolha.BackColor = Color.FromArgb(50, 130, 184);
            btnGerarFolha.Cursor = Cursors.Hand;
            btnGerarFolha.FlatStyle = FlatStyle.Flat;
            btnGerarFolha.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnGerarFolha.ForeColor = SystemColors.ButtonHighlight;
            btnGerarFolha.Location = new Point(656, 560);
            btnGerarFolha.Margin = new Padding(0);
            btnGerarFolha.Name = "btnGerarFolha";
            btnGerarFolha.Size = new Size(116, 34);
            btnGerarFolha.TabIndex = 24;
            btnGerarFolha.Text = "Gerar folha";
            btnGerarFolha.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Window;
            panel3.Controls.Add(imgLupa);
            panel3.Controls.Add(txbNomeID);
            panel3.Location = new Point(249, 103);
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
            // frmGerarFolhaPagamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(876, 630);
            Controls.Add(panel9);
            Controls.Add(panel3);
            Controls.Add(btnGerarFolha);
            Controls.Add(btnCalcular);
            Controls.Add(btnBuscar);
            Controls.Add(gpbLinha);
            Controls.Add(lblMensagemCalculo);
            Controls.Add(lblMensagem);
            Controls.Add(tblResultadoFolhaPagamento);
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
            gbxHorasExtras.ResumeLayout(false);
            gbxHorasExtras.PerformLayout();
            tblResultadoFolhaPagamento.ResumeLayout(false);
            tblResultadoFolhaPagamento.PerformLayout();
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
        private Label lblREF536;
        private Label lblCOD02;
        private Label lblHorasExtras;
        private Label lblREF382;
        private Label lblCOD03;
        private Label lblINSS;
        private Label lblREF617;
        private Label lblIRPF;
        private Label lblREF194;
        private TableLayoutPanel tblResultadoFolhaPagamento;
        private Label lblResultadoValorLiquido;
        private Label lblResultadoDescontosTotais;
        private Label lblResultadoVencimentosTotais;
        private Label lblValorLiquido;
        private Label lblDescontosTotais;
        private Label lblVencimentosTotais;
        private Button btnGerarFolha;
        private Label lblSalarioBaseVencimentos;
        private Label lblMensagem;
        private Label lblINSSDesconto;
        private Label lblIRPFDesconto;
        private Label lblMensagemCalculo;
        private GroupBox gpbLinha;
        private PictureBox btnVoltar;
        private GroupBox gbxHorasExtras;
        private ComboBox cbxHorasExtras;
        private Label lblHorasExtrasVencimentos;
        private Label label1;
        private Label label2;
        private Button btnBuscar;
        private Button btnCalcular;
        private Button button1;
        private Label lblVencimentos;
        private Label lblREF;
        private Label lblCOD;
        private Label lblDescricao;
        private Label lblDescontos;
        private Panel panel3;
        private PictureBox imgLupa;
        private TextBox txbNomeID;
        private Panel panel9;
        private Label label9;
    }
}