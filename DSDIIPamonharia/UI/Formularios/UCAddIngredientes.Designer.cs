namespace DSDIIPamonharia.UI.Formularios
{
    partial class UCAddIngredientes
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
            this.btnRemover = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtQuantidade = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbIngrediente = new MaterialSkin.Controls.MaterialComboBox();
            this.lblCusto = new MaterialSkin.Controls.MaterialLabel();
            this.lbl = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.lblCusto);
            this.materialCard1.Controls.Add(this.lbl);
            this.materialCard1.Controls.Add(this.btnRemover);
            this.materialCard1.Controls.Add(this.materialLabel2);
            this.materialCard1.Controls.Add(this.txtQuantidade);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Controls.Add(this.cmbIngrediente);
            this.materialCard1.Depth = 0;
            this.materialCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(0, 0);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(500, 139);
            this.materialCard1.TabIndex = 5;
            // 
            // btnRemover
            // 
            this.btnRemover.AutoSize = false;
            this.btnRemover.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRemover.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRemover.Depth = 0;
            this.btnRemover.HighEmphasis = true;
            this.btnRemover.Icon = null;
            this.btnRemover.Location = new System.Drawing.Point(403, 103);
            this.btnRemover.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRemover.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRemover.Size = new System.Drawing.Size(76, 30);
            this.btnRemover.TabIndex = 10;
            this.btnRemover.Text = "Remover";
            this.btnRemover.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnRemover.UseAccentColor = false;
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(400, 15);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(83, 19);
            this.materialLabel2.TabIndex = 7;
            this.materialLabel2.Text = "Quantidade";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.AnimateReadOnly = false;
            this.txtQuantidade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtQuantidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtQuantidade.Depth = 0;
            this.txtQuantidade.Enabled = false;
            this.txtQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtQuantidade.HideSelection = true;
            this.txtQuantidade.LeadingIcon = null;
            this.txtQuantidade.Location = new System.Drawing.Point(400, 37);
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
            this.txtQuantidade.TabIndex = 6;
            this.txtQuantidade.TabStop = false;
            this.txtQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtQuantidade.TrailingIcon = null;
            this.txtQuantidade.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(17, 14);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(79, 19);
            this.materialLabel1.TabIndex = 5;
            this.materialLabel1.Text = "Ingrediente";
            // 
            // cmbIngrediente
            // 
            this.cmbIngrediente.AutoResize = false;
            this.cmbIngrediente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbIngrediente.Depth = 0;
            this.cmbIngrediente.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbIngrediente.DropDownHeight = 174;
            this.cmbIngrediente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIngrediente.DropDownWidth = 121;
            this.cmbIngrediente.Enabled = false;
            this.cmbIngrediente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbIngrediente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbIngrediente.FormattingEnabled = true;
            this.cmbIngrediente.IntegralHeight = false;
            this.cmbIngrediente.ItemHeight = 43;
            this.cmbIngrediente.Location = new System.Drawing.Point(17, 36);
            this.cmbIngrediente.MaxDropDownItems = 4;
            this.cmbIngrediente.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbIngrediente.Name = "cmbIngrediente";
            this.cmbIngrediente.Size = new System.Drawing.Size(367, 49);
            this.cmbIngrediente.StartIndex = 0;
            this.cmbIngrediente.TabIndex = 4;
            // 
            // lblCusto
            // 
            this.lblCusto.AutoSize = true;
            this.lblCusto.Depth = 0;
            this.lblCusto.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCusto.Location = new System.Drawing.Point(101, 110);
            this.lblCusto.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCusto.Name = "lblCusto";
            this.lblCusto.Size = new System.Drawing.Size(31, 19);
            this.lblCusto.TabIndex = 24;
            this.lblCusto.Text = "0,00";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Depth = 0;
            this.lbl.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl.Location = new System.Drawing.Point(17, 110);
            this.lbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(73, 19);
            this.lbl.TabIndex = 23;
            this.lbl.Text = "Custo: R$ ";
            // 
            // UCAddIngredientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.materialCard1);
            this.Name = "UCAddIngredientes";
            this.Size = new System.Drawing.Size(500, 139);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox2 txtQuantidade;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialComboBox cmbIngrediente;
        private MaterialSkin.Controls.MaterialButton btnRemover;
        private MaterialSkin.Controls.MaterialLabel lblCusto;
        private MaterialSkin.Controls.MaterialLabel lbl;
    }
}
