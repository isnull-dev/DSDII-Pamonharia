using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DSDIIPamonharia.UI.Classes;
using DSDIIPamonharia.UI.Formularios;

namespace DSDIIPamonharia
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ThemeConfig.ApplyTheme();

            // Captura exceções não tratadas em threads do Windows Forms
            Application.ThreadException += (sender, e) =>
            {
                MessageBox.Show("Ocorreu um erro:\n" + e.Exception.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            };

            // Captura exceções não tratadas em threads de background
            AppDomain.CurrentDomain.UnhandledException += (sender, e) =>
            {
                Exception ex = e.ExceptionObject as Exception;
                MessageBox.Show("Ocorreu um erro:\n" + (ex?.Message ?? "Erro desconhecido"), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            };

            Application.Run(new FormPrincipal());
        }
    }
}
