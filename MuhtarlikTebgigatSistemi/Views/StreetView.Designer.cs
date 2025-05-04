namespace MuhtarlikTebgigatSistemi.Views
{
    partial class StreetView
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
            TabPageStreetList = new TabPage();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            dataGridView = new DataGridView();
            btnSearch = new Button();
            txtSearch = new TextBox();
            label2 = new Label();
            TabPageStreetDetail = new TabPage();
            label9 = new Label();
            txtUpdateDate = new TextBox();
            label8 = new Label();
            txtRegisterDate = new TextBox();
            btnCancel = new Button();
            btnSave = new Button();
            txtStreetName = new TextBox();
            txtStreetId = new TextBox();
            lbl2 = new Label();
            lbl1 = new Label();
            formBorderPanel.SuspendLayout();
            tabControl1.SuspendLayout();
            TabPageStreetList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            TabPageStreetDetail.SuspendLayout();
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
            label1.Size = new Size(86, 28);
            label1.TabIndex = 0;
            label1.Text = "STREETS";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(TabPageStreetList);
            tabControl1.Controls.Add(TabPageStreetDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 35);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 415);
            tabControl1.TabIndex = 3;
            // 
            // TabPageStreetList
            // 
            TabPageStreetList.Controls.Add(btnDelete);
            TabPageStreetList.Controls.Add(btnUpdate);
            TabPageStreetList.Controls.Add(btnAdd);
            TabPageStreetList.Controls.Add(dataGridView);
            TabPageStreetList.Controls.Add(btnSearch);
            TabPageStreetList.Controls.Add(txtSearch);
            TabPageStreetList.Controls.Add(label2);
            TabPageStreetList.Location = new Point(4, 24);
            TabPageStreetList.Name = "TabPageStreetList";
            TabPageStreetList.Padding = new Padding(3);
            TabPageStreetList.Size = new Size(792, 387);
            TabPageStreetList.TabIndex = 0;
            TabPageStreetList.Text = "Street List";
            TabPageStreetList.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.Location = new Point(709, 118);
            btnDelete.Margin = new Padding(4, 3, 4, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnUpdate.Location = new Point(709, 89);
            btnUpdate.Margin = new Padding(4, 3, 4, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.Location = new Point(709, 60);
            btnAdd.Margin = new Padding(4, 3, 4, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(9, 60);
            dataGridView.Margin = new Padding(4, 3, 4, 3);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(694, 304);
            dataGridView.TabIndex = 10;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.Location = new Point(628, 31);
            btnSearch.Margin = new Padding(4, 3, 4, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 9;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Location = new Point(9, 32);
            txtSearch.Margin = new Padding(4, 3, 4, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(613, 21);
            txtSearch.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(8, 9);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(101, 21);
            label2.TabIndex = 7;
            label2.Text = "Search Street";
            // 
            // TabPageStreetDetail
            // 
            TabPageStreetDetail.Controls.Add(label9);
            TabPageStreetDetail.Controls.Add(txtUpdateDate);
            TabPageStreetDetail.Controls.Add(label8);
            TabPageStreetDetail.Controls.Add(txtRegisterDate);
            TabPageStreetDetail.Controls.Add(btnCancel);
            TabPageStreetDetail.Controls.Add(btnSave);
            TabPageStreetDetail.Controls.Add(txtStreetName);
            TabPageStreetDetail.Controls.Add(txtStreetId);
            TabPageStreetDetail.Controls.Add(lbl2);
            TabPageStreetDetail.Controls.Add(lbl1);
            TabPageStreetDetail.Location = new Point(4, 24);
            TabPageStreetDetail.Name = "TabPageStreetDetail";
            TabPageStreetDetail.Padding = new Padding(3);
            TabPageStreetDetail.Size = new Size(792, 387);
            TabPageStreetDetail.TabIndex = 1;
            TabPageStreetDetail.Text = "Street Detail";
            TabPageStreetDetail.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(237, 132);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(133, 21);
            label9.TabIndex = 44;
            label9.Text = "Güncelleme Tarihi";
            // 
            // txtUpdateDate
            // 
            txtUpdateDate.Location = new Point(382, 132);
            txtUpdateDate.Margin = new Padding(4, 3, 4, 3);
            txtUpdateDate.Name = "txtUpdateDate";
            txtUpdateDate.Size = new Size(162, 21);
            txtUpdateDate.TabIndex = 43;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(237, 107);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(85, 21);
            label8.TabIndex = 42;
            label8.Text = "Kayıt Tarihi";
            // 
            // txtRegisterDate
            // 
            txtRegisterDate.Location = new Point(382, 107);
            txtRegisterDate.Margin = new Padding(4, 3, 4, 3);
            txtRegisterDate.Name = "txtRegisterDate";
            txtRegisterDate.Size = new Size(162, 21);
            txtRegisterDate.TabIndex = 34;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(398, 294);
            btnCancel.Margin = new Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 30;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(278, 294);
            btnSave.Margin = new Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 29;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // txtStreetName
            // 
            txtStreetName.Location = new Point(382, 80);
            txtStreetName.Margin = new Padding(4, 3, 4, 3);
            txtStreetName.Name = "txtStreetName";
            txtStreetName.Size = new Size(162, 21);
            txtStreetName.TabIndex = 28;
            // 
            // txtStreetId
            // 
            txtStreetId.Location = new Point(382, 55);
            txtStreetId.Margin = new Padding(4, 3, 4, 3);
            txtStreetId.Name = "txtStreetId";
            txtStreetId.ReadOnly = true;
            txtStreetId.Size = new Size(162, 21);
            txtStreetId.TabIndex = 27;
            txtStreetId.Text = "0";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("Segoe UI", 12F);
            lbl2.Location = new Point(237, 80);
            lbl2.Margin = new Padding(4, 0, 4, 0);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(79, 21);
            lbl2.TabIndex = 26;
            lbl2.Text = "Sokak Adı";
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Segoe UI", 12F);
            lbl1.Location = new Point(237, 55);
            lbl1.Margin = new Padding(4, 0, 4, 0);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(77, 21);
            lbl1.TabIndex = 25;
            lbl1.Text = "Sokak No";
            // 
            // StreetView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(formBorderPanel);
            Font = new Font("Arial", 9F);
            Name = "StreetView";
            Text = "StreetView";
            formBorderPanel.ResumeLayout(false);
            formBorderPanel.PerformLayout();
            tabControl1.ResumeLayout(false);
            TabPageStreetList.ResumeLayout(false);
            TabPageStreetList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            TabPageStreetDetail.ResumeLayout(false);
            TabPageStreetDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel formBorderPanel;
        private Button btnClose;
        private Label label1;
        private TabControl tabControl1;
        private TabPage TabPageStreetList;
        private TabPage TabPageStreetDetail;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private DataGridView dataGridView;
        private Button btnSearch;
        private TextBox txtSearch;
        private Label label2;
        private Label label9;
        private TextBox txtUpdateDate;
        private Label label8;
        private TextBox txtApt;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtDeliveredBy;
        private TextBox txtRegisterDate;
        private TextBox txtStreetName;
        private TextBox txtCompanyName;
        private TextBox txtPersonName;
        private Button btnCancel;
        private Button btnSave;
        private TextBox txtStreetId;
        private Label lbl1;
        private Label lbl2;
    }
}