using System;
using System.Windows.Forms;

namespace MuhtarlikTebgigatSistemi.Views.Interfaces
{
    public interface IDocTypeView
    {
        // Properties
        string DocumentTypeID { get; set; }
        string DocumentType { get; set; }
        string UpdateDate { get; set; }

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
        void SetDocTypeListBindingSource(BindingSource docTypesBindingSource);
        void Show();
    }
}
