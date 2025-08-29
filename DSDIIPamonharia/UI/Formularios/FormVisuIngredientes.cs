using DSDIIPamonharia.BLL;
using DSDIIPamonharia.Core;
using MaterialSkin.Controls;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace DSDIIPamonharia.UI.Formularios
{
    public partial class FormVisuIngredientes : MaterialForm
    {
        private IngredientesModel _model;
        private readonly Action<IngredientesModel> _callback;
        private readonly Action _onDelete;

        public FormVisuIngredientes(
            bool permitirInclusao,
            bool permitirAlteracao,
            bool permitirExclusao,
            Action<IngredientesModel> callback = null,
            Action onDelete = null)
        {
            InitializeComponent();
            btnIncluir.Visible = permitirInclusao;
            btnAlterar.Visible = permitirAlteracao;
            btnExcluir.Visible = permitirExclusao;

            _callback = callback;
            _onDelete = onDelete;
        }

        #region Ingredientes
        public void SetModel(IngredientesModel model)
        {
            _model = model;

            txtNomeProduto.Text = _model.Nome;
            txtDescricao.Text = _model.Descricao;
            txtValor.Text = _model.Custo.ToString("F2");

            if (_model.Imagem != null)
            {
                picProduto.Image = Utilities.ImageHelper.BytesToImage(_model.Imagem);
            }
            else
            {
                picProduto.Image = null;
            }
            cmbUN.SelectedItem = _model.Unidade.ToUpper();


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
        private void btnIncluir_Click(object sender, EventArgs e)
        {
            IngredientesModel modelIncluir = new IngredientesModel
            {
                Nome = txtNomeProduto.Text,
                Descricao = txtDescricao.Text,
                Unidade = cmbUN.Text,
                Quantidade_Estoque = 0,
                Custo = decimal.Parse(txtValor.Text),
                Imagem = Utilities.ImageHelper.ImageToBytes(picProduto.Image)
            };

            var bll = new IngredienteBLL();
            IngredientesModel novo = bll.Incluir(modelIncluir);

            _callback?.Invoke(novo); // chama o callback do form chamador

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            IngredientesModel modelAlterado = new IngredientesModel
            {
                Id = _model.Id,
                Nome = txtNomeProduto.Text,
                Unidade = cmbUN.Text,
                Quantidade_Estoque = _model.Quantidade_Estoque,
                Custo = Decimal.Parse(txtValor.Text),
                Descricao = txtDescricao.Text,
                Imagem = Utilities.ImageHelper.ImageToBytes(picProduto.Image),
            };

            var bll = new IngredienteBLL();
            if (bll.Alterar(modelAlterado))
            {
                _callback?.Invoke(modelAlterado);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {

            var bll = new IngredienteBLL();
            if (bll.Excluir(_model))
            {
                _onDelete?.Invoke();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

        }
        #endregion
    }

}
