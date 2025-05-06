using MuhtarlikTebgigatSistemi.Views.Interfaces;
using System.Windows.Forms;

namespace MuhtarlikTebgigatSistemi.Views
{
    public partial class StreetView : Form, IStreetView
    {

        private string message;
        private bool isSuccessful;
        private bool isEdit;

        private bool isTimerRunning = false;
        private System.Windows.Forms.Timer searchDelayTimer;

        public StreetView()
        {
            InitializeComponent();

            AssociateAndRaiseViewEvents();
            tabControl1.TabPages.Remove(TabPageStreetDetail);
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
                tabControl1.TabPages.Remove(TabPageStreetList);
                tabControl1.TabPages.Add(TabPageStreetDetail);
                TabPageStreetDetail.Text = "Add new street";
            };
            // Update selected document
            btnUpdate.Click += delegate
            {
                UpdateEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(TabPageStreetList);
                tabControl1.TabPages.Add(TabPageStreetDetail);
                TabPageStreetDetail.Text = "Update street";
            };
            // Delete selected document
            btnDelete.Click += delegate
            {
                var result = MessageBox.Show("Are you sure you want to delete the selected street?", "Warning",
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
                    tabControl1.TabPages.Remove(TabPageStreetDetail);
                    tabControl1.TabPages.Add(TabPageStreetList);
                }
                if (!string.IsNullOrWhiteSpace(Message)) { MessageBox.Show(Message); }
            };
            // Cancel action
            btnCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(TabPageStreetDetail);
                tabControl1.TabPages.Add(TabPageStreetList);
            };
        }

        public string StreetID { get => txtStreetId.Text; set => txtStreetId.Text = value; }
        public string StreetName { get => txtStreetName.Text; set => txtStreetName.Text = value; }
        public string RegisterDate { get => txtRegisterDate.Text; set => txtRegisterDate.Text = value; }
        public string UpdateDate { get => txtUpdateDate.Text; set => txtUpdateDate.Text = value; }

        public string SearchValue { get => txtSearch.Text; set => txtSearch.Text = value; }
        public bool IsEdit { get => isEdit; set => isEdit = value; }
        public bool IsSuccessful { get => isSuccessful; set => isSuccessful = value; }
        public string Message { get => message; set => message = value; }

        public event EventHandler SearchEvent;
        public event EventHandler AddEvent;
        public event EventHandler UpdateEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;
        private static StreetView instance;

        public void SetStreetListBindingSource(BindingSource StreetList)
        {
            dataGridView.DataSource = StreetList;
        }

        public static StreetView GetInstace(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new StreetView();
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
