using MuhtarlikTebgigatSistemi.Model;
using MuhtarlikTebgigatSistemi.Views.Interfaces;

namespace MuhtarlikTebgigatSistemi.Presenters
{
    public class StreetPresenter
    {
        // Fields
        private IStreetView view;
        private IRepository<StreetModel> repository;
        private BindingSource streetsBindingSource;
        private IEnumerable<StreetModel> streetList;

        // Constructor
        public StreetPresenter(IStreetView _view, IRepository<StreetModel> _repository)
        {
            this.view = _view;
            this.repository = _repository;
            this.streetsBindingSource = new BindingSource();

            // Associate and raise view events
            this.view.SearchEvent += SearchStreet;
            this.view.AddEvent += AddNewStreet;
            this.view.UpdateEvent += UpdateSelectedStreet;
            this.view.DeleteEvent += DeleteSelectedStreet;
            this.view.SaveEvent += SaveStreet;
            this.view.CancelEvent += CancelAction;

            // Set street binding source
            this.view.SetStreetListBindingSource(streetsBindingSource);

            // Load streets to binding source
            LoadAllStreetList();

            // Show view
            this.view.Show();
        }

        // Methods
        private void LoadAllStreetList()
        {
            streetList = repository.GetAll();
            streetsBindingSource.DataSource = streetList; // Binding source is updated
        }
        private void SearchStreet(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
                streetList = repository.GetByValue(this.view.SearchValue);
            else
                streetList = repository.GetAll();

            streetsBindingSource.DataSource = streetList;
        }
        private void AddNewStreet(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }
        private void UpdateSelectedStreet(object? sender, EventArgs e)
        {
            var street = (StreetModel)streetsBindingSource.Current;
            view.StreetID = street.Id.ToString();
            view.StreetName = street.Street;
            view.RegisterDate = street.RegisterDate.ToString("yyyy-MM-dd");
            view.UpdateDate = street.UpdateDate.ToString("yyyy-MM-dd");
            view.IsEdit = true;
        }
        private void DeleteSelectedStreet(object? sender, EventArgs e)
        {
            try
            {
                var street = (StreetModel)streetsBindingSource.Current;
                repository.Delete(street.Id);
                view.IsSuccessful = true;
                LoadAllStreetList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = $"An error occurred: {ex.Message}";
                Console.WriteLine($"Error details: {ex}");

            }
        }
        private void SaveStreet(object? sender, EventArgs e)
        {
            var model = new StreetModel();
            model.Street = view.StreetName;
            model.UpdateDate = DateTime.Now;
            try
            {
                new Common.ModelDataValidation().Validate(model);

                if (view.IsEdit)
                {
                    if (int.TryParse(view.StreetID, out int id))
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
                LoadAllStreetList();
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
            view.StreetID = string.Empty;
            view.StreetName = string.Empty;
            view.RegisterDate = string.Empty;
            view.UpdateDate = string.Empty;
        }
        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }
    }
}
