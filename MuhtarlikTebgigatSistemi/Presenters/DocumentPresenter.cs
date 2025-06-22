using MuhtarlikTebgigatSistemi.Model;
using MuhtarlikTebgigatSistemi.Repository;
using MuhtarlikTebgigatSistemi.Views;
using System.ComponentModel;

namespace MuhtarlikTebgigatSistemi.Presenters;

public class DocumentPresenter
{
    private readonly IDocumentView _view;
    private readonly DocumentRepository _repository;
    private readonly DocumentOverviewRepository _overviewRepo;
    private readonly StreetRepository _streetRepo;
    private readonly PersonRepository _personRepo;
    private readonly CompanyRepository _companyRepo;
    private readonly DocumentTypeRepository _docTypeRepo;

    private readonly BindingList<DocumentOverviewModel> _documentList;
    private readonly BindingSource _bindingSource;

    public DocumentPresenter(
        IDocumentView view,
        DocumentRepository repository,
        DocumentOverviewRepository overviewRepo,
        StreetRepository streetRepo,
        PersonRepository personRepo,
        CompanyRepository companyRepo,
        DocumentTypeRepository docTypeRepo)
    {
        _view = view;
        _repository = repository;
        _overviewRepo = overviewRepo;
        _streetRepo = streetRepo;
        _personRepo = personRepo;
        _companyRepo = companyRepo;
        _docTypeRepo = docTypeRepo;

        _bindingSource = new BindingSource();
        _documentList = new BindingList<DocumentOverviewModel>(_overviewRepo.GetAll().ToList());

        _bindingSource.DataSource = _documentList;
        _view.DisplayDocuments(_documentList);

        SubscribeToEvents();
    }

    private void SubscribeToEvents()
    {
        _view.LoadAll += (s, e) => RefreshDocumentList();
        _view.SaveEvent += OnSave;
        _view.SearchTextChanged += OnSearch;
        _view.AddEvent += (s, e) => { ClearForm(); _view.IsEdit = false; };
        _view.UpdateEvent += OnUpdate;
        _view.DeleteEvent += OnDelete;
        _view.CancelEvent += (s, e) => ClearForm();
    }

    private void OnSave(object? sender, EventArgs e)
    {
        var input = _view.NewDocumentInput;

        try
        {
            int docTypeId = _docTypeRepo.GetOrCreate(input.DocumentType);
            int streetId = _streetRepo.GetOrCreate(input.Street);

            int? personId = null;
            int? companyId = null;
            int? receiverId = null;

            if (input.IsCompany)
            {
                var company = new CompanyModel
                {
                    CompanyName = input.Name,
                    StreetId = streetId,
                    Building = input.Building
                };
                companyId = _companyRepo.GetOrCreate(company);
            }
            else
            {
                var person = new PersonModel
                {
                    PersonName = input.Name,
                    StreetId = streetId,
                    Building = input.Building
                };
                personId = _personRepo.GetOrCreate(person);
            }

            if (!string.IsNullOrWhiteSpace(input.Receiver))
            {
                var receiver = new PersonModel
                {
                    PersonName = input.Receiver,
                    StreetId = 0,
                    Building = ""
                };
                receiverId = _personRepo.GetOrCreate(receiver);
            }

            var document = new DocumentModel
            {
                DocumentTypeId = docTypeId,
                PersonId = personId,
                CompanyId = companyId,
                ReceiverId = receiverId,
                UpdateDate = string.IsNullOrWhiteSpace(input.UpdateDate) ? null : DateTime.Parse(input.UpdateDate)
            };

            if (_view.IsEdit && int.TryParse(_view.DocumentID, out int docId))
            {
                document.DocumentId = docId;
                _repository.Update(document);
            }
            else
            {
                _repository.AddAndReturnId(document);
            }

            _view.IsSuccessful = true;
            _view.Message = "Kayıt başarıyla kaydedildi.";
            RefreshDocumentList();
            ClearForm();
        }
        catch (Exception ex)
        {
            _view.IsSuccessful = false;
            _view.Message = $"Hata: {ex.Message}";
        }
    }

    private void OnUpdate(object? sender, EventArgs e)
    {
        if (_bindingSource.Current is not DocumentOverviewModel selected)
            return;
        //MessageBox.Show("1");
        var full = _repository.GetById(selected.DocumentId);
        if (full == null)
        {
            _view.IsSuccessful = false;
            _view.Message = "Kayıt bulunamadı.";
            return;
        }
        //MessageBox.Show("2");
        _view.DocumentID = full.DocumentId.ToString();
        //MessageBox.Show("3");
        _view.DocumentType = _docTypeRepo.GetById(full.DocumentTypeId)?.DocumentType ?? "";
        //MessageBox.Show("4");
        _view.StreetName = "";
        //MessageBox.Show("5");
        _view.Apt = "";
        //MessageBox.Show("6");
        _view.UpdateDate = full.UpdateDate?.ToString("yyyy-MM-dd") ?? "";
        //MessageBox.Show("7");
        _view.ReceiverName = _personRepo.GetById(full.ReceiverId ?? 0)?.PersonName ?? "";
        //MessageBox.Show("8");
        _view.IsCompany = full.CompanyId.HasValue;
        //MessageBox.Show("9");

        _view.IsEdit = true;
    }

    private void OnDelete(object? sender, EventArgs e)
    {
        if (_bindingSource.Current is not DocumentOverviewModel selected)
            return;

        try
        {
            _repository.Delete(selected.DocumentId);
            _view.IsSuccessful = true;
            _view.Message = "Kayıt silindi.";
            RefreshDocumentList();
        }
        catch (Exception ex)
        {
            _view.IsSuccessful = false;
            _view.Message = $"Hata: {ex.Message}";
        }
    }

    private void OnSearch(object? sender, EventArgs e)
    {
        string value = _view.SearchValue?.Trim() ?? "";
        var filtered = _overviewRepo.Search(value);
        _documentList.Clear();
        foreach (var item in filtered)
            _documentList.Add(item);
    }

    private void ClearForm()
    {
        _view.DocumentID = "";
        _view.DocumentType = "";
        _view.StreetName = "";
        _view.Apt = "";
        _view.UpdateDate = null;
        _view.ReceiverName = "";
        _view.IsCompany = false;
        _view.IsEdit = false;
    }

    private void RefreshDocumentList()
    {
        _documentList.Clear();
        foreach (var item in _overviewRepo.GetAll())
            _documentList.Add(item);
    }
}
