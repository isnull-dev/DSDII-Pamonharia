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
    public partial class UCCProdutos : UserControl
    {
        private ProdutosModel _model;
        public UCCProdutos()
        {
            InitializeComponent();
        }
        // Método público para setar o model no UC
        public void SetModelUC(ProdutosModel model)
        {
            _model = model;
            lblNomeProd.Text = _model.Nome;
            lblCodProd.Text = _model.Id.ToString();
            txtDescrição.Text = _model.Descricao;

            if (_model.Imagem != null)
            {
                picProduto.Image = Utilities.ImageHelper.BytesToImage(_model.Imagem);
            }
            else
            {
                picProduto.Image = null;
            }
        }

        private void CardProduto_Click(object sender, EventArgs e)
        {
            var frm = new FormVisuProdutos(
                permitirInclusao: false,
                permitirAlteracao: true,
                permitirExclusao: true,
                callback: model =>
                {
                    SetModelUC(model);
                },
                onDelete: () =>
                {
                    this.Parent.Controls.Remove(this);
                    this.Dispose();
                }
            );
            frm.SetModel(_model);
            frm.ShowDialog();
        }
    }
}
