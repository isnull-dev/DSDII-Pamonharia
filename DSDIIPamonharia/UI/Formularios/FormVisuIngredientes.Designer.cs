namespace DSDIIPamonharia.UI.Formularios
{
    partial class FormVisuIngredientes
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
            this.btnExcluir = new MaterialSkin.Controls.MaterialButton();
            this.btnAlterar = new MaterialSkin.Controls.MaterialButton();
            this.btnIncluir = new MaterialSkin.Controls.MaterialButton();
            this.picProduto = new System.Windows.Forms.PictureBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbUN = new MaterialSkin.Controls.MaterialComboBox();
            this.txtNomeProduto = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.txtValor = new MaterialSkin.Controls.MaterialTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProduto)).BeginInit();
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
            this.txtDescricao.Location = new System.Drawing.Point(30, 190);
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
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.btnExcluir, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAlterar, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnIncluir, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(434, 420);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(320, 41);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // btnExcluir
            // 
            this.btnExcluir.AutoSize = false;
            this.btnExcluir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExcluir.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnExcluir.Depth = 0;
            this.btnExcluir.HighEmphasis = true;
            this.btnExcluir.Icon = null;
            this.btnExcluir.Location = new System.Drawing.Point(216, 6);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnExcluir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnExcluir.Size = new System.Drawing.Size(98, 29);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnExcluir.UseAccentColor = false;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.AutoSize = false;
            this.btnAlterar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAlterar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAlterar.Depth = 0;
            this.btnAlterar.HighEmphasis = true;
            this.btnAlterar.Icon = null;
            this.btnAlterar.Location = new System.Drawing.Point(110, 6);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAlterar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAlterar.Size = new System.Drawing.Size(98, 29);
            this.btnAlterar.TabIndex = 1;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAlterar.UseAccentColor = false;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
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
            this.btnIncluir.Size = new System.Drawing.Size(98, 29);
            this.btnIncluir.TabIndex = 0;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnIncluir.UseAccentColor = false;
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // picProduto
            // 
            this.picProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picProduto.Location = new System.Drawing.Point(434, 84);
            this.picProduto.Name = "picProduto";
            this.picProduto.Size = new System.Drawing.Size(320, 320);
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
            this.materialLabel3.Location = new System.Drawing.Point(264, 382);
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
            this.materialLabel2.Location = new System.Drawing.Point(27, 168);
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
            this.materialLabel1.Location = new System.Drawing.Point(27, 84);
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
            "-",
            "G",
            "KG",
            "LITRO",
            "UN"});
            this.cmbUN.Location = new System.Drawing.Point(267, 404);
            this.cmbUN.MaxDropDownItems = 4;
            this.cmbUN.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbUN.Name = "cmbUN";
            this.cmbUN.Size = new System.Drawing.Size(113, 49);
            this.cmbUN.StartIndex = 0;
            this.cmbUN.TabIndex = 3;
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.AnimateReadOnly = false;
            this.txtNomeProduto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomeProduto.Depth = 0;
            this.txtNomeProduto.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNomeProduto.LeadingIcon = null;
            this.txtNomeProduto.Location = new System.Drawing.Point(30, 106);
            this.txtNomeProduto.MaxLength = 50;
            this.txtNomeProduto.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNomeProduto.Multiline = false;
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(350, 50);
            this.txtNomeProduto.TabIndex = 0;
            this.txtNomeProduto.Text = "";
            this.txtNomeProduto.TrailingIcon = null;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(28, 382);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(38, 19);
            this.materialLabel4.TabIndex = 20;
            this.materialLabel4.Text = "Valor";
            // 
            // txtValor
            // 
            this.txtValor.AnimateReadOnly = false;
            this.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValor.Depth = 0;
            this.txtValor.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtValor.LeadingIcon = null;
            this.txtValor.Location = new System.Drawing.Point(30, 405);
            this.txtValor.MaxLength = 50;
            this.txtValor.MouseState = MaterialSkin.MouseState.OUT;
            this.txtValor.Multiline = false;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(199, 50);
            this.txtValor.TabIndex = 2;
            this.txtValor.Text = "";
            this.txtValor.TrailingIcon = null;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormVisuIngredientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 518);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.picProduto);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.cmbUN);
            this.Controls.Add(this.txtNomeProduto);
            this.Name = "FormVisuIngredientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormVisuProduto";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private MaterialSkin.Controls.MaterialTextBox txtValor;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}