namespace MuhtarlikTebgigatSistemi.Views
{
    public partial class DocumentView : Form, IDocumentView
    {
        // Fields
        private string message;
        private bool isSuccessful;
        private bool isEdit;

        private bool isTimerRunning = false;
        private System.Windows.Forms.Timer searchDelayTimer;

        // Constructor
        public DocumentView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabControl1.TabPages.Remove(TabPageDocDetail);
            btnClose.Click += delegate { this.Close(); };

            // formBorderPanel.MouseDown += formBorderPanel_MouseDown;
        }

        private void AssociateAndRaiseViewEvents()
        {
            // Search document
            txtSearch.TextChanged += (s, e) =>
            {
                searchDelayTimer.Stop();
                searchDelayTimer.Start();
            };
            searchDelayTimer = new System.Windows.Forms.Timer
            {
                Interval = 300
            };
            searchDelayTimer.Tick += (s, e) =>
            {
                if (!isTimerRunning)
                {
                    isTimerRunning = true;

                    searchDelayTimer.Stop();
                    SearchEvent?.Invoke(this, EventArgs.Empty);

                    isTimerRunning = false;
                }
            };

            txtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    SearchEvent?.Invoke(this, EventArgs.Empty);
            };
            // Add new document
            btnAdd.Click += delegate
            {
                AddEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(TabPageDocList);
                tabControl1.TabPages.Add(TabPageDocDetail);
                TabPageDocDetail.Text = "Add new document";
            };
            // Update selected document
            btnUpdate.Click += delegate
            {
                UpdateEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(TabPageDocList);
                tabControl1.TabPages.Add(TabPageDocDetail);
                TabPageDocDetail.Text = "Update document";
            };
            // Delete selected document
            btnDelete.Click += delegate
            {
                var result = MessageBox.Show("Are you sure you want to delete the selected document?", "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    if (!string.IsNullOrWhiteSpace(Message)) { MessageBox.Show(Message); }
                }
            };
            // Save document
            btnSave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (IsSuccessful)
                {
                    tabControl1.TabPages.Remove(TabPageDocDetail);
                    tabControl1.TabPages.Add(TabPageDocList);
                }
                if (!string.IsNullOrWhiteSpace(Message)) { MessageBox.Show(Message); }
            };
            // Cancel action
            btnCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(TabPageDocDetail);
                tabControl1.TabPages.Add(TabPageDocList);
            };
        }

        // Properties
        public string DocumentID { get => txtDocId.Text; set => txtDocId.Text = value; }
        public string DocumentType { get => txtDocType.Text; set => txtDocType.Text = value; }
        public string PersonName { get => txtPersonName.Text; set => txtPersonName.Text = value; }
        public string CompanyName { get => txtCompanyName.Text; set => txtCompanyName.Text = value; }
        public string StreetName { get => txtStreetName.Text; set => txtStreetName.Text = value; }
        public string RegistrationDate { get => txtRegDate.Text; set => txtRegDate.Text = value; }
        public string DeliveryDate { get => txtDeliveryDate.Text; set => txtDeliveryDate.Text = value; }
        public string DeliveredBy { get => txtDeliveredBy.Text; set => txtDeliveredBy.Text = value; }
        public string BuildingApt { get => txtApt.Text; set => txtApt.Text = value; }

        public string SearchValue { get => txtSearch.Text; set => txtSearch.Text = value; }
        public bool IsEdit { get => isEdit; set => isEdit = value; }
        public bool IsSuccessful { get => isSuccessful; set => isSuccessful = value; }
        public string Message { get => message; set => message = value; }

        // Events
        public event EventHandler SearchEvent;
        public event EventHandler SearchTextChanged;
        public event EventHandler AddEvent;
        public event EventHandler UpdateEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        // Methods
        public void SetDocumentListBindingSource(BindingSource documentList)
        {
            dataGridView.DataSource = documentList;
        }

        //Singleton pattern (Open a single form instance)
        private static DocumentView instance;
        public static DocumentView GetInstace(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new DocumentView();
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                    instance.WindowState = FormWindowState.Normal;
                instance.BringToFront();
            }
            return instance;
        }
    }
}
