using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuhtarlikTebgigatSistemi.Views.Interfaces
{
    public interface IPersonView
    {
        // Properties - Fields
        string PersonID { get; set; }
        string PersonName { get; set; }
        string StreetName { get; set; }
        string BuildingApt { get; set; }
        string CompanyName { get; set; }
        string PhoneNumber { get; set; }
        string Email { get; set; }
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
        void SetPersonListBindingSource(BindingSource documentList);
        void Show();
    }
}
