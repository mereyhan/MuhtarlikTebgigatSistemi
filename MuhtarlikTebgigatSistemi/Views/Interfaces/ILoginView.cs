namespace MuhtarlikTebgigatSistemi.Views.Interfaces;

public interface ILoginView
{
    string UserName { get; }
    string Password { get; }
    bool IsLoginSuccessful { get; set; }

    event EventHandler LoginEvent;

    void ShowError(string message);
    void CloseView();
}

public interface IUserView
{
    string UserID { get; set; }
    string UserName { get; set; }
    string Password { get; set; }
    string Role { get; set; }

    string SearchValue { get; set; }
    bool IsEdit { get; set; }
    bool IsSuccessful { get; set; }
    string Message { get; set; }

    event EventHandler SearchEvent;
    event EventHandler SearchTextChanged;
    event EventHandler AddEvent;
    event EventHandler UpdateEvent;
    event EventHandler DeleteEvent;
    event EventHandler SaveEvent;
    event EventHandler CancelEvent;

    void SetUserListBindingSource(BindingSource userList);
    void Show();
}
