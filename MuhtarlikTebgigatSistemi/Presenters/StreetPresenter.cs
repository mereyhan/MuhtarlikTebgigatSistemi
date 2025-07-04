﻿using MuhtarlikTebgigatSistemi.Model;
using MuhtarlikTebgigatSistemi.Repository;
using MuhtarlikTebgigatSistemi.Views.Interfaces;
using System.ComponentModel;

namespace MuhtarlikTebgigatSistemi.Presenters;

public class StreetPresenter
{
    private readonly IStreetView _view;
    private readonly StreetRepository _repository;

    private readonly BindingList<StreetModel> _streets;
    private readonly BindingSource _bindingSource;

    public StreetPresenter(IStreetView view, StreetRepository repository)
    {
        _view = view;
        _repository = repository;

        _bindingSource = new BindingSource();
        _streets = new BindingList<StreetModel>(_repository.GetAll().ToList());
        _bindingSource.DataSource = _streets;

        _view.SetStreetListBindingSource(_bindingSource);

        SubscribeToEvents();
        _view.Show();
    }

    private void SubscribeToEvents()
    {
        _view.SearchEvent += OnSearch;
        _view.AddEvent += OnAdd;
        _view.UpdateEvent += OnUpdate;
        _view.DeleteEvent += OnDelete;
        _view.SaveEvent += OnSave;
        _view.CancelEvent += OnCancel;
    }

    private void OnSearch(object? sender, EventArgs e)
    {
        var result = _repository.Search(_view.SearchValue.Trim());
        _streets.Clear();
        foreach (var item in result)
            _streets.Add(item);
    }

    private void OnAdd(object? sender, EventArgs e)
    {
        _view.IsEdit = false;
        ClearViewFields();
    }

    private void OnDelete(object? sender, EventArgs e)
    {
        if (!int.TryParse(_view.StreetID, out int id))
        {
            _view.IsSuccessful = false;
            _view.Message = "Geçerli bir ID girilmedi.";
            return;
        }

        _repository.Delete(id);
        _view.IsSuccessful = true;
        _view.Message = "Kayıt silindi.";
        RefreshList();
    }

    private void OnUpdate(object? sender, EventArgs e)
    {
        if (_bindingSource.Current is not StreetModel selected) { 
        MessageBox.Show("Seçili öğe bulunamadı!");
        return;
        }
        

        _view.StreetID = selected.StreetId.ToString();
        _view.StreetName = selected.Street;
        _view.UpdateDate = selected.UpdateDate?.ToString("yyyy-MM-dd") ?? "";
        _view.IsEdit = true;
    }



    private void OnSave(object? sender, EventArgs e)
    {
        try
        {
            var model = new StreetModel
            {
                StreetId = int.TryParse(_view.StreetID, out int id) ? id : 0,
                Street = _view.StreetName,
                UpdateDate = string.IsNullOrWhiteSpace(_view.UpdateDate)
                    ? (DateTime?)null
                    : DateTime.Parse(_view.UpdateDate) // Burada boş string gelirse null atanacak
            };

            if (string.IsNullOrWhiteSpace(model.Street))
            {
                _view.IsSuccessful = false;
                _view.Message = "Sokak adı boş olamaz.";
                return;
            }

            if (_view.IsEdit)
                _repository.Update(model);
            else
                _repository.Add(model);

            _view.IsSuccessful = true;
            RefreshList();
            ClearViewFields();
        }
        catch (Exception ex)
        {
            _view.IsSuccessful = false;
            _view.Message = $"Hata oluştu: {ex.Message}";
        }
    }


    private void OnCancel(object? sender, EventArgs e)
    {
        ClearViewFields();
    }

    private void ClearViewFields()
    {
        _view.StreetID = "";
        _view.StreetName = "";
        _view.UpdateDate = "";
        _view.IsEdit = false;
    }

    private void RefreshList()
    {
        _streets.Clear();
        foreach (var item in _repository.GetAll())
            _streets.Add(item);
    }
}
