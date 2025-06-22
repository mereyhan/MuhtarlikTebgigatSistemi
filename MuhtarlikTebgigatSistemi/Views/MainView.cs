using MuhtarlikTebgigatSistemi.Views.Interfaces;
using System.Configuration;

namespace MuhtarlikTebgigatSistemi.Views
{
    public partial class MainView : Form, IMainView
    {
        public MainView()
        {
            InitializeComponent();
            this.IsMdiContainer = true;

            btnDocuments.Click += delegate { ShowDocumentView?.Invoke(this, EventArgs.Empty); };
            btnDocTypes.Click += delegate { ShowDocTypeView?.Invoke(this, EventArgs.Empty); };
            btnStreets.Click += delegate { ShowStreetView?.Invoke(this, EventArgs.Empty); };
            btnPersons.Click += delegate { ShowPersonView?.Invoke(this, EventArgs.Empty); };
            btnCompanies.Click += delegate { ShowCompanyView?.Invoke(this, EventArgs.Empty); };
            btnUsers.Click += delegate { ShowUserView?.Invoke(this, EventArgs.Empty); };
        }

        public event EventHandler ShowDocumentView;
        public event EventHandler ShowDocTypeView;
        public event EventHandler ShowStreetView;
        public event EventHandler ShowPersonView;
        public event EventHandler ShowCompanyView;
        public event EventHandler ShowUserView;
    }
}
