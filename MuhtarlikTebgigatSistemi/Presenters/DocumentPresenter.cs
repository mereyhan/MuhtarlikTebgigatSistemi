using MuhtarlikTebgigatSistemi.Model;
using MuhtarlikTebgigatSistemi.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace MuhtarlikTebgigatSistemi.Presenters
{
    public class DocumentPresenter
    {
        // Fields
        private IDocumentView view;
        private IDocumentRepository repository;
        private BindingSource documentsBindingSource;
        private IEnumerable<DocumentModel> documentList;

        // Constructor
        public DocumentPresenter(IDocumentView _view, IDocumentRepository _repository)
        {
            this.view = _view;
            this.repository = _repository;
            this.documentsBindingSource = new BindingSource();

            // Associate and raise view events
            this.view.SearchEvent += SearchDocument;
            this.view.AddEvent += AddNewDocument;
            this.view.UpdateEvent += UpdateSelectedDocument;
            this.view.DeleteEvent += DeleteSelectedDocument;
            this.view.SaveEvent += SaveDocument;
            this.view.CancelEvent += CancelAction;

            // Set document binding source
            this.view.SetDocumentListBindingSource(documentsBindingSource);

            // Load documents to binding source
            LoadAllDocumentList();

            // Show view
            this.view.Show();
        }

        // Methods
        private void LoadAllDocumentList()
        {
            documentList = repository.GetAll();
            documentsBindingSource.DataSource = documentList; // Binding source is updated
        }
        private void SearchDocument(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false) documentList = repository.GetByValue(this.view.SearchValue);
            else documentList = repository.GetAll();
            documentsBindingSource.DataSource = documentList;
        }
        private void AddNewDocument(object? sender, EventArgs e) { view.IsEdit = false; }
        private void UpdateSelectedDocument(object? sender, EventArgs e)
        {
            var document = (DocumentModel)documentsBindingSource.Current;
            view.DocumentID = document.Id.ToString();
            view.DocumentName = document.Name;
            view.DocumentType = document.Type;
            view.DocumentColor = document.Color;
            view.IsEdit = true;
        }
        private void DeleteSelectedDocument(object? sender, EventArgs e)
        {
            try
            {
                var document = (DocumentModel)documentsBindingSource.Current;
                repository.Delete(document.Id);
                view.IsSuccessful = true;
                view.Message = "Document deleted successfully";
                LoadAllDocumentList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = $"An error occurred: {ex.Message}";
                Console.WriteLine($"Error details: {ex}");

            }
        }
        private void SaveDocument(object? sender, EventArgs e)
        {
            var model = new DocumentModel();
            model.Id = int.Parse(view.DocumentID);
            model.Name = view.DocumentName;
            model.Type = view.DocumentType;
            model.Color = view.DocumentColor;
            try
            {
                new Common.ModelDataValidation().Validate(model);
                if(view.IsEdit) repository.Update(model);
                else repository.Add(model);
                view.IsSuccessful = true;
                LoadAllDocumentList();
                CleanViewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }
        private void CleanViewFields()
        {
            view.DocumentID = "0";
            view.DocumentName = "";
            view.DocumentType = "";
            view.DocumentColor = "";
        }
        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }
    }
}
