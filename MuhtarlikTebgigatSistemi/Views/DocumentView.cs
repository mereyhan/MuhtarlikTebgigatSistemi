using MuhtarlikTebgigatSistemi.Model;
using System.ComponentModel;
using System.Xml;

namespace MuhtarlikTebgigatSistemi.Views
{
    public partial class DocumentView : Form, IDocumentView
    {
        private string message;
        private bool isSuccessful;
        private bool isEdit;

        private readonly System.Windows.Forms.Timer searchDelayTimer;

        public DocumentView()
        {
            InitializeComponent();
            InitializeEvents();

            tabControl1.TabPages.Remove(TabPageDocDetail);

            searchDelayTimer = new System.Windows.Forms.Timer { Interval = 300 };
            searchDelayTimer.Tick += SearchDelayTimer_Tick;

            btnClose.Click += (s, e) => Close();
        }

        private static DocumentView instance;
        public static DocumentView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new DocumentView();
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
                instance.Show();
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                    instance.WindowState = FormWindowState.Normal;
                instance.BringToFront();
            }
            return instance;
        }

        private void InitializeEvents()
        {
            txtSearch.TextChanged += TxtSearch_TextChanged;
            txtSearch.KeyDown += TxtSearch_KeyDown;

            btnAdd.Click += BtnAdd_Click;
            btnUpdate.Click += BtnUpdate_Click;
            btnDelete.Click += BtnDelete_Click;

            btnSave.Click += BtnSave_Click;
            btnCancel.Click += BtnCancel_Click;

            dtpUpdate.ShowCheckBox = false;
            dtpUpdate.Enabled = chkUpdate.Checked;
            chkUpdate.CheckedChanged += (s, e) => dtpUpdate.Enabled = chkUpdate.Checked;

        }

        private void SearchDelayTimer_Tick(object sender, EventArgs e)
        {
            searchDelayTimer.Stop();
            SearchEvent?.Invoke(this, EventArgs.Empty);
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            searchDelayTimer.Stop();
            searchDelayTimer.Start();
            SearchTextChanged?.Invoke(this, EventArgs.Empty);
        }

        private void TxtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchDelayTimer.Stop();
                SearchEvent?.Invoke(this, EventArgs.Empty);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            AddEvent?.Invoke(this, EventArgs.Empty);
            tabControl1.TabPages.Remove(TabPageDocList);
            tabControl1.TabPages.Add(TabPageDocDetail);
            TabPageDocDetail.Text = "Yeni Doküman";
            ClearFields();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            UpdateEvent?.Invoke(this, EventArgs.Empty);
            tabControl1.TabPages.Remove(TabPageDocList);
            tabControl1.TabPages.Add(TabPageDocDetail);
            TabPageDocDetail.Text = "Doküman Güncelle";
            chkUpdate.Checked = true;
            ClearFields();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                DeleteEvent?.Invoke(this, EventArgs.Empty);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveEvent?.Invoke(this, EventArgs.Empty);

            if (IsSuccessful)
            {
                tabControl1.TabPages.Remove(TabPageDocDetail);
                tabControl1.TabPages.Add(TabPageDocList);
                ClearFields();
            }

            if (!string.IsNullOrWhiteSpace(Message))
            {
                ClearFields();
                MessageBox.Show(Message);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            CancelEvent?.Invoke(this, EventArgs.Empty);
            tabControl1.TabPages.Remove(TabPageDocDetail);
            tabControl1.TabPages.Add(TabPageDocList);
            ClearFields();
        }

        // IDocumentView Properties
        public string DocumentID { get => lblDocId.Text; set => lblDocId.Text = value; }
        public string DocumentType { get => comboDocType.Text; set => comboDocType.Text = value; }
        public string StreetName { get => comboStreet.Text; set => comboStreet.Text = value; }
        public string Apt { get => txtApt.Text; set => txtApt.Text = value; }
        public string ReceiverName { get => comboReceiver.Text; set => comboReceiver.Text = value; }

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

        public bool IsCompany
        {
            get => chkCompany.Checked;
            set
            {
                chkCompany.Checked = value;
                label3.Text = value ? "Firma" : "Kişi";
                comboPerson.Visible = !value;
                comboCompany.Visible = value;
            }
        }

        public string SearchValue { get => txtSearch.Text; set => txtSearch.Text = value; }
        public bool IsEdit { get => isEdit; set => isEdit = value; }
        public bool IsSuccessful { get => isSuccessful; set => isSuccessful = value; }
        public string Message { get => message; set => message = value; }

        public DocumentInputModel NewDocumentInput => new DocumentInputModel
        {
            DocumentType = DocumentType,
            Name = IsCompany ? comboCompany.Text : comboPerson.Text,
            Street = StreetName,
            Building = Apt,
            UpdateDate = UpdateDate,
            Receiver = ReceiverName,
            IsCompany = IsCompany
        };

        public event EventHandler SearchEvent;
        public event EventHandler SearchTextChanged;
        public event EventHandler AddEvent;
        public event EventHandler UpdateEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;
        public event EventHandler LoadAll;

        public void SetDocumentListBindingSource(BindingSource documentList)
        {
            dataGridView.DataSource = documentList;
        }

        public void LoadComboBoxData(
            IEnumerable<DocumentTypeModel> docTypes,
            IEnumerable<PersonModel> persons,
            IEnumerable<CompanyModel> companies,
            IEnumerable<StreetModel> streets)
        {
            comboDocType.DataSource = docTypes != null ? new BindingList<DocumentTypeModel>(new List<DocumentTypeModel>(docTypes)) : null;
            comboDocType.DisplayMember = "Type";
            comboDocType.ValueMember = "Id";

            comboPerson.DataSource = persons != null ? new BindingList<PersonModel>(new List<PersonModel>(persons)) : null;
            comboPerson.DisplayMember = "PersonName";
            comboPerson.ValueMember = "Id";

            comboCompany.DataSource = companies != null ? new BindingList<CompanyModel>(new List<CompanyModel>(companies)) : null;
            comboCompany.DisplayMember = "CompanyName";
            comboCompany.ValueMember = "Id";

            comboStreet.DataSource = streets != null ? new BindingList<StreetModel>(new List<StreetModel>(streets)) : null;
            comboStreet.DisplayMember = "Street";
            comboStreet.ValueMember = "Id";

            comboReceiver.DataSource = persons != null ? new BindingList<PersonModel>(new List<PersonModel>(persons)) : null;
            comboReceiver.DisplayMember = "PersonName";
            comboReceiver.ValueMember = "Id";
        }

        public void DisplayDocuments(BindingList<DocumentOverviewModel> documents)
        {
            dataGridView.DataSource = documents;
        }

        public void ClearFields()
        {
            comboDocType.Text = "";
            comboPerson.Text = "";
            comboCompany.Text = "";
            comboStreet.Text = "";
            txtApt.Text = "";
            comboReceiver.Text = "";
            chkUpdate.Checked = false;
            dtpUpdate.Value = DateTime.Today;
            chkCompany.Checked = false;
        }
    }
}

