namespace MuhtarlikTebgigatSistemi.Views.Interfaces
{
    public interface IDocTypeView
    {
        // Properties - Fields
        string DocTypeID { get; set; }
        string DocumentType { get; set; }
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
        void SetDocTypeListBindingSource(BindingSource documentList);
        void Show();
    }
}
