using MuhtarlikTebgigatSistemi.Model;
using MuhtarlikTebgigatSistemi.Views;

namespace MuhtarlikTebgigatSistemi.Presenters
{
    public class DocumentPresenter
    {
        // Fields
        private IDocumentView view;
        private IRepository<DocumentModel> repository;
        private BindingSource documentsBindingSource;
        private IEnumerable<DocumentModel> documentList;

        // Constructor
        public DocumentPresenter(IDocumentView _view, IRepository<DocumentModel> _repository)
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
            view.DocumentType = document.Type;
            view.PersonName = document.PersonName;
            view.CompanyName = document.CompanyName;
            view.StreetName = document.StreetName;
            view.BuildingApt = document.BuildingApt;
            view.RegistrationDate = document.RegistrationDate.ToString("yyyy-MM-dd");
            view.DeliveredBy = document.DeliveredBy;
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
            model.Type = view.DocumentType;
            model.PersonName = view.PersonName;
            model.CompanyName = view.CompanyName;
            model.StreetName = view.StreetName;
            model.BuildingApt = view.BuildingApt;
            model.DeliveryDate = DateTime.Now;
            model.DeliveredBy = view.DeliveredBy;
            try
            {
                new Common.ModelDataValidation().Validate(model);

                if (view.IsEdit)
                {
                    if (int.TryParse(view.DocumentID, out int id))
                    {
                        model.Id = id;
                        repository.Update(model);
                    }
                    else
                    {
                        view.IsSuccessful = false;
                        view.Message = "Invalid Street ID for update.";
                        return;
                    }
                }
                else
                {
                    model.RegistrationDate = DateTime.Now;
                    repository.Add(model);
                }

                view.IsSuccessful = true;
                LoadAllDocumentList();
                CleanViewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = $"Error: {ex.Message}";
            }
        }
        private void CleanViewFields()
        {
            view.DocumentID = string.Empty;
            view.DocumentType = string.Empty;
            view.PersonName = string.Empty;
            view.CompanyName = string.Empty;
            view.StreetName = string.Empty;
            view.BuildingApt = string.Empty;
            view.RegistrationDate = string.Empty;
            view.DeliveredBy = string.Empty;
        }
        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }
    }
}