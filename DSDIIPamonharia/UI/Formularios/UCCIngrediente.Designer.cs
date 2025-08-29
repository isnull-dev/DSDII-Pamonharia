namespace DSDIIPamonharia.UI.Formularios
{
    partial class UCCIngrediente
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
            this.lblCodIngr = new MaterialSkin.Controls.MaterialLabel();
            this.lblNomeIngr = new MaterialSkin.Controls.MaterialLabel();
            this.picProduto = new System.Windows.Forms.PictureBox();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.lblCodIngr);
            this.materialCard1.Controls.Add(this.lblNomeIngr);
            this.materialCard1.Controls.Add(this.picProduto);
            this.materialCard1.Depth = 0;
            this.materialCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(0, 0);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(200, 253);
            this.materialCard1.TabIndex = 0;
            this.materialCard1.Click += new System.EventHandler(this.materialCard1_Click);
            // 
            // lblCodIngr
            // 
            this.lblCodIngr.AutoSize = true;
            this.lblCodIngr.Depth = 0;
            this.lblCodIngr.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCodIngr.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCodIngr.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            this.lblCodIngr.Location = new System.Drawing.Point(14, 33);
            this.lblCodIngr.Margin = new System.Windows.Forms.Padding(0);
            this.lblCodIngr.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCodIngr.Name = "lblCodIngr";
            this.lblCodIngr.Size = new System.Drawing.Size(74, 14);
            this.lblCodIngr.TabIndex = 2;
            this.lblCodIngr.Text = "#CodProduto";
            this.lblCodIngr.Click += new System.EventHandler(this.materialCard1_Click);
            // 
            // lblNomeIngr
            // 
            this.lblNomeIngr.AutoSize = true;
            this.lblNomeIngr.Depth = 0;
            this.lblNomeIngr.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNomeIngr.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblNomeIngr.Location = new System.Drawing.Point(14, 14);
            this.lblNomeIngr.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNomeIngr.Name = "lblNomeIngr";
            this.lblNomeIngr.Size = new System.Drawing.Size(109, 19);
            this.lblNomeIngr.TabIndex = 1;
            this.lblNomeIngr.Text = "#NomeProduto";
            this.lblNomeIngr.Click += new System.EventHandler(this.materialCard1_Click);
            // 
            // picProduto
            // 
            this.picProduto.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.picProduto.Location = new System.Drawing.Point(14, 64);
            this.picProduto.Name = "picProduto";
            this.picProduto.Size = new System.Drawing.Size(172, 175);
            this.picProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProduto.TabIndex = 0;
            this.picProduto.TabStop = false;
            this.picProduto.Click += new System.EventHandler(this.materialCard1_Click);
            // 
            // UCCIngrediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.materialCard1);
            this.Name = "UCCIngrediente";
            this.Size = new System.Drawing.Size(200, 253);
            this.Click += new System.EventHandler(this.materialCard1_Click);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProduto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel lblCodIngr;
        private MaterialSkin.Controls.MaterialLabel lblNomeIngr;
        private System.Windows.Forms.PictureBox picProduto;
    }
}
