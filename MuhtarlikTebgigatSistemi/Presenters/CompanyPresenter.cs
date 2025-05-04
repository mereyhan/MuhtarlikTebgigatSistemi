using MuhtarlikTebgigatSistemi.Model;
using MuhtarlikTebgigatSistemi.Views.Interfaces;

namespace MuhtarlikTebgigatSistemi.Presenters
{
    public class CompanyPresenter
    {
        // Fields
        private ICompanyView view;
        private IRepository<CompanyModel> repository;
        private BindingSource documentsBindingSource;
        private IEnumerable<CompanyModel> documentList;

        // Constructor
        public CompanyPresenter(ICompanyView _view, IRepository<CompanyModel> _repository)
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
            this.view.SetCompanyListBindingSource(documentsBindingSource);

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
        private void AddNewDocument(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }
        private void UpdateSelectedDocument(object? sender, EventArgs e)
        {
            var document = (CompanyModel)documentsBindingSource.Current;
            view.CompanyID= document.Id.ToString();
            view.CompanyName = document.CompanyName;
            view.StreetName = document.StreetName;
            view.BuildingApt = document.BuildingApt;
            view.PersonName = document.PersonName;
            view.PhoneNumber = document.PhoneNumber;
            view.Email = document.Email;
            view.RegisterDate = document.RegisterDate.ToString("yyyy-MM-dd");
            view.UpdateDate = document.UpdateDate.ToString("yyyy-MM-dd");
            view.IsEdit = true;
        }
        private void DeleteSelectedDocument(object? sender, EventArgs e)
        {
            try
            {
                var document = (CompanyModel)documentsBindingSource.Current;
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
            var model = new CompanyModel();
            model.CompanyName = view.CompanyName;
            model.StreetName = view.StreetName;
            model.BuildingApt = view.BuildingApt;
            model.PersonName = view.PersonName;
            model.PhoneNumber = view.PhoneNumber;
            model.Email = view.Email;
            model.UpdateDate = DateTime.Now;
            try
            {
                new Common.ModelDataValidation().Validate(model);

                if (view.IsEdit)
                {
                    if (int.TryParse(view.CompanyID, out int id))
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
                    model.RegisterDate = DateTime.Now;
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
            view.CompanyID = string.Empty;
            view.CompanyName = string.Empty;
            view.StreetName = string.Empty;
            view.BuildingApt = string.Empty;
            view.PersonName = string.Empty;
            view.PhoneNumber = string.Empty;
            view.Email = string.Empty;
            view.RegisterDate = string.Empty;
            view.UpdateDate = string.Empty;
        }
        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }
    }
}
