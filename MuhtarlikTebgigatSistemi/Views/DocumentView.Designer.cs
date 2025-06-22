using System.Windows.Forms;

namespace MuhtarlikTebgigatSistemi.Views
{
    partial class DocumentView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label1 = new Label();
            formBorderPanel = new Panel();
            btnClose = new Button();
            tabControl1 = new TabControl();
            TabPageDocList = new TabPage();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            dataGridView = new DataGridView();
            txtSearch = new TextBox();
            label2 = new Label();
            TabPageDocDetail = new TabPage();
            chkUpdate = new CheckBox();
            dtpUpdate = new DateTimePicker();
            comboReceiver = new ComboBox();
            comboStreet = new ComboBox();
            comboCompany = new ComboBox();
            comboPerson = new ComboBox();
            comboDocType = new ComboBox();
            txtApt = new TextBox();
            label7 = new Label();
            label5 = new Label();
            label3 = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            lblDocId = new Label();
            documentType = new Label();
            documentID = new Label();
            chkCompany = new CheckBox();
            formBorderPanel.SuspendLayout();
            tabControl1.SuspendLayout();
            TabPageDocList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            TabPageDocDetail.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(55, 1);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(81, 28);
            label1.TabIndex = 0;
            label1.Text = "Evraklar";
            // 
            // formBorderPanel
            // 
            formBorderPanel.BackColor = Color.Maroon;
            formBorderPanel.Controls.Add(btnClose);
            formBorderPanel.Controls.Add(label1);
            formBorderPanel.Dock = DockStyle.Top;
            formBorderPanel.Location = new Point(0, 0);
            formBorderPanel.Margin = new Padding(4, 3, 4, 3);
            formBorderPanel.Name = "formBorderPanel";
            formBorderPanel.Size = new Size(800, 35);
            formBorderPanel.TabIndex = 1;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.Dock = DockStyle.Left;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseOverBackColor = Color.Firebrick;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.ForeColor = SystemColors.ButtonHighlight;
            btnClose.Location = new Point(0, 0);
            btnClose.Margin = new Padding(4, 3, 4, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(43, 35);
            btnClose.TabIndex = 7;
            btnClose.Text = "<";
            btnClose.UseCompatibleTextRendering = true;
            btnClose.UseVisualStyleBackColor = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(TabPageDocList);
            tabControl1.Controls.Add(TabPageDocDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 35);
            tabControl1.Margin = new Padding(4, 3, 4, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 415);
            tabControl1.TabIndex = 2;
            // 
            // TabPageDocList
            // 
            TabPageDocList.BackgroundImageLayout = ImageLayout.Zoom;
            TabPageDocList.Controls.Add(btnDelete);
            TabPageDocList.Controls.Add(btnUpdate);
            TabPageDocList.Controls.Add(btnAdd);
            TabPageDocList.Controls.Add(dataGridView);
            TabPageDocList.Controls.Add(txtSearch);
            TabPageDocList.Controls.Add(label2);
            TabPageDocList.Location = new Point(4, 24);
            TabPageDocList.Margin = new Padding(4, 3, 4, 3);
            TabPageDocList.Name = "TabPageDocList";
            TabPageDocList.Padding = new Padding(4, 3, 4, 3);
            TabPageDocList.Size = new Size(792, 387);
            TabPageDocList.TabIndex = 0;
            TabPageDocList.Text = "Evrak Listesi";
            TabPageDocList.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(175, 59);
            btnDelete.Margin = new Padding(4, 3, 4, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(92, 59);
            btnUpdate.Margin = new Padding(4, 3, 4, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(9, 60);
            btnAdd.Margin = new Padding(4, 3, 4, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.BackgroundColor = SystemColors.Control;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Arial", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.Location = new Point(9, 89);
            dataGridView.Margin = new Padding(4, 3, 4, 3);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(774, 275);
            dataGridView.TabIndex = 3;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Location = new Point(9, 32);
            txtSearch.Margin = new Padding(4, 3, 4, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(775, 21);
            txtSearch.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F);
            label2.Location = new Point(9, 8);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(62, 18);
            label2.TabIndex = 0;
            label2.Text = "Sorgula";
            // 
            // TabPageDocDetail
            // 
            TabPageDocDetail.Controls.Add(chkCompany);
            TabPageDocDetail.Controls.Add(chkUpdate);
            TabPageDocDetail.Controls.Add(dtpUpdate);
            TabPageDocDetail.Controls.Add(comboReceiver);
            TabPageDocDetail.Controls.Add(comboStreet);
            TabPageDocDetail.Controls.Add(comboCompany);
            TabPageDocDetail.Controls.Add(comboPerson);
            TabPageDocDetail.Controls.Add(comboDocType);
            TabPageDocDetail.Controls.Add(txtApt);
            TabPageDocDetail.Controls.Add(label7);
            TabPageDocDetail.Controls.Add(label5);
            TabPageDocDetail.Controls.Add(label3);
            TabPageDocDetail.Controls.Add(btnCancel);
            TabPageDocDetail.Controls.Add(btnSave);
            TabPageDocDetail.Controls.Add(lblDocId);
            TabPageDocDetail.Controls.Add(documentType);
            TabPageDocDetail.Controls.Add(documentID);
            TabPageDocDetail.Location = new Point(4, 24);
            TabPageDocDetail.Margin = new Padding(4, 3, 4, 3);
            TabPageDocDetail.Name = "TabPageDocDetail";
            TabPageDocDetail.Padding = new Padding(4, 3, 4, 3);
            TabPageDocDetail.Size = new Size(792, 387);
            TabPageDocDetail.TabIndex = 1;
            TabPageDocDetail.Text = "Evrak Detayları";
            TabPageDocDetail.UseVisualStyleBackColor = true;
            // 
            // chkUpdate
            // 
            chkUpdate.AutoSize = true;
            chkUpdate.Location = new Point(544, 161);
            chkUpdate.Name = "chkUpdate";
            chkUpdate.Size = new Size(15, 14);
            chkUpdate.TabIndex = 32;
            chkUpdate.UseVisualStyleBackColor = true;
            // 
            // dtpUpdate
            // 
            dtpUpdate.CustomFormat = "dd.MM.yyyy";
            dtpUpdate.Format = DateTimePickerFormat.Custom;
            dtpUpdate.Location = new Point(377, 158);
            dtpUpdate.Name = "dtpUpdate";
            dtpUpdate.Size = new Size(162, 21);
            dtpUpdate.TabIndex = 31;
            dtpUpdate.Value = new DateTime(2025, 6, 22, 9, 20, 57, 0);
            // 
            // comboReceiver
            // 
            comboReceiver.FormattingEnabled = true;
            comboReceiver.Location = new Point(208, 157);
            comboReceiver.Name = "comboReceiver";
            comboReceiver.Size = new Size(162, 23);
            comboReceiver.TabIndex = 29;
            // 
            // comboStreet
            // 
            comboStreet.FormattingEnabled = true;
            comboStreet.Location = new Point(208, 128);
            comboStreet.Name = "comboStreet";
            comboStreet.Size = new Size(162, 23);
            comboStreet.TabIndex = 28;
            // 
            // comboCompany
            // 
            comboCompany.FormattingEnabled = true;
            comboCompany.Location = new Point(376, 99);
            comboCompany.Name = "comboCompany";
            comboCompany.Size = new Size(162, 23);
            comboCompany.TabIndex = 27;
            comboCompany.Text = "Firma";
            // 
            // comboPerson
            // 
            comboPerson.FormattingEnabled = true;
            comboPerson.Location = new Point(208, 99);
            comboPerson.Name = "comboPerson";
            comboPerson.Size = new Size(162, 23);
            comboPerson.TabIndex = 26;
            comboPerson.Text = "Kişi";
            // 
            // comboDocType
            // 
            comboDocType.FormattingEnabled = true;
            comboDocType.Location = new Point(208, 70);
            comboDocType.Name = "comboDocType";
            comboDocType.Size = new Size(162, 23);
            comboDocType.TabIndex = 25;
            // 
            // txtApt
            // 
            txtApt.Location = new Point(377, 129);
            txtApt.Margin = new Padding(4, 3, 4, 3);
            txtApt.Name = "txtApt";
            txtApt.Size = new Size(162, 21);
            txtApt.TabIndex = 21;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F);
            label7.Location = new Point(101, 158);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(100, 18);
            label7.TabIndex = 20;
            label7.Text = "Teslim Edilen";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F);
            label5.Location = new Point(149, 129);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(50, 18);
            label5.TabIndex = 18;
            label5.Text = "Adres";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F);
            label3.Location = new Point(165, 100);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(36, 18);
            label3.TabIndex = 16;
            label3.Text = "Alıcı";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(376, 213);
            btnCancel.Margin = new Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 30);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "İptal";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(207, 213);
            btnSave.Margin = new Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 30);
            btnSave.TabIndex = 8;
            btnSave.Text = "Kayıt";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // lblDocId
            // 
            lblDocId.AutoSize = true;
            lblDocId.Font = new Font("Arial", 12F);
            lblDocId.Location = new Point(208, 44);
            lblDocId.Margin = new Padding(4, 3, 4, 3);
            lblDocId.Name = "lblDocId";
            lblDocId.Size = new Size(17, 18);
            lblDocId.TabIndex = 4;
            lblDocId.Text = "0";
            // 
            // documentType
            // 
            documentType.AutoSize = true;
            documentType.Font = new Font("Arial", 12F);
            documentType.Location = new Point(117, 71);
            documentType.Margin = new Padding(4, 0, 4, 0);
            documentType.Name = "documentType";
            documentType.Size = new Size(82, 18);
            documentType.TabIndex = 2;
            documentType.Text = "Evrak Türü";
            // 
            // documentID
            // 
            documentID.AutoSize = true;
            documentID.Font = new Font("Arial", 12F);
            documentID.Location = new Point(129, 44);
            documentID.Margin = new Padding(4, 0, 4, 0);
            documentID.Name = "documentID";
            documentID.Size = new Size(72, 18);
            documentID.TabIndex = 0;
            documentID.Text = "Evrak No";
            // 
            // chkCompany
            // 
            chkCompany.AutoSize = true;
            chkCompany.Location = new Point(544, 104);
            chkCompany.Name = "chkCompany";
            chkCompany.Size = new Size(15, 14);
            chkCompany.TabIndex = 33;
            chkCompany.UseVisualStyleBackColor = true;
            // 
            // DocumentView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(formBorderPanel);
            Font = new Font("Arial", 9F);
            Margin = new Padding(4, 3, 4, 3);
            Name = "DocumentView";
            ShowIcon = false;
            Text = "DocumentView";
            formBorderPanel.ResumeLayout(false);
            formBorderPanel.PerformLayout();
            tabControl1.ResumeLayout(false);
            TabPageDocList.ResumeLayout(false);
            TabPageDocList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            TabPageDocDetail.ResumeLayout(false);
            TabPageDocDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel formBorderPanel;
        private TabControl tabControl1;
        private TabPage TabPageDocList;
        private TabPage TabPageDocDetail;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private DataGridView dataGridView;
        private TextBox txtSearch;
        private Label label2;
        private Button btnSave;
        private Label lblDocId;
        private Label documentType;
        private Label documentID;
        private Button btnCancel;
        private Button btnClose;
        private Label label5;
        private Label label3;
        private Label label7;
        private TextBox txtApt;
        private ComboBox comboDocType;
        private ComboBox comboCompany;
        private ComboBox comboPerson;
        private ComboBox comboReceiver;
        private ComboBox comboStreet;
        private CheckBox chkUpdate;
        private DateTimePicker dtpUpdate;
        private CheckBox chkCompany;
    }
}