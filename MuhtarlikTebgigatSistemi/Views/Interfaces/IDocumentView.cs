using MuhtarlikTebgigatSistemi.Model;
using System.ComponentModel;

namespace MuhtarlikTebgigatSistemi.Views
{
    public interface IDocumentView
    {
        // Properties - Fields
        event EventHandler LoadAll;
        event EventHandler SaveEvent;
        event EventHandler SearchTextChanged;
        event EventHandler AddEvent;
        event EventHandler UpdateEvent;
        event EventHandler DeleteEvent;
        event EventHandler CancelEvent;

        // Veri alanları
        string DocumentID { get; set; }
        string DocumentType { get; set; }
        string StreetName { get; set; }
        string Apt { get; set; }
        string? UpdateDate { get; set; }
        string ReceiverName { get; set; }
        bool IsCompany { get; set; }

        // State bilgisi
        bool IsSuccessful { get; set; }
        string Message { get; set; }
        bool IsEdit { get; set; }
        string SearchValue { get; set; }


        // Methods
        DocumentInputModel NewDocumentInput { get; }
        void DisplayDocuments(BindingList<DocumentOverviewModel> documents);
        void ClearFields();

        void LoadComboBoxData(IEnumerable<DocumentTypeModel> docTypes, IEnumerable<PersonModel> persons, IEnumerable<CompanyModel> companies, IEnumerable<StreetModel> streets);

    }

    public class DocumentInputModel
    {
        public string DocumentType { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string Building { get; set; }
        public string? UpdateDate { get; set; }
        public string Receiver { get; set; }
        public bool IsCompany { get; set; }
    }
}