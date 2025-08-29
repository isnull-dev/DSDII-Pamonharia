using DSDIIPamonharia.Core;
using DSDIIPamonharia.DAL;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DSDIIPamonharia.BLL
{
    public class ProdutoBLL
    {
        private readonly ProdutosDAL _dal;

        public ProdutoBLL()
        {
            string connectionString = DatabaseConfig.ConnectionString;
            _dal = new ProdutosDAL(connectionString);
        }

        public List<ProdutosModel> ListarProdutos(bool Zerados)
        {
            try
            {
                var produtos = _dal.ObterTodos() ?? new List<ProdutosModel>();

                if (!Zerados)
                {
                    produtos.RemoveAll(p => p.Quantidade_Estoque <= 0);
                }

                return produtos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar produtos no banco de dados:\n" + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<ProdutosModel>();
            }
        }

        public ProdutosModel ObterPorId(int id)
        {
            try
            {
                return _dal.ObterPorId(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao obter produto no banco de dados:\n" + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public ProdutosModel ObterPorNome(string nome)
        {
            try
            {
                return _dal.ObterPorNome(nome);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao obter produto no banco de dados:\n" + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public ProdutosModel Incluir(ProdutosModel model)
        {
            try
            {
                model = _dal.Inserir(model);
                return model;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao incluir produto no banco de dados:\n" + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public bool Alterar(ProdutosModel model)
        {
            try
            {
                _dal.Alterar(model);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar produto no banco de dados:\n" + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool Excluir(ProdutosModel model)
        {
            try
            {
                _dal.Excluir(model.Id);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir produto no banco de dados:\n" + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
