
namespace Pesquisa_Selecao {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.gpboxParam = new System.Windows.Forms.GroupBox();
            this.lblTempoCriar = new System.Windows.Forms.Label();
            this.btnCriarArray = new System.Windows.Forms.Button();
            this.numericNumeros = new System.Windows.Forms.NumericUpDown();
            this.lblQuantidadeNumeros = new System.Windows.Forms.Label();
            this.radioButtonOrdemDescrescente = new System.Windows.Forms.RadioButton();
            this.radioButtonOrdemCrescente = new System.Windows.Forms.RadioButton();
            this.radioButtonAleatorio = new System.Windows.Forms.RadioButton();
            this.lblCriarLista = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTempoPassadoArray = new System.Windows.Forms.Label();
            this.lstBoxNumeros = new System.Windows.Forms.ListBox();
            this.gpxBoxOperacoes = new System.Windows.Forms.GroupBox();
            this.lblTempoPesquisas = new System.Windows.Forms.Label();
            this.pnlResultado = new System.Windows.Forms.Panel();
            this.lblResultadoContar = new System.Windows.Forms.Label();
            this.lblResultadoMaxMin = new System.Windows.Forms.Label();
            this.lblResultadoKMin = new System.Windows.Forms.Label();
            this.lblResultadoKMax = new System.Windows.Forms.Label();
            this.lblResultadoMin = new System.Windows.Forms.Label();
            this.lblResultadoMax = new System.Windows.Forms.Label();
            this.lblResultadoFinal = new System.Windows.Forms.Label();
            this.lblResultadoPesquisa = new System.Windows.Forms.Label();
            this.btnContar = new System.Windows.Forms.Button();
            this.txtValorContar = new System.Windows.Forms.TextBox();
            this.lblValorContar = new System.Windows.Forms.Label();
            this.btnKEsimoMin = new System.Windows.Forms.Button();
            this.btnKEsimoMax = new System.Windows.Forms.Button();
            this.numericKNum = new System.Windows.Forms.NumericUpDown();
            this.btnMaxMin = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.lblSelecao = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnPesquisaBinaria = new System.Windows.Forms.Button();
            this.btnPesquisaSequencial = new System.Windows.Forms.Button();
            this.txtValorProcurar = new System.Windows.Forms.TextBox();
            this.lblValorProcura = new System.Windows.Forms.Label();
            this.gpboxParam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumeros)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.gpxBoxOperacoes.SuspendLayout();
            this.pnlResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericKNum)).BeginInit();
            this.SuspendLayout();
            // 
            // gpboxParam
            // 
            this.gpboxParam.Controls.Add(this.lblTempoCriar);
            this.gpboxParam.Controls.Add(this.btnCriarArray);
            this.gpboxParam.Controls.Add(this.numericNumeros);
            this.gpboxParam.Controls.Add(this.lblQuantidadeNumeros);
            this.gpboxParam.Controls.Add(this.radioButtonOrdemDescrescente);
            this.gpboxParam.Controls.Add(this.radioButtonOrdemCrescente);
            this.gpboxParam.Controls.Add(this.radioButtonAleatorio);
            this.gpboxParam.Controls.Add(this.lblCriarLista);
            this.gpboxParam.Location = new System.Drawing.Point(17, 20);
            this.gpboxParam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpboxParam.Name = "gpboxParam";
            this.gpboxParam.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpboxParam.Size = new System.Drawing.Size(551, 373);
            this.gpboxParam.TabIndex = 0;
            this.gpboxParam.TabStop = false;
            this.gpboxParam.Text = "Parametros";
            // 
            // lblTempoCriar
            // 
            this.lblTempoCriar.AutoSize = true;
            this.lblTempoCriar.Location = new System.Drawing.Point(221, 338);
            this.lblTempoCriar.Name = "lblTempoCriar";
            this.lblTempoCriar.Size = new System.Drawing.Size(0, 25);
            this.lblTempoCriar.TabIndex = 7;
            // 
            // btnCriarArray
            // 
            this.btnCriarArray.Location = new System.Drawing.Point(36, 278);
            this.btnCriarArray.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCriarArray.Name = "btnCriarArray";
            this.btnCriarArray.Size = new System.Drawing.Size(469, 55);
            this.btnCriarArray.TabIndex = 6;
            this.btnCriarArray.Text = "Criar Array de  Números";
            this.btnCriarArray.UseVisualStyleBackColor = true;
            this.btnCriarArray.Click += new System.EventHandler(this.btnCriarArray_Click);
            // 
            // numericNumeros
            // 
            this.numericNumeros.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericNumeros.Location = new System.Drawing.Point(333, 165);
            this.numericNumeros.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericNumeros.Maximum = new decimal(new int[] {
            900000000,
            0,
            0,
            0});
            this.numericNumeros.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericNumeros.Name = "numericNumeros";
            this.numericNumeros.Size = new System.Drawing.Size(171, 31);
            this.numericNumeros.TabIndex = 5;
            this.numericNumeros.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericNumeros.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // lblQuantidadeNumeros
            // 
            this.lblQuantidadeNumeros.AutoSize = true;
            this.lblQuantidadeNumeros.Location = new System.Drawing.Point(323, 135);
            this.lblQuantidadeNumeros.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantidadeNumeros.Name = "lblQuantidadeNumeros";
            this.lblQuantidadeNumeros.Size = new System.Drawing.Size(205, 25);
            this.lblQuantidadeNumeros.TabIndex = 4;
            this.lblQuantidadeNumeros.Text = "Quantidade de números";
            // 
            // radioButtonOrdemDescrescente
            // 
            this.radioButtonOrdemDescrescente.AutoSize = true;
            this.radioButtonOrdemDescrescente.Location = new System.Drawing.Point(36, 207);
            this.radioButtonOrdemDescrescente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonOrdemDescrescente.Name = "radioButtonOrdemDescrescente";
            this.radioButtonOrdemDescrescente.Size = new System.Drawing.Size(264, 29);
            this.radioButtonOrdemDescrescente.TabIndex = 3;
            this.radioButtonOrdemDescrescente.Text = "Ordenada decrescentemente";
            this.radioButtonOrdemDescrescente.UseVisualStyleBackColor = true;
            // 
            // radioButtonOrdemCrescente
            // 
            this.radioButtonOrdemCrescente.AutoSize = true;
            this.radioButtonOrdemCrescente.Location = new System.Drawing.Point(36, 155);
            this.radioButtonOrdemCrescente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonOrdemCrescente.Name = "radioButtonOrdemCrescente";
            this.radioButtonOrdemCrescente.Size = new System.Drawing.Size(244, 29);
            this.radioButtonOrdemCrescente.TabIndex = 2;
            this.radioButtonOrdemCrescente.Text = "Ordenada crescentemente";
            this.radioButtonOrdemCrescente.UseVisualStyleBackColor = true;
            // 
            // radioButtonAleatorio
            // 
            this.radioButtonAleatorio.AutoSize = true;
            this.radioButtonAleatorio.Checked = true;
            this.radioButtonAleatorio.Location = new System.Drawing.Point(36, 103);
            this.radioButtonAleatorio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonAleatorio.Name = "radioButtonAleatorio";
            this.radioButtonAleatorio.Size = new System.Drawing.Size(107, 29);
            this.radioButtonAleatorio.TabIndex = 1;
            this.radioButtonAleatorio.TabStop = true;
            this.radioButtonAleatorio.Text = "Aleatória";
            this.radioButtonAleatorio.UseVisualStyleBackColor = true;
            // 
            // lblCriarLista
            // 
            this.lblCriarLista.AutoSize = true;
            this.lblCriarLista.Location = new System.Drawing.Point(164, 32);
            this.lblCriarLista.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCriarLista.Name = "lblCriarLista";
            this.lblCriarLista.Size = new System.Drawing.Size(184, 25);
            this.lblCriarLista.TabIndex = 0;
            this.lblCriarLista.Text = "Criar lista de números";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTempoPassadoArray);
            this.groupBox2.Controls.Add(this.lstBoxNumeros);
            this.groupBox2.Location = new System.Drawing.Point(19, 403);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(550, 408);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Array";
            // 
            // lblTempoPassadoArray
            // 
            this.lblTempoPassadoArray.AutoSize = true;
            this.lblTempoPassadoArray.Location = new System.Drawing.Point(219, 372);
            this.lblTempoPassadoArray.Name = "lblTempoPassadoArray";
            this.lblTempoPassadoArray.Size = new System.Drawing.Size(0, 25);
            this.lblTempoPassadoArray.TabIndex = 1;
            // 
            // lstBoxNumeros
            // 
            this.lstBoxNumeros.FormattingEnabled = true;
            this.lstBoxNumeros.ItemHeight = 25;
            this.lstBoxNumeros.Location = new System.Drawing.Point(174, 34);
            this.lstBoxNumeros.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstBoxNumeros.Name = "lstBoxNumeros";
            this.lstBoxNumeros.Size = new System.Drawing.Size(188, 329);
            this.lstBoxNumeros.TabIndex = 0;
            // 
            // gpxBoxOperacoes
            // 
            this.gpxBoxOperacoes.Controls.Add(this.lblTempoPesquisas);
            this.gpxBoxOperacoes.Controls.Add(this.pnlResultado);
            this.gpxBoxOperacoes.Controls.Add(this.lblResultadoPesquisa);
            this.gpxBoxOperacoes.Controls.Add(this.btnContar);
            this.gpxBoxOperacoes.Controls.Add(this.txtValorContar);
            this.gpxBoxOperacoes.Controls.Add(this.lblValorContar);
            this.gpxBoxOperacoes.Controls.Add(this.btnKEsimoMin);
            this.gpxBoxOperacoes.Controls.Add(this.btnKEsimoMax);
            this.gpxBoxOperacoes.Controls.Add(this.numericKNum);
            this.gpxBoxOperacoes.Controls.Add(this.btnMaxMin);
            this.gpxBoxOperacoes.Controls.Add(this.btnMin);
            this.gpxBoxOperacoes.Controls.Add(this.btnMax);
            this.gpxBoxOperacoes.Controls.Add(this.lblSelecao);
            this.gpxBoxOperacoes.Controls.Add(this.lblResultado);
            this.gpxBoxOperacoes.Controls.Add(this.txtResultado);
            this.gpxBoxOperacoes.Controls.Add(this.btnPesquisaBinaria);
            this.gpxBoxOperacoes.Controls.Add(this.btnPesquisaSequencial);
            this.gpxBoxOperacoes.Controls.Add(this.txtValorProcurar);
            this.gpxBoxOperacoes.Controls.Add(this.lblValorProcura);
            this.gpxBoxOperacoes.Location = new System.Drawing.Point(613, 20);
            this.gpxBoxOperacoes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpxBoxOperacoes.Name = "gpxBoxOperacoes";
            this.gpxBoxOperacoes.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpxBoxOperacoes.Size = new System.Drawing.Size(562, 791);
            this.gpxBoxOperacoes.TabIndex = 2;
            this.gpxBoxOperacoes.TabStop = false;
            this.gpxBoxOperacoes.Text = "Operações de pesquisa e selecção";
            // 
            // lblTempoPesquisas
            // 
            this.lblTempoPesquisas.AutoSize = true;
            this.lblTempoPesquisas.Location = new System.Drawing.Point(257, 293);
            this.lblTempoPesquisas.Name = "lblTempoPesquisas";
            this.lblTempoPesquisas.Size = new System.Drawing.Size(0, 25);
            this.lblTempoPesquisas.TabIndex = 16;
            // 
            // pnlResultado
            // 
            this.pnlResultado.Controls.Add(this.lblResultadoContar);
            this.pnlResultado.Controls.Add(this.lblResultadoMaxMin);
            this.pnlResultado.Controls.Add(this.lblResultadoKMin);
            this.pnlResultado.Controls.Add(this.lblResultadoKMax);
            this.pnlResultado.Controls.Add(this.lblResultadoMin);
            this.pnlResultado.Controls.Add(this.lblResultadoMax);
            this.pnlResultado.Controls.Add(this.lblResultadoFinal);
            this.pnlResultado.Location = new System.Drawing.Point(36, 558);
            this.pnlResultado.Name = "pnlResultado";
            this.pnlResultado.Size = new System.Drawing.Size(506, 196);
            this.pnlResultado.TabIndex = 15;
            // 
            // lblResultadoContar
            // 
            this.lblResultadoContar.AutoSize = true;
            this.lblResultadoContar.Location = new System.Drawing.Point(180, 150);
            this.lblResultadoContar.Name = "lblResultadoContar";
            this.lblResultadoContar.Size = new System.Drawing.Size(28, 25);
            this.lblResultadoContar.TabIndex = 6;
            this.lblResultadoContar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblResultadoKMin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // lblResultadoMaxMin
            // 
            this.lblResultadoMaxMin.AutoSize = true;
            this.lblResultadoMaxMin.Location = new System.Drawing.Point(160, 125);
            this.lblResultadoMaxMin.Name = "lblResultadoMaxMin";
            this.lblResultadoMaxMin.Size = new System.Drawing.Size(28, 25);
            this.lblResultadoKMin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblResultadoMaxMin.TabIndex = 5;
            this.lblResultadoMaxMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResultadoKMin
            // 
            this.lblResultadoKMin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblResultadoKMin.AutoSize = true;
            this.lblResultadoKMin.Location = new System.Drawing.Point(180, 92);
            this.lblResultadoKMin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblResultadoKMin.Name = "lblResultadoKMin";
            this.lblResultadoKMin.Size = new System.Drawing.Size(28, 25);
            this.lblResultadoKMin.TabIndex = 4;
            this.lblResultadoKMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResultadoKMax
            // 
            this.lblResultadoKMax.AutoSize = true;
            this.lblResultadoKMin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblResultadoKMax.Location = new System.Drawing.Point(180, 42);
            this.lblResultadoKMax.Name = "lblResultadoKMax";
            this.lblResultadoKMax.Size = new System.Drawing.Size(0, 25);
            this.lblResultadoKMax.TabIndex = 3;
            this.lblResultadoKMax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResultadoMin
            // 
            this.lblResultadoMin.AutoSize = true;
            this.lblResultadoMin.Location = new System.Drawing.Point(180, 67);
            this.lblResultadoKMin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblResultadoMin.Name = "lblResultadoMin";
            this.lblResultadoMin.Size = new System.Drawing.Size(0, 25);
            this.lblResultadoMin.TabIndex = 2;
            this.lblResultadoMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResultadoMax
            // 
            this.lblResultadoMax.AutoSize = true;
            this.lblResultadoMax.Location = new System.Drawing.Point(180, 17);
            this.lblResultadoKMin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblResultadoMax.Name = "lblResultadoMax";
            this.lblResultadoMax.Size = new System.Drawing.Size(0, 25);
            this.lblResultadoMax.TabIndex = 1;
            this.lblResultadoMax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResultadoFinal
            // 
            this.lblResultadoFinal.Location = new System.Drawing.Point(0, 0);
            this.lblResultadoFinal.Name = "lblResultadoFinal";
            this.lblResultadoFinal.Size = new System.Drawing.Size(100, 23);
            this.lblResultadoFinal.TabIndex = 7;
            // 
            // lblResultadoPesquisa
            // 
            this.lblResultadoPesquisa.AutoSize = true;
            this.lblResultadoPesquisa.Location = new System.Drawing.Point(220, 530);
            this.lblResultadoPesquisa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResultadoPesquisa.Name = "lblResultadoPesquisa";
            this.lblResultadoPesquisa.Size = new System.Drawing.Size(167, 25);
            this.lblResultadoPesquisa.TabIndex = 14;
            this.lblResultadoPesquisa.Text = "Resultado Pesquisa:";
            // 
            // btnContar
            // 
            this.btnContar.Enabled = false;
            this.btnContar.Location = new System.Drawing.Point(400, 465);
            this.btnContar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnContar.Name = "btnContar";
            this.btnContar.Size = new System.Drawing.Size(142, 38);
            this.btnContar.TabIndex = 13;
            this.btnContar.Text = "Contar";
            this.btnContar.UseVisualStyleBackColor = true;
            this.btnContar.Click += new System.EventHandler(this.btnContar_Click);
            // 
            // txtValorContar
            // 
            this.txtValorContar.Enabled = false;
            this.txtValorContar.Location = new System.Drawing.Point(400, 421);
            this.txtValorContar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtValorContar.Name = "txtValorContar";
            this.txtValorContar.Size = new System.Drawing.Size(142, 31);
            this.txtValorContar.TabIndex = 12;
            // 
            // lblValorContar
            // 
            this.lblValorContar.AutoSize = true;
            this.lblValorContar.Location = new System.Drawing.Point(417, 377);
            this.lblValorContar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValorContar.Name = "lblValorContar";
            this.lblValorContar.Size = new System.Drawing.Size(125, 25);
            this.lblValorContar.TabIndex = 11;
            this.lblValorContar.Text = "Valor a contar:";
            // 
            // btnKEsimoMin
            // 
            this.btnKEsimoMin.Enabled = false;
            this.btnKEsimoMin.Location = new System.Drawing.Point(197, 465);
            this.btnKEsimoMin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnKEsimoMin.Name = "btnKEsimoMin";
            this.btnKEsimoMin.Size = new System.Drawing.Size(183, 38);
            this.btnKEsimoMin.TabIndex = 10;
            this.btnKEsimoMin.Text = "K-Ésimo Menor";
            this.btnKEsimoMin.UseVisualStyleBackColor = true;
            this.btnKEsimoMin.Click += new System.EventHandler(this.btnKEsimoMin_Click);
            // 
            // btnKEsimoMax
            // 
            this.btnKEsimoMax.Enabled = false;
            this.btnKEsimoMax.Location = new System.Drawing.Point(197, 417);
            this.btnKEsimoMax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnKEsimoMax.Name = "btnKEsimoMax";
            this.btnKEsimoMax.Size = new System.Drawing.Size(183, 38);
            this.btnKEsimoMax.TabIndex = 9;
            this.btnKEsimoMax.Text = "K-Ésimo Maior";
            this.btnKEsimoMax.UseVisualStyleBackColor = true;
            this.btnKEsimoMax.Click += new System.EventHandler(this.btnKEsimoMax_Click);
            // 
            // numericKNum
            // 
            this.numericKNum.Enabled = false;
            this.numericKNum.Location = new System.Drawing.Point(197, 369);
            this.numericKNum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericKNum.Maximum = new decimal(new int[] {
            900000000,
            0,
            0,
            0});
            this.numericKNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericKNum.Name = "numericKNum";
            this.numericKNum.Size = new System.Drawing.Size(183, 31);
            this.numericKNum.TabIndex = 8;
            this.numericKNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericKNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnMaxMin
            // 
            this.btnMaxMin.Enabled = false;
            this.btnMaxMin.Location = new System.Drawing.Point(36, 465);
            this.btnMaxMin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMaxMin.Name = "btnMaxMin";
            this.btnMaxMin.Size = new System.Drawing.Size(131, 38);
            this.btnMaxMin.TabIndex = 8;
            this.btnMaxMin.Text = "Max e Min";
            this.btnMaxMin.UseVisualStyleBackColor = true;
            this.btnMaxMin.Click += new System.EventHandler(this.btnMaxMin_Click);
            // 
            // btnMin
            // 
            this.btnMin.Enabled = false;
            this.btnMin.Location = new System.Drawing.Point(36, 417);
            this.btnMin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(131, 38);
            this.btnMin.TabIndex = 7;
            this.btnMin.Text = "Mínimo";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnMax
            // 
            this.btnMax.Enabled = false;
            this.btnMax.Location = new System.Drawing.Point(36, 364);
            this.btnMax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(131, 38);
            this.btnMax.TabIndex = 6;
            this.btnMax.Text = "Máximo";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // lblSelecao
            // 
            this.lblSelecao.AutoSize = true;
            this.lblSelecao.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSelecao.Location = new System.Drawing.Point(248, 329);
            this.lblSelecao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelecao.Name = "lblSelecao";
            this.lblSelecao.Size = new System.Drawing.Size(78, 25);
            this.lblSelecao.TabIndex = 5;
            this.lblSelecao.Text = "Seleção";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(186, 207);
            this.lblResultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(194, 25);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "Resultado da pesquisa:";
            // 
            // txtResultado
            // 
            this.txtResultado.Enabled = false;
            this.txtResultado.Location = new System.Drawing.Point(36, 253);
            this.txtResultado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(506, 31);
            this.txtResultado.TabIndex = 3;
            // 
            // btnPesquisaBinaria
            // 
            this.btnPesquisaBinaria.Enabled = false;
            this.btnPesquisaBinaria.Location = new System.Drawing.Point(304, 135);
            this.btnPesquisaBinaria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPesquisaBinaria.Name = "btnPesquisaBinaria";
            this.btnPesquisaBinaria.Size = new System.Drawing.Size(238, 38);
            this.btnPesquisaBinaria.TabIndex = 2;
            this.btnPesquisaBinaria.Text = "Pesquisa binária";
            this.btnPesquisaBinaria.UseVisualStyleBackColor = true;
            this.btnPesquisaBinaria.Click += new System.EventHandler(this.btnPesquisaBinaria_Click);
            // 
            // btnPesquisaSequencial
            // 
            this.btnPesquisaSequencial.Enabled = false;
            this.btnPesquisaSequencial.Location = new System.Drawing.Point(36, 135);
            this.btnPesquisaSequencial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPesquisaSequencial.Name = "btnPesquisaSequencial";
            this.btnPesquisaSequencial.Size = new System.Drawing.Size(225, 38);
            this.btnPesquisaSequencial.TabIndex = 2;
            this.btnPesquisaSequencial.Text = "Pesquisa sequencial";
            this.btnPesquisaSequencial.UseVisualStyleBackColor = true;
            this.btnPesquisaSequencial.Click += new System.EventHandler(this.btnPesquisaSequencial_Click);
            // 
            // txtValorProcurar
            // 
            this.txtValorProcurar.Enabled = false;
            this.txtValorProcurar.Location = new System.Drawing.Point(220, 80);
            this.txtValorProcurar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtValorProcurar.Name = "txtValorProcurar";
            this.txtValorProcurar.Size = new System.Drawing.Size(141, 31);
            this.txtValorProcurar.TabIndex = 1;
            // 
            // lblValorProcura
            // 
            this.lblValorProcura.AutoSize = true;
            this.lblValorProcura.Location = new System.Drawing.Point(220, 50);
            this.lblValorProcura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValorProcura.Name = "lblValorProcura";
            this.lblValorProcura.Size = new System.Drawing.Size(142, 25);
            this.lblValorProcura.TabIndex = 0;
            this.lblValorProcura.Text = "Valor a procurar:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 840);
            this.Controls.Add(this.gpxBoxOperacoes);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gpboxParam);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Pesquisa e Seleção";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpboxParam.ResumeLayout(false);
            this.gpboxParam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumeros)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gpxBoxOperacoes.ResumeLayout(false);
            this.gpxBoxOperacoes.PerformLayout();
            this.pnlResultado.ResumeLayout(false);
            this.pnlResultado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericKNum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpboxParam;
        private System.Windows.Forms.Button btnCriarArray;
        private System.Windows.Forms.NumericUpDown numericNumeros;
        private System.Windows.Forms.Label lblQuantidadeNumeros;
        private System.Windows.Forms.RadioButton radioButtonOrdemDescrescente;
        private System.Windows.Forms.RadioButton radioButtonOrdemCrescente;
        private System.Windows.Forms.RadioButton radioButtonAleatorio;
        private System.Windows.Forms.Label lblCriarLista;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstBoxNumeros;
        private System.Windows.Forms.GroupBox gpxBoxOperacoes;
        private System.Windows.Forms.Button btnPesquisaBinaria;
        private System.Windows.Forms.Button btnPesquisaSequencial;
        private System.Windows.Forms.TextBox txtValorProcurar;
        private System.Windows.Forms.Label lblValorProcura;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label lblTempoCriar;
        private System.Windows.Forms.Label lblTempoPassadoArray;
        private System.Windows.Forms.Label lblValorContar;
        private System.Windows.Forms.Button btnKEsimoMin;
        private System.Windows.Forms.Button btnKEsimoMax;
        private System.Windows.Forms.NumericUpDown numericKNum;
        private System.Windows.Forms.Button btnMaxMin;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Label lblSelecao;
        private System.Windows.Forms.TextBox txtValorContar;
        private System.Windows.Forms.Panel pnlResultado;
        private System.Windows.Forms.Label lblResultadoFinal;
        private System.Windows.Forms.Label lblResultadoPesquisa;
        private System.Windows.Forms.Button btnContar;
        private System.Windows.Forms.Label lblTempoPesquisas;
        private System.Windows.Forms.Label lblResultadoMax;
        private System.Windows.Forms.Label lblResultadoContar;
        private System.Windows.Forms.Label lblResultadoMaxMin;
        private System.Windows.Forms.Label lblResultadoKMin;
        private System.Windows.Forms.Label lblResultadoKMax;
        private System.Windows.Forms.Label lblResultadoMin;
    }
}
