using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DSDIIPamonharia.DAL
{
    public class ProdutosDAL
    {
        private readonly string _connectionString;

        public ProdutosDAL(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<ProdutosModel> ObterTodos()
        {
            try
            {
                var lista = new List<ProdutosModel>();
                string sql = "SELECT id, nome, unidade, descricao ,quantidade_estoque, custo, preco, imagem FROM produto";

                using (var conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();
                    var cmd = new MySqlCommand(sql, conn);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new ProdutosModel
                            {
                                Id = reader.GetInt32("id"),
                                Nome = reader.GetString("nome"),
                                Unidade = reader.GetString("unidade"),
                                Descricao = reader.GetString("descricao"),
                                Quantidade_Estoque = reader.GetDecimal("quantidade_estoque"),
                                Custo = reader.GetDecimal("custo"),
                                Preco = reader.GetDecimal("preco"),
                                Imagem = reader["imagem"] as byte[]
                            });
                        }
                    }
                }
                return lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao obter todos os produtos:\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<ProdutosModel>();
            }
        }

        public ProdutosModel ObterPorId(int id)
        {
            try
            {
                ProdutosModel prod = null;

                using (var conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();
                    string sql = @"SELECT id, nome, descricao, unidade, quantidade_estoque, 
                                      custo, preco, imagem 
                               FROM produto WHERE id=@id";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                prod = new ProdutosModel
                                {
                                    Id = reader.GetInt32("id"),
                                    Nome = reader.GetString("nome"),
                                    Descricao = reader.IsDBNull(reader.GetOrdinal("descricao")) ? "" : reader.GetString("descricao"),
                                    Unidade = reader.GetString("unidade"),
                                    Quantidade_Estoque = reader.GetDecimal("quantidade_estoque"),
                                    Custo = reader.GetDecimal("custo"),
                                    Preco = reader.GetDecimal("preco"),
                                    Imagem = reader.IsDBNull(reader.GetOrdinal("imagem")) ? null : (byte[])reader["imagem"]
                                };
                            }
                        }
                    }
                }

                return prod;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao obter produto pelo Id {id}:\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public ProdutosModel ObterPorNome(string nome)
        {
            try
            {
                ProdutosModel prod = null;

                using (var conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();
                    string sql = @"SELECT id, nome, descricao, unidade, quantidade_estoque, 
                                      custo, preco, imagem 
                               FROM produto WHERE nome=@nome";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@nome", nome);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                prod = new ProdutosModel
                                {
                                    Id = reader.GetInt32("id"),
                                    Nome = reader.GetString("nome"),
                                    Descricao = reader.IsDBNull(reader.GetOrdinal("descricao")) ? "" : reader.GetString("descricao"),
                                    Unidade = reader.GetString("unidade"),
                                    Quantidade_Estoque = reader.GetDecimal("quantidade_estoque"),
                                    Custo = reader.GetDecimal("custo"),
                                    Preco = reader.GetDecimal("preco"),
                                    Imagem = reader.IsDBNull(reader.GetOrdinal("imagem")) ? null : (byte[])reader["imagem"]
                                };
                            }
                        }
                    }
                }

                return prod;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao obter produto pelo nome {nome}:\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public ProdutosModel Inserir(ProdutosModel prod)
        {
            try
            {
                using (var conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();
                    string sql = @"INSERT INTO produto (nome, descricao, unidade, quantidade_estoque, custo, preco, imagem) 
                               VALUES (@nome, @descricao, @unidade, @quantidade, @custo, @preco, @imagem);
                               SELECT LAST_INSERT_ID();";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@nome", prod.Nome);
                        cmd.Parameters.AddWithValue("@descricao", prod.Descricao ?? "");
                        cmd.Parameters.AddWithValue("@unidade", prod.Unidade);
                        cmd.Parameters.AddWithValue("@quantidade", prod.Quantidade_Estoque);
                        cmd.Parameters.AddWithValue("@custo", prod.Custo);
                        cmd.Parameters.AddWithValue("@preco", prod.Preco);
                        cmd.Parameters.AddWithValue("@imagem", (object)prod.Imagem ?? DBNull.Value);

                        var id = Convert.ToInt32(cmd.ExecuteScalar());
                        prod.Id = id;
                    }
                    return prod;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir produto:\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public void Alterar(ProdutosModel prod)
        {
            try
            {
                using (var conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();
                    string sql = @"UPDATE produto 
                               SET nome=@nome, descricao=@descricao, unidade=@unidade, 
                                   quantidade_estoque=@quantidade, custo=@custo, preco=@preco, imagem=@imagem
                               WHERE id=@id";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", prod.Id);
                        cmd.Parameters.AddWithValue("@nome", prod.Nome);
                        cmd.Parameters.AddWithValue("@descricao", prod.Descricao ?? "");
                        cmd.Parameters.AddWithValue("@unidade", prod.Unidade);
                        cmd.Parameters.AddWithValue("@quantidade", prod.Quantidade_Estoque);
                        cmd.Parameters.AddWithValue("@custo", prod.Custo);
                        cmd.Parameters.AddWithValue("@preco", prod.Preco);
                        cmd.Parameters.AddWithValue("@imagem", (object)prod.Imagem ?? DBNull.Value);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao alterar produto Id {prod.Id}:\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Excluir(int id)
        {
            try
            {
                using (var conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();
                    string sql = "DELETE FROM produto WHERE id=@id";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao excluir produto Id {id}:\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
