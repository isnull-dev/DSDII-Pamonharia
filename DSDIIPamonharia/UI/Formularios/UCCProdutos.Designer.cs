namespace DSDIIPamonharia.UI.Formularios
{
    partial class UCCProdutos
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
            this.CardProduto = new MaterialSkin.Controls.MaterialCard();
            this.picProduto = new System.Windows.Forms.PictureBox();
            this.lblCodProd = new MaterialSkin.Controls.MaterialLabel();
            this.lblNomeProd = new MaterialSkin.Controls.MaterialLabel();
            this.txtDescrição = new System.Windows.Forms.TextBox();
            this.CardProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // CardProduto
            // 
            this.CardProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CardProduto.Controls.Add(this.txtDescrição);
            this.CardProduto.Controls.Add(this.lblCodProd);
            this.CardProduto.Controls.Add(this.lblNomeProd);
            this.CardProduto.Controls.Add(this.picProduto);
            this.CardProduto.Depth = 0;
            this.CardProduto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CardProduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CardProduto.Location = new System.Drawing.Point(0, 0);
            this.CardProduto.Margin = new System.Windows.Forms.Padding(14);
            this.CardProduto.MouseState = MaterialSkin.MouseState.HOVER;
            this.CardProduto.Name = "CardProduto";
            this.CardProduto.Padding = new System.Windows.Forms.Padding(14);
            this.CardProduto.Size = new System.Drawing.Size(525, 156);
            this.CardProduto.TabIndex = 1;
            this.CardProduto.Click += new System.EventHandler(this.CardProduto_Click);
            // 
            // picProduto
            // 
            this.picProduto.Location = new System.Drawing.Point(17, 14);
            this.picProduto.Name = "picProduto";
            this.picProduto.Size = new System.Drawing.Size(125, 125);
            this.picProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProduto.TabIndex = 0;
            this.picProduto.TabStop = false;
            // 
            // lblCodProd
            // 
            this.lblCodProd.AutoSize = true;
            this.lblCodProd.Depth = 0;
            this.lblCodProd.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCodProd.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            this.lblCodProd.Location = new System.Drawing.Point(170, 38);
            this.lblCodProd.Margin = new System.Windows.Forms.Padding(0);
            this.lblCodProd.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCodProd.Name = "lblCodProd";
            this.lblCodProd.Size = new System.Drawing.Size(69, 14);
            this.lblCodProd.TabIndex = 5;
            this.lblCodProd.Text = "#CodReceita";
            // 
            // lblNomeProd
            // 
            this.lblNomeProd.AutoSize = true;
            this.lblNomeProd.Depth = 0;
            this.lblNomeProd.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblNomeProd.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblNomeProd.Location = new System.Drawing.Point(169, 14);
            this.lblNomeProd.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNomeProd.Name = "lblNomeProd";
            this.lblNomeProd.Size = new System.Drawing.Size(138, 24);
            this.lblNomeProd.TabIndex = 4;
            this.lblNomeProd.Text = "#Nome Receita";
            // 
            // txtDescrição
            // 
            this.txtDescrição.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescrição.Enabled = false;
            this.txtDescrição.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescrição.Location = new System.Drawing.Point(173, 69);
            this.txtDescrição.MaxLength = 150;
            this.txtDescrição.Multiline = true;
            this.txtDescrição.Name = "txtDescrição";
            this.txtDescrição.Size = new System.Drawing.Size(337, 70);
            this.txtDescrição.TabIndex = 6;
            this.txtDescrição.Text = "#Descrição";
            // 
            // UCCProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CardProduto);
            this.Name = "UCCProdutos";
            this.Size = new System.Drawing.Size(525, 156);
            this.CardProduto.ResumeLayout(false);
            this.CardProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProduto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialCard CardProduto;
        private System.Windows.Forms.PictureBox picProduto;
        private MaterialSkin.Controls.MaterialLabel lblCodProd;
        private MaterialSkin.Controls.MaterialLabel lblNomeProd;
        private System.Windows.Forms.TextBox txtDescrição;
    }
}
