using MuhtarlikTebgigatSistemi.Model;
using MuhtarlikTebgigatSistemi.Repository;
using MuhtarlikTebgigatSistemi.Views.Interfaces;
using System.ComponentModel;

namespace MuhtarlikTebgigatSistemi.Presenters;

public class PersonPresenter
{
    private readonly IPersonView _view;
    private readonly PersonRepository _personRepo;
    private readonly PersonOverviewRepository _overviewRepo;
    private readonly StreetRepository _streetRepo;

    private readonly BindingList<PersonOverviewModel> _personList;
    private readonly BindingSource _bindingSource;

    public PersonPresenter(
    IPersonView view,
    PersonRepository personRepo,
    PersonOverviewRepository overviewRepo,
    StreetRepository streetRepo)
    {
        _view = view;
        _personRepo = personRepo;
        _overviewRepo = overviewRepo;
        _streetRepo = streetRepo;

        //MessageBox.Show("1");
        _bindingSource = new BindingSource();
        //MessageBox.Show("2");
        _personList = new BindingList<PersonOverviewModel>(_overviewRepo.GetAll().ToList());
        //MessageBox.Show("3");
        _bindingSource.DataSource = _personList;
        //MessageBox.Show("4");
        _view.SetPersonListBindingSource(_bindingSource);
        //MessageBox.Show("5");
        SubscribeToEvents();
        //MessageBox.Show("6");
        _view.Show();
    }

    private void SubscribeToEvents()
    {
        _view.SearchEvent += OnSearch;
        _view.SearchTextChanged += OnSearch;
        _view.AddEvent += OnAdd;
        _view.UpdateEvent += OnUpdate;
        _view.DeleteEvent += OnDelete;
        _view.SaveEvent += OnSave;
        _view.CancelEvent += OnCancel;
        LoadStreetComboBox();
    }

    private void OnSearch(object? sender, EventArgs e)
    {
        var query = _view.SearchValue?.Trim().ToLower() ?? "";

        var result = string.IsNullOrWhiteSpace(query)
            ? _overviewRepo.GetAll()
            : _overviewRepo.Search(query)
                  .Select(p => new PersonOverviewModel
                  {
                      PersonId = p.PersonId,
                      PersonName = p.PersonName,
                      Building = p.Building,
                      Email = p.Email,
                      Phone = p.Phone,
                      RegisterDate = p.RegisterDate,
                      UpdateDate = p.UpdateDate,
                      Street = p.Street
                  });

        _personList.Clear();
        foreach (var item in result)
            _personList.Add(item);
    }

    private void OnAdd(object? sender, EventArgs e)
    {
        _view.IsEdit = false;
    }

    private void OnUpdate(object? sender, EventArgs e)
    {
        if (_bindingSource.Current is not PersonOverviewModel selected)
            return;

        var model = _personRepo.GetAll().FirstOrDefault(x => x.PersonId == selected.PersonId);
        if (model == null)
        {
            _view.IsSuccessful = false;
            _view.Message = "Kayıt bulunamadı.";
            return;
        }

        _view.PersonID = model.PersonId.ToString();
        _view.PersonName = model.PersonName;
        _view.StreetName = _streetRepo.GetById(model.StreetId)?.Street ?? "";
        _view.BuildingApt = model.Building;
        _view.PhoneNumber = model.Phone;
        _view.Email = model.Email;

        _view.IsEdit = true;
    }

    private void OnDelete(object? sender, EventArgs e)
    {
        if (!int.TryParse(_view.PersonID, out int id))
        {
            _view.IsSuccessful = false;
            _view.Message = "Geçerli bir ID girilmedi.";
            return;
        }

        try
        {
            _personRepo.Delete(id);
            _view.IsSuccessful = true;
            _view.Message = "Kayıt silindi.";
            RefreshCompanyList();
        }
        catch (Exception ex)
        {
            _view.IsSuccessful = false;
            _view.Message = $"Silme hatası: {ex.Message}";
        }
    }

    private void OnSave(object? sender, EventArgs e)
    {
        try
        {
            int streetId = _streetRepo.GetOrCreate(_view.StreetName.Trim());

            var model = new PersonModel
            {
                PersonId = int.TryParse(_view.PersonID, out int id) ? id : 0,
                PersonName = _view.PersonName.Trim(),
                StreetId = streetId,
                Building = _view.BuildingApt.Trim(),
                Phone = _view.PhoneNumber?.Trim(),
                Email = _view.Email?.Trim(),
                UpdateDate = string.IsNullOrWhiteSpace(_view.UpdateDate) ? (DateTime?)null : DateTime.Parse(_view.UpdateDate)
            };

            if (_view.IsEdit)
                _personRepo.Update(model);
            else
                _personRepo.AddAndReturnId(model);

            _view.IsSuccessful = true;
            _view.Message = _view.IsEdit ? "Kayıt güncellendi." : "Yeni kayıt eklendi.";

            RefreshCompanyList();
            ClearForm();
        }
        catch (Exception ex)
        {
            _view.IsSuccessful = false;
            _view.Message = $"Kayıt hatası: {ex.Message}";
        }
    }

    private void OnCancel(object? sender, EventArgs e)
    {
        ClearForm();
    }

    private void RefreshCompanyList()
    {
        _personList.Clear();
        foreach (var item in _overviewRepo.GetAll())
            _personList.Add(item);
    }

    private void ClearForm()
    {
        _view.PersonID = "";
        _view.PersonName = "";
        _view.StreetName = "";
        _view.BuildingApt = "";
        _view.PhoneNumber = "";
        _view.Email = "";
        _view.IsEdit = false;
    }

    private void LoadStreetComboBox()
    {
        var streets = _streetRepo.GetAll()
                                 .Select(s => s.Street)
                                 .Distinct()
                                 .ToList();
        _view.SetStreetComboBox(streets);
    }
}