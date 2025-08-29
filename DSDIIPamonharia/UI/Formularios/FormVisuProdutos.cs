using DSDIIPamonharia.BLL;
using DSDIIPamonharia.Core;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;


namespace DSDIIPamonharia.UI.Formularios
{
    public partial class FormVisuProdutos : MaterialForm
    {
        private ProdutosModel _model;
        private decimal _aux;

        private Action<ProdutosModel> _callback;
        private readonly Action _onDelete;

        public FormVisuProdutos(
            bool permitirInclusao,
            bool permitirAlteracao,
            bool permitirExclusao,
            Action<ProdutosModel> callback = null,
            Action onDelete = null)
        {
            InitializeComponent();
            btnIncluir.Visible = permitirInclusao;
            btnAlterar.Visible = permitirAlteracao;
            btnExcluir.Visible = permitirExclusao;

            _callback = callback;
            _onDelete = onDelete;
        }

        private void TBCProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (TBCProduto.TabPages[TBCProduto.SelectedIndex].Text)
            {
                case "Informações":

                    break;
                case "Receita":
                    CarregarReceitaflp(flpReceita);
                    CarregarIngrediente(cmbReceita);

                    break;
                default:
                    break;
            }
            this.Text = TBCProduto.TabPages[TBCProduto.SelectedIndex].Text;

        }
        private bool ValidarC()
        {
            if (!Utilities.Validadores.VControles(PageInformacoes))
            {
                MessageBox.Show(
                    "Tem informações sem preencher na pagina informações. Preencha!",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return false;

            }

            if (cmbUsaReceita.SelectedItem.ToString() == "Sim")
            {
                if (flpReceita.HasChildren)
                {
                    if (!Utilities.Validadores.VControles(flpReceita))
                    {
                        MessageBox.Show(
                            "Tem informações sem preencher na pagina informações. Preencha!",
                            "Atenção",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        ); return false;
                    }
                }
                else
                {
                    MessageBox.Show("Produto sem receita!",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return false;
                }
            }

            return true;
        }


        #region FormVisuProduto
        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (!ValidarC()){ return; }
            ;
            ProdutosModel modelIncluir = new ProdutosModel
            {
                Nome = txtNomeProduto.Text,
                Descricao = txtDescricao.Text,
                Unidade = cmbUN.Text,
                Quantidade_Estoque = 0,
                Custo = decimal.Parse(txtCusto.Text),
                Preco = decimal.Parse(txtValor.Text),
                Imagem = Utilities.ImageHelper.ImageToBytes(picProduto.Image)
            };

            var bll = new ProdutoBLL();
            ProdutosModel novo = bll.Incluir(modelIncluir);

            var Rbll = new ReceitaBLL();
            List<ReceitasModel> listaIngredientes = new List<ReceitasModel>();

            foreach (UCAddIngredientes uc in flpReceita.Controls.OfType<UCAddIngredientes>())
            {
                listaIngredientes.Add(uc.GetModel());
            }
            foreach (var item in listaIngredientes)
            {
                item.IdProduto = novo.Id;
                Rbll.Incluir(item);

            }

            _callback?.Invoke(novo); // chama o callback do form chamador

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            ProdutosModel modelAlterado = new ProdutosModel
            {
                Id = _model.Id,
                Nome = txtNomeProduto.Text,
                Unidade = cmbUN.Text,
                Quantidade_Estoque = _model.Quantidade_Estoque,
                Custo = Decimal.Parse(txtCusto.Text),
                Preco = Decimal.Parse(txtValor.Text),
                Descricao = txtDescricao.Text,
                Imagem = Utilities.ImageHelper.ImageToBytes(picProduto.Image),
            };

            var Rbll = new ReceitaBLL();
            List<ReceitasModel> listaIngredientes = new List<ReceitasModel>();

            foreach (UCAddIngredientes uc in flpReceita.Controls.OfType<UCAddIngredientes>())
            {
                listaIngredientes.Add(uc.GetModel());
            }
            foreach (var item in listaIngredientes)
            {
                if (item.Id.ToString() != "")
                {
                    Rbll.Alterar(item);
                }
                else
                {
                    item.IdProduto = _model.Id;
                    Rbll.Incluir(item);
                }
                    

            }
            var bll = new ProdutoBLL();
            if (bll.Alterar(modelAlterado))
            {
                _callback?.Invoke(modelAlterado);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {

            var bll = new ProdutoBLL();
            var Rbll = new ReceitaBLL();
            Rbll.ExcluirPorProduto(_model);

            if (bll.Excluir(_model))
            {
                _onDelete?.Invoke();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

        }
        #endregion

        #region Informações
        public void SetModel(ProdutosModel model)
        {
            _model = model;

            txtNomeProduto.Text = _model.Nome;
            cmbUN.SelectedItem = _model.Unidade.ToUpper();
            txtDescricao.Text = _model.Descricao;
            txtCusto.Text = _model.Custo.ToString("F2");
            txtValor.Text = _model.Preco.ToString("F2");

            if (_model.Imagem != null)
            {
                picProduto.Image = Utilities.ImageHelper.BytesToImage(_model.Imagem);
            }
            else
            {
                picProduto.Image = null;
            }



        }
        private void picProduto_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Arquivos de imagem|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                picProduto.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
        #endregion

        #region Receitas
        public void CarregarReceitaflp(FlowLayoutPanel flp)
        {
            if (_model == null) return;
            var bll = new ReceitaBLL();
            var Receita = bll.ObterPorId(_model.Id);
            foreach (var ing in Receita)
            {
                var uc = new UCAddIngredientes();
                uc.SetModelUC(ing);
                flp.Controls.Add(uc);
            }
        }
        public void CarregarIngrediente(MaterialComboBox cmb)
        {
            cmb.Items.Clear();
            List<IngredientesModel> list = new List<IngredientesModel>();
            var bll = new IngredienteBLL();
            list = bll.ListarIngredientes();
            foreach (var ing in list)
            {
                cmb.Items.Add(ing.Nome);
            }

        }
        private void cmbReceita_SelectedIndexChanged(object sender, EventArgs e)
        {
            var bll = new IngredienteBLL();
            IngredientesModel ingrediente = bll.ObterPorNome(cmbReceita.SelectedItem.ToString());
            lblCusto.Text = ingrediente.Custo.ToString("F2");
            txtId.Text = ingrediente.Id.ToString();
            _aux = ingrediente.Custo;
        }
        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {

            if (txtQuantidade.Text != "" && decimal.Parse(txtQuantidade.Text) > 0)
            {
                decimal quantidade = decimal.Parse(txtQuantidade.Text);
                lblCusto.Text = (_aux * quantidade).ToString();
            }
            else
            {
                lblCusto.Text = "0,00";
            }

        }
        private void cmbUsaReceita_SelectedIndexChanged(object sender, EventArgs e)
        {
            string resposta = cmbUsaReceita.SelectedItem.ToString();
            switch (resposta)
            {
                case "Sim":
                    txtCusto.Enabled = false;
                    decimal soma = flpReceita.Controls
                        .OfType<UCAddIngredientes>()
                        .Where(x => x.GetModel() != null)
                        .Sum(x => x.GetModel().Custo);
                    txtCusto.Text = soma.ToString();
                    break;
                case "Não":
                    txtCusto.Enabled = true; break;

                default:
                    break;
            }
        }
        private void flpReceita_ControlAdded(object sender, ControlEventArgs e)
        {
            decimal soma = flpReceita.Controls
                        .OfType<UCAddIngredientes>()
                        .Where(x => x.GetModel() != null)
                        .Sum(x => x.GetModel().Custo);
            txtCusto.Text = soma.ToString();
        }
        private void btnAddIngrediente_Click(object sender, EventArgs e)
        {
            ReceitasModel receita = new ReceitasModel
            {
                IdIngrediente = int.Parse(txtId.Text),
                NomeIngrediente = cmbReceita.SelectedItem.ToString(),
                Quantidade = decimal.Parse(txtQuantidade.Text),
                Custo = decimal.Parse(lblCusto.Text),
            };

            var uc = new UCAddIngredientes();
            uc.SetModelUC(receita);
            flpReceita.Controls.Add(uc);
        }
        #endregion


    }
}
