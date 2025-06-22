using MuhtarlikTebgigatSistemi.Views.Interfaces;

namespace MuhtarlikTebgigatSistemi.Views
{
    public partial class CompanyView : Form, ICompanyView
    {
        private string message;
        private bool isSuccessful;
        private bool isEdit;

        private bool isTimerRunning = false;
        private System.Windows.Forms.Timer searchDelayTimer;

        public CompanyView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabControl1.TabPages.Remove(TabPageCompanyDetail);
            btnClose.Click += delegate { this.Close(); };
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
                tabControl1.TabPages.Remove(TabPageCompanyList);
                tabControl1.TabPages.Add(TabPageCompanyDetail);
                TabPageCompanyDetail.Text = "Add new document";
            };
            // Update selected document
            btnUpdate.Click += delegate
            {
                UpdateEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(TabPageCompanyList);
                tabControl1.TabPages.Add(TabPageCompanyDetail);
                TabPageCompanyDetail.Text = "Update document";
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
                    tabControl1.TabPages.Remove(TabPageCompanyDetail);
                    tabControl1.TabPages.Add(TabPageCompanyList);
                }
                if (!string.IsNullOrWhiteSpace(Message)) { MessageBox.Show(Message); }
            };
            // Cancel action
            btnCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(TabPageCompanyDetail);
                tabControl1.TabPages.Add(TabPageCompanyList);
            };
        }

        public string CompanyID { get => txtCompanyId.Text; set => txtCompanyId.Text = value; }
        public string MyCompanyName { get => txtCompanyName.Text; set => txtCompanyName.Text = value; }
        public string StreetName { get => cmbStreet.Text; set => cmbStreet.Text = value; }
        public string BuildingApt { get => txtApt.Text; set => txtApt.Text = value; }
        public string PhoneNumber { get => txtPhone.Text; set => txtPhone.Text = value; }
        public string Email { get => txtEmail.Text; set => txtEmail.Text = value; }
        public string UpdateDate
        {
            get => chkUpdate.Checked ? dtpUpdate.Value.ToString("yyyy-MM-dd") : "";
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    chkUpdate.Checked = false;
                    dtpUpdate.Enabled = false;
                }
                else
                {
                    chkUpdate.Checked = true;
                    dtpUpdate.Enabled = true;
                    dtpUpdate.Value = DateTime.Parse(value);
                }
            }
        }


        public string SearchValue { get => txtSearch.Text; set => txtSearch.Text = value; }
        public bool IsEdit { get => isEdit; set => isEdit = value; }
        public bool IsSuccessful { get => isSuccessful; set => isSuccessful = value; }
        public string Message { get => message; set => message = value; }

        public event EventHandler SearchEvent;
        public event EventHandler SearchTextChanged;
        public event EventHandler AddEvent;
        public event EventHandler UpdateEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public void SetCompanyListBindingSource(BindingSource companyList)
        {
            dataGridView.DataSource = companyList;
        }

        public void SetStreetComboBox(List<string> streetNames)
        {
            cmbStreet.DataSource = streetNames;
        }

        private static CompanyView instance;
        public static CompanyView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new CompanyView();
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
