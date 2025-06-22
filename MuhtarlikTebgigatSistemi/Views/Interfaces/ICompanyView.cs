
namespace MuhtarlikTebgigatSistemi.Views.Interfaces
{
    public interface ICompanyView
    {
        // Properties - Fields
        string CompanyID { get; set; }
        string MyCompanyName { get; set; }
        string StreetName { get; set; }
        string BuildingApt { get; set; }
        string? PhoneNumber { get; set; }
        string? Email { get; set; }

        // Properties - Validations
        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }
        string? UpdateDate { get; }

        // Events
        event EventHandler SearchEvent;
        event EventHandler SearchTextChanged;
        event EventHandler AddEvent;
        event EventHandler UpdateEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        // Methods
        void SetCompanyListBindingSource(BindingSource documentList);
        void SetStreetComboBox(List<string> streets);
        void Show();
    }
}
