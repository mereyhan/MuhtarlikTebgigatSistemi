﻿namespace MuhtarlikTebgigatSistemi.Views
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
            txtSearch = new TextBox();
            label2 = new Label();
            TabPageStreetDetail = new TabPage();
            chkUpdate = new CheckBox();
            dtpUpdate = new DateTimePicker();
            label9 = new Label();
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
            label1.Size = new Size(110, 28);
            label1.TabIndex = 0;
            label1.Text = "SOKAKLAR";
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
            btnDelete.Location = new Point(175, 59);
            btnDelete.Margin = new Padding(4, 3, 4, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Kaldır";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(92, 59);
            btnUpdate.Margin = new Padding(4, 3, 4, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(9, 60);
            btnAdd.Margin = new Padding(4, 3, 4, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(9, 89);
            dataGridView.Margin = new Padding(4, 3, 4, 3);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(774, 275);
            dataGridView.TabIndex = 10;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Location = new Point(9, 32);
            txtSearch.Margin = new Padding(4, 3, 4, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(774, 21);
            txtSearch.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(8, 9);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(83, 21);
            label2.TabIndex = 7;
            label2.Text = "Sokak arat";
            // 
            // TabPageStreetDetail
            // 
            TabPageStreetDetail.Controls.Add(chkUpdate);
            TabPageStreetDetail.Controls.Add(dtpUpdate);
            TabPageStreetDetail.Controls.Add(label9);
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
            // chkUpdate
            // 
            chkUpdate.AutoSize = true;
            chkUpdate.Location = new Point(504, 112);
            chkUpdate.Name = "chkUpdate";
            chkUpdate.Size = new Size(15, 14);
            chkUpdate.TabIndex = 46;
            chkUpdate.UseVisualStyleBackColor = true;
            // 
            // dtpUpdate
            // 
            dtpUpdate.Location = new Point(298, 108);
            dtpUpdate.Name = "dtpUpdate";
            dtpUpdate.Size = new Size(200, 21);
            dtpUpdate.TabIndex = 45;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(153, 108);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(133, 21);
            label9.TabIndex = 44;
            label9.Text = "Güncelleme Tarihi";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(327, 173);
            btnCancel.Margin = new Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 30);
            btnCancel.TabIndex = 30;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(215, 173);
            btnSave.Margin = new Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 30);
            btnSave.TabIndex = 29;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // txtStreetName
            // 
            txtStreetName.Location = new Point(298, 81);
            txtStreetName.Margin = new Padding(4, 3, 4, 3);
            txtStreetName.Name = "txtStreetName";
            txtStreetName.Size = new Size(200, 21);
            txtStreetName.TabIndex = 28;
            // 
            // txtStreetId
            // 
            txtStreetId.Location = new Point(298, 56);
            txtStreetId.Margin = new Padding(4, 3, 4, 3);
            txtStreetId.Name = "txtStreetId";
            txtStreetId.ReadOnly = true;
            txtStreetId.Size = new Size(200, 21);
            txtStreetId.TabIndex = 27;
            txtStreetId.Text = "0";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("Segoe UI", 12F);
            lbl2.Location = new Point(153, 81);
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
            lbl1.Location = new Point(153, 56);
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
        private TextBox txtSearch;
        private Label label2;
        private Label label9;
        private TextBox txtApt;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtDeliveredBy;
        private TextBox txtStreetName;
        private TextBox txtCompanyName;
        private TextBox txtPersonName;
        private Button btnCancel;
        private Button btnSave;
        private Label lbl2;
        private DateTimePicker dtpUpdate;
        private TextBox txtStreetId;
        private Label lbl1;
        private CheckBox chkUpdate;
    }
}