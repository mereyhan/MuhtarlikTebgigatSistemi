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
            btnCancel = new Button();
            btnSave = new Button();
            txtDocColor = new TextBox();
            txtDocType = new TextBox();
            txtDocName = new TextBox();
            txtDocId = new TextBox();
            documentColor = new Label();
            documentType = new Label();
            documentName = new Label();
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
            label1.Location = new Point(47, 1);
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
            formBorderPanel.Name = "formBorderPanel";
            formBorderPanel.Size = new Size(686, 37);
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
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(37, 37);
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
            tabControl1.Location = new Point(0, 37);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(686, 443);
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
            TabPageDocList.Location = new Point(4, 25);
            TabPageDocList.Name = "TabPageDocList";
            TabPageDocList.Padding = new Padding(3);
            TabPageDocList.Size = new Size(678, 414);
            TabPageDocList.TabIndex = 0;
            TabPageDocList.Text = "Document List";
            TabPageDocList.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.Location = new Point(608, 126);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(64, 25);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnUpdate.Location = new Point(608, 95);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(64, 25);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.Location = new Point(608, 64);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(64, 25);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(8, 64);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(595, 323);
            dataGridView.TabIndex = 3;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.Location = new Point(538, 33);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(64, 25);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Location = new Point(8, 34);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(526, 21);
            txtSearch.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(8, 9);
            label2.Name = "label2";
            label2.Size = new Size(133, 21);
            label2.TabIndex = 0;
            label2.Text = "Search Document";
            // 
            // TabPageDocDetail
            // 
            TabPageDocDetail.Controls.Add(btnCancel);
            TabPageDocDetail.Controls.Add(btnSave);
            TabPageDocDetail.Controls.Add(txtDocColor);
            TabPageDocDetail.Controls.Add(txtDocType);
            TabPageDocDetail.Controls.Add(txtDocName);
            TabPageDocDetail.Controls.Add(txtDocId);
            TabPageDocDetail.Controls.Add(documentColor);
            TabPageDocDetail.Controls.Add(documentType);
            TabPageDocDetail.Controls.Add(documentName);
            TabPageDocDetail.Controls.Add(documentID);
            TabPageDocDetail.Location = new Point(4, 25);
            TabPageDocDetail.Name = "TabPageDocDetail";
            TabPageDocDetail.Padding = new Padding(3);
            TabPageDocDetail.Size = new Size(678, 414);
            TabPageDocDetail.TabIndex = 1;
            TabPageDocDetail.Text = "Document Detail";
            TabPageDocDetail.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(190, 214);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(64, 25);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(109, 214);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(64, 25);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // txtDocColor
            // 
            txtDocColor.Location = new Point(35, 173);
            txtDocColor.Name = "txtDocColor";
            txtDocColor.Size = new Size(294, 21);
            txtDocColor.TabIndex = 7;
            // 
            // txtDocType
            // 
            txtDocType.Location = new Point(190, 116);
            txtDocType.Name = "txtDocType";
            txtDocType.Size = new Size(139, 21);
            txtDocType.TabIndex = 6;
            // 
            // txtDocName
            // 
            txtDocName.Location = new Point(35, 116);
            txtDocName.Name = "txtDocName";
            txtDocName.Size = new Size(139, 21);
            txtDocName.TabIndex = 5;
            // 
            // txtDocId
            // 
            txtDocId.Location = new Point(35, 60);
            txtDocId.Name = "txtDocId";
            txtDocId.ReadOnly = true;
            txtDocId.Size = new Size(139, 21);
            txtDocId.TabIndex = 4;
            txtDocId.Text = "0";
            // 
            // documentColor
            // 
            documentColor.AutoSize = true;
            documentColor.Font = new Font("Segoe UI", 12F);
            documentColor.Location = new Point(35, 147);
            documentColor.Name = "documentColor";
            documentColor.Size = new Size(124, 21);
            documentColor.TabIndex = 3;
            documentColor.Text = "Document Color";
            // 
            // documentType
            // 
            documentType.AutoSize = true;
            documentType.Font = new Font("Segoe UI", 12F);
            documentType.Location = new Point(190, 91);
            documentType.Name = "documentType";
            documentType.Size = new Size(118, 21);
            documentType.TabIndex = 2;
            documentType.Text = "Document Type";
            // 
            // documentName
            // 
            documentName.AutoSize = true;
            documentName.Font = new Font("Segoe UI", 12F);
            documentName.Location = new Point(35, 91);
            documentName.Name = "documentName";
            documentName.Size = new Size(128, 21);
            documentName.TabIndex = 1;
            documentName.Text = "Document Name";
            // 
            // documentID
            // 
            documentID.AutoSize = true;
            documentID.Font = new Font("Segoe UI", 12F);
            documentID.Location = new Point(35, 34);
            documentID.Name = "documentID";
            documentID.Size = new Size(101, 21);
            documentID.TabIndex = 0;
            documentID.Text = "Document ID";
            // 
            // DocumentView
            // 
            AutoScaleDimensions = new SizeF(6F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(686, 480);
            Controls.Add(tabControl1);
            Controls.Add(formBorderPanel);
            Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
        private TextBox txtDocColor;
        private TextBox txtDocType;
        private TextBox txtDocName;
        private TextBox txtDocId;
        private Label documentColor;
        private Label documentType;
        private Label documentName;
        private Label documentID;
        private Button btnCancel;
        private Button btnClose;
    }
}