namespace MuhtarlikTebgigatSistemi.Views
{
    partial class CompanyView
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
            formBorderPanel = new Panel();
            btnClose = new Button();
            label1 = new Label();
            tabControl1 = new TabControl();
            TabPageCompanyList = new TabPage();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            dataGridView = new DataGridView();
            txtSearch = new TextBox();
            label2 = new Label();
            TabPageCompanyDetail = new TabPage();
            label8 = new Label();
            txtApt = new TextBox();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            txtEmail = new TextBox();
            txtCompanyName = new TextBox();
            btnCancel = new Button();
            btnSave = new Button();
            txtPhone = new TextBox();
            txtCompanyId = new TextBox();
            documentType = new Label();
            documentID = new Label();
            dtpUpdate = new DateTimePicker();
            chkUpdate = new CheckBox();
            cmbStreet = new ComboBox();
            formBorderPanel.SuspendLayout();
            tabControl1.SuspendLayout();
            TabPageCompanyList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            TabPageCompanyDetail.SuspendLayout();
            SuspendLayout();
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
            formBorderPanel.TabIndex = 2;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(55, 1);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(120, 28);
            label1.TabIndex = 0;
            label1.Text = "COMPANIES";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(TabPageCompanyList);
            tabControl1.Controls.Add(TabPageCompanyDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 35);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 415);
            tabControl1.TabIndex = 3;
            // 
            // TabPageCompanyList
            // 
            TabPageCompanyList.Controls.Add(btnDelete);
            TabPageCompanyList.Controls.Add(btnUpdate);
            TabPageCompanyList.Controls.Add(btnAdd);
            TabPageCompanyList.Controls.Add(dataGridView);
            TabPageCompanyList.Controls.Add(txtSearch);
            TabPageCompanyList.Controls.Add(label2);
            TabPageCompanyList.Location = new Point(4, 24);
            TabPageCompanyList.Name = "TabPageCompanyList";
            TabPageCompanyList.Padding = new Padding(3);
            TabPageCompanyList.Size = new Size(792, 387);
            TabPageCompanyList.TabIndex = 0;
            TabPageCompanyList.Text = "Company List";
            TabPageCompanyList.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(175, 60);
            btnDelete.Margin = new Padding(4, 3, 4, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 20;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(92, 60);
            btnUpdate.Margin = new Padding(4, 3, 4, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 19;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(9, 60);
            btnAdd.Margin = new Padding(4, 3, 4, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.BackgroundColor = SystemColors.Control;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(9, 89);
            dataGridView.Margin = new Padding(4, 3, 4, 3);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(774, 275);
            dataGridView.TabIndex = 17;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Location = new Point(9, 32);
            txtSearch.Margin = new Padding(4, 3, 4, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(774, 23);
            txtSearch.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(9, 8);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(128, 21);
            label2.TabIndex = 14;
            label2.Text = "Search Company";
            // 
            // TabPageCompanyDetail
            // 
            TabPageCompanyDetail.Controls.Add(cmbStreet);
            TabPageCompanyDetail.Controls.Add(chkUpdate);
            TabPageCompanyDetail.Controls.Add(dtpUpdate);
            TabPageCompanyDetail.Controls.Add(label8);
            TabPageCompanyDetail.Controls.Add(txtApt);
            TabPageCompanyDetail.Controls.Add(label7);
            TabPageCompanyDetail.Controls.Add(label5);
            TabPageCompanyDetail.Controls.Add(label4);
            TabPageCompanyDetail.Controls.Add(txtEmail);
            TabPageCompanyDetail.Controls.Add(txtCompanyName);
            TabPageCompanyDetail.Controls.Add(btnCancel);
            TabPageCompanyDetail.Controls.Add(btnSave);
            TabPageCompanyDetail.Controls.Add(txtPhone);
            TabPageCompanyDetail.Controls.Add(txtCompanyId);
            TabPageCompanyDetail.Controls.Add(documentType);
            TabPageCompanyDetail.Controls.Add(documentID);
            TabPageCompanyDetail.Location = new Point(4, 24);
            TabPageCompanyDetail.Name = "TabPageCompanyDetail";
            TabPageCompanyDetail.Padding = new Padding(3);
            TabPageCompanyDetail.Size = new Size(792, 387);
            TabPageCompanyDetail.TabIndex = 1;
            TabPageCompanyDetail.Text = "Company Detail";
            TabPageCompanyDetail.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(99, 149);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(48, 21);
            label8.TabIndex = 42;
            label8.Text = "Email";
            // 
            // txtApt
            // 
            txtApt.Location = new Point(372, 96);
            txtApt.Margin = new Padding(4, 3, 4, 3);
            txtApt.Name = "txtApt";
            txtApt.Size = new Size(100, 23);
            txtApt.TabIndex = 41;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(99, 176);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(132, 21);
            label7.TabIndex = 40;
            label7.Text = "Güncelleme tarihi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(99, 98);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(50, 21);
            label5.TabIndex = 38;
            label5.Text = "Adres";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(99, 123);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(59, 21);
            label4.TabIndex = 37;
            label4.Text = "Telefon";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(244, 147);
            txtEmail.Margin = new Padding(4, 3, 4, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(228, 23);
            txtEmail.TabIndex = 34;
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new Point(244, 71);
            txtCompanyName.Margin = new Padding(4, 3, 4, 3);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(228, 23);
            txtCompanyName.TabIndex = 32;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(291, 228);
            btnCancel.Margin = new Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 30);
            btnCancel.TabIndex = 30;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(171, 228);
            btnSave.Margin = new Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 30);
            btnSave.TabIndex = 29;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(244, 121);
            txtPhone.Margin = new Padding(4, 3, 4, 3);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(228, 23);
            txtPhone.TabIndex = 28;
            // 
            // txtCompanyId
            // 
            txtCompanyId.Location = new Point(244, 46);
            txtCompanyId.Margin = new Padding(4, 3, 4, 3);
            txtCompanyId.Name = "txtCompanyId";
            txtCompanyId.ReadOnly = true;
            txtCompanyId.Size = new Size(228, 23);
            txtCompanyId.TabIndex = 27;
            txtCompanyId.Text = "0";
            // 
            // documentType
            // 
            documentType.AutoSize = true;
            documentType.Font = new Font("Segoe UI", 12F);
            documentType.Location = new Point(99, 71);
            documentType.Margin = new Padding(4, 0, 4, 0);
            documentType.Name = "documentType";
            documentType.Size = new Size(83, 21);
            documentType.TabIndex = 26;
            documentType.Text = "Firma İsmi";
            // 
            // documentID
            // 
            documentID.AutoSize = true;
            documentID.Font = new Font("Segoe UI", 12F);
            documentID.Location = new Point(99, 46);
            documentID.Margin = new Padding(4, 0, 4, 0);
            documentID.Name = "documentID";
            documentID.Size = new Size(75, 21);
            documentID.TabIndex = 25;
            documentID.Text = "Firma No";
            // 
            // dtpUpdate
            // 
            dtpUpdate.Location = new Point(244, 176);
            dtpUpdate.Name = "dtpUpdate";
            dtpUpdate.Size = new Size(207, 23);
            dtpUpdate.TabIndex = 43;
            // 
            // chkUpdate
            // 
            chkUpdate.AutoSize = true;
            chkUpdate.Location = new Point(457, 182);
            chkUpdate.Name = "chkUpdate";
            chkUpdate.Size = new Size(15, 14);
            chkUpdate.TabIndex = 44;
            chkUpdate.UseVisualStyleBackColor = true;
            // 
            // cmbStreet
            // 
            cmbStreet.FormattingEnabled = true;
            cmbStreet.Location = new Point(244, 96);
            cmbStreet.Name = "cmbStreet";
            cmbStreet.Size = new Size(121, 23);
            cmbStreet.TabIndex = 46;
            // 
            // CompanyView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(formBorderPanel);
            Name = "CompanyView";
            Text = "CompanyView";
            formBorderPanel.ResumeLayout(false);
            formBorderPanel.PerformLayout();
            tabControl1.ResumeLayout(false);
            TabPageCompanyList.ResumeLayout(false);
            TabPageCompanyList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            TabPageCompanyDetail.ResumeLayout(false);
            TabPageCompanyDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel formBorderPanel;
        private Button btnClose;
        private Label label1;
        private TabControl tabControl1;
        private TabPage TabPageCompanyList;
        private TabPage TabPageCompanyDetail;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private DataGridView dataGridView;
        private TextBox txtSearch;
        private Label label2;
        private Label label8;
        private TextBox txtApt;
        private Label label7;
        private Label label5;
        private Label label4;
        private TextBox txtEmail;
        private TextBox txtCompanyName;
        private Button btnCancel;
        private Button btnSave;
        private TextBox txtPhone;
        private TextBox txtCompanyId;
        private Label documentType;
        private Label documentID;
        private CheckBox chkUpdate;
        private DateTimePicker dtpUpdate;
        private ComboBox cmbStreet;
    }
}