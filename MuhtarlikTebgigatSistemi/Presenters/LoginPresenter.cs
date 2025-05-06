using MuhtarlikTebgigatSistemi._Repository;
using MuhtarlikTebgigatSistemi.Views;
using MuhtarlikTebgigatSistemi.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuhtarlikTebgigatSistemi.Presenters
{
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
                view.ShowError("Kullanıcı adı veya şifre hatalı.");
            }
        }
    }

}
