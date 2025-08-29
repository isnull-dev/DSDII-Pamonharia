using DSDIIPamonharia.BLL;
using DSDIIPamonharia.Core;
using MaterialSkin.Controls;
using DSDIIPamonharia.UI.Formularios;
using System;
using System.Windows.Forms;


namespace DSDIIPamonharia.UI.Formularios
{
    public partial class FormCadastro : MaterialForm
    {

        public FormCadastro()
        {
            InitializeComponent();
            this.Text = TBCMenu.TabPages[TBCMenu.SelectedIndex].Text;

        }
        private void FormCadastro_Load(object sender, EventArgs e)
        {
            CarregarProdutos(flpProdutos);
        }

        private void TBCMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (TBCMenu.TabPages[TBCMenu.SelectedIndex].Text)
            {
                case "Ingredientes":
                    CarregarIngredientes(flpIngredientes);
                    break;
                case "Produtos":
                    CarregarProdutos(flpProdutos);
                    break;
                default:
                    break;
            }
            this.Text = TBCMenu.TabPages[TBCMenu.SelectedIndex].Text;

        }

        #region Ingredientes
        public void CarregarIngredientes(FlowLayoutPanel flp)
        {
            flp.Controls.Clear();
            var bll = new IngredienteBLL();
            var ingredientes = bll.ListarIngredientes();
            foreach (var ing in ingredientes)
            {
                var uc = new UCCIngrediente();
                uc.SetModelUC(ing); // só passa o model inteiro
                flp.Controls.Add(uc);
            }
        }
        private void btnIIncluir_Click(object sender, EventArgs e)
        {
            var frm = new FormVisuIngredientes(
                permitirInclusao: true,
                permitirAlteracao: false,
                permitirExclusao: false,
                callback: novoIngrediente =>
                {
                    var uc = new UCCIngrediente();
                    uc.SetModelUC(novoIngrediente);
                    flpIngredientes.Controls.Add(uc);
                }
            );
            frm.ShowDialog();
        }
        #endregion

        #region Produtos
        public void CarregarProdutos(FlowLayoutPanel flp)
        {
            flp.Controls.Clear();
            var bll = new ProdutoBLL();
            var produtos = bll.ListarProdutos(true);
            foreach (var prod in produtos)
            {
                var uc = new UCCProdutos();
                uc.SetModelUC(prod);
                flp.Controls.Add(uc);
            }
        }
        private void btnPIncluir_Click(object sender, EventArgs e)
        {
            var frm = new FormVisuProdutos(
                permitirInclusao: true,
                permitirAlteracao: false,
                permitirExclusao: false,
                callback: novoProduto =>
                {
                    var uc = new UCCProdutos();
                    uc.SetModelUC(novoProduto);
                    flpProdutos.Controls.Add(uc);
                }
            );
            frm.ShowDialog();
        }

        #endregion

        
    }

}