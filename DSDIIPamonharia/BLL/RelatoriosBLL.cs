using DSDIIPamonharia.Core;
using DSDIIPamonharia.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DSDIIPamonharia.BLL
{
    public class RelatoriosBLL
    {
        private readonly ProdutosDAL _Pdal;
        private readonly ReceitasDAL _Rdal;
        private readonly IngredienteDAL _Idal;
        private readonly VendasDAL _Vdal;

        public RelatoriosBLL()
        {
            string connectionString = DatabaseConfig.ConnectionString;
            _Pdal = new ProdutosDAL(connectionString);
            _Rdal = new ReceitasDAL(connectionString);
            _Idal = new IngredienteDAL(connectionString);
            _Vdal = new VendasDAL(connectionString);
        }

        public List<ProdutosModel> EstoqueProdutoFQuant(decimal Filtro_Quantidade)
        {
            try
            {
                var Produtos = _Pdal.ObterTodos();
                return Produtos
                       .Where(p => p.Quantidade_Estoque <= Filtro_Quantidade)
                       .ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<ProdutosModel>();
            }
        }

        public List<IngredientesModel> EstoqueIngredienteFQuant(decimal Filtro_Quantidade)
        {
            try
            {
                var Ingredientes = _Idal.ObterTodos();
                return Ingredientes
                       .Where(p => p.Quantidade_Estoque <= Filtro_Quantidade)
                       .ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<IngredientesModel>();
            }
        }

        public List<VendasModel> Vendas()
        {
            try
            {
                var vendas = _Vdal.ObterVendas();

                var agrupado = vendas
                    .GroupBy(v => v.Id_produto)
                    .Select(g => new VendasModel
                    {
                        Nome = g.First().Nome,  // pega o nome do primeiro item do grupo
                        Id_produto = g.Key,
                        Quantidade = g.Sum(v => v.Quantidade),
                        Total = g.Sum(v => v.Quantidade * v.Preco),
                        Preco = g.Average(v => v.Preco) // preço médio simples
                    })
                    .ToList();


                List<VendasModel> lista = new List<VendasModel>();
                lista.Add(agrupado.OrderByDescending(x => x.Quantidade).FirstOrDefault());
                lista.Add(agrupado.OrderByDescending(x => x.Total).FirstOrDefault());
                lista.Add(agrupado.OrderBy(x => x.Quantidade).FirstOrDefault());
                lista.Add(agrupado.OrderBy(x => x.Total).FirstOrDefault());

                return lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<VendasModel>();
            }
        }

        public List<VendasModel> ObterVendasRel()
        {
            try
            {
                List<VendasModel> vendas = _Vdal.ObterVendas();
                return vendas;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<VendasModel>();
            }
        }
    }
}
