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
            label1 = new Label();
            formBorderPanel = new Panel();
            btnClose = new Button();
            tabControl1 = new TabControl();
            TabPageDocList = new TabPage();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            dataGridView = new DataGridView();
            btnSearch = new Button();
            txtSearch = new TextBox();
            label2 = new Label();
            TabPageDocDetail = new TabPage();
            label9 = new Label();
            txtDeliveryDate = new TextBox();
            label8 = new Label();
            txtApt = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtDeliveredBy = new TextBox();
            txtRegDate = new TextBox();
            txtStreetName = new TextBox();
            txtCompanyName = new TextBox();
            txtPersonName = new TextBox();
            btnCancel = new Button();
            btnSave = new Button();
            txtDocType = new TextBox();
            txtDocId = new TextBox();
            documentType = new Label();
            documentID = new Label();
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
            label1.Size = new Size(131, 28);
            label1.TabIndex = 0;
            label1.Text = "DOCUMENTS";
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
            TabPageDocList.Controls.Add(btnSearch);
            TabPageDocList.Controls.Add(txtSearch);
            TabPageDocList.Controls.Add(label2);
            TabPageDocList.Location = new Point(4, 24);
            TabPageDocList.Margin = new Padding(4, 3, 4, 3);
            TabPageDocList.Name = "TabPageDocList";
            TabPageDocList.Padding = new Padding(4, 3, 4, 3);
            TabPageDocList.Size = new Size(792, 387);
            TabPageDocList.TabIndex = 0;
            TabPageDocList.Text = "Document List";
            TabPageDocList.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.Location = new Point(709, 118);
            btnDelete.Margin = new Padding(4, 3, 4, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 6;
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
            btnUpdate.TabIndex = 5;
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
            btnAdd.TabIndex = 4;
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
            dataGridView.TabIndex = 3;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.Location = new Point(628, 31);
            btnSearch.Margin = new Padding(4, 3, 4, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 2;
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
            txtSearch.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(9, 8);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(133, 21);
            label2.TabIndex = 0;
            label2.Text = "Search Document";
            // 
            // TabPageDocDetail
            // 
            TabPageDocDetail.Controls.Add(label9);
            TabPageDocDetail.Controls.Add(txtDeliveryDate);
            TabPageDocDetail.Controls.Add(label8);
            TabPageDocDetail.Controls.Add(txtApt);
            TabPageDocDetail.Controls.Add(label7);
            TabPageDocDetail.Controls.Add(label6);
            TabPageDocDetail.Controls.Add(label5);
            TabPageDocDetail.Controls.Add(label4);
            TabPageDocDetail.Controls.Add(label3);
            TabPageDocDetail.Controls.Add(txtDeliveredBy);
            TabPageDocDetail.Controls.Add(txtRegDate);
            TabPageDocDetail.Controls.Add(txtStreetName);
            TabPageDocDetail.Controls.Add(txtCompanyName);
            TabPageDocDetail.Controls.Add(txtPersonName);
            TabPageDocDetail.Controls.Add(btnCancel);
            TabPageDocDetail.Controls.Add(btnSave);
            TabPageDocDetail.Controls.Add(txtDocType);
            TabPageDocDetail.Controls.Add(txtDocId);
            TabPageDocDetail.Controls.Add(documentType);
            TabPageDocDetail.Controls.Add(documentID);
            TabPageDocDetail.Location = new Point(4, 24);
            TabPageDocDetail.Margin = new Padding(4, 3, 4, 3);
            TabPageDocDetail.Name = "TabPageDocDetail";
            TabPageDocDetail.Padding = new Padding(4, 3, 4, 3);
            TabPageDocDetail.Size = new Size(792, 387);
            TabPageDocDetail.TabIndex = 1;
            TabPageDocDetail.Text = "Document Detail";
            TabPageDocDetail.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(50, 209);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(94, 21);
            label9.TabIndex = 24;
            label9.Text = "Teslim Tarihi";
            // 
            // txtDeliveryDate
            // 
            txtDeliveryDate.Location = new Point(195, 209);
            txtDeliveryDate.Margin = new Padding(4, 3, 4, 3);
            txtDeliveryDate.Name = "txtDeliveryDate";
            txtDeliveryDate.Size = new Size(162, 21);
            txtDeliveryDate.TabIndex = 23;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(50, 184);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(85, 21);
            label8.TabIndex = 22;
            label8.Text = "Kayıt Tarihi";
            // 
            // txtApt
            // 
            txtApt.Location = new Point(195, 158);
            txtApt.Margin = new Padding(4, 3, 4, 3);
            txtApt.Name = "txtApt";
            txtApt.Size = new Size(162, 21);
            txtApt.TabIndex = 21;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(50, 234);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(99, 21);
            label7.TabIndex = 20;
            label7.Text = "Teslim Edilen";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(50, 158);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(40, 21);
            label6.TabIndex = 19;
            label6.Text = "Bina";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(50, 133);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(52, 21);
            label5.TabIndex = 18;
            label5.Text = "Sokak";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(50, 108);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(50, 21);
            label4.TabIndex = 17;
            label4.Text = "Firma";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(50, 82);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(39, 21);
            label3.TabIndex = 16;
            label3.Text = "İsim";
            // 
            // txtDeliveredBy
            // 
            txtDeliveredBy.Location = new Point(195, 234);
            txtDeliveredBy.Margin = new Padding(4, 3, 4, 3);
            txtDeliveredBy.Name = "txtDeliveredBy";
            txtDeliveredBy.Size = new Size(162, 21);
            txtDeliveredBy.TabIndex = 14;
            // 
            // txtRegDate
            // 
            txtRegDate.Location = new Point(195, 184);
            txtRegDate.Margin = new Padding(4, 3, 4, 3);
            txtRegDate.Name = "txtRegDate";
            txtRegDate.Size = new Size(162, 21);
            txtRegDate.TabIndex = 13;
            // 
            // txtStreetName
            // 
            txtStreetName.Location = new Point(195, 133);
            txtStreetName.Margin = new Padding(4, 3, 4, 3);
            txtStreetName.Name = "txtStreetName";
            txtStreetName.Size = new Size(162, 21);
            txtStreetName.TabIndex = 12;
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new Point(195, 108);
            txtCompanyName.Margin = new Padding(4, 3, 4, 3);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(162, 21);
            txtCompanyName.TabIndex = 11;
            // 
            // txtPersonName
            // 
            txtPersonName.Location = new Point(195, 82);
            txtPersonName.Margin = new Padding(4, 3, 4, 3);
            txtPersonName.Name = "txtPersonName";
            txtPersonName.Size = new Size(162, 21);
            txtPersonName.TabIndex = 10;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(211, 271);
            btnCancel.Margin = new Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(91, 271);
            btnSave.Margin = new Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // txtDocType
            // 
            txtDocType.Location = new Point(195, 57);
            txtDocType.Margin = new Padding(4, 3, 4, 3);
            txtDocType.Name = "txtDocType";
            txtDocType.Size = new Size(162, 21);
            txtDocType.TabIndex = 6;
            // 
            // txtDocId
            // 
            txtDocId.Location = new Point(195, 32);
            txtDocId.Margin = new Padding(4, 3, 4, 3);
            txtDocId.Name = "txtDocId";
            txtDocId.ReadOnly = true;
            txtDocId.Size = new Size(162, 21);
            txtDocId.TabIndex = 4;
            txtDocId.Text = "0";
            // 
            // documentType
            // 
            documentType.AutoSize = true;
            documentType.Font = new Font("Segoe UI", 12F);
            documentType.Location = new Point(50, 57);
            documentType.Margin = new Padding(4, 0, 4, 0);
            documentType.Name = "documentType";
            documentType.Size = new Size(84, 21);
            documentType.TabIndex = 2;
            documentType.Text = "Evrak Türü";
            // 
            // documentID
            // 
            documentID.AutoSize = true;
            documentID.Font = new Font("Segoe UI", 12F);
            documentID.Location = new Point(50, 32);
            documentID.Margin = new Padding(4, 0, 4, 0);
            documentID.Name = "documentID";
            documentID.Size = new Size(73, 21);
            documentID.TabIndex = 0;
            documentID.Text = "Evrak No";
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
        private Button btnSearch;
        private TextBox txtSearch;
        private Label label2;
        private Button btnSave;
        private TextBox txtDocType;
        private TextBox txtDocId;
        private Label documentType;
        private Label documentID;
        private Button btnCancel;
        private Button btnClose;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtDeliveredBy;
        private TextBox txtRegDate;
        private TextBox txtStreetName;
        private TextBox txtCompanyName;
        private TextBox txtPersonName;
        private Label label7;
        private Label label6;
        private Label label8;
        private TextBox txtApt;
        private Label label9;
        private TextBox txtDeliveryDate;
    }
}