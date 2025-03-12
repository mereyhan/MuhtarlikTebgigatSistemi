using System;
using System.Windows.Forms;
using MuhtarlikTebgigatSistemi.Model;
using MuhtarlikTebgigatSistemi.Presenters;
using MuhtarlikTebgigatSistemi._Repository;
using MuhtarlikTebgigatSistemi.Views;
using System.Configuration;

namespace MuhtarlikTebgigatSistemi
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // NameSpace, Properties, Settings, General, Settings.settings, SqlConnectionString
            string sqlConnectionString = ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString;
            
            IMainView view = new MainView();
            new MainPresenter(view, sqlConnectionString);

            Application.Run((Form)view);
        }
    }
}