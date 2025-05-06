using MuhtarlikTebgigatSistemi.Model;
using MuhtarlikTebgigatSistemi.Views.Interfaces;

namespace MuhtarlikTebgigatSistemi.Presenters
{
    public class DocTypePresenter
    {
        // Fields
        private IDocTypeView view;
        private IRepository<DocTypeModel> repository;
        private BindingSource docTypesBindingSource;
        private IEnumerable<DocTypeModel> docTypeList;

        // Constructor
        public DocTypePresenter(IDocTypeView _view, IRepository<DocTypeModel> _repository)
        {
            this.view = _view;
            this.repository = _repository;
            this.docTypesBindingSource = new BindingSource();

            // Associate and raise view events
            this.view.SearchEvent += SearchDocType;
            this.view.AddEvent += AddNewDocType;
            this.view.UpdateEvent += UpdateSelectedDocType;
            this.view.DeleteEvent += DeleteSelectedDocType;
            this.view.SaveEvent += SaveDocType;
            this.view.CancelEvent += CancelAction;

            // Set document binding source
            this.view.SetDocTypeListBindingSource(docTypesBindingSource);

            // Load documents to binding source
            LoadAllDocTypeList();

            // Show view
            this.view.Show();
        }

        // Methods
        private void LoadAllDocTypeList()
        {
            docTypeList = repository.GetAll();
            docTypesBindingSource.DataSource = docTypeList; // Binding source is updated
        }
        private void SearchDocType(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
                docTypeList = repository.GetByValue(this.view.SearchValue);
            else
                docTypeList = repository.GetAll();

            docTypesBindingSource.DataSource = docTypeList;
        }
        private void AddNewDocType(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }
        private void UpdateSelectedDocType(object? sender, EventArgs e)
        {
            var document = (DocTypeModel)docTypesBindingSource.Current;
            view.DocTypeID = document.Id.ToString();
            view.DocumentType = document.Type;
            view.RegisterDate = document.RegisterDate.ToString("yyyy-MM-dd");
            view.UpdateDate = document.UpdateDate.ToString("yyyy-MM-dd");
            view.IsEdit = true;
        }
        private void DeleteSelectedDocType(object? sender, EventArgs e)
        {
            try
            {
                var document = (DocTypeModel)docTypesBindingSource.Current;
                repository.Delete(document.Id);
                view.IsSuccessful = true;
                LoadAllDocTypeList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = $"An error occurred: {ex.Message}";
                Console.WriteLine($"Error details: {ex}");

            }
        }
        private void SaveDocType(object? sender, EventArgs e)
        {
            var model = new DocTypeModel();
            model.Type = view.DocumentType;
            model.UpdateDate = DateTime.Now;
            try
            {
                new Common.ModelDataValidation().Validate(model);

                if (view.IsEdit)
                {
                    if (int.TryParse(view.DocTypeID, out int id))
                    {
                        model.Id = id;
                        repository.Update(model);
                    }
                    else
                    {
                        view.IsSuccessful = false;
                        view.Message = "Güncelleme için geçersiz bir ID";
                        return;
                    }
                }
                else
                {
                    model.RegisterDate = DateTime.Now;
                    repository.Add(model);
                }

                view.IsSuccessful = true;
                LoadAllDocTypeList();
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
            view.DocTypeID = string.Empty;
            view.DocumentType = string.Empty;
            view.RegisterDate = string.Empty;
            view.UpdateDate = string.Empty;
        }
        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }
    }
}
