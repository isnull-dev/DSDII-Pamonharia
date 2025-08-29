namespace DSDIIPamonharia
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.lblContador = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSair = new MaterialSkin.Controls.MaterialButton();
            this.btnVendas = new MaterialSkin.Controls.MaterialButton();
            this.btnCadastros = new MaterialSkin.Controls.MaterialButton();
            this.btnEstoque = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.flpResumoEstoque = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard4 = new MaterialSkin.Controls.MaterialCard();
            this.flpResumoVendasMais = new System.Windows.Forms.FlowLayoutPanel();
            this.materialCard5 = new MaterialSkin.Controls.MaterialCard();
            this.flpResumoVendasMenos = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRelato = new MaterialSkin.Controls.MaterialButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.materialCard4.SuspendLayout();
            this.materialCard5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.materialCard1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 64);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1209, 157);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.lblContador);
            this.materialCard1.Controls.Add(this.materialLabel7);
            this.materialCard1.Controls.Add(this.tableLayoutPanel3);
            this.materialCard1.Controls.Add(this.materialLabel2);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Depth = 0;
            this.materialCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(29, 14);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(1151, 129);
            this.materialCard1.TabIndex = 0;
            // 
            // lblContador
            // 
            this.lblContador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblContador.AutoSize = true;
            this.lblContador.Depth = 0;
            this.lblContador.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblContador.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.lblContador.Location = new System.Drawing.Point(1105, 14);
            this.lblContador.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(29, 17);
            this.lblContador.TabIndex = 4;
            this.lblContador.Text = "5:00";
            // 
            // materialLabel7
            // 
            this.materialLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel7.Location = new System.Drawing.Point(940, 14);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(159, 17);
            this.materialLabel7.TabIndex = 3;
            this.materialLabel7.Text = "Próxima atualização em:";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 6;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.btnSair, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnVendas, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnCadastros, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnEstoque, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnRelato, 4, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(14, 75);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1123, 40);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // btnSair
            // 
            this.btnSair.AutoSize = false;
            this.btnSair.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSair.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSair.Depth = 0;
            this.btnSair.HighEmphasis = true;
            this.btnSair.Icon = null;
            this.btnSair.Location = new System.Drawing.Point(364, 6);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSair.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSair.Name = "btnSair";
            this.btnSair.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSair.Size = new System.Drawing.Size(112, 28);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSair.UseAccentColor = false;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnVendas
            // 
            this.btnVendas.AutoSize = false;
            this.btnVendas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVendas.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnVendas.Depth = 0;
            this.btnVendas.HighEmphasis = true;
            this.btnVendas.Icon = null;
            this.btnVendas.Location = new System.Drawing.Point(4, 6);
            this.btnVendas.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVendas.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVendas.Name = "btnVendas";
            this.btnVendas.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnVendas.Size = new System.Drawing.Size(112, 28);
            this.btnVendas.TabIndex = 0;
            this.btnVendas.Text = "Vendas";
            this.btnVendas.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnVendas.UseAccentColor = false;
            this.btnVendas.UseVisualStyleBackColor = true;
            this.btnVendas.Click += new System.EventHandler(this.btnVendas_Click);
            // 
            // btnCadastros
            // 
            this.btnCadastros.AutoSize = false;
            this.btnCadastros.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCadastros.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCadastros.Depth = 0;
            this.btnCadastros.HighEmphasis = true;
            this.btnCadastros.Icon = null;
            this.btnCadastros.Location = new System.Drawing.Point(124, 6);
            this.btnCadastros.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCadastros.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCadastros.Name = "btnCadastros";
            this.btnCadastros.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCadastros.Size = new System.Drawing.Size(112, 28);
            this.btnCadastros.TabIndex = 1;
            this.btnCadastros.Text = "Cadastros";
            this.btnCadastros.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCadastros.UseAccentColor = false;
            this.btnCadastros.UseVisualStyleBackColor = true;
            this.btnCadastros.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // btnEstoque
            // 
            this.btnEstoque.AutoSize = false;
            this.btnEstoque.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEstoque.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEstoque.Depth = 0;
            this.btnEstoque.HighEmphasis = true;
            this.btnEstoque.Icon = null;
            this.btnEstoque.Location = new System.Drawing.Point(244, 6);
            this.btnEstoque.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEstoque.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEstoque.Size = new System.Drawing.Size(112, 28);
            this.btnEstoque.TabIndex = 2;
            this.btnEstoque.Text = "Estoque";
            this.btnEstoque.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEstoque.UseAccentColor = false;
            this.btnEstoque.UseVisualStyleBackColor = true;
            this.btnEstoque.Click += new System.EventHandler(this.btnEstoque_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel2.Location = new System.Drawing.Point(21, 55);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(168, 17);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Matheus de Souza Pereira";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel1.Location = new System.Drawing.Point(17, 14);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(293, 41);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "DSDII - Pamonharia";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel2.Controls.Add(this.materialCard2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.materialCard3, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 221);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1209, 573);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.flpResumoEstoque);
            this.materialCard2.Controls.Add(this.tableLayoutPanel4);
            this.materialCard2.Depth = 0;
            this.materialCard2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(29, 14);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(561, 545);
            this.materialCard2.TabIndex = 0;
            // 
            // flpResumoEstoque
            // 
            this.flpResumoEstoque.AutoScroll = true;
            this.flpResumoEstoque.BackColor = System.Drawing.SystemColors.Control;
            this.flpResumoEstoque.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpResumoEstoque.Location = new System.Drawing.Point(14, 81);
            this.flpResumoEstoque.Name = "flpResumoEstoque";
            this.flpResumoEstoque.Size = new System.Drawing.Size(533, 450);
            this.flpResumoEstoque.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.materialLabel5, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.materialLabel3, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(14, 14);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(533, 67);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // materialLabel5
            // 
            this.materialLabel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel5.Location = new System.Drawing.Point(187, 42);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(159, 17);
            this.materialLabel5.TabIndex = 5;
            this.materialLabel5.Text = "Estoque Baixo ou Zerado";
            // 
            // materialLabel3
            // 
            this.materialLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel3.Location = new System.Drawing.Point(138, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(257, 41);
            this.materialLabel3.TabIndex = 4;
            this.materialLabel3.Text = "Resumo Estoque";
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.tableLayoutPanel5);
            this.materialCard3.Depth = 0;
            this.materialCard3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(618, 14);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(561, 545);
            this.materialCard3.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.materialLabel8, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.materialLabel6, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.materialLabel4, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.materialCard4, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.materialCard5, 0, 4);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(14, 14);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 5;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(533, 514);
            this.tableLayoutPanel5.TabIndex = 4;
            // 
            // materialLabel8
            // 
            this.materialLabel8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel8.Location = new System.Drawing.Point(225, 278);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(83, 17);
            this.materialLabel8.TabIndex = 7;
            this.materialLabel8.Text = "Menos Saída";
            // 
            // materialLabel6
            // 
            this.materialLabel6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel6.Location = new System.Drawing.Point(231, 42);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(71, 17);
            this.materialLabel6.TabIndex = 6;
            this.materialLabel6.Text = "Mais Saída";
            // 
            // materialLabel4
            // 
            this.materialLabel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel4.Location = new System.Drawing.Point(133, 0);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(267, 41);
            this.materialLabel4.TabIndex = 2;
            this.materialLabel4.Text = "Resumos Vendas";
            // 
            // materialCard4
            // 
            this.materialCard4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard4.Controls.Add(this.flpResumoVendasMais);
            this.materialCard4.Depth = 0;
            this.materialCard4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard4.Location = new System.Drawing.Point(14, 76);
            this.materialCard4.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard4.Name = "materialCard4";
            this.materialCard4.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard4.Size = new System.Drawing.Size(505, 188);
            this.materialCard4.TabIndex = 3;
            // 
            // flpResumoVendasMais
            // 
            this.flpResumoVendasMais.AutoScroll = true;
            this.flpResumoVendasMais.BackColor = System.Drawing.SystemColors.Control;
            this.flpResumoVendasMais.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpResumoVendasMais.Location = new System.Drawing.Point(14, 14);
            this.flpResumoVendasMais.Name = "flpResumoVendasMais";
            this.flpResumoVendasMais.Size = new System.Drawing.Size(477, 160);
            this.flpResumoVendasMais.TabIndex = 0;
            // 
            // materialCard5
            // 
            this.materialCard5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard5.Controls.Add(this.flpResumoVendasMenos);
            this.materialCard5.Depth = 0;
            this.materialCard5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard5.Location = new System.Drawing.Point(14, 312);
            this.materialCard5.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard5.Name = "materialCard5";
            this.materialCard5.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard5.Size = new System.Drawing.Size(505, 188);
            this.materialCard5.TabIndex = 4;
            // 
            // flpResumoVendasMenos
            // 
            this.flpResumoVendasMenos.AutoScroll = true;
            this.flpResumoVendasMenos.BackColor = System.Drawing.SystemColors.Control;
            this.flpResumoVendasMenos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpResumoVendasMenos.Location = new System.Drawing.Point(14, 14);
            this.flpResumoVendasMenos.Name = "flpResumoVendasMenos";
            this.flpResumoVendasMenos.Size = new System.Drawing.Size(477, 160);
            this.flpResumoVendasMenos.TabIndex = 0;
            // 
            // btnRelato
            // 
            this.btnRelato.AutoSize = false;
            this.btnRelato.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRelato.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRelato.Depth = 0;
            this.btnRelato.HighEmphasis = true;
            this.btnRelato.Icon = null;
            this.btnRelato.Location = new System.Drawing.Point(484, 6);
            this.btnRelato.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRelato.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRelato.Name = "btnRelato";
            this.btnRelato.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRelato.Size = new System.Drawing.Size(112, 28);
            this.btnRelato.TabIndex = 4;
            this.btnRelato.Text = "Relato Venda";
            this.btnRelato.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRelato.UseAccentColor = false;
            this.btnRelato.UseVisualStyleBackColor = true;
            this.btnRelato.Click += new System.EventHandler(this.btnRelato_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 797);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu - Pamonharia";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.materialCard2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.materialCard3.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.materialCard4.ResumeLayout(false);
            this.materialCard5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private MaterialSkin.Controls.MaterialButton btnSair;
        private MaterialSkin.Controls.MaterialButton btnVendas;
        private MaterialSkin.Controls.MaterialButton btnCadastros;
        private MaterialSkin.Controls.MaterialButton btnEstoque;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private System.Windows.Forms.FlowLayoutPanel flpResumoEstoque;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Timer TimerUpdate;
        private System.Windows.Forms.Timer TimerContador;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel lblContador;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialCard materialCard4;
        private System.Windows.Forms.FlowLayoutPanel flpResumoVendasMais;
        private MaterialSkin.Controls.MaterialCard materialCard5;
        private System.Windows.Forms.FlowLayoutPanel flpResumoVendasMenos;
        private MaterialSkin.Controls.MaterialButton btnRelato;
    }
}

