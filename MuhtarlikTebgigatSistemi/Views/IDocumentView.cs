using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuhtarlikTebgigatSistemi.Views
{
    public interface IDocumentView
    {
        // Properties - Fields
        string DocumentID { get; set; }
        string DocumentType { get; set; }
        string PersonName { get; set; }
        string CompanyName { get; set; }
        string StreetName { get; set; }
        string BuildingApt { get; set; }
        string RegistrationDate { get; set; }
        string DeliveredBy { get; set; }

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
        void SetDocumentListBindingSource(BindingSource documentList);
        void Show();
    }
}
