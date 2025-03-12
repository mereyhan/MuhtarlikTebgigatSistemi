using MuhtarlikTebgigatSistemi._Repository;
using MuhtarlikTebgigatSistemi.Model;
using MuhtarlikTebgigatSistemi.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MuhtarlikTebgigatSistemi.Presenters
{
    public class MainPresenter
    {
        private IMainView mainView;
        private readonly string sqlConnectionString;

        public MainPresenter(IMainView mainView, string sqlConnectionString)
        {
            this.mainView = mainView;
            this.sqlConnectionString = sqlConnectionString;
            this.mainView.ShowDocumentView += ShowDocumentView;
        }

        private void ShowDocumentView(object? sender, EventArgs e)
        {
            IDocumentView view = DocumentView.GetInstace((MainView)mainView);
            IDocumentRepository repository = new DocumentRepository(sqlConnectionString);
            new DocumentPresenter(view, repository);
        }
    }
}
