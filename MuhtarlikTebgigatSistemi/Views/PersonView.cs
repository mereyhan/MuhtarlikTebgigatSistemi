using MuhtarlikTebgigatSistemi.Views.Interfaces;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ToolTip = System.Windows.Forms.ToolTip;

namespace MuhtarlikTebgigatSistemi.Views
{
    public partial class PersonView : Form, IPersonView
    {
        private string message;
        private bool isSuccessful;
        private bool isEdit;

        private bool isTimerRunning = false;
        private System.Windows.Forms.Timer searchDelayTimer;

        public PersonView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabControl1.TabPages.Remove(TabPagePersonDetail);
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
                tabControl1.TabPages.Remove(TabPagePersonList);
                tabControl1.TabPages.Add(TabPagePersonDetail);
                TabPagePersonDetail.Text = "Evrak Ekle";
            };
            // Update selected document
            btnUpdate.Click += delegate
            {
                UpdateEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(TabPagePersonList);
                tabControl1.TabPages.Add(TabPagePersonDetail);
                TabPagePersonDetail.Text = "Evrak Güncelle";
            };
            // Delete selected document
            btnDelete.Click += delegate
            {
                var result = MessageBox.Show("Evrak silinsin mi?", "Warning",
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
                    tabControl1.TabPages.Remove(TabPagePersonDetail);
                    tabControl1.TabPages.Add(TabPagePersonList);
                }
                if (!string.IsNullOrWhiteSpace(Message)) { MessageBox.Show(Message); }
            };
            // Cancel action
            btnCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(TabPagePersonDetail);
                tabControl1.TabPages.Add(TabPagePersonList);
            };
            // DataGridView Mouse Hover Event
            // dataGridView.CellMouseEnter += DataGridView_CellMouseEnter;
        }

        public string PersonID { get => txtPersonId.Text; set => txtPersonId.Text = value; }
        public string PersonName { get => txtPersonName.Text; set => txtPersonName.Text = value; }
        public string StreetName { get => txtStreetName.Text; set => txtStreetName.Text = value; }
        public string BuildingApt { get => txtApt.Text; set => txtApt.Text = value; }
        public string CompanyName { get => txtCompanyName.Text; set => txtCompanyName.Text = value; }
        public string PhoneNumber { get => txtPhone.Text; set => txtPhone.Text = value; }
        public string Email { get => txtEmail.Text; set => txtEmail.Text = value; }
        public string RegisterDate { get => txtRegisterDate.Text; set => txtRegisterDate.Text = value; }
        public string UpdateDate { get => txtUpdateDate.Text; set => txtUpdateDate.Text = value; }

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

        public void SetPersonListBindingSource(BindingSource personList)
        {
            dataGridView.DataSource = personList;
        }

        private static PersonView instance;
        public static PersonView GetInstace(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new PersonView();
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

    //    private void DataGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
    //    {
    //        if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
    //        {
    //            var columnName = dataGridView.Columns[e.ColumnIndex].Name;
    //            ToolTip toolTip1 = new ToolTip(); // Yeni ToolTip nesnesi oluşturulur
    //            toolTip1.SetToolTip(dataGridView, "Bu hücreye ait detaylar");

    //            if (columnName == "PersonID") // foreign key sütun adı
    //            {
    //                string personId = dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString();

    //                if (!string.IsNullOrWhiteSpace(personId))
    //                {
    //                    // Burada DB'den veya önceden yüklenmiş bir listeden kişi bilgilerini al:
    //                    var person = dataGridView(personId); // senin yazacağın bir metot

    //                    if (person != null)
    //                    {
    //                        string tooltipText = $"Ad Soyad: {person.FullName}\nTelefon: {person.Phone}\nEmail: {person.Email}";
    //                        var cellRectangle = dataGridView.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
    //                        var location = dataGridView.PointToScreen(cellRectangle.Location);

    //                        ToolTip toolTip = new ToolTip();
    //                        toolTip.Show(tooltipText, dataGridView, cellRectangle.X + 10, cellRectangle.Y + 20, 3000);
    //                    }
    //                }
    //            }
    //        }
    //    }
    }
}
