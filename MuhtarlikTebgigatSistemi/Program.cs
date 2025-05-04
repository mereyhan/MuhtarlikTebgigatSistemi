using MuhtarlikTebgigatSistemi.Presenters;
using MuhtarlikTebgigatSistemi.Views;
using MuhtarlikTebgigatSistemi.Views.Interfaces;
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
            string sqliteConnectionString = ConfigurationManager.ConnectionStrings["SqliteConnection"].ConnectionString;
            
            IMainView view = new MainView();
            new MainPresenter(view, sqliteConnectionString);

            Application.Run((Form)view);
        }
    }
}