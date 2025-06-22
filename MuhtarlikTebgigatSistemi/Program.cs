using Microsoft.Identity.Client;
using MuhtarlikTebgigatSistemi.Presenter;
using MuhtarlikTebgigatSistemi.Presenters;
using MuhtarlikTebgigatSistemi.Repository;
using MuhtarlikTebgigatSistemi.Views;
using MuhtarlikTebgigatSistemi.Views.Interfaces;
using System.Configuration;

namespace MuhtarlikTebgigatSistemi
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            try
            {
                ApplicationConfiguration.Initialize();
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                string sqliteConnectionString = ConfigurationManager.ConnectionStrings["SqliteConnection"].ConnectionString;

                var loginView = new LoginView();
                var loginRepo = new LoginRepository(sqliteConnectionString);
                var loginPresenter = new LoginPresenter(loginView, loginRepo);

                loginView.ShowDialog();

                if (loginView.IsLoginSuccessful)
                {
                    IMainView mainView = new MainView();
                    var mainPresenter = new MainPresenter(mainView, sqliteConnectionString);

                    Application.Run((Form)mainView);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu:\n\n{ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
