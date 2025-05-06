using MuhtarlikTebgigatSistemi._Repository;
using MuhtarlikTebgigatSistemi.Model;
using MuhtarlikTebgigatSistemi.Views;
using MuhtarlikTebgigatSistemi.Views.Interfaces;

namespace MuhtarlikTebgigatSistemi.Presenters
{
    public class MainPresenter
    {
        private IMainView mainView;
        private readonly string sqliteConnectionString;

        public MainPresenter(IMainView mainView, string sqliteConnectionString)
        {
            this.mainView = mainView;
            this.sqliteConnectionString = sqliteConnectionString;
            this.mainView.ShowDocumentView += ShowDocumentView;
            this.mainView.ShowDocTypeView += ShowDocTypeView;
            this.mainView.ShowStreetView += ShowStreetView;
            this.mainView.ShowPersonView += ShowPersonView;
            this.mainView.ShowCompanyView += ShowCompanyView;
        }

        private void CloseOtherMdiChilds()
        {
            foreach (Form child in ((MainView)mainView).MdiChildren)
                child.Close();
        }

        private void ShowDocumentView(object? sender, EventArgs e)
        {
            CloseOtherMdiChilds();
            IDocumentView view = DocumentView.GetInstace((MainView)mainView);
            IRepository<DocumentModel> repository = new DocumentRepository(sqliteConnectionString);
            new DocumentPresenter(view, repository);
        }
        private void ShowDocTypeView(object? sender, EventArgs e)
        {
            CloseOtherMdiChilds();
            IDocTypeView view = DocTypeView.GetInstace((MainView)mainView);
            IRepository<DocTypeModel> repository = new DocTypeRepository(sqliteConnectionString);
            new DocTypePresenter(view, repository);
        }
        private void ShowStreetView(object? sender, EventArgs e)
        {
            CloseOtherMdiChilds();
            IStreetView view = StreetView.GetInstace((MainView)mainView);
            IRepository<StreetModel> repository = new StreetRepository(sqliteConnectionString);
            new StreetPresenter(view, repository);
        }
        private void ShowPersonView(object? sender, EventArgs e)
        {
            CloseOtherMdiChilds();
            IPersonView view = PersonView.GetInstace((MainView)mainView);
            IRepository<PersonModel> repository = new PersonRepository(sqliteConnectionString);
            new PersonPresenter(view, repository);
        }
        private void ShowCompanyView(object? sender, EventArgs e)
        {
            CloseOtherMdiChilds();
            ICompanyView view = CompanyView.GetInstace((MainView)mainView);
            IRepository<CompanyModel> repository = new CompanyRepository(sqliteConnectionString);
            new CompanyPresenter(view, repository);
        }
    }
}