namespace DSDIIPamonharia.UI.Formularios
{
    partial class FormVisuProdutos
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
            this.txtDescricao = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnIncluir = new MaterialSkin.Controls.MaterialButton();
            this.btnAlterar = new MaterialSkin.Controls.MaterialButton();
            this.btnExcluir = new MaterialSkin.Controls.MaterialButton();
            this.picProduto = new System.Windows.Forms.PictureBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbUN = new MaterialSkin.Controls.MaterialComboBox();
            this.txtNomeProduto = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCusto = new MaterialSkin.Controls.MaterialTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.txtValor = new MaterialSkin.Controls.MaterialTextBox();
            this.TBCProduto = new MaterialSkin.Controls.MaterialTabControl();
            this.PageInformacoes = new System.Windows.Forms.TabPage();
            this.PageReceita = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.flpReceita = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.txtId = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblCusto = new MaterialSkin.Controls.MaterialLabel();
            this.lbl = new MaterialSkin.Controls.MaterialLabel();
            this.btnAddIngrediente = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.txtQuantidade = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbReceita = new MaterialSkin.Controls.MaterialComboBox();
            this.cmbUsaReceita = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProduto)).BeginInit();
            this.TBCProduto.SuspendLayout();
            this.PageInformacoes.SuspendLayout();
            this.PageReceita.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDescricao
            // 
            this.txtDescricao.AnimateReadOnly = false;
            this.txtDescricao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDescricao.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescricao.Depth = 0;
            this.txtDescricao.HideSelection = true;
            this.txtDescricao.Location = new System.Drawing.Point(18, 127);
            this.txtDescricao.MaxLength = 32767;
            this.txtDescricao.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.PasswordChar = '\0';
            this.txtDescricao.ReadOnly = false;
            this.txtDescricao.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescricao.SelectedText = "";
            this.txtDescricao.SelectionLength = 0;
            this.txtDescricao.SelectionStart = 0;
            this.txtDescricao.ShortcutsEnabled = true;
            this.txtDescricao.Size = new System.Drawing.Size(350, 152);
            this.txtDescricao.TabIndex = 1;
            this.txtDescricao.TabStop = false;
            this.txtDescricao.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDescricao.UseSystemPasswordChar = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnIncluir, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAlterar, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnExcluir, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 64);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(874, 35);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // btnIncluir
            // 
            this.btnIncluir.AutoSize = false;
            this.btnIncluir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnIncluir.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnIncluir.Depth = 0;
            this.btnIncluir.HighEmphasis = true;
            this.btnIncluir.Icon = null;
            this.btnIncluir.Location = new System.Drawing.Point(4, 6);
            this.btnIncluir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnIncluir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnIncluir.Size = new System.Drawing.Size(109, 23);
            this.btnIncluir.TabIndex = 0;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnIncluir.UseAccentColor = false;
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.AutoSize = false;
            this.btnAlterar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAlterar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAlterar.Depth = 0;
            this.btnAlterar.HighEmphasis = true;
            this.btnAlterar.Icon = null;
            this.btnAlterar.Location = new System.Drawing.Point(124, 6);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAlterar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAlterar.Size = new System.Drawing.Size(112, 23);
            this.btnAlterar.TabIndex = 1;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAlterar.UseAccentColor = false;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.AutoSize = false;
            this.btnExcluir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExcluir.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnExcluir.Depth = 0;
            this.btnExcluir.HighEmphasis = true;
            this.btnExcluir.Icon = null;
            this.btnExcluir.Location = new System.Drawing.Point(244, 6);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnExcluir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnExcluir.Size = new System.Drawing.Size(112, 23);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnExcluir.UseAccentColor = false;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // picProduto
            // 
            this.picProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picProduto.Location = new System.Drawing.Point(421, 43);
            this.picProduto.Name = "picProduto";
            this.picProduto.Size = new System.Drawing.Size(416, 416);
            this.picProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProduto.TabIndex = 15;
            this.picProduto.TabStop = false;
            this.picProduto.DoubleClick += new System.EventHandler(this.picProduto_DoubleClick);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(15, 297);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(63, 19);
            this.materialLabel3.TabIndex = 14;
            this.materialLabel3.Text = "Un. Med.";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(15, 105);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(71, 19);
            this.materialLabel2.TabIndex = 13;
            this.materialLabel2.Text = "Descrição";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(15, 21);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(43, 19);
            this.materialLabel1.TabIndex = 12;
            this.materialLabel1.Text = "Nome";
            // 
            // cmbUN
            // 
            this.cmbUN.AutoResize = false;
            this.cmbUN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbUN.Depth = 0;
            this.cmbUN.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbUN.DropDownHeight = 174;
            this.cmbUN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUN.DropDownWidth = 121;
            this.cmbUN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbUN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbUN.FormattingEnabled = true;
            this.cmbUN.IntegralHeight = false;
            this.cmbUN.ItemHeight = 43;
            this.cmbUN.Items.AddRange(new object[] {
            "UN",
            "G",
            "KG",
            "LITRO"});
            this.cmbUN.Location = new System.Drawing.Point(18, 319);
            this.cmbUN.MaxDropDownItems = 4;
            this.cmbUN.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbUN.Name = "cmbUN";
            this.cmbUN.Size = new System.Drawing.Size(159, 49);
            this.cmbUN.StartIndex = 0;
            this.cmbUN.TabIndex = 4;
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.AnimateReadOnly = false;
            this.txtNomeProduto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomeProduto.Depth = 0;
            this.txtNomeProduto.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNomeProduto.LeadingIcon = null;
            this.txtNomeProduto.Location = new System.Drawing.Point(18, 43);
            this.txtNomeProduto.MaxLength = 50;
            this.txtNomeProduto.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNomeProduto.Multiline = false;
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(347, 50);
            this.txtNomeProduto.TabIndex = 0;
            this.txtNomeProduto.Text = "";
            this.txtNomeProduto.TrailingIcon = null;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(16, 383);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(42, 19);
            this.materialLabel4.TabIndex = 20;
            this.materialLabel4.Text = "Custo";
            // 
            // txtCusto
            // 
            this.txtCusto.AnimateReadOnly = false;
            this.txtCusto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCusto.Depth = 0;
            this.txtCusto.Enabled = false;
            this.txtCusto.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCusto.LeadingIcon = null;
            this.txtCusto.Location = new System.Drawing.Point(18, 406);
            this.txtCusto.MaxLength = 50;
            this.txtCusto.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCusto.Multiline = false;
            this.txtCusto.Name = "txtCusto";
            this.txtCusto.Size = new System.Drawing.Size(160, 50);
            this.txtCusto.TabIndex = 2;
            this.txtCusto.Text = "";
            this.txtCusto.TrailingIcon = null;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(199, 383);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(38, 19);
            this.materialLabel5.TabIndex = 22;
            this.materialLabel5.Text = "Valor";
            // 
            // txtValor
            // 
            this.txtValor.AnimateReadOnly = false;
            this.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValor.Depth = 0;
            this.txtValor.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtValor.LeadingIcon = null;
            this.txtValor.Location = new System.Drawing.Point(202, 406);
            this.txtValor.MaxLength = 50;
            this.txtValor.MouseState = MaterialSkin.MouseState.OUT;
            this.txtValor.Multiline = false;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(163, 50);
            this.txtValor.TabIndex = 3;
            this.txtValor.Text = "";
            this.txtValor.TrailingIcon = null;
            // 
            // TBCProduto
            // 
            this.TBCProduto.Controls.Add(this.PageInformacoes);
            this.TBCProduto.Controls.Add(this.PageReceita);
            this.TBCProduto.Depth = 0;
            this.TBCProduto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBCProduto.Location = new System.Drawing.Point(3, 99);
            this.TBCProduto.MouseState = MaterialSkin.MouseState.HOVER;
            this.TBCProduto.Multiline = true;
            this.TBCProduto.Name = "TBCProduto";
            this.TBCProduto.SelectedIndex = 0;
            this.TBCProduto.Size = new System.Drawing.Size(874, 548);
            this.TBCProduto.TabIndex = 1;
            this.TBCProduto.SelectedIndexChanged += new System.EventHandler(this.TBCProduto_SelectedIndexChanged);
            // 
            // PageInformacoes
            // 
            this.PageInformacoes.BackColor = System.Drawing.SystemColors.Control;
            this.PageInformacoes.Controls.Add(this.cmbUsaReceita);
            this.PageInformacoes.Controls.Add(this.materialLabel9);
            this.PageInformacoes.Controls.Add(this.materialLabel5);
            this.PageInformacoes.Controls.Add(this.cmbUN);
            this.PageInformacoes.Controls.Add(this.txtValor);
            this.PageInformacoes.Controls.Add(this.txtNomeProduto);
            this.PageInformacoes.Controls.Add(this.materialLabel4);
            this.PageInformacoes.Controls.Add(this.materialLabel1);
            this.PageInformacoes.Controls.Add(this.txtCusto);
            this.PageInformacoes.Controls.Add(this.materialLabel2);
            this.PageInformacoes.Controls.Add(this.txtDescricao);
            this.PageInformacoes.Controls.Add(this.materialLabel3);
            this.PageInformacoes.Controls.Add(this.picProduto);
            this.PageInformacoes.Location = new System.Drawing.Point(4, 22);
            this.PageInformacoes.Name = "PageInformacoes";
            this.PageInformacoes.Padding = new System.Windows.Forms.Padding(3);
            this.PageInformacoes.Size = new System.Drawing.Size(866, 522);
            this.PageInformacoes.TabIndex = 0;
            this.PageInformacoes.Text = "Informações";
            // 
            // PageReceita
            // 
            this.PageReceita.Controls.Add(this.tableLayoutPanel3);
            this.PageReceita.Controls.Add(this.tableLayoutPanel2);
            this.PageReceita.Location = new System.Drawing.Point(4, 22);
            this.PageReceita.Name = "PageReceita";
            this.PageReceita.Padding = new System.Windows.Forms.Padding(3);
            this.PageReceita.Size = new System.Drawing.Size(866, 522);
            this.PageReceita.TabIndex = 1;
            this.PageReceita.Text = "Receita";
            this.PageReceita.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.flpReceita, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 184);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(860, 335);
            this.tableLayoutPanel3.TabIndex = 7;
            // 
            // flpReceita
            // 
            this.flpReceita.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpReceita.Location = new System.Drawing.Point(18, 3);
            this.flpReceita.Name = "flpReceita";
            this.flpReceita.Size = new System.Drawing.Size(824, 329);
            this.flpReceita.TabIndex = 0;
            this.flpReceita.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.flpReceita_ControlAdded);
            this.flpReceita.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.flpReceita_ControlAdded);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 670F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 164F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel2.Controls.Add(this.materialCard1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(860, 181);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.materialLabel6);
            this.materialCard1.Controls.Add(this.txtId);
            this.materialCard1.Controls.Add(this.lblCusto);
            this.materialCard1.Controls.Add(this.lbl);
            this.materialCard1.Controls.Add(this.btnAddIngrediente);
            this.materialCard1.Controls.Add(this.materialLabel7);
            this.materialCard1.Controls.Add(this.txtQuantidade);
            this.materialCard1.Controls.Add(this.materialLabel8);
            this.materialCard1.Controls.Add(this.cmbReceita);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(29, 14);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(604, 148);
            this.materialCard1.TabIndex = 1;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(27, 20);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(46, 19);
            this.materialLabel6.TabIndex = 24;
            this.materialLabel6.Text = "Cód Id";
            // 
            // txtId
            // 
            this.txtId.AnimateReadOnly = false;
            this.txtId.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtId.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtId.Depth = 0;
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtId.HideSelection = true;
            this.txtId.LeadingIcon = null;
            this.txtId.Location = new System.Drawing.Point(27, 42);
            this.txtId.MaxLength = 32767;
            this.txtId.MouseState = MaterialSkin.MouseState.OUT;
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.PrefixSuffixText = null;
            this.txtId.ReadOnly = false;
            this.txtId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtId.SelectedText = "";
            this.txtId.SelectionLength = 0;
            this.txtId.SelectionStart = 0;
            this.txtId.ShortcutsEnabled = true;
            this.txtId.Size = new System.Drawing.Size(83, 48);
            this.txtId.TabIndex = 23;
            this.txtId.TabStop = false;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtId.TrailingIcon = null;
            this.txtId.UseSystemPasswordChar = false;
            // 
            // lblCusto
            // 
            this.lblCusto.AutoSize = true;
            this.lblCusto.Depth = 0;
            this.lblCusto.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblCusto.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCusto.Location = new System.Drawing.Point(108, 107);
            this.lblCusto.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCusto.Name = "lblCusto";
            this.lblCusto.Size = new System.Drawing.Size(31, 19);
            this.lblCusto.TabIndex = 22;
            this.lblCusto.Text = "0,00";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Depth = 0;
            this.lbl.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl.Location = new System.Drawing.Point(24, 107);
            this.lbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(73, 19);
            this.lbl.TabIndex = 21;
            this.lbl.Text = "Custo: R$ ";
            // 
            // btnAddIngrediente
            // 
            this.btnAddIngrediente.AutoSize = false;
            this.btnAddIngrediente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddIngrediente.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddIngrediente.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddIngrediente.Depth = 0;
            this.btnAddIngrediente.HighEmphasis = true;
            this.btnAddIngrediente.Icon = null;
            this.btnAddIngrediente.Location = new System.Drawing.Point(498, 101);
            this.btnAddIngrediente.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddIngrediente.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddIngrediente.Name = "btnAddIngrediente";
            this.btnAddIngrediente.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAddIngrediente.Size = new System.Drawing.Size(83, 28);
            this.btnAddIngrediente.TabIndex = 0;
            this.btnAddIngrediente.Text = "Adicionar";
            this.btnAddIngrediente.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddIngrediente.UseAccentColor = false;
            this.btnAddIngrediente.UseVisualStyleBackColor = false;
            this.btnAddIngrediente.Click += new System.EventHandler(this.btnAddIngrediente_Click);
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(496, 20);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(83, 19);
            this.materialLabel7.TabIndex = 19;
            this.materialLabel7.Text = "Quantidade";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.AnimateReadOnly = false;
            this.txtQuantidade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtQuantidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtQuantidade.Depth = 0;
            this.txtQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtQuantidade.HideSelection = true;
            this.txtQuantidade.LeadingIcon = null;
            this.txtQuantidade.Location = new System.Drawing.Point(496, 42);
            this.txtQuantidade.MaxLength = 32767;
            this.txtQuantidade.MouseState = MaterialSkin.MouseState.OUT;
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.PasswordChar = '\0';
            this.txtQuantidade.PrefixSuffixText = null;
            this.txtQuantidade.ReadOnly = false;
            this.txtQuantidade.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtQuantidade.SelectedText = "";
            this.txtQuantidade.SelectionLength = 0;
            this.txtQuantidade.SelectionStart = 0;
            this.txtQuantidade.ShortcutsEnabled = true;
            this.txtQuantidade.Size = new System.Drawing.Size(83, 48);
            this.txtQuantidade.TabIndex = 18;
            this.txtQuantidade.TabStop = false;
            this.txtQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtQuantidade.TrailingIcon = null;
            this.txtQuantidade.UseSystemPasswordChar = false;
            this.txtQuantidade.TextChanged += new System.EventHandler(this.txtQuantidade_TextChanged);
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.Location = new System.Drawing.Point(123, 20);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(79, 19);
            this.materialLabel8.TabIndex = 17;
            this.materialLabel8.Text = "Ingrediente";
            // 
            // cmbReceita
            // 
            this.cmbReceita.AutoResize = false;
            this.cmbReceita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbReceita.Depth = 0;
            this.cmbReceita.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbReceita.DropDownHeight = 174;
            this.cmbReceita.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReceita.DropDownWidth = 121;
            this.cmbReceita.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbReceita.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbReceita.FormattingEnabled = true;
            this.cmbReceita.IntegralHeight = false;
            this.cmbReceita.ItemHeight = 43;
            this.cmbReceita.Items.AddRange(new object[] {
            "-"});
            this.cmbReceita.Location = new System.Drawing.Point(123, 42);
            this.cmbReceita.MaxDropDownItems = 4;
            this.cmbReceita.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbReceita.Name = "cmbReceita";
            this.cmbReceita.Size = new System.Drawing.Size(367, 49);
            this.cmbReceita.StartIndex = 0;
            this.cmbReceita.TabIndex = 16;
            this.cmbReceita.SelectedIndexChanged += new System.EventHandler(this.cmbReceita_SelectedIndexChanged);
            // 
            // cmbUsaReceita
            // 
            this.cmbUsaReceita.AutoResize = false;
            this.cmbUsaReceita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbUsaReceita.Depth = 0;
            this.cmbUsaReceita.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbUsaReceita.DropDownHeight = 174;
            this.cmbUsaReceita.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsaReceita.DropDownWidth = 121;
            this.cmbUsaReceita.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbUsaReceita.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbUsaReceita.FormattingEnabled = true;
            this.cmbUsaReceita.IntegralHeight = false;
            this.cmbUsaReceita.ItemHeight = 43;
            this.cmbUsaReceita.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.cmbUsaReceita.Location = new System.Drawing.Point(202, 319);
            this.cmbUsaReceita.MaxDropDownItems = 4;
            this.cmbUsaReceita.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbUsaReceita.Name = "cmbUsaReceita";
            this.cmbUsaReceita.Size = new System.Drawing.Size(159, 49);
            this.cmbUsaReceita.StartIndex = 0;
            this.cmbUsaReceita.TabIndex = 23;
            this.cmbUsaReceita.SelectedIndexChanged += new System.EventHandler(this.cmbUsaReceita_SelectedIndexChanged);
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.Location = new System.Drawing.Point(199, 297);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(84, 19);
            this.materialLabel9.TabIndex = 24;
            this.materialLabel9.Text = "Usa Receita";
            // 
            // FormVisuProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 650);
            this.Controls.Add(this.TBCProduto);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DrawerTabControl = this.TBCProduto;
            this.Name = "FormVisuProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormVisuProduto";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picProduto)).EndInit();
            this.TBCProduto.ResumeLayout(false);
            this.PageInformacoes.ResumeLayout(false);
            this.PageInformacoes.PerformLayout();
            this.PageReceita.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtDescricao;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialButton btnExcluir;
        private MaterialSkin.Controls.MaterialButton btnAlterar;
        private MaterialSkin.Controls.MaterialButton btnIncluir;
        private System.Windows.Forms.PictureBox picProduto;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialComboBox cmbUN;
        private MaterialSkin.Controls.MaterialTextBox txtNomeProduto;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialTextBox txtCusto;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialTextBox txtValor;
        private MaterialSkin.Controls.MaterialTabControl TBCProduto;
        private System.Windows.Forms.TabPage PageInformacoes;
        private System.Windows.Forms.TabPage PageReceita;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialButton btnAddIngrediente;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialTextBox2 txtQuantidade;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialComboBox cmbReceita;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flpReceita;
        private MaterialSkin.Controls.MaterialLabel lblCusto;
        private MaterialSkin.Controls.MaterialLabel lbl;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialTextBox2 txtId;
        private MaterialSkin.Controls.MaterialComboBox cmbUsaReceita;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
    }
}