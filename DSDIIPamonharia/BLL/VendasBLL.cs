using DSDIIPamonharia.Core;
using DSDIIPamonharia.DAL;
using System;
using System.Windows.Forms;

namespace DSDIIPamonharia.BLL
{
    public class VendasBLL
    {
        private readonly VendasDAL _dal;

        public VendasBLL()
        {
            string connectionString = DatabaseConfig.ConnectionString;
            _dal = new VendasDAL(connectionString);
        }

        public VendasModel IncluirItem(VendasModel model)
        {
            try
            {
                return _dal.IncluirItem(model);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public VendasModel IncluirVenda(decimal total)
        {
            try
            {
                return _dal.IncluirVenda(total);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
