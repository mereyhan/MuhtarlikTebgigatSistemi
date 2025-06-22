using MuhtarlikTebgigatSistemi.Model;
using MuhtarlikTebgigatSistemi.Repository;
using MuhtarlikTebgigatSistemi.Views.Interfaces;
using System.ComponentModel;

namespace MuhtarlikTebgigatSistemi.Presenters;

public class CompanyPresenter
{
    private readonly ICompanyView _view;
    private readonly CompanyRepository _companyRepo;
    private readonly CompanyOverviewRepository _overviewRepo;
    private readonly StreetRepository _streetRepo;

    private readonly BindingList<CompanyOverviewModel> _companyList;
    private readonly BindingSource _bindingSource;

    public CompanyPresenter(
        ICompanyView view,
        CompanyRepository companyRepo,
        CompanyOverviewRepository overviewRepo,
        StreetRepository streetRepo)
    {
        _view = view;
        _companyRepo = companyRepo;
        _overviewRepo = overviewRepo;
        _streetRepo = streetRepo;

        _bindingSource = new BindingSource();
        _companyList = new BindingList<CompanyOverviewModel>(_overviewRepo.GetAll().ToList());

        _bindingSource.DataSource = _companyList;
        _view.SetCompanyListBindingSource(_bindingSource);

        SubscribeToEvents();

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
                  .Select(c => new CompanyOverviewModel
                  {
                      CompanyId = c.CompanyId,
                      CompanyName = c.CompanyName,
                      Building = c.Building,
                      Email = c.Email,
                      Phone = c.Phone,
                      RegisterDate = c.RegisterDate,
                      UpdateDate = c.UpdateDate,
                      StreetName = c.StreetName
                  });

        _companyList.Clear();
        foreach (var item in result)
            _companyList.Add(item);
    }

    private void OnAdd(object? sender, EventArgs e)
    {
        _view.IsEdit = false;
    }

    private void OnUpdate(object? sender, EventArgs e)
    {
        if (_bindingSource.Current is not CompanyOverviewModel selected)
            return;

        var model = _companyRepo.GetAll().FirstOrDefault(x => x.CompanyId == selected.CompanyId);
        if (model == null)
        {
            _view.IsSuccessful = false;
            _view.Message = "Kayıt bulunamadı.";
            return;
        }

        _view.CompanyID = model.CompanyId.ToString();
        _view.MyCompanyName = model.CompanyName;
        _view.StreetName = _streetRepo.GetById(model.StreetId)?.Street ?? "";
        _view.BuildingApt = model.Building;
        _view.PhoneNumber = model.Phone;
        _view.Email = model.Email;

        _view.IsEdit = true;
    }

    private void OnDelete(object? sender, EventArgs e)
    {
        if (!int.TryParse(_view.CompanyID, out int id))
        {
            _view.IsSuccessful = false;
            _view.Message = "Geçerli bir ID girilmedi.";
            return;
        }

        try
        {
            _companyRepo.Delete(id);
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

            var model = new CompanyModel
            {
                CompanyId = int.TryParse(_view.CompanyID, out int id) ? id : 0,
                CompanyName = _view.MyCompanyName.Trim(),
                StreetId = streetId,
                Building = _view.BuildingApt.Trim(),
                Phone = _view.PhoneNumber?.Trim(),
                Email = _view.Email?.Trim(),
                UpdateDate = string.IsNullOrWhiteSpace(_view.UpdateDate) ? (DateTime?)null : DateTime.Parse(_view.UpdateDate)
            };

            if (_view.IsEdit)
                _companyRepo.Update(model);
            else
                _companyRepo.AddAndReturnId(model);

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
        _companyList.Clear();
        foreach (var item in _overviewRepo.GetAll())
            _companyList.Add(item);
    }

    private void ClearForm()
    {
        _view.CompanyID = "";
        _view.MyCompanyName = "";
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