using DSDIIPamonharia.BLL;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSDIIPamonharia.UI.Formularios
{
    public partial class FormVendas : MaterialForm
    {
        public FormVendas()
        {
            InitializeComponent();
        }

        private void btnAddVendas_Click(object sender, EventArgs e)
        {
            VendasModel vendas = new VendasModel
            {
                Id_venda = 0, //banco gera
                Total = decimal.Parse(lblTotal.Text),

                Id_item = 0, //banco gera
                Id_produto = int.Parse(cmbVendaProduto.SelectedItem.ToString().Split(new[] { "- " }, StringSplitOptions.None)[1]),
                Quantidade = decimal.Parse(txtQuantidade.Text),
                Preco = decimal.Parse(txtUnit.Text),

                Nome = cmbVendaProduto.SelectedItem.ToString().Split(new[] { " -" }, StringSplitOptions.None)[0]

            };

            var uc = new UCVendas();
            uc.SetModel(vendas);
            flpVendas.Controls.Add(uc);
        }

        private void FormVendas_Load(object sender, EventArgs e)
        {
            CarregarProdutos();
        }
        private void CarregarProdutos()
        {
            var bll = new ProdutoBLL();
            var produtos = bll.ListarProdutos(false);
            foreach (var produto in produtos)
            {
                cmbVendaProduto.Items.Add(produto.Nome + " - " + produto.Id);
            }
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

        private void materialButton1_Click(object sender, EventArgs e)
        {
            
            var bll = new VendasBLL();
            List<VendasModel> listaVendas = new List<VendasModel>();
            foreach (UCVendas uc in flpVendas.Controls.OfType<UCVendas>())
            {
                listaVendas.Add(uc.GetModel());
            }
            decimal totalGeral = flpVendas.Controls
                        .OfType<UCVendas>()
                        .Sum(uc => uc.GetModel().Total);

            var IdVenda = bll.IncluirVenda(totalGeral);

            foreach (var venda in listaVendas)
            {
                venda.Id_venda = IdVenda.Id_venda;
                VendasModel vendaCompleta = bll.IncluirItem(venda);
                venda.Id_item = vendaCompleta.Id_item;
            }
            flpVendas.Controls.Clear();
            cmbVendaProduto.SelectedItem = null;
            CarregarProdutos();
            txtQuantidade.Text = string.Empty;
            txtUnit.Text = string.Empty;
            lblTotal.Text = "0,00";
        }

        private void cmbVendaProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbVendaProduto.SelectedItem == null) return;
            ProdutoBLL bll = new ProdutoBLL();
            ProdutosModel produto = new ProdutosModel();
            produto = bll.ObterPorId(int.Parse(cmbVendaProduto.SelectedItem.ToString().Split(new[] { "- " }, StringSplitOptions.None)[1]));
            
            txtUnit.Text = produto.Preco.ToString("F2");
        }
    }
}
