using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DSDIIPamonharia.DAL
{
    public class ReceitasDAL
    {
        private readonly string _connectionString;
        public ReceitasDAL(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<ReceitasModel> ObterTodos()
        {
            try
            {
                var list = new List<ReceitasModel>();
                using (var conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();
                    string sql = @"SELECT 
                                    receita.id AS ReceitaId, 
                                    receita.id_produto AS ProdutoId, 
                                    produto.nome AS ProdutoNome, 
                                    produto.descricao AS ProdutoDescricao,
                                    produto.imagem AS ProdutoImagem,
                                    receita.id_ingrediente AS IngredienteId,
                                    ingrediente.nome AS IngredienteNome, 
                                    receita.quantidade AS ReceitaQuantidade
                                FROM receita
                                INNER JOIN produto ON receita.id_produto = produto.id
                                INNER JOIN ingrediente ON receita.id_ingrediente = ingrediente.id";

                    var cmd = new MySqlCommand(sql, conn);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new ReceitasModel
                            {
                                Id = reader.GetInt32("ReceitaId"),
                                IdProduto = reader.GetInt32("ProdutoId"),
                                NomeProduto = reader.GetString("ProdutoNome"),
                                Descricao = reader.GetString("ProdutoDescricao"),
                                IdIngrediente = reader.GetInt32("IngredienteId"),
                                NomeIngrediente = reader.GetString("IngredienteNome"),
                                Quantidade = reader.GetDecimal("ReceitaQuantidade"),
                                Imagem = reader["ProdutoImagem"] as byte[]
                            });
                        }
                    }
                }
                return list;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao obter todas as receitas:\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<ReceitasModel>();
            }
        }

        public List<ReceitasModel> ObterPorIdProduto(int id)
        {
            try
            {
                var list = new List<ReceitasModel>();
                using (var conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();
                    string sql = @"SELECT 
                                    receita.id AS ReceitaId, 
                                    receita.id_produto AS ProdutoId, 
                                    produto.nome AS ProdutoNome, 
                                    produto.descricao AS ProdutoDescricao,
                                    produto.imagem AS ProdutoImagem,
                                    receita.id_ingrediente AS IngredienteId,
                                    ingrediente.nome AS IngredienteNome, 
                                    receita.quantidade AS ReceitaQuantidade
                                FROM receita
                                INNER JOIN produto ON receita.id_produto = produto.id
                                INNER JOIN ingrediente ON receita.id_ingrediente = ingrediente.id
                                WHERE receita.id_produto = @id";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                list.Add(new ReceitasModel
                                {
                                    Id = reader.GetInt32("ReceitaId"),
                                    IdProduto = reader.GetInt32("ProdutoId"),
                                    NomeProduto = reader.GetString("ProdutoNome"),
                                    Descricao = reader.GetString("ProdutoDescricao"),
                                    IdIngrediente = reader.GetInt32("IngredienteId"),
                                    NomeIngrediente = reader.GetString("IngredienteNome"),
                                    Quantidade = reader.GetDecimal("ReceitaQuantidade"),
                                    Imagem = reader["ProdutoImagem"] as byte[]
                                });
                            }
                        }
                    }
                }
                return list;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao obter receitas por produto:\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<ReceitasModel>();
            }
        }

        public ReceitasModel Inserir(ReceitasModel receita)
        {
            try
            {
                using (var conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();
                    string sql = @"INSERT INTO receita (id_produto, id_ingrediente, quantidade) 
                                   VALUES (@id_produto, @id_ingrediente, @quantidade);
                                   SELECT LAST_INSERT_ID();";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id_produto", receita.IdProduto);
                        cmd.Parameters.AddWithValue("@id_ingrediente", receita.IdIngrediente);
                        cmd.Parameters.AddWithValue("@quantidade", receita.Quantidade);

                        var id = Convert.ToInt32(cmd.ExecuteScalar());
                        receita.Id = id;
                    }
                    return receita;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir receita:\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public bool Alterar(ReceitasModel receita)
        {
            try
            {
                using (var conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();
                    string sql = @"UPDATE receita 
                                   SET id_produto=@id_produto, 
                                       id_ingrediente=@id_ingrediente, 
                                       quantidade=@quantidade
                                   WHERE id=@id";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", receita.Id);
                        cmd.Parameters.AddWithValue("@id_produto", receita.IdProduto);
                        cmd.Parameters.AddWithValue("@id_ingrediente", receita.IdIngrediente);
                        cmd.Parameters.AddWithValue("@quantidade", receita.Quantidade);

                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar receita:\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool Excluir(int id)
        {
            try
            {
                using (var conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();
                    string sql = "DELETE FROM receita WHERE id=@id";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir receita:\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool ExcluirPorProduto(int id_produto)
        {
            try
            {
                using (var conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();
                    string sql = "DELETE FROM receita WHERE id_produto=@id_produto";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id_produto", id_produto);
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir receitas por produto:\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
