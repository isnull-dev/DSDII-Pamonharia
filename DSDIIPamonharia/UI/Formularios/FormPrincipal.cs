using DSDIIPamonharia.BLL;
using DSDIIPamonharia.UI.Formularios;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static DSDIIPamonharia.Core.Utilities;

namespace DSDIIPamonharia
{
    public partial class FormPrincipal : MaterialForm
    {

        private TimeSpan TempoRestante; // Tempo restante para próxima execução
        private int m = 1;

        public FormPrincipal()
        {
            InitializeComponent();
            IniciarTimers();
        }

        #region Ação dos Botões Principais
        private void btnCadastro_Click(object sender, EventArgs e)
        {
            TrocarForms(new FormCadastro());
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            TrocarForms(new FormEstoque());
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            TrocarForms(new FormVendas());
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRelato_Click(object sender, EventArgs e)
        {

            var produtos = new ProdutoBLL().ListarProdutos(true);
            PdfGenerator.GerarPdfGenerico(produtos, "Relatório de Produtos");
            var vendas = new RelatoriosBLL().ObterVendasRel();
            PdfGenerator.GerarRelatorioVenda(vendas);
        }

        #endregion

        #region Metodos Privados
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            AtualizarResumos();

        }
        private void TrocarForms(MaterialForm NovoForm)
        {
            this.Hide();
            NovoForm.ShowDialog();
            this.Show();
        }
        private void IniciarTimers()
        {

            TimerUpdate = new Timer();
            TimerUpdate.Interval = m * 60 * 1000; // minutos em milissegundos
            TimerUpdate.Tick += TimerUpdate_Tick;
            TimerUpdate.Start();

            TempoRestante = TimeSpan.FromMinutes(m);
            TimerContador = new Timer();
            TimerContador.Interval = 1000; // 1 segundo
            TimerContador.Tick += TimerContador_Tick;
            TimerContador.Start();
        }
        private void TimerUpdate_Tick(object sender, EventArgs e)
        {
            // Ação a ser repetir a cada 5 minutos
            AtualizarResumos();
            TempoRestante = TimeSpan.FromMinutes(m);
        }
        private void TimerContador_Tick(object sender, EventArgs e)
        {
            TempoRestante = TempoRestante.Subtract(TimeSpan.FromSeconds(1));
            if (TempoRestante.TotalSeconds < 0)
                TempoRestante = TimeSpan.Zero;

            // Atualiza Label no Form
            lblContador.Text = $"{TempoRestante.Minutes:D2}:{TempoRestante.Seconds:D2}";
        }
        private void AtualizarResumos()
        {
            try
            {
                #region ResumoEstoque
                flpResumoEstoque.Controls.Clear();

                var EstoqueBLL = new RelatoriosBLL();
                List<ProdutosModel> produtos = new List<ProdutosModel>();
                produtos = EstoqueBLL.EstoqueProdutoFQuant(3);
                foreach (var produto in produtos)
                {
                    var uc = new UCEstoque();
                    uc.SetModelUCP(produto);
                    flpResumoEstoque.Controls.Add(uc);
                }

                List<IngredientesModel> ingredientes = new List<IngredientesModel>();
                ingredientes = EstoqueBLL.EstoqueIngredienteFQuant(3);
                foreach (var ing in ingredientes)
                {
                    var uc = new UCEstoque();
                    uc.SetModelUCI(ing);
                    flpResumoEstoque.Controls.Add(uc);
                }
                #endregion

                #region ResumoVendas
                flpResumoVendasMais.Controls.Clear();

                var VendasBLL = new RelatoriosBLL();
                List<VendasModel> vendas = VendasBLL.Vendas();

                for (int i = 0; i <= 1; i++)
                {
                    UCResumoVendas uc = new UCResumoVendas();
                    uc.setmodel(vendas[i]);
                    flpResumoVendasMais.Controls.Add(uc);
                }
                for (int i = 2; i <= 3; i++)
                {
                    UCResumoVendas uc = new UCResumoVendas();
                    uc.setmodel(vendas[i]);
                    flpResumoVendasMenos.Controls.Add(uc);
                }
                #endregion
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        
        #endregion
        

        

        
    }
}
