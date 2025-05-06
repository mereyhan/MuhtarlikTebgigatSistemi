using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuhtarlikTebgigatSistemi.Views.Interfaces
{
    public interface ILoginView
    {
        string UserName { get; }
        string Password { get; }
        bool IsLoginSuccessful { get; set; }

        event EventHandler LoginEvent;

        void ShowError(string message);
        void CloseView();
    }

}
