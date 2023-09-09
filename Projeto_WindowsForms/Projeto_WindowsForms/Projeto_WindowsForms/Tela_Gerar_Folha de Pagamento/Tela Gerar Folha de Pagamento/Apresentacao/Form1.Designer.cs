namespace Tela_Gerar_Folha_de_Pagamento
{
    partial class frmGerarFolha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGerarFolha));
            lblTitulo = new Label();
            imageList1 = new ImageList(components);
            imgSetaEsquerda = new PictureBox();
            lblSelecionarColaborador = new Label();
            txbNomeID = new TextBox();
            imgLupa = new PictureBox();
            lblNomeEmpresa = new Label();
            lblResultadoNomeEmpresa = new Label();
            lblCNPJ = new Label();
            lblResultadoCNPJ = new Label();
            lblNomeColaborador = new Label();
            lblResultadoNomeColaborador = new Label();
            lblFuncao = new Label();
            lblResultadoFuncao = new Label();
            tblDadosFolhaPagamento = new TableLayoutPanel();
            txbHorasExtrasVencimentos = new TextBox();
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
            btnGerarFolha = new Button();
            lblMensagem = new Label();
            btnBuscar = new Button();
            btnCalcular = new Button();
            lblMensagemCalculo = new Label();
            gpbLinha = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)imgSetaEsquerda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgLupa).BeginInit();
            tblDadosFolhaPagamento.SuspendLayout();
            tblResultadoFolhaPagamento.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(289, 34);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(263, 28);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Gerar Folha de Pagamento";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // imgSetaEsquerda
            // 
            imgSetaEsquerda.Image = (Image)resources.GetObject("imgSetaEsquerda.Image");
            imgSetaEsquerda.InitialImage = (Image)resources.GetObject("imgSetaEsquerda.InitialImage");
            imgSetaEsquerda.Location = new Point(12, 12);
            imgSetaEsquerda.Name = "imgSetaEsquerda";
            imgSetaEsquerda.Size = new Size(50, 50);
            imgSetaEsquerda.TabIndex = 1;
            imgSetaEsquerda.TabStop = false;
            // 
            // lblSelecionarColaborador
            // 
            lblSelecionarColaborador.AutoSize = true;
            lblSelecionarColaborador.Location = new Point(119, 115);
            lblSelecionarColaborador.Name = "lblSelecionarColaborador";
            lblSelecionarColaborador.Size = new Size(131, 15);
            lblSelecionarColaborador.TabIndex = 2;
            lblSelecionarColaborador.Text = "Selecionar colaborador:";
            // 
            // txbNomeID
            // 
            txbNomeID.Location = new Point(256, 112);
            txbNomeID.Name = "txbNomeID";
            txbNomeID.PlaceholderText = "Nome ou ID";
            txbNomeID.Size = new Size(302, 23);
            txbNomeID.TabIndex = 3;
            // 
            // imgLupa
            // 
            imgLupa.Image = (Image)resources.GetObject("imgLupa.Image");
            imgLupa.Location = new Point(564, 111);
            imgLupa.Name = "imgLupa";
            imgLupa.Size = new Size(24, 24);
            imgLupa.SizeMode = PictureBoxSizeMode.Zoom;
            imgLupa.TabIndex = 4;
            imgLupa.TabStop = false;
            imgLupa.Click += imgLupa_Click;
            imgLupa.MouseEnter += imgLupa_MouseEnter;
            imgLupa.MouseLeave += imgLupa_MouseLeave;
            // 
            // lblNomeEmpresa
            // 
            lblNomeEmpresa.AutoSize = true;
            lblNomeEmpresa.Location = new Point(42, 150);
            lblNomeEmpresa.Name = "lblNomeEmpresa";
            lblNomeEmpresa.Size = new Size(107, 15);
            lblNomeEmpresa.TabIndex = 5;
            lblNomeEmpresa.Text = "Nome da Empresa:";
            // 
            // lblResultadoNomeEmpresa
            // 
            lblResultadoNomeEmpresa.AutoSize = true;
            lblResultadoNomeEmpresa.Location = new Point(155, 150);
            lblResultadoNomeEmpresa.Name = "lblResultadoNomeEmpresa";
            lblResultadoNomeEmpresa.Size = new Size(12, 15);
            lblResultadoNomeEmpresa.TabIndex = 6;
            lblResultadoNomeEmpresa.Text = "-";
            // 
            // lblCNPJ
            // 
            lblCNPJ.AutoSize = true;
            lblCNPJ.Location = new Point(42, 171);
            lblCNPJ.Name = "lblCNPJ";
            lblCNPJ.Size = new Size(37, 15);
            lblCNPJ.TabIndex = 7;
            lblCNPJ.Text = "CNPJ:";
            // 
            // lblResultadoCNPJ
            // 
            lblResultadoCNPJ.AutoSize = true;
            lblResultadoCNPJ.Location = new Point(85, 171);
            lblResultadoCNPJ.Name = "lblResultadoCNPJ";
            lblResultadoCNPJ.Size = new Size(12, 15);
            lblResultadoCNPJ.TabIndex = 8;
            lblResultadoCNPJ.Text = "-";
            // 
            // lblNomeColaborador
            // 
            lblNomeColaborador.AutoSize = true;
            lblNomeColaborador.Location = new Point(42, 214);
            lblNomeColaborador.Name = "lblNomeColaborador";
            lblNomeColaborador.Size = new Size(129, 15);
            lblNomeColaborador.TabIndex = 12;
            lblNomeColaborador.Text = "Nome do Colaborador:";
            // 
            // lblResultadoNomeColaborador
            // 
            lblResultadoNomeColaborador.AutoSize = true;
            lblResultadoNomeColaborador.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblResultadoNomeColaborador.Location = new Point(177, 214);
            lblResultadoNomeColaborador.Name = "lblResultadoNomeColaborador";
            lblResultadoNomeColaborador.Size = new Size(12, 15);
            lblResultadoNomeColaborador.TabIndex = 11;
            lblResultadoNomeColaborador.Text = "-";
            // 
            // lblFuncao
            // 
            lblFuncao.AutoSize = true;
            lblFuncao.Location = new Point(42, 238);
            lblFuncao.Name = "lblFuncao";
            lblFuncao.Size = new Size(49, 15);
            lblFuncao.TabIndex = 10;
            lblFuncao.Text = "Função:";
            // 
            // lblResultadoFuncao
            // 
            lblResultadoFuncao.AutoSize = true;
            lblResultadoFuncao.Location = new Point(97, 238);
            lblResultadoFuncao.Name = "lblResultadoFuncao";
            lblResultadoFuncao.Size = new Size(12, 15);
            lblResultadoFuncao.TabIndex = 9;
            lblResultadoFuncao.Text = "-";
            // 
            // tblDadosFolhaPagamento
            // 
            tblDadosFolhaPagamento.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tblDadosFolhaPagamento.ColumnCount = 5;
            tblDadosFolhaPagamento.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.7735844F));
            tblDadosFolhaPagamento.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.22642F));
            tblDadosFolhaPagamento.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 66F));
            tblDadosFolhaPagamento.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 141F));
            tblDadosFolhaPagamento.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 140F));
            tblDadosFolhaPagamento.Controls.Add(txbHorasExtrasVencimentos, 3, 2);
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
            tblDadosFolhaPagamento.Location = new Point(60, 286);
            tblDadosFolhaPagamento.Name = "tblDadosFolhaPagamento";
            tblDadosFolhaPagamento.RowCount = 5;
            tblDadosFolhaPagamento.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tblDadosFolhaPagamento.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblDadosFolhaPagamento.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblDadosFolhaPagamento.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblDadosFolhaPagamento.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblDadosFolhaPagamento.Size = new Size(672, 152);
            tblDadosFolhaPagamento.TabIndex = 13;
            // 
            // txbHorasExtrasVencimentos
            // 
            txbHorasExtrasVencimentos.Location = new Point(391, 67);
            txbHorasExtrasVencimentos.Name = "txbHorasExtrasVencimentos";
            txbHorasExtrasVencimentos.Size = new Size(135, 23);
            txbHorasExtrasVencimentos.TabIndex = 33;
            txbHorasExtrasVencimentos.Text = "0";
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
            lblVencimentos.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblVencimentos.Location = new Point(391, 1);
            lblVencimentos.Name = "lblVencimentos";
            lblVencimentos.Size = new Size(109, 21);
            lblVencimentos.TabIndex = 17;
            lblVencimentos.Text = "Vencimentos";
            // 
            // lblREF
            // 
            lblREF.AutoSize = true;
            lblREF.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblREF.Location = new Point(324, 1);
            lblREF.Name = "lblREF";
            lblREF.Size = new Size(37, 21);
            lblREF.TabIndex = 16;
            lblREF.Text = "REF";
            // 
            // lblCOD
            // 
            lblCOD.AutoSize = true;
            lblCOD.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCOD.Location = new Point(4, 1);
            lblCOD.Name = "lblCOD";
            lblCOD.Size = new Size(44, 21);
            lblCOD.TabIndex = 14;
            lblCOD.Text = "COD";
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDescricao.Location = new Point(96, 1);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(84, 21);
            lblDescricao.TabIndex = 15;
            lblDescricao.Text = "Descrição";
            // 
            // lblDescontos
            // 
            lblDescontos.AutoSize = true;
            lblDescontos.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDescontos.Location = new Point(533, 1);
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
            lblSalarioBase.Location = new Point(96, 34);
            lblSalarioBase.Name = "lblSalarioBase";
            lblSalarioBase.Size = new Size(69, 15);
            lblSalarioBase.TabIndex = 20;
            lblSalarioBase.Text = "Salário Base";
            // 
            // lblREF536
            // 
            lblREF536.AutoSize = true;
            lblREF536.Location = new Point(324, 34);
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
            lblHorasExtras.Location = new Point(96, 64);
            lblHorasExtras.Name = "lblHorasExtras";
            lblHorasExtras.Size = new Size(72, 15);
            lblHorasExtras.TabIndex = 23;
            lblHorasExtras.Text = "Horas Extras";
            // 
            // lblREF382
            // 
            lblREF382.AutoSize = true;
            lblREF382.Location = new Point(324, 64);
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
            lblINSS.Location = new Point(96, 94);
            lblINSS.Name = "lblINSS";
            lblINSS.Size = new Size(31, 15);
            lblINSS.TabIndex = 26;
            lblINSS.Text = "INSS";
            // 
            // lblREF617
            // 
            lblREF617.AutoSize = true;
            lblREF617.Location = new Point(324, 94);
            lblREF617.Name = "lblREF617";
            lblREF617.Size = new Size(25, 15);
            lblREF617.TabIndex = 27;
            lblREF617.Text = "617";
            // 
            // lblIRPF
            // 
            lblIRPF.AutoSize = true;
            lblIRPF.Location = new Point(96, 124);
            lblIRPF.Name = "lblIRPF";
            lblIRPF.Size = new Size(29, 15);
            lblIRPF.TabIndex = 29;
            lblIRPF.Text = "IRFF";
            // 
            // lblREF194
            // 
            lblREF194.AutoSize = true;
            lblREF194.Location = new Point(324, 124);
            lblREF194.Name = "lblREF194";
            lblREF194.Size = new Size(25, 15);
            lblREF194.TabIndex = 30;
            lblREF194.Text = "194";
            // 
            // lblSalarioBaseVencimentos
            // 
            lblSalarioBaseVencimentos.AutoSize = true;
            lblSalarioBaseVencimentos.Location = new Point(391, 34);
            lblSalarioBaseVencimentos.Name = "lblSalarioBaseVencimentos";
            lblSalarioBaseVencimentos.Size = new Size(13, 15);
            lblSalarioBaseVencimentos.TabIndex = 39;
            lblSalarioBaseVencimentos.Text = "0";
            // 
            // lblINSSDesconto
            // 
            lblINSSDesconto.AutoSize = true;
            lblINSSDesconto.Location = new Point(533, 94);
            lblINSSDesconto.Name = "lblINSSDesconto";
            lblINSSDesconto.Size = new Size(12, 15);
            lblINSSDesconto.TabIndex = 40;
            lblINSSDesconto.Text = "-";
            // 
            // lblIRPFDesconto
            // 
            lblIRPFDesconto.AutoSize = true;
            lblIRPFDesconto.Location = new Point(533, 124);
            lblIRPFDesconto.Name = "lblIRPFDesconto";
            lblIRPFDesconto.Size = new Size(12, 15);
            lblIRPFDesconto.TabIndex = 41;
            lblIRPFDesconto.Text = "-";
            // 
            // tblResultadoFolhaPagamento
            // 
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
            tblResultadoFolhaPagamento.Location = new Point(60, 482);
            tblResultadoFolhaPagamento.Name = "tblResultadoFolhaPagamento";
            tblResultadoFolhaPagamento.RowCount = 2;
            tblResultadoFolhaPagamento.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tblResultadoFolhaPagamento.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblResultadoFolhaPagamento.Size = new Size(541, 61);
            tblResultadoFolhaPagamento.TabIndex = 14;
            // 
            // lblResultadoValorLiquido
            // 
            lblResultadoValorLiquido.AutoSize = true;
            lblResultadoValorLiquido.Location = new Point(388, 34);
            lblResultadoValorLiquido.Name = "lblResultadoValorLiquido";
            lblResultadoValorLiquido.Size = new Size(12, 15);
            lblResultadoValorLiquido.TabIndex = 28;
            lblResultadoValorLiquido.Text = "-";
            // 
            // lblResultadoDescontosTotais
            // 
            lblResultadoDescontosTotais.AutoSize = true;
            lblResultadoDescontosTotais.Location = new Point(211, 34);
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
            lblValorLiquido.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblValorLiquido.Location = new Point(388, 1);
            lblValorLiquido.Name = "lblValorLiquido";
            lblValorLiquido.Size = new Size(112, 21);
            lblValorLiquido.TabIndex = 25;
            lblValorLiquido.Text = "Valor Líquido";
            // 
            // lblDescontosTotais
            // 
            lblDescontosTotais.AutoSize = true;
            lblDescontosTotais.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDescontosTotais.Location = new Point(211, 1);
            lblDescontosTotais.Name = "lblDescontosTotais";
            lblDescontosTotais.Size = new Size(138, 21);
            lblDescontosTotais.TabIndex = 24;
            lblDescontosTotais.Text = "Descontos Totais";
            // 
            // lblVencimentosTotais
            // 
            lblVencimentosTotais.AutoSize = true;
            lblVencimentosTotais.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblVencimentosTotais.Location = new Point(4, 1);
            lblVencimentosTotais.Name = "lblVencimentosTotais";
            lblVencimentosTotais.Size = new Size(158, 21);
            lblVencimentosTotais.TabIndex = 23;
            lblVencimentosTotais.Text = "Vencimentos Totais";
            // 
            // btnGerarFolha
            // 
            btnGerarFolha.Location = new Point(634, 506);
            btnGerarFolha.Name = "btnGerarFolha";
            btnGerarFolha.Size = new Size(98, 23);
            btnGerarFolha.TabIndex = 15;
            btnGerarFolha.Text = "Gerar Folha";
            btnGerarFolha.UseVisualStyleBackColor = true;
            // 
            // lblMensagem
            // 
            lblMensagem.AutoSize = true;
            lblMensagem.Location = new Point(489, 150);
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Size = new Size(10, 15);
            lblMensagem.TabIndex = 16;
            lblMensagem.Text = " ";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(608, 112);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 17;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(634, 444);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(98, 23);
            btnCalcular.TabIndex = 18;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblMensagemCalculo
            // 
            lblMensagemCalculo.AutoSize = true;
            lblMensagemCalculo.Location = new Point(445, 442);
            lblMensagemCalculo.Name = "lblMensagemCalculo";
            lblMensagemCalculo.Size = new Size(0, 15);
            lblMensagemCalculo.TabIndex = 19;
            // 
            // gpbLinha
            // 
            gpbLinha.BackColor = SystemColors.Control;
            gpbLinha.ForeColor = SystemColors.ControlLight;
            gpbLinha.Location = new Point(42, 193);
            gpbLinha.Name = "gpbLinha";
            gpbLinha.Size = new Size(709, 11);
            gpbLinha.TabIndex = 20;
            gpbLinha.TabStop = false;
            // 
            // frmGerarFolha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 585);
            Controls.Add(gpbLinha);
            Controls.Add(lblMensagemCalculo);
            Controls.Add(btnCalcular);
            Controls.Add(btnBuscar);
            Controls.Add(lblMensagem);
            Controls.Add(btnGerarFolha);
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
            Controls.Add(imgLupa);
            Controls.Add(txbNomeID);
            Controls.Add(lblSelecionarColaborador);
            Controls.Add(imgSetaEsquerda);
            Controls.Add(lblTitulo);
            Name = "frmGerarFolha";
            Text = "Gerar Folha de Pagamento";
            ((System.ComponentModel.ISupportInitialize)imgSetaEsquerda).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgLupa).EndInit();
            tblDadosFolhaPagamento.ResumeLayout(false);
            tblDadosFolhaPagamento.PerformLayout();
            tblResultadoFolhaPagamento.ResumeLayout(false);
            tblResultadoFolhaPagamento.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private ImageList imageList1;
        private PictureBox imgSetaEsquerda;
        private Label lblSelecionarColaborador;
        private TextBox txbNomeID;
        private PictureBox imgLupa;
        private Label lblNomeEmpresa;
        private Label lblResultadoNomeEmpresa;
        private Label lblCNPJ;
        private Label lblResultadoCNPJ;
        private Label lblNomeColaborador;
        private Label lblResultadoNomeColaborador;
        private Label lblFuncao;
        private Label lblResultadoFuncao;
        private TableLayoutPanel tblDadosFolhaPagamento;
        private Label lblCOD;
        private Label lblDescricao;
        private Label lblCOD04;
        private Label lblVencimentos;
        private Label lblREF;
        private Label lblDescontos;
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
        private TextBox txbHorasExtrasVencimentos;
        private Label lblSalarioBaseVencimentos;
        private Label lblMensagem;
        private Button btnBuscar;
        private Button btnCalcular;
        private Label lblINSSDesconto;
        private Label lblIRPFDesconto;
        private Label lblMensagemCalculo;
        private GroupBox gpbLinha;
    }
}