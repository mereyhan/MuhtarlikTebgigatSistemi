using MuhtarlikTebgigatSistemi.Model;
using MuhtarlikTebgigatSistemi.Views.Interfaces;

namespace MuhtarlikTebgigatSistemi.Presenters
{
    public class PersonPresenter
    {
        // Fields
        private IPersonView view;
        private IRepository<PersonModel> repository;
        private BindingSource documentsBindingSource;
        private IEnumerable<PersonModel> documentList;

        // Constructor
        public PersonPresenter(IPersonView _view, IRepository<PersonModel> _repository)
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
            this.view.SetPersonListBindingSource(documentsBindingSource);

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
            view.PersonID = document.Id.ToString();
            view.PersonName = document.PersonName;
            view.StreetName = document.StreetName;
            view.BuildingApt = document.BuildingApt;
            view.CompanyName = document.CompanyName;
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
                var document = (PersonModel)documentsBindingSource.Current;
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
            var model = new PersonModel();
            model.PersonName = view.PersonName;
            model.StreetName = view.StreetName;
            model.BuildingApt = view.BuildingApt;
            model.CompanyName = view.CompanyName;
            model.PhoneNumber = view.PhoneNumber;
            model.Email = view.Email;
            model.UpdateDate = DateTime.Now;
            try
            {
                new Common.ModelDataValidation().Validate(model);

                if (view.IsEdit)
                {
                    if (int.TryParse(view.PersonID, out int id))
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
            view.PersonID = string.Empty;
            view.PersonName = string.Empty;
            view.StreetName = string.Empty;
            view.BuildingApt = string.Empty;
            view.CompanyName = string.Empty;
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
