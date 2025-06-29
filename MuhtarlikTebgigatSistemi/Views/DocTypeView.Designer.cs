﻿namespace MuhtarlikTebgigatSistemi.Views
{
    partial class DocTypeView
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
            TabPageDocTypeList = new TabPage();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            dataGridView = new DataGridView();
            txtSearch = new TextBox();
            label2 = new Label();
            TabPageDocTypeDetail = new TabPage();
            label9 = new Label();
            label3 = new Label();
            txtDocumentType = new TextBox();
            btnCancel = new Button();
            btnSave = new Button();
            txtDocTypeId = new TextBox();
            documentID = new Label();
            dtpUpdate = new DateTimePicker();
            chkUpdate = new CheckBox();
            formBorderPanel.SuspendLayout();
            tabControl1.SuspendLayout();
            TabPageDocTypeList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            TabPageDocTypeDetail.SuspendLayout();
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
            label1.Size = new Size(178, 28);
            label1.TabIndex = 0;
            label1.Text = "DOCUMENT TYPES";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(TabPageDocTypeList);
            tabControl1.Controls.Add(TabPageDocTypeDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 35);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 415);
            tabControl1.TabIndex = 3;
            // 
            // TabPageDocTypeList
            // 
            TabPageDocTypeList.Controls.Add(btnDelete);
            TabPageDocTypeList.Controls.Add(btnUpdate);
            TabPageDocTypeList.Controls.Add(btnAdd);
            TabPageDocTypeList.Controls.Add(dataGridView);
            TabPageDocTypeList.Controls.Add(txtSearch);
            TabPageDocTypeList.Controls.Add(label2);
            TabPageDocTypeList.Location = new Point(4, 24);
            TabPageDocTypeList.Name = "TabPageDocTypeList";
            TabPageDocTypeList.Padding = new Padding(3);
            TabPageDocTypeList.Size = new Size(792, 387);
            TabPageDocTypeList.TabIndex = 0;
            TabPageDocTypeList.Text = "Document Type List";
            TabPageDocTypeList.UseVisualStyleBackColor = true;
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
            dataGridView.Size = new Size(694, 275);
            dataGridView.TabIndex = 17;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Location = new Point(9, 32);
            txtSearch.Margin = new Padding(4, 3, 4, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(694, 23);
            txtSearch.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(9, 8);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(169, 21);
            label2.TabIndex = 14;
            label2.Text = "Search Document Type";
            // 
            // TabPageDocTypeDetail
            // 
            TabPageDocTypeDetail.Controls.Add(chkUpdate);
            TabPageDocTypeDetail.Controls.Add(dtpUpdate);
            TabPageDocTypeDetail.Controls.Add(label9);
            TabPageDocTypeDetail.Controls.Add(label3);
            TabPageDocTypeDetail.Controls.Add(txtDocumentType);
            TabPageDocTypeDetail.Controls.Add(btnCancel);
            TabPageDocTypeDetail.Controls.Add(btnSave);
            TabPageDocTypeDetail.Controls.Add(txtDocTypeId);
            TabPageDocTypeDetail.Controls.Add(documentID);
            TabPageDocTypeDetail.Location = new Point(4, 24);
            TabPageDocTypeDetail.Name = "TabPageDocTypeDetail";
            TabPageDocTypeDetail.Padding = new Padding(3);
            TabPageDocTypeDetail.Size = new Size(792, 387);
            TabPageDocTypeDetail.TabIndex = 1;
            TabPageDocTypeDetail.Text = "Document Type Detail";
            TabPageDocTypeDetail.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(139, 107);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(133, 21);
            label9.TabIndex = 44;
            label9.Text = "Güncelleme Tarihi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(139, 78);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(84, 21);
            label3.TabIndex = 36;
            label3.Text = "Evrak Türü";
            // 
            // txtDocumentType
            // 
            txtDocumentType.Location = new Point(284, 78);
            txtDocumentType.Margin = new Padding(4, 3, 4, 3);
            txtDocumentType.Name = "txtDocumentType";
            txtDocumentType.Size = new Size(162, 23);
            txtDocumentType.TabIndex = 31;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(404, 301);
            btnCancel.Margin = new Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 30;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(284, 301);
            btnSave.Margin = new Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 29;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // txtDocTypeId
            // 
            txtDocTypeId.Location = new Point(284, 49);
            txtDocTypeId.Margin = new Padding(4, 3, 4, 3);
            txtDocTypeId.Name = "txtDocTypeId";
            txtDocTypeId.ReadOnly = true;
            txtDocTypeId.Size = new Size(162, 23);
            txtDocTypeId.TabIndex = 27;
            txtDocTypeId.Text = "0";
            // 
            // documentID
            // 
            documentID.AutoSize = true;
            documentID.Font = new Font("Segoe UI", 12F);
            documentID.Location = new Point(139, 49);
            documentID.Margin = new Padding(4, 0, 4, 0);
            documentID.Name = "documentID";
            documentID.Size = new Size(58, 21);
            documentID.TabIndex = 25;
            documentID.Text = "Tür No";
            // 
            // dtpUpdate
            // 
            dtpUpdate.Location = new Point(284, 107);
            dtpUpdate.Name = "dtpUpdate";
            dtpUpdate.Size = new Size(200, 23);
            dtpUpdate.TabIndex = 45;
            // 
            // chkUpdate
            // 
            chkUpdate.AutoSize = true;
            chkUpdate.Location = new Point(490, 113);
            chkUpdate.Name = "chkUpdate";
            chkUpdate.Size = new Size(15, 14);
            chkUpdate.TabIndex = 46;
            chkUpdate.UseVisualStyleBackColor = true;
            // 
            // DocTypeView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(formBorderPanel);
            Name = "DocTypeView";
            Text = "DocTypeView";
            formBorderPanel.ResumeLayout(false);
            formBorderPanel.PerformLayout();
            tabControl1.ResumeLayout(false);
            TabPageDocTypeList.ResumeLayout(false);
            TabPageDocTypeList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            TabPageDocTypeDetail.ResumeLayout(false);
            TabPageDocTypeDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel formBorderPanel;
        private Button btnClose;
        private Label label1;
        private TabControl tabControl1;
        private TabPage TabPageDocTypeList;
        private TabPage TabPageDocTypeDetail;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private DataGridView dataGridView;
        private TextBox txtSearch;
        private Label label2;
        private Label label9;
        private Label label3;
        private Button btnCancel;
        private Button btnSave;
        private TextBox txtDocTypeId;
        private Label documentID;
        private TextBox txtDocumentType;
        private CheckBox chkUpdate;
        private DateTimePicker dtpUpdate;
    }
}