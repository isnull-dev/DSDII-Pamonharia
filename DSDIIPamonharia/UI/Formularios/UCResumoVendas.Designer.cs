namespace DSDIIPamonharia.UI.Formularios
{
    partial class UCResumoVendas
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtTotalUN = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblCodProd = new MaterialSkin.Controls.MaterialLabel();
            this.lblNomeProd = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtTotal = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtPrecoMed = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.materialLabel3);
            this.materialCard1.Controls.Add(this.txtPrecoMed);
            this.materialCard1.Controls.Add(this.materialLabel2);
            this.materialCard1.Controls.Add(this.txtTotal);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Controls.Add(this.txtTotalUN);
            this.materialCard1.Controls.Add(this.lblCodProd);
            this.materialCard1.Controls.Add(this.lblNomeProd);
            this.materialCard1.Depth = 0;
            this.materialCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(0, 0);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(500, 150);
            this.materialCard1.TabIndex = 0;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(17, 63);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(72, 19);
            this.materialLabel1.TabIndex = 16;
            this.materialLabel1.Text = "Total (Un)";
            // 
            // txtTotalUN
            // 
            this.txtTotalUN.AnimateReadOnly = false;
            this.txtTotalUN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTotalUN.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTotalUN.Depth = 0;
            this.txtTotalUN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTotalUN.HideSelection = true;
            this.txtTotalUN.LeadingIcon = null;
            this.txtTotalUN.Location = new System.Drawing.Point(19, 85);
            this.txtTotalUN.MaxLength = 32767;
            this.txtTotalUN.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTotalUN.Name = "txtTotalUN";
            this.txtTotalUN.PasswordChar = '\0';
            this.txtTotalUN.PrefixSuffixText = null;
            this.txtTotalUN.ReadOnly = false;
            this.txtTotalUN.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTotalUN.SelectedText = "";
            this.txtTotalUN.SelectionLength = 0;
            this.txtTotalUN.SelectionStart = 0;
            this.txtTotalUN.ShortcutsEnabled = true;
            this.txtTotalUN.Size = new System.Drawing.Size(138, 48);
            this.txtTotalUN.TabIndex = 15;
            this.txtTotalUN.TabStop = false;
            this.txtTotalUN.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTotalUN.TrailingIcon = null;
            this.txtTotalUN.UseSystemPasswordChar = false;
            // 
            // lblCodProd
            // 
            this.lblCodProd.AutoSize = true;
            this.lblCodProd.Depth = 0;
            this.lblCodProd.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCodProd.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            this.lblCodProd.Location = new System.Drawing.Point(16, 32);
            this.lblCodProd.Margin = new System.Windows.Forms.Padding(0);
            this.lblCodProd.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCodProd.Name = "lblCodProd";
            this.lblCodProd.Size = new System.Drawing.Size(74, 14);
            this.lblCodProd.TabIndex = 14;
            this.lblCodProd.Text = "#CodProduto";
            // 
            // lblNomeProd
            // 
            this.lblNomeProd.AutoSize = true;
            this.lblNomeProd.Depth = 0;
            this.lblNomeProd.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblNomeProd.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblNomeProd.Location = new System.Drawing.Point(15, 8);
            this.lblNomeProd.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNomeProd.Name = "lblNomeProd";
            this.lblNomeProd.Size = new System.Drawing.Size(142, 24);
            this.lblNomeProd.TabIndex = 13;
            this.lblNomeProd.Text = "#Nome Produto";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(305, 63);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(72, 19);
            this.materialLabel2.TabIndex = 19;
            this.materialLabel2.Text = "Total (R$)";
            // 
            // txtTotal
            // 
            this.txtTotal.AnimateReadOnly = false;
            this.txtTotal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTotal.Depth = 0;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTotal.HideSelection = true;
            this.txtTotal.LeadingIcon = null;
            this.txtTotal.Location = new System.Drawing.Point(307, 85);
            this.txtTotal.MaxLength = 32767;
            this.txtTotal.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.PasswordChar = '\0';
            this.txtTotal.PrefixSuffixText = null;
            this.txtTotal.ReadOnly = false;
            this.txtTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTotal.SelectedText = "";
            this.txtTotal.SelectionLength = 0;
            this.txtTotal.SelectionStart = 0;
            this.txtTotal.ShortcutsEnabled = true;
            this.txtTotal.Size = new System.Drawing.Size(138, 48);
            this.txtTotal.TabIndex = 18;
            this.txtTotal.TabStop = false;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTotal.TrailingIcon = null;
            this.txtTotal.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(161, 63);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(80, 19);
            this.materialLabel3.TabIndex = 21;
            this.materialLabel3.Text = "Preço Méd.";
            // 
            // txtPrecoMed
            // 
            this.txtPrecoMed.AnimateReadOnly = false;
            this.txtPrecoMed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtPrecoMed.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPrecoMed.Depth = 0;
            this.txtPrecoMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrecoMed.HideSelection = true;
            this.txtPrecoMed.LeadingIcon = null;
            this.txtPrecoMed.Location = new System.Drawing.Point(163, 85);
            this.txtPrecoMed.MaxLength = 32767;
            this.txtPrecoMed.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPrecoMed.Name = "txtPrecoMed";
            this.txtPrecoMed.PasswordChar = '\0';
            this.txtPrecoMed.PrefixSuffixText = null;
            this.txtPrecoMed.ReadOnly = false;
            this.txtPrecoMed.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPrecoMed.SelectedText = "";
            this.txtPrecoMed.SelectionLength = 0;
            this.txtPrecoMed.SelectionStart = 0;
            this.txtPrecoMed.ShortcutsEnabled = true;
            this.txtPrecoMed.Size = new System.Drawing.Size(138, 48);
            this.txtPrecoMed.TabIndex = 20;
            this.txtPrecoMed.TabStop = false;
            this.txtPrecoMed.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPrecoMed.TrailingIcon = null;
            this.txtPrecoMed.UseSystemPasswordChar = false;
            // 
            // UCResumoVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.materialCard1);
            this.Name = "UCResumoVendas";
            this.Size = new System.Drawing.Size(500, 150);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox2 txtTotalUN;
        private MaterialSkin.Controls.MaterialLabel lblCodProd;
        private MaterialSkin.Controls.MaterialLabel lblNomeProd;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox2 txtPrecoMed;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox2 txtTotal;
    }
}
