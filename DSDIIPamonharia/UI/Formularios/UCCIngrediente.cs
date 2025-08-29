using DSDIIPamonharia.BLL;
using DSDIIPamonharia.Core;

using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DSDIIPamonharia.UI.Formularios
{
    public partial class UCCIngrediente : UserControl
    {
        private IngredientesModel _model;

        public UCCIngrediente()
        {
            InitializeComponent();
        }

        // Método público para setar o model no UC
        public void SetModelUC(IngredientesModel model)
        {
            //if (_model == null) return;

            _model = model;
            lblNomeIngr.Text = _model.Nome;
            lblCodIngr.Text = _model.Id.ToString();

            if (_model.Imagem != null)
            {
                picProduto.Image = Utilities.ImageHelper.BytesToImage(_model.Imagem);
            }
            else
            {
                picProduto.Image = null;
            }
        }


        private void materialCard1_Click(object sender, EventArgs e)
        {
            var frm = new FormVisuIngredientes(
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