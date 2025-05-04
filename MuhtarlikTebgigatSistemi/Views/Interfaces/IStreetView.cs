namespace MuhtarlikTebgigatSistemi.Views.Interfaces
{
    public interface IStreetView
    {
        // Properties - Fields
        string StreetID { get; set; }
        string StreetName { get; set; }
        string RegisterDate { get; set; }
        string UpdateDate { get; set; }

        // Properties - Validations
        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        // Events
        event EventHandler SearchEvent;
        event EventHandler AddEvent;
        event EventHandler UpdateEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        // Methods
        void SetStreetListBindingSource(BindingSource documentList);
        void Show();
    }
}
