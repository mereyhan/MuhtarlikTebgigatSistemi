using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuhtarlikTebgigatSistemi.Views.Interfaces
{
    public interface IMainView
    {
        event EventHandler ShowDocumentView;
        event EventHandler ShowDocTypeView;
        event EventHandler ShowStreetView;
        event EventHandler ShowPersonView;
        event EventHandler ShowCompanyView;

        event EventHandler ShowOwnerView;
        event EventHandler ShowAdminView;
    }
}
