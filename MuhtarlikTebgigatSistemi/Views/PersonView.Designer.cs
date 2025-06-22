namespace MuhtarlikTebgigatSistemi.Views
{
    partial class PersonView
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
            TabPagePersonList = new TabPage();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            dataGridView = new DataGridView();
            txtSearch = new TextBox();
            label2 = new Label();
            TabPagePersonDetail = new TabPage();
            chkUpdate = new CheckBox();
            dtpUpdate = new DateTimePicker();
            label8 = new Label();
            txtPhone = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label3 = new Label();
            txtEmail = new TextBox();
            txtApt = new TextBox();
            btnCancel = new Button();
            btnSave = new Button();
            txtPersonName = new TextBox();
            txtPersonId = new TextBox();
            documentType = new Label();
            documentID = new Label();
            cmbStreet = new ComboBox();
            formBorderPanel.SuspendLayout();
            tabControl1.SuspendLayout();
            TabPagePersonList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            TabPagePersonDetail.SuspendLayout();
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
            label1.Size = new Size(97, 28);
            label1.TabIndex = 0;
            label1.Text = "PERSONS";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(TabPagePersonList);
            tabControl1.Controls.Add(TabPagePersonDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 35);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 415);
            tabControl1.TabIndex = 3;
            // 
            // TabPagePersonList
            // 
            TabPagePersonList.Controls.Add(btnDelete);
            TabPagePersonList.Controls.Add(btnUpdate);
            TabPagePersonList.Controls.Add(btnAdd);
            TabPagePersonList.Controls.Add(dataGridView);
            TabPagePersonList.Controls.Add(txtSearch);
            TabPagePersonList.Controls.Add(label2);
            TabPagePersonList.Location = new Point(4, 24);
            TabPagePersonList.Name = "TabPagePersonList";
            TabPagePersonList.Padding = new Padding(3);
            TabPagePersonList.Size = new Size(792, 387);
            TabPagePersonList.TabIndex = 0;
            TabPagePersonList.Text = "Person List";
            TabPagePersonList.UseVisualStyleBackColor = true;
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
            label2.Size = new Size(108, 21);
            label2.TabIndex = 14;
            label2.Text = "Search Person";
            // 
            // TabPagePersonDetail
            // 
            TabPagePersonDetail.Controls.Add(cmbStreet);
            TabPagePersonDetail.Controls.Add(chkUpdate);
            TabPagePersonDetail.Controls.Add(dtpUpdate);
            TabPagePersonDetail.Controls.Add(label8);
            TabPagePersonDetail.Controls.Add(txtPhone);
            TabPagePersonDetail.Controls.Add(label7);
            TabPagePersonDetail.Controls.Add(label6);
            TabPagePersonDetail.Controls.Add(label3);
            TabPagePersonDetail.Controls.Add(txtEmail);
            TabPagePersonDetail.Controls.Add(txtApt);
            TabPagePersonDetail.Controls.Add(btnCancel);
            TabPagePersonDetail.Controls.Add(btnSave);
            TabPagePersonDetail.Controls.Add(txtPersonName);
            TabPagePersonDetail.Controls.Add(txtPersonId);
            TabPagePersonDetail.Controls.Add(documentType);
            TabPagePersonDetail.Controls.Add(documentID);
            TabPagePersonDetail.Location = new Point(4, 24);
            TabPagePersonDetail.Name = "TabPagePersonDetail";
            TabPagePersonDetail.Padding = new Padding(3);
            TabPagePersonDetail.Size = new Size(792, 387);
            TabPagePersonDetail.TabIndex = 1;
            TabPagePersonDetail.Text = "Person Detail";
            TabPagePersonDetail.UseVisualStyleBackColor = true;
            // 
            // chkUpdate
            // 
            chkUpdate.AutoSize = true;
            chkUpdate.Location = new Point(472, 196);
            chkUpdate.Name = "chkUpdate";
            chkUpdate.Size = new Size(15, 14);
            chkUpdate.TabIndex = 46;
            chkUpdate.UseVisualStyleBackColor = true;
            // 
            // dtpUpdate
            // 
            dtpUpdate.Location = new Point(247, 191);
            dtpUpdate.Name = "dtpUpdate";
            dtpUpdate.Size = new Size(219, 23);
            dtpUpdate.TabIndex = 45;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(102, 160);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(48, 21);
            label8.TabIndex = 42;
            label8.Text = "Email";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(247, 133);
            txtPhone.Margin = new Padding(4, 3, 4, 3);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(240, 23);
            txtPhone.TabIndex = 41;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(102, 190);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(133, 21);
            label7.TabIndex = 40;
            label7.Text = "Güncelleme Tarihi";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(102, 131);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(59, 21);
            label6.TabIndex = 39;
            label6.Text = "Telefon";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(102, 102);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(50, 21);
            label3.TabIndex = 36;
            label3.Text = "Adres";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(247, 162);
            txtEmail.Margin = new Padding(4, 3, 4, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(240, 23);
            txtEmail.TabIndex = 34;
            // 
            // txtApt
            // 
            txtApt.Location = new Point(375, 104);
            txtApt.Margin = new Padding(4, 3, 4, 3);
            txtApt.Name = "txtApt";
            txtApt.Size = new Size(112, 23);
            txtApt.TabIndex = 32;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(320, 243);
            btnCancel.Margin = new Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 30);
            btnCancel.TabIndex = 30;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(200, 243);
            btnSave.Margin = new Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 30);
            btnSave.TabIndex = 29;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // txtPersonName
            // 
            txtPersonName.Location = new Point(247, 75);
            txtPersonName.Margin = new Padding(4, 3, 4, 3);
            txtPersonName.Name = "txtPersonName";
            txtPersonName.Size = new Size(240, 23);
            txtPersonName.TabIndex = 28;
            // 
            // txtPersonId
            // 
            txtPersonId.Location = new Point(247, 46);
            txtPersonId.Margin = new Padding(4, 3, 4, 3);
            txtPersonId.Name = "txtPersonId";
            txtPersonId.ReadOnly = true;
            txtPersonId.Size = new Size(240, 23);
            txtPersonId.TabIndex = 27;
            txtPersonId.Text = "0";
            // 
            // documentType
            // 
            documentType.AutoSize = true;
            documentType.Font = new Font("Segoe UI", 12F);
            documentType.Location = new Point(102, 73);
            documentType.Margin = new Padding(4, 0, 4, 0);
            documentType.Name = "documentType";
            documentType.Size = new Size(67, 21);
            documentType.TabIndex = 26;
            documentType.Text = "Kişi İsmi";
            // 
            // documentID
            // 
            documentID.AutoSize = true;
            documentID.Font = new Font("Segoe UI", 12F);
            documentID.Location = new Point(102, 44);
            documentID.Margin = new Padding(4, 0, 4, 0);
            documentID.Name = "documentID";
            documentID.Size = new Size(59, 21);
            documentID.TabIndex = 25;
            documentID.Text = "Kişi No";
            // 
            // cmbStreet
            // 
            cmbStreet.FormattingEnabled = true;
            cmbStreet.Location = new Point(247, 104);
            cmbStreet.Name = "cmbStreet";
            cmbStreet.Size = new Size(121, 23);
            cmbStreet.TabIndex = 47;
            // 
            // PersonView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(formBorderPanel);
            Name = "PersonView";
            Text = "PersonView";
            formBorderPanel.ResumeLayout(false);
            formBorderPanel.PerformLayout();
            tabControl1.ResumeLayout(false);
            TabPagePersonList.ResumeLayout(false);
            TabPagePersonList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            TabPagePersonDetail.ResumeLayout(false);
            TabPagePersonDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel formBorderPanel;
        private Button btnClose;
        private Label label1;
        private TabControl tabControl1;
        private TabPage TabPagePersonList;
        private TabPage TabPagePersonDetail;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private DataGridView dataGridView;
        private TextBox txtSearch;
        private Label label2;
        private Label label8;
        private TextBox txtPhone;
        private Label label7;
        private Label label6;
        private Label label3;
        private TextBox txtEmail;
        private TextBox txtApt;
        private Button btnCancel;
        private Button btnSave;
        private TextBox txtPersonName;
        private TextBox txtPersonId;
        private Label documentType;
        private Label documentID;
        private CheckBox chkUpdate;
        private DateTimePicker dtpUpdate;
        private ComboBox cmbStreet;
    }
}