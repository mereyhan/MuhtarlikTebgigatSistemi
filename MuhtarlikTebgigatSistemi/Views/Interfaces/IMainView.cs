namespace MuhtarlikTebgigatSistemi.Views.Interfaces
{
    public interface IMainView
    {
        event EventHandler ShowDocumentView;
        event EventHandler ShowDocTypeView;
        event EventHandler ShowStreetView;
        event EventHandler ShowPersonView;
        event EventHandler ShowCompanyView;
        event EventHandler ShowUserView;
    }
}
