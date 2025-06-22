using MuhtarlikTebgigatSistemi.Model;
using MuhtarlikTebgigatSistemi.Repository;
using MuhtarlikTebgigatSistemi.Views.Interfaces;
using System.ComponentModel;

namespace MuhtarlikTebgigatSistemi.Presenters;

public class DocumentTypePresenter
{
    private readonly IDocTypeView _view;
    private readonly DocumentTypeRepository _repository;

    private readonly BindingList<DocumentTypeModel> _docTypes;
    private readonly BindingSource _bindingSource;

    public DocumentTypePresenter(IDocTypeView view, DocumentTypeRepository repository)
    {
        _view = view;
        _repository = repository;

        _bindingSource = new BindingSource();
        _docTypes = new BindingList<DocumentTypeModel>(_repository.GetAll().ToList());
        _bindingSource.DataSource = _docTypes;

        _view.SetDocTypeListBindingSource(_bindingSource);

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
        _docTypes.Clear();
        foreach (var item in result)
            _docTypes.Add(item);
    }

    private void OnAdd(object? sender, EventArgs e)
    {
        _view.IsEdit = false;
        ClearViewFields();
    }

    private void OnUpdate(object? sender, EventArgs e)
    {
        if (_bindingSource.Current is not DocumentTypeModel selected)
            return;

        _view.DocumentTypeID = selected.DocumentTypeId.ToString();
        _view.DocumentType = selected.DocumentType;
        _view.UpdateDate = selected.UpdateDate?.ToString("yyyy-MM-dd") ?? "";
        _view.IsEdit = true;
    }

    private void OnDelete(object? sender, EventArgs e)
    {
        if (!int.TryParse(_view.DocumentTypeID, out int id))
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

    private void OnSave(object? sender, EventArgs e)
    {
        try
        {
            var model = new DocumentTypeModel
            {
                DocumentTypeId = int.TryParse(_view.DocumentTypeID, out int id) ? id : 0,
                DocumentType = _view.DocumentType,
                UpdateDate = DateTime.TryParse(_view.UpdateDate, out DateTime upd) ? upd : null
            };

            if (string.IsNullOrWhiteSpace(model.DocumentType))
            {
                _view.IsSuccessful = false;
                _view.Message = "Tür adı boş olamaz.";
                return;
            }

            if (_view.IsEdit)
            {
                _repository.Update(model);
            }
            else
            {
                _repository.Add(model);
            }

            _view.IsSuccessful = true;
            _view.Message = "Kayıt başarıyla kaydedildi.";
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
        _view.DocumentTypeID = "";
        _view.DocumentType = "";
        _view.UpdateDate = "";
        _view.IsEdit = false;
    }

    private void RefreshList()
    {
        _docTypes.Clear();
        foreach (var item in _repository.GetAll())
            _docTypes.Add(item);
    }
}
