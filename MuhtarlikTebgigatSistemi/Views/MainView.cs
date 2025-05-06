using MuhtarlikTebgigatSistemi.Helpers;
using MuhtarlikTebgigatSistemi.Helpers.PreviewProvider;
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
        }

        //private void MainView_Load(object sender, EventArgs e)
        //{
        //    string connectionString = ConfigurationManager.ConnectionStrings["SqliteConnection"].ConnectionString;

        //    var previewProviders = new Dictionary<string, IForeignKeyPreview>
        //    {
        //        { "PersonID", new PersonPreviewProvider(connectionString) }
        //        // { "DocumentID", new DocumentPreviewProvider(connectionString) }
        //        // { "DocTypeID", new DocTypePreviewProvider(connectionString) }
        //        // { "CompanyID", new CompanyPreviewProvider(connectionString) }
        //    };

        //    var tooltipHelper = new DataGridTooltipHelper(previewProviders);
        //    // tooltipHelper.AttachTo(dataGridView);
        //}


        public event EventHandler ShowDocumentView;
        public event EventHandler ShowDocTypeView;
        public event EventHandler ShowStreetView;
        public event EventHandler ShowPersonView;
        public event EventHandler ShowCompanyView;

        public event EventHandler ShowOwnerView;
        public event EventHandler ShowAdminView;
    }
}
