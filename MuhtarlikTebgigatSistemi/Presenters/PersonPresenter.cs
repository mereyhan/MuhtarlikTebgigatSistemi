using MuhtarlikTebgigatSistemi.Model;
using MuhtarlikTebgigatSistemi.Views.Interfaces;

namespace MuhtarlikTebgigatSistemi.Presenters
{
    public class PersonPresenter
    {
        // Fields
        private IPersonView view;
        private IRepository<PersonModel> repository;
        private BindingSource personsBindingSource;
        private IEnumerable<PersonModel> personList;

        // Constructor
        public PersonPresenter(IPersonView _view, IRepository<PersonModel> _repository)
        {
            this.view = _view;
            this.repository = _repository;
            this.personsBindingSource = new BindingSource();

            // Associate and raise view events
            this.view.SearchEvent += SearchPerson;
            this.view.AddEvent += AddNewPerson;
            this.view.UpdateEvent += UpdateSelectedPerson;
            this.view.DeleteEvent += DeleteSelectedPerson;
            this.view.SaveEvent += SavePerson;
            this.view.CancelEvent += CancelAction;

            // Set person binding source
            this.view.SetPersonListBindingSource(personsBindingSource);

            // Load person to binding source
            LoadAllPersonList();

            // Show view
            this.view.Show();
        }

        // Methods
        private void LoadAllPersonList()
        {
            personList = repository.GetAll();
            personsBindingSource.DataSource = personList; // Binding source is updated
        }
        private void SearchPerson(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
                personList = repository.GetByValue(this.view.SearchValue);
            else
                personList = repository.GetAll();

            personsBindingSource.DataSource = personList;
        }
        private void AddNewPerson(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }
        private void UpdateSelectedPerson(object? sender, EventArgs e)
        {
            var person = (PersonModel)personsBindingSource.Current;
            view.PersonID = person.Id.ToString();
            view.PersonName = person.PersonName;
            view.StreetName = person.StreetName;
            view.BuildingApt = person.BuildingApt;
            view.CompanyName = person.CompanyName;
            view.PhoneNumber = person.PhoneNumber;
            view.Email = person.Email;
            view.RegisterDate = person.RegisterDate.ToString("yyyy-MM-dd");
            view.UpdateDate = person.UpdateDate.ToString("yyyy-MM-dd");
            view.IsEdit = true;
        }
        private void DeleteSelectedPerson(object? sender, EventArgs e)
        {
            try
            {
                var person = (PersonModel)personsBindingSource.Current;
                repository.Delete(person.Id);
                view.IsSuccessful = true;
                LoadAllPersonList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = $"An error occurred: {ex.Message}";
                Console.WriteLine($"Error details: {ex}");

            }
        }
        private void SavePerson(object? sender, EventArgs e)
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
                LoadAllPersonList();
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
