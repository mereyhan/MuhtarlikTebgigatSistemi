using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MuhtarlikTebgigatSistemi.Views
{
    public partial class DocumentView : Form, IDocumentView
    {
        // Fields
        private string message;
        private bool isSuccessful;
        private bool isEdit;

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
            btnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            txtSearch.KeyDown += (s, e) => { if (e.KeyCode == Keys.Enter) SearchEvent?.Invoke(this, EventArgs.Empty); };
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
                DeleteEvent?.Invoke(this, EventArgs.Empty);
                var result = MessageBox.Show("Are you sure you want to delete the selected pet?", "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes) {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
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
                MessageBox.Show(Message);
            };
            // Cancel action
            btnCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                if (IsSuccessful)
                {
                    tabControl1.TabPages.Remove(TabPageDocDetail);
                    tabControl1.TabPages.Add(TabPageDocList);
                }
                MessageBox.Show(Message);
            };
        }

        // Properties
        public string DocumentID { get => txtDocId.Text; set => txtDocId.Text = value; }
        public string DocumentName { get => txtDocName.Text; set => txtDocName.Text = value; }
        public string DocumentType { get => txtDocType.Text; set => txtDocType.Text = value; }
        public string DocumentColor { get => txtDocColor.Text; set => txtDocColor.Text = value; }
        public string SearchValue { get => txtSearch.Text; set => txtSearch.Text = value; }
        public bool IsEdit { get => isEdit; set => isEdit = value; }
        public bool IsSuccessful { get => isSuccessful; set => isSuccessful = value; }
        public string Message { get => message; set => message = value; }

        // Events
        public event EventHandler SearchEvent;
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

        /* Manuel Form Border Events [Closed]
        // Native metotları kullanarak taşıma işlemi yapılır
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void formBorderPanel_MouseDown(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture(); // Fare kontrolünü bırakır
                SendMessage(this.Handle, 0xA1, 0x2, 0); // Formun taşıma mesajını işler

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal) this.WindowState = FormWindowState.Maximized; // Formu büyüt
            else this.WindowState = FormWindowState.Normal; // Orijinal boyuta döndür
        }
        */
    }
}
