namespace DSDIIPamonharia.UI.Formularios
{
    partial class FormCadastro
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
            this.tabCProdutos = new System.Windows.Forms.TabPage();
            this.flpProdutos = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnPIncluir = new MaterialSkin.Controls.MaterialButton();
            this.tabCIngrediente = new System.Windows.Forms.TabPage();
            this.flpIngredientes = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnIIncluir = new MaterialSkin.Controls.MaterialButton();
            this.TBCMenu = new MaterialSkin.Controls.MaterialTabControl();
            this.tabCProdutos.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tabCIngrediente.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.TBCMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCProdutos
            // 
            this.tabCProdutos.Controls.Add(this.flpProdutos);
            this.tabCProdutos.Controls.Add(this.tableLayoutPanel3);
            this.tabCProdutos.ImageKey = "produtos.png";
            this.tabCProdutos.Location = new System.Drawing.Point(4, 22);
            this.tabCProdutos.Name = "tabCProdutos";
            this.tabCProdutos.Size = new System.Drawing.Size(1228, 692);
            this.tabCProdutos.TabIndex = 3;
            this.tabCProdutos.Text = "Produtos";
            this.tabCProdutos.UseVisualStyleBackColor = true;
            // 
            // flpProdutos
            // 
            this.flpProdutos.AutoScroll = true;
            this.flpProdutos.BackColor = System.Drawing.SystemColors.Control;
            this.flpProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpProdutos.Location = new System.Drawing.Point(0, 36);
            this.flpProdutos.Name = "flpProdutos";
            this.flpProdutos.Size = new System.Drawing.Size(1228, 656);
            this.flpProdutos.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 124F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.btnPIncluir, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1228, 36);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // btnPIncluir
            // 
            this.btnPIncluir.AutoSize = false;
            this.btnPIncluir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPIncluir.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnPIncluir.Depth = 0;
            this.btnPIncluir.HighEmphasis = true;
            this.btnPIncluir.Icon = null;
            this.btnPIncluir.Location = new System.Drawing.Point(4, 6);
            this.btnPIncluir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPIncluir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPIncluir.Name = "btnPIncluir";
            this.btnPIncluir.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnPIncluir.Size = new System.Drawing.Size(116, 24);
            this.btnPIncluir.TabIndex = 0;
            this.btnPIncluir.Text = "Incluir";
            this.btnPIncluir.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnPIncluir.UseAccentColor = false;
            this.btnPIncluir.UseVisualStyleBackColor = true;
            this.btnPIncluir.Click += new System.EventHandler(this.btnPIncluir_Click);
            // 
            // tabCIngrediente
            // 
            this.tabCIngrediente.BackColor = System.Drawing.Color.Transparent;
            this.tabCIngrediente.Controls.Add(this.flpIngredientes);
            this.tabCIngrediente.Controls.Add(this.tableLayoutPanel1);
            this.tabCIngrediente.ImageKey = "ingredientes.png";
            this.tabCIngrediente.Location = new System.Drawing.Point(4, 22);
            this.tabCIngrediente.Name = "tabCIngrediente";
            this.tabCIngrediente.Size = new System.Drawing.Size(1228, 692);
            this.tabCIngrediente.TabIndex = 0;
            this.tabCIngrediente.Text = "Ingredientes";
            this.tabCIngrediente.UseVisualStyleBackColor = true;
            // 
            // flpIngredientes
            // 
            this.flpIngredientes.AutoScroll = true;
            this.flpIngredientes.BackColor = System.Drawing.SystemColors.Control;
            this.flpIngredientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpIngredientes.Location = new System.Drawing.Point(0, 36);
            this.flpIngredientes.Name = "flpIngredientes";
            this.flpIngredientes.Size = new System.Drawing.Size(1228, 656);
            this.flpIngredientes.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 124F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnIIncluir, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1228, 36);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnIIncluir
            // 
            this.btnIIncluir.AutoSize = false;
            this.btnIIncluir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnIIncluir.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnIIncluir.Depth = 0;
            this.btnIIncluir.HighEmphasis = true;
            this.btnIIncluir.Icon = null;
            this.btnIIncluir.Location = new System.Drawing.Point(4, 6);
            this.btnIIncluir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnIIncluir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnIIncluir.Name = "btnIIncluir";
            this.btnIIncluir.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnIIncluir.Size = new System.Drawing.Size(116, 24);
            this.btnIIncluir.TabIndex = 1;
            this.btnIIncluir.Text = "Incluir";
            this.btnIIncluir.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnIIncluir.UseAccentColor = false;
            this.btnIIncluir.UseVisualStyleBackColor = true;
            this.btnIIncluir.Click += new System.EventHandler(this.btnIIncluir_Click);
            // 
            // TBCMenu
            // 
            this.TBCMenu.Controls.Add(this.tabCProdutos);
            this.TBCMenu.Controls.Add(this.tabCIngrediente);
            this.TBCMenu.Depth = 0;
            this.TBCMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBCMenu.Location = new System.Drawing.Point(3, 64);
            this.TBCMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.TBCMenu.Multiline = true;
            this.TBCMenu.Name = "TBCMenu";
            this.TBCMenu.SelectedIndex = 0;
            this.TBCMenu.Size = new System.Drawing.Size(1236, 718);
            this.TBCMenu.TabIndex = 1;
            this.TBCMenu.SelectedIndexChanged += new System.EventHandler(this.TBCMenu_SelectedIndexChanged);
            // 
            // FormCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 785);
            this.Controls.Add(this.TBCMenu);
            this.DrawerTabControl = this.TBCMenu;
            this.Name = "FormCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCadastro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormCadastro_Load);
            this.tabCProdutos.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tabCIngrediente.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.TBCMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabCProdutos;
        private System.Windows.Forms.FlowLayoutPanel flpProdutos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private MaterialSkin.Controls.MaterialButton btnPIncluir;
        private System.Windows.Forms.TabPage tabCIngrediente;
        private System.Windows.Forms.FlowLayoutPanel flpIngredientes;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialButton btnIIncluir;
        private MaterialSkin.Controls.MaterialTabControl TBCMenu;
    }
}