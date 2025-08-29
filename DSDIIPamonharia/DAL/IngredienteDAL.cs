using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DSDIIPamonharia.DAL
{
    public class IngredienteDAL
    {
        private readonly string _connectionString;

        public IngredienteDAL(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<IngredientesModel> ObterTodos()
        {
            try
            {
                var lista = new List<IngredientesModel>();
                string sql = "SELECT id, nome, unidade, quantidade_estoque, custo, descricao, imagem FROM ingrediente";

                using (var conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();
                    var cmd = new MySqlCommand(sql, conn);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new IngredientesModel
                            {
                                Id = reader.GetInt32("id"),
                                Nome = reader.GetString("nome"),
                                Unidade = reader.GetString("unidade"),
                                Quantidade_Estoque = reader.GetDecimal("quantidade_estoque"),
                                Custo = reader.GetDecimal("custo"),
                                Descricao = reader["descricao"] as string,
                                Imagem = reader["imagem"] as byte[]
                            });
                        }
                    }
                }
                return lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao obter ingredientes:\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<IngredientesModel>();
            }
        }

        public IngredientesModel ObterPorId(int id)
        {
            try
            {
                IngredientesModel ing = null;
                using (var conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();
                    string sql = "SELECT id, nome, descricao, unidade, quantidade_estoque, custo, imagem FROM ingrediente WHERE id=@id";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                ing = new IngredientesModel
                                {
                                    Id = reader.GetInt32("id"),
                                    Nome = reader.GetString("nome"),
                                    Descricao = reader.IsDBNull(reader.GetOrdinal("descricao")) ? "" : reader.GetString("descricao"),
                                    Unidade = reader.GetString("unidade"),
                                    Quantidade_Estoque = reader.GetDecimal("quantidade_estoque"),
                                    Custo = reader.GetDecimal("custo"),
                                    Imagem = reader.IsDBNull(reader.GetOrdinal("imagem")) ? null : (byte[])reader["imagem"]
                                };
                            }
                        }
                    }
                }
                return ing;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao obter ingrediente por ID:\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public IngredientesModel ObterPorNome(string nome)
        {
            try
            {
                IngredientesModel ing = null;
                using (var conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();
                    string sql = "SELECT id, nome, descricao, unidade, quantidade_estoque, custo, imagem FROM ingrediente WHERE nome=@nome";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@nome", nome);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                ing = new IngredientesModel
                                {
                                    Id = reader.GetInt32("id"),
                                    Nome = reader.GetString("nome"),
                                    Descricao = reader.IsDBNull(reader.GetOrdinal("descricao")) ? "" : reader.GetString("descricao"),
                                    Unidade = reader.GetString("unidade"),
                                    Quantidade_Estoque = reader.GetDecimal("quantidade_estoque"),
                                    Custo = reader.GetDecimal("custo"),
                                    Imagem = reader.IsDBNull(reader.GetOrdinal("imagem")) ? null : (byte[])reader["imagem"]
                                };
                            }
                        }
                    }
                }
                return ing;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao obter ingrediente por nome:\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public IngredientesModel Inserir(IngredientesModel ing)
        {
            try
            {
                using (var conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();
                    string sql = @"INSERT INTO ingrediente (nome, descricao, unidade, quantidade_estoque, custo, imagem) 
                                   VALUES (@nome, @descricao, @unidade, @quantidade, @custo, @imagem);
                                   SELECT LAST_INSERT_ID();";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@nome", ing.Nome);
                        cmd.Parameters.AddWithValue("@descricao", ing.Descricao ?? "");
                        cmd.Parameters.AddWithValue("@unidade", ing.Unidade);
                        cmd.Parameters.AddWithValue("@quantidade", ing.Quantidade_Estoque);
                        cmd.Parameters.AddWithValue("@custo", ing.Custo);
                        cmd.Parameters.AddWithValue("@imagem", (object)ing.Imagem ?? DBNull.Value);
                        var id = Convert.ToInt32(cmd.ExecuteScalar());
                        ing.Id = id;
                    }
                    return ing;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir ingrediente:\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public void Alterar(IngredientesModel ing)
        {
            try
            {
                using (var conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();
                    string sql = @"UPDATE ingrediente 
                                   SET nome=@nome, descricao=@descricao, unidade=@unidade, 
                                       quantidade_estoque=@quantidade, custo=@custo, imagem=@imagem
                                   WHERE id=@id";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", ing.Id);
                        cmd.Parameters.AddWithValue("@nome", ing.Nome);
                        cmd.Parameters.AddWithValue("@descricao", ing.Descricao ?? "");
                        cmd.Parameters.AddWithValue("@unidade", ing.Unidade);
                        cmd.Parameters.AddWithValue("@quantidade", ing.Quantidade_Estoque);
                        cmd.Parameters.AddWithValue("@custo", ing.Custo);
                        cmd.Parameters.AddWithValue("@imagem", (object)ing.Imagem ?? DBNull.Value);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar ingrediente:\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Excluir(int id)
        {
            try
            {
                using (var conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();
                    string sql = "DELETE FROM ingrediente WHERE id=@id";
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir ingrediente:\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
