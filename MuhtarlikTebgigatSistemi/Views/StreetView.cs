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

            searchDelayTimer = new System.Windows.Forms.Timer { Interval = 300 };

            AssociateAndRaiseViewEvents();

            tabControl1.TabPages.Remove(TabPageStreetDetail);

            btnClose.Click += delegate { this.Close(); };
        }

        private void AssociateAndRaiseViewEvents()
        {
            txtSearch.TextChanged += (s, e) =>
            {
                searchDelayTimer.Stop();
                searchDelayTimer.Start();
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

            btnAdd.Click += delegate
            {
                AddEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(TabPageStreetList);
                tabControl1.TabPages.Add(TabPageStreetDetail);
                TabPageStreetDetail.Text = "Ekle";
            };

            btnUpdate.Click += delegate
            {
                UpdateEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(TabPageStreetList);
                tabControl1.TabPages.Add(TabPageStreetDetail);
                TabPageStreetDetail.Text = "Güncelle";
            };

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

            btnCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(TabPageStreetDetail);
                tabControl1.TabPages.Add(TabPageStreetList);
            };

            chkUpdate.CheckedChanged += (s, e) =>
            {
                dtpUpdate.Enabled = chkUpdate.Checked;
            };
        }

        public string StreetID
        {
            get => txtStreetId.Text;
            set => txtStreetId.Text = value;
        }

        public string StreetName
        {
            get => txtStreetName.Text;
            set => txtStreetName.Text = value;
        }

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

        public string SearchValue
        {
            get => txtSearch.Text;
            set => txtSearch.Text = value;
        }

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

        public void SetStreetListBindingSource(BindingSource streetList)
        {
            dataGridView.DataSource = streetList;
        }

        public static StreetView GetInstance(Form parentContainer)
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

        public void ClearFields()
        {
            txtStreetId.Text = "";
            txtStreetName.Text = "";
            chkUpdate.Checked = false;
            dtpUpdate.Value = DateTime.Today;
        }
    }

}
