using MuhtarlikTebgigatSistemi._Repository;
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

            string sqliteConnectionString = ConfigurationManager.ConnectionStrings["SqliteConnection"].ConnectionString;

            var loginView = new LoginView();
            var userRepository = new LoginRepository(sqliteConnectionString);
            var loginPresenter = new LoginPresenter(loginView, userRepository);

            var result = loginView.ShowDialog();

            if (loginView.IsLoginSuccessful)
            {
                IMainView view = new MainView();
                new MainPresenter(view, sqliteConnectionString);

                Application.Run((Form)view);
            }
        }
    }
}