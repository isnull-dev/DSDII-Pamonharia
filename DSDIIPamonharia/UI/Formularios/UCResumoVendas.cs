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
    public partial class UCResumoVendas : UserControl
    {
        public UCResumoVendas()
        {
            InitializeComponent();
        }

        public void setmodel(VendasModel model)
        {
            lblNomeProd.Text = model.Nome;
            lblCodProd.Text = model.Id_produto.ToString();
            txtPrecoMed.Text = model.Preco.ToString("F2");
            txtTotal.Text = model.Total.ToString("F2");
            txtTotalUN.Text = model.Quantidade.ToString("F2");
        }
    }
}
