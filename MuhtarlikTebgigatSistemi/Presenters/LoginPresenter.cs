using MuhtarlikTebgigatSistemi.Model;
using MuhtarlikTebgigatSistemi.Repository;
using MuhtarlikTebgigatSistemi.Views.Interfaces;

namespace MuhtarlikTebgigatSistemi.Presenters;

public class LoginPresenter
{
    private readonly ILoginView view;
    private readonly LoginRepository repository;

    public LoginPresenter(ILoginView view, LoginRepository repository)
    {
        this.view = view;
        this.repository = repository;

        this.view.LoginEvent += HandleLogin;
    }

    private void HandleLogin(object sender, EventArgs e)
    {
        bool success = repository.ValidateUser(view.UserName, view.Password);

        if (success)
        {
            view.IsLoginSuccessful = true;
            view.CloseView();
        }
        else
        {
            view.IsLoginSuccessful = false;
            view.ShowError("Kullanıcı adı veya şifre hatalı.");
        }
    }
}

public class UserPresenter
{
    private readonly IUserView view;
    private readonly LoginRepository repository;
    private readonly BindingSource usersBindingSource;
    private IEnumerable<LoginModel> userList;

    public UserPresenter(IUserView view, LoginRepository repository)
    {
        this.view = view;
        this.repository = repository;
        usersBindingSource = new BindingSource();

        this.view.SearchEvent += OnSearch;
        this.view.SearchTextChanged += OnSearch;
        this.view.AddEvent += OnAdd;
        this.view.UpdateEvent += OnUpdate;
        this.view.DeleteEvent += OnDelete;
        this.view.SaveEvent += OnSave;
        this.view.CancelEvent += OnCancel;

        this.view.SetUserListBindingSource(usersBindingSource);

        LoadUserList();
        this.view.Show();
    }

    private void OnSearch(object? sender, EventArgs e)
    {
        var value = view.SearchValue?.Trim();
        userList = string.IsNullOrEmpty(value)
            ? repository.GetAll()
            : repository.Search(value);

        usersBindingSource.DataSource = userList;
    }

    private void OnAdd(object? sender, EventArgs e)
    {
        view.IsEdit = false;
    }

    private void OnUpdate(object? sender, EventArgs e)
    {
        if (usersBindingSource.Current is not LoginModel user) return;

        view.UserID = user.UserId.ToString();
        view.UserName = user.UserName;
        view.Password = string.Empty;
        view.Role = user.Role;
        view.IsEdit = true;
    }

    private void OnDelete(object? sender, EventArgs e)
    {
        if (usersBindingSource.Current is not LoginModel user) return;

        try
        {
            repository.Delete(user.UserId);
            view.IsSuccessful = true;
            view.Message = "Kullanıcı silindi.";
            LoadUserList();
        }
        catch (Exception ex)
        {
            view.IsSuccessful = false;
            view.Message = $"Silme hatası: {ex.Message}";
        }
    }

    private void OnSave(object? sender, EventArgs e)
    {
        var model = new LoginModel
        {
            UserName = view.UserName.Trim(),
            Password = view.Password,
            Role = string.IsNullOrWhiteSpace(view.Role) ? "Admin" : view.Role.Trim()
        };

        try
        {
            if (view.IsEdit)
            {
                model.UserId = Convert.ToInt32(view.UserID);
                repository.Update(model);
                view.Message = "Kullanıcı güncellendi.";
            }
            else
            {
                repository.Add(model);
                view.Message = "Yeni kullanıcı eklendi.";
            }

            view.IsSuccessful = true;
            LoadUserList();
            ClearFields();
        }
        catch (Exception ex)
        {
            view.IsSuccessful = false;
            view.Message = $"Kayıt hatası: {ex.Message}";
        }
    }

    private void OnCancel(object? sender, EventArgs e)
    {
        ClearFields();
    }

    private void LoadUserList()
    {
        userList = repository.GetAll();
        usersBindingSource.DataSource = userList;
    }

    private void ClearFields()
    {
        view.UserID = "";
        view.UserName = "";
        view.Password = "";
        view.Role = "";
    }
}
