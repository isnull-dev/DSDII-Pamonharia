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
    public partial class UCAddIngredientes : UserControl
    {
        private ReceitasModel _model;
        public UCAddIngredientes()
        {
            InitializeComponent();
        }
        // Método público para setar o model no UC
        public void SetModelUC(ReceitasModel model)
        {
            _model = model;
            cmbIngrediente.Items.Add(_model.NomeIngrediente);
            cmbIngrediente.SelectedIndex = 0;
            txtQuantidade.Text = _model.Quantidade.ToString("F2");
            lblCusto.Text = _model.Custo.ToString("F2");
            
        }

        public ReceitasModel GetModel()
        {
            return _model;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            var bll = new ReceitaBLL();
            if (_model.Id.ToString() == "")
            {
                this.Parent.Controls.Remove(this);
                this.Dispose();
            }
            else if(bll.Excluir(_model))
            {
                this.Parent.Controls.Remove(this);
                this.Dispose();
            }
            
            
        }
    }
}
