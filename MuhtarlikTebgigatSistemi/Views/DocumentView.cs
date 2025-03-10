using System.Runtime.InteropServices;

namespace MuhtarlikTebgigatSistemi.Views
{
    public partial class DocumentView : Form, IDocumentView
    {
        // Native metotları kullanarak taşıma işlemi yapılır
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

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

            // formBorderPanel üzerine olay eklenir
            formBorderPanel.MouseDown += formBorderPanel_MouseDown;
        }

        private void formBorderPanel_MouseDown(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture(); // Fare kontrolünü bırakır
                SendMessage(this.Handle, 0xA1, 0x2, 0); // Formun taşıma mesajını işler

            }
        }

        private void AssociateAndRaiseViewEvents()
        {
            btnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            txtSearch.KeyDown += (s, e) => { if (e.KeyCode == Keys.Enter) SearchEvent?.Invoke(this, EventArgs.Empty); };

            /* 
            btnSearch.Click += (s, e) => SearchEvent?.Invoke(s, e);
            btnAdd.Click += (s, e) => AddEvent?.Invoke(s, e);
            btnUpdate.Click += (s, e) => UpdateEvent?.Invoke(s, e);
            btnDelete.Click += (s, e) => DeleteEvent?.Invoke(s, e);
            btnSave.Click += (s, e) => SaveEvent?.Invoke(s, e);
            btnCancel.Click += (s, e) => CancelEvent?.Invoke(s, e);
            */
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

        private void documentDetail_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void documentList_Click(object sender, EventArgs e)
        {

        }

        private void formBorderPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
