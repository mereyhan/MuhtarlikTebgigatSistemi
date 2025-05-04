using MuhtarlikTebgigatSistemi.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }
        public event EventHandler ShowDocumentView;
        public event EventHandler ShowDocTypeView;
        public event EventHandler ShowStreetView;
        public event EventHandler ShowPersonView;
        public event EventHandler ShowCompanyView;

        public event EventHandler ShowOwnerView;
        public event EventHandler ShowAdminView;
    }
}
