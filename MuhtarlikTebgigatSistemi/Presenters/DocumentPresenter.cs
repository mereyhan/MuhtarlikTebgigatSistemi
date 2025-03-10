using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MuhtarlikTebgigatSistemi.Views;
using MuhtarlikTebgigatSistemi.Model;

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
        private void CancelAction(object? sender, EventArgs e) { throw new NotImplementedException(); }
        private void SaveDocument(object? sender, EventArgs e) { throw new NotImplementedException(); }
        private void DeleteSelectedDocument(object? sender, EventArgs e) { throw new NotImplementedException(); }
        private void UpdateSelectedDocument(object? sender, EventArgs e) { throw new NotImplementedException(); }
        private void AddNewDocument(object? sender, EventArgs e) { throw new NotImplementedException(); }
    }
}
