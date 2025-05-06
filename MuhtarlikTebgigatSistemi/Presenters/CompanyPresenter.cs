using MuhtarlikTebgigatSistemi.Model;
using MuhtarlikTebgigatSistemi.Views.Interfaces;

namespace MuhtarlikTebgigatSistemi.Presenters
{
    public class CompanyPresenter
    {
        // Fields
        private ICompanyView view;
        private IRepository<CompanyModel> repository;
        private BindingSource companyBindingSource;
        private IEnumerable<CompanyModel> companyList;

        // Constructor
        public CompanyPresenter(ICompanyView _view, IRepository<CompanyModel> _repository)
        {
            this.view = _view;
            this.repository = _repository;
            this.companyBindingSource = new BindingSource();

            // Associate and raise view events
            this.view.SearchEvent += SearchCompany;
            this.view.AddEvent += AddNewCompany;
            this.view.UpdateEvent += UpdateSelectedCompany;
            this.view.DeleteEvent += DeleteSelectedCompany;
            this.view.SaveEvent += SaveCompany;
            this.view.CancelEvent += CancelAction;

            // Set dompany binding source
            this.view.SetCompanyListBindingSource(companyBindingSource);

            // Load dompanys to binding source
            LoadAllCompanyList();

            // Show view
            this.view.Show();
        }

        // Methods
        private void LoadAllCompanyList()
        {
            companyList = repository.GetAll();
            companyBindingSource.DataSource = companyList; // Binding source is updated
        }
        private void SearchCompany(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
                companyList = repository.GetByValue(this.view.SearchValue);
            else
                companyList = repository.GetAll();

            companyBindingSource.DataSource = companyList;
        }
        private void AddNewCompany(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }
        private void UpdateSelectedCompany(object? sender, EventArgs e)
        {
            var company = (CompanyModel)companyBindingSource.Current;
            view.CompanyID= company.Id.ToString();
            view.CompanyName = company.CompanyName;
            view.StreetName = company.StreetName;
            view.BuildingApt = company.BuildingApt;
            view.PersonName = company.PersonName;
            view.PhoneNumber = company.PhoneNumber;
            view.Email = company.Email;
            view.RegisterDate = company.RegisterDate.ToString("yyyy-MM-dd");
            view.UpdateDate = company.UpdateDate.ToString("yyyy-MM-dd");
            view.IsEdit = true;
        }
        private void DeleteSelectedCompany(object? sender, EventArgs e)
        {
            try
            {
                var company = (CompanyModel)companyBindingSource.Current;
                repository.Delete(company.Id);
                view.IsSuccessful = true;
                LoadAllCompanyList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = $"An error occurred: {ex.Message}";
                Console.WriteLine($"Error details: {ex}");

            }
        }
        private void SaveCompany(object? sender, EventArgs e)
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
                LoadAllCompanyList();
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
