using MuhtarlikTebgigatSistemi.Presenters;
using MuhtarlikTebgigatSistemi.Repository;
using MuhtarlikTebgigatSistemi.Views.Interfaces;
using MuhtarlikTebgigatSistemi.Views;

namespace MuhtarlikTebgigatSistemi.Presenter;

public class MainPresenter
{
    private readonly IMainView _mainForm;
    private readonly string _cs;

    public MainPresenter(IMainView mainView, string connectionString)
    {
        _mainForm = mainView;
        _cs = connectionString;

        _mainForm.ShowDocumentView += OnShowDocumentView;
        _mainForm.ShowDocTypeView += OnShowDocTypeView;
        _mainForm.ShowStreetView += OnShowStreetView;
        _mainForm.ShowPersonView += OnShowPersonView;
        _mainForm.ShowCompanyView += OnShowCompanyView;
    }

    private void OnShowDocumentView(object? sender, EventArgs e)
    {
        CloseOtherMdiChilds();
        var view = DocumentView.GetInstance((MainView)_mainForm);

        var docRepo = new DocumentRepository(_cs);
        var overviewRepo = new DocumentOverviewRepository(_cs);
        var streetRepo = new StreetRepository(_cs);
        var personRepo = new PersonRepository(_cs);
        var companyRepo = new CompanyRepository(_cs);
        var docTypeRepo = new DocumentTypeRepository(_cs);

        new DocumentPresenter(view, docRepo, overviewRepo, streetRepo, personRepo, companyRepo, docTypeRepo);
    }

    private void OnShowDocTypeView(object? sender, EventArgs e)
    {
        CloseOtherMdiChilds();
        var view = DocTypeView.GetInstace((MainView)_mainForm);
        var repo = new DocumentTypeRepository(_cs);
        new DocumentTypePresenter(view, repo);
    }

    private void OnShowStreetView(object? sender, EventArgs e)
    {
        CloseOtherMdiChilds();
        var view = StreetView.GetInstance((MainView)_mainForm);
        var repo = new StreetRepository(_cs);
        new StreetPresenter(view, repo);
    }

    private void OnShowPersonView(object? sender, EventArgs e)
    {
        CloseOtherMdiChilds();
        //MessageBox.Show("1");
        var view = PersonView.GetInstance((MainView)_mainForm);
        //MessageBox.Show("2");
        var repo = new PersonRepository(_cs);

        //MessageBox.Show("3"); 
        var overviewRepo = new PersonOverviewRepository(_cs);

        //MessageBox.Show("4"); 
        var streetRepo = new StreetRepository(_cs);
        //MessageBox.Show("5"); 
        new PersonPresenter(view, repo, overviewRepo, streetRepo);
    }

    private void OnShowCompanyView(object? sender, EventArgs e)
    {
        CloseOtherMdiChilds();
        var view = CompanyView.GetInstance((MainView)_mainForm);
        var repo = new CompanyRepository(_cs);
        var overviewRepo = new CompanyOverviewRepository(_cs);
        var streetRepo = new StreetRepository(_cs);
        new CompanyPresenter(view, repo, overviewRepo, streetRepo);
    }
    
    private void CloseOtherMdiChilds()
    {
        foreach (Form child in ((MainView)_mainForm).MdiChildren)
            child.Close();
    }
}
