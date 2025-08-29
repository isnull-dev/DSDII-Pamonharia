using DSDIIPamonharia.BLL;
using MaterialSkin.Controls;
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
    public partial class FormEstoque : MaterialForm
    {
        public FormEstoque()
        {
            InitializeComponent();
        }

        private void FormEstoque_Load(object sender, EventArgs e)
        {
            var bll = new ProdutoBLL();
            var produtos = bll.ListarProdutos(true);
            foreach (var produto in produtos)
            {
                var uc =new UCEstoque();
                uc.SetModelUCP(produto);
                flpEstoque.Controls.Add(uc);
            }

            var bll2 = new IngredienteBLL();
            var ingredientes = bll2.ListarIngredientes();
            foreach (var ingrediente in ingredientes)
            {
                var uc = new UCEstoque();
                uc.SetModelUCI(ingrediente);
                flpEstoque.Controls.Add(uc);
            }

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            FormPrincipal frm = new FormPrincipal();
            frm.Show();
            this.Dispose();
        }
    }
}
