using DSDIIPamonharia.Core;
using DSDIIPamonharia.DAL;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DSDIIPamonharia.BLL
{
    public class IngredienteBLL
    {
        private readonly IngredienteDAL _dal;

        public IngredienteBLL()
        {
            string connectionString = DatabaseConfig.ConnectionString;
            _dal = new IngredienteDAL(connectionString);
        }

        public List<IngredientesModel> ListarIngredientes()
        {
            try
            {
                var ingredientes = _dal.ObterTodos() ?? new List<IngredientesModel>();
                return ingredientes;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar ingredientes no banco de dados:\n" + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<IngredientesModel>();
            }
        }

        public IngredientesModel ObterPorId(int id)
        {
            try
            {
                return _dal.ObterPorId(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao obter ingrediente no banco de dados:\n" + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public IngredientesModel ObterPorNome(string nome)
        {
            try
            {
                return _dal.ObterPorNome(nome);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao obter ingrediente no banco de dados:\n" + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public IngredientesModel Incluir(IngredientesModel model)
        {
            try
            {
                model = _dal.Inserir(model);
                return model;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao incluir ingrediente no banco de dados:\n" + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public bool Alterar(IngredientesModel model)
        {
            try
            {
                _dal.Alterar(model);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar ingrediente no banco de dados:\n" + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool Excluir(IngredientesModel model)
        {
            try
            {
                _dal.Excluir(model.Id);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir ingrediente no banco de dados:\n" + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
