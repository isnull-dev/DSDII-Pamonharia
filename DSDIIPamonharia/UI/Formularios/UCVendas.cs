using DSDIIPamonharia.BLL;
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
     
    public partial class UCVendas : UserControl
    {
        private VendasModel _vendasModel;
        public UCVendas()
        {
            InitializeComponent();
        }

        public void SetModel(VendasModel model)

        {
            _vendasModel = model;
            cmbProduto.Items.Add(_vendasModel.Nome);
            cmbProduto.SelectedIndex = 0;
            cmbProduto.Enabled = false;

            txtQuantidade.Text = _vendasModel.Quantidade.ToString("F2");

            txtUnit.Text = _vendasModel.Preco.ToString("F2");
            txtUnit.Enabled = false;

            lblTotal.Text = _vendasModel.Total.ToString("F2");
        }
        public VendasModel GetModel()
        {
            return _vendasModel;
        }



    private void btnRemover_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
            this.Dispose();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            
        }

        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {
            if (txtQuantidade.Text != "" && txtUnit.Text != "")
            {
                decimal a = decimal.Parse(txtQuantidade.Text);
                decimal b = decimal.Parse(txtUnit.Text);
                lblTotal.Text = (a * b).ToString("F2");
            }
        }
    }
}
