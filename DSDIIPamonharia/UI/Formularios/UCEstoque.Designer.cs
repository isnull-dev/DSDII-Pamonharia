namespace DSDIIPamonharia.UI.Formularios
{
    partial class UCEstoque
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.lblTipo = new MaterialSkin.Controls.MaterialLabel();
            this.picAviso = new System.Windows.Forms.PictureBox();
            this.btnSalvar = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtQtdEstoque = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblCodProd = new MaterialSkin.Controls.MaterialLabel();
            this.lblNomeProd = new MaterialSkin.Controls.MaterialLabel();
            this.picProduto = new System.Windows.Forms.PictureBox();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAviso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.lblTipo);
            this.materialCard1.Controls.Add(this.picAviso);
            this.materialCard1.Controls.Add(this.btnSalvar);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Controls.Add(this.txtQtdEstoque);
            this.materialCard1.Controls.Add(this.lblCodProd);
            this.materialCard1.Controls.Add(this.lblNomeProd);
            this.materialCard1.Controls.Add(this.picProduto);
            this.materialCard1.Depth = 0;
            this.materialCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(0, 0);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(500, 167);
            this.materialCard1.TabIndex = 0;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Depth = 0;
            this.lblTipo.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTipo.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            this.lblTipo.Location = new System.Drawing.Point(173, 41);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(0);
            this.lblTipo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(32, 14);
            this.lblTipo.TabIndex = 12;
            this.lblTipo.Text = "#Tipo";
            // 
            // picAviso
            // 
            this.picAviso.Enabled = false;
            this.picAviso.Image = global::DSDIIPamonharia.Properties.Resources.caution;
            this.picAviso.Location = new System.Drawing.Point(409, 17);
            this.picAviso.Name = "picAviso";
            this.picAviso.Size = new System.Drawing.Size(64, 64);
            this.picAviso.TabIndex = 11;
            this.picAviso.TabStop = false;
            this.picAviso.Visible = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.AutoSize = false;
            this.btnSalvar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalvar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSalvar.Depth = 0;
            this.btnSalvar.Enabled = false;
            this.btnSalvar.HighEmphasis = true;
            this.btnSalvar.Icon = null;
            this.btnSalvar.Location = new System.Drawing.Point(409, 112);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSalvar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSalvar.Size = new System.Drawing.Size(64, 30);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSalvar.UseAccentColor = false;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(174, 72);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(83, 19);
            this.materialLabel1.TabIndex = 9;
            this.materialLabel1.Text = "Quantidade";
            // 
            // txtQtdEstoque
            // 
            this.txtQtdEstoque.AnimateReadOnly = false;
            this.txtQtdEstoque.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtQtdEstoque.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtQtdEstoque.Depth = 0;
            this.txtQtdEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtQtdEstoque.HideSelection = true;
            this.txtQtdEstoque.LeadingIcon = null;
            this.txtQtdEstoque.Location = new System.Drawing.Point(176, 94);
            this.txtQtdEstoque.MaxLength = 32767;
            this.txtQtdEstoque.MouseState = MaterialSkin.MouseState.OUT;
            this.txtQtdEstoque.Name = "txtQtdEstoque";
            this.txtQtdEstoque.PasswordChar = '\0';
            this.txtQtdEstoque.PrefixSuffixText = null;
            this.txtQtdEstoque.ReadOnly = false;
            this.txtQtdEstoque.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtQtdEstoque.SelectedText = "";
            this.txtQtdEstoque.SelectionLength = 0;
            this.txtQtdEstoque.SelectionStart = 0;
            this.txtQtdEstoque.ShortcutsEnabled = true;
            this.txtQtdEstoque.Size = new System.Drawing.Size(134, 48);
            this.txtQtdEstoque.TabIndex = 8;
            this.txtQtdEstoque.TabStop = false;
            this.txtQtdEstoque.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtQtdEstoque.TrailingIcon = null;
            this.txtQtdEstoque.UseSystemPasswordChar = false;
            this.txtQtdEstoque.TextChanged += new System.EventHandler(this.txtQtdEstoque_TextChanged);
            // 
            // lblCodProd
            // 
            this.lblCodProd.AutoSize = true;
            this.lblCodProd.Depth = 0;
            this.lblCodProd.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCodProd.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            this.lblCodProd.Location = new System.Drawing.Point(264, 41);
            this.lblCodProd.Margin = new System.Windows.Forms.Padding(0);
            this.lblCodProd.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCodProd.Name = "lblCodProd";
            this.lblCodProd.Size = new System.Drawing.Size(74, 14);
            this.lblCodProd.TabIndex = 7;
            this.lblCodProd.Text = "#CodProduto";
            // 
            // lblNomeProd
            // 
            this.lblNomeProd.AutoSize = true;
            this.lblNomeProd.Depth = 0;
            this.lblNomeProd.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblNomeProd.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblNomeProd.Location = new System.Drawing.Point(172, 17);
            this.lblNomeProd.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNomeProd.Name = "lblNomeProd";
            this.lblNomeProd.Size = new System.Drawing.Size(142, 24);
            this.lblNomeProd.TabIndex = 6;
            this.lblNomeProd.Text = "#Nome Produto";
            // 
            // picProduto
            // 
            this.picProduto.Location = new System.Drawing.Point(17, 17);
            this.picProduto.Name = "picProduto";
            this.picProduto.Size = new System.Drawing.Size(125, 125);
            this.picProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProduto.TabIndex = 0;
            this.picProduto.TabStop = false;
            // 
            // UCEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.materialCard1);
            this.Name = "UCEstoque";
            this.Size = new System.Drawing.Size(500, 167);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAviso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProduto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.PictureBox picProduto;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox2 txtQtdEstoque;
        private MaterialSkin.Controls.MaterialLabel lblCodProd;
        private MaterialSkin.Controls.MaterialLabel lblNomeProd;
        private System.Windows.Forms.PictureBox picAviso;
        private MaterialSkin.Controls.MaterialButton btnSalvar;
        private MaterialSkin.Controls.MaterialLabel lblTipo;
    }
}
