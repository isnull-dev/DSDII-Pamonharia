using DSDIIPamonharia.Core;
using DSDIIPamonharia.DAL;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DSDIIPamonharia.BLL
{
    public class ReceitaBLL
    {
        private readonly ReceitasDAL _dal;

        public ReceitaBLL()
        {
            string connectionString = DatabaseConfig.ConnectionString;
            _dal = new ReceitasDAL(connectionString);
        }

        public List<ReceitasModel> ListarReceitas()
        {
            try
            {
                var receitas = _dal.ObterTodos();
                return receitas ?? new List<ReceitasModel>();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar receitas no banco de dados:\n" + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<ReceitasModel>();
            }
        }

        public List<ReceitasModel> ObterPorId(int id)
        {
            try
            {
                var receita = _dal.ObterPorIdProduto(id);
                return receita ?? new List<ReceitasModel>();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao obter receita no banco de dados:\n" + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<ReceitasModel>();
            }
        }

        public ReceitasModel Incluir(ReceitasModel model)
        {
            try
            {
                model = _dal.Inserir(model);
                return model;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao incluir receita no banco de dados:\n" + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public bool Alterar(ReceitasModel model)
        {
            try
            {
                return _dal.Alterar(model);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar receita no banco de dados:\n" + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool Excluir(ReceitasModel model)
        {
            try
            {
                return _dal.Excluir(model.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir receita no banco de dados:\n" + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool ExcluirPorProduto(ProdutosModel model)
        {
            try
            {
                return _dal.ExcluirPorProduto(model.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir receita no banco de dados:\n" + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
