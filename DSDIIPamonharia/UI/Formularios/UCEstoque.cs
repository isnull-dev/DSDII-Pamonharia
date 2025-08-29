using DSDIIPamonharia.BLL;
using DSDIIPamonharia.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSDIIPamonharia.UI.Formularios
{
    public partial class UCEstoque : UserControl
    {
        private ProdutosModel _produtoModel;
        private IngredientesModel _ingredienteModel;
        public UCEstoque()
        {
            InitializeComponent();
        }

        public void SetModelUCP(ProdutosModel model)
        {
            _produtoModel = model;
            lblNomeProd.Text = _produtoModel.Nome;
            lblCodProd.Text = _produtoModel.Id.ToString();
            txtQtdEstoque.Text = _produtoModel.Quantidade_Estoque.ToString("F2");
            lblTipo.Text = "Produto";
            if (_produtoModel.Imagem != null)
            {
                picProduto.Image = Utilities.ImageHelper.BytesToImage(_produtoModel.Imagem);
            }
            else
            {
                picProduto.Image = null;
            }
            btnSalvar.Enabled = false;
        }

        public void SetModelUCI(IngredientesModel model)
        {
            _ingredienteModel = model;
            lblNomeProd.Text = _ingredienteModel.Nome;
            lblCodProd.Text = _ingredienteModel.Id.ToString();
            txtQtdEstoque.Text = _ingredienteModel.Quantidade_Estoque.ToString("F2");
            lblTipo.Text = "Ingrediente";
            if (_ingredienteModel.Imagem != null)
            {
                picProduto.Image = Utilities.ImageHelper.BytesToImage(_ingredienteModel.Imagem);
            }
            else
            {
                picProduto.Image = null;
            }
            btnSalvar.Enabled = false;
        }
        private void txtQtdEstoque_TextChanged(object sender, EventArgs e)
        {
            if (txtQtdEstoque.Text == "" )
            {
                txtQtdEstoque.Text = "0";

            }
            if (decimal.Parse(txtQtdEstoque.Text) <=1)
            {
                picAviso.Visible = true;
            }
            else
            {
                picAviso.Visible = false;

            }

            btnSalvar.Enabled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            _produtoModel.Quantidade_Estoque = decimal.Parse(txtQtdEstoque.Text);
            var bll = new ProdutoBLL();
            if (bll.Alterar(_produtoModel))
            {
                btnSalvar.Enabled = false;

            }

        }
    }
}
