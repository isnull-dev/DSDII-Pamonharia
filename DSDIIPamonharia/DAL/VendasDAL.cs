using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DSDIIPamonharia.DAL
{
    public class VendasDAL
    {
        private readonly string _connectionString;
        public VendasDAL(string connectionString)
        {
            _connectionString = connectionString;
        }

        public VendasModel IncluirItem(VendasModel venda)
        {
            try
            {
                using (var conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();

                    string sql2 = @"INSERT INTO item_venda  (id_venda, id_produto, quantidade,preco_unitario) 
                                   VALUES (@id_venda, @id_produto, @quantidade, @preco_unitario);
                                   SELECT LAST_INSERT_ID();";

                    using (var cmd = new MySqlCommand(sql2, conn))
                    {
                        cmd.Parameters.AddWithValue("@id_venda", venda.Id_venda);
                        cmd.Parameters.AddWithValue("@id_produto", venda.Id_produto);
                        cmd.Parameters.AddWithValue("@quantidade", venda.Quantidade);
                        cmd.Parameters.AddWithValue("@preco_unitario", venda.Preco);

                        var id = Convert.ToInt32(cmd.ExecuteScalar());
                        venda.Id_item = id;
                    }

                    BaixaEstoque(venda);
                    return venda;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao incluir item na venda:\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public VendasModel IncluirVenda(decimal total)
        {
            try
            {
                VendasModel vendasModel = new VendasModel();
                using (var conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();
                    string sql1 = @"INSERT INTO venda  (data_venda, total) 
                                   VALUES (@data_venda, @total);
                                   SELECT LAST_INSERT_ID();";

                    using (var cmd = new MySqlCommand(sql1, conn))
                    {
                        cmd.Parameters.AddWithValue("@data_venda", DateTime.Now);
                        cmd.Parameters.AddWithValue("@total", total);

                        var id = Convert.ToInt32(cmd.ExecuteScalar());
                        vendasModel.Id_venda = id;
                    }

                    return vendasModel;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao incluir venda:\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public bool BaixaEstoque(VendasModel model)
        {
            try
            {
                var dal = new ProdutosDAL(_connectionString);
                var produto = dal.ObterPorId(model.Id_produto);
                decimal estoqueATL = produto.Quantidade_Estoque - model.Quantidade;

                using (var conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();
                    string sql = @"UPDATE produto
                                   SET quantidade_estoque = @estoque
                                   WHERE id = @id";
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@estoque", estoqueATL);
                        cmd.Parameters.AddWithValue("@id", model.Id_produto);
                        cmd.ExecuteNonQuery();
                    }
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar estoque:\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public List<VendasModel> ObterVendas()
        {
            try
            {
                List<VendasModel> lista = new List<VendasModel>();
                using (var conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();
                    string sql = @"SELECT IT.id, IT.id_venda, IT.id_produto,P.nome,IT.quantidade, IT.preco_unitario 
                                   FROM item_venda IT
                                   INNER JOIN produto P ON IT.id_produto = P.id";
                    using (var cmd = new MySqlCommand(sql, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new VendasModel
                            {
                                Id_item = reader.GetInt32("id"),
                                Id_venda = reader.GetInt32("id_venda"),
                                Id_produto = reader.GetInt32("id_produto"),
                                Nome = reader.GetString("nome"),
                                Quantidade = reader.GetDecimal("quantidade"),
                                Preco = reader.GetDecimal("preco_unitario")
                            });
                        }
                    }
                    return lista;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao obter vendas:\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<VendasModel>();
            }
        }
    }
}
