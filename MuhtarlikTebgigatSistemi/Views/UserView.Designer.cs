namespace MuhtarlikTebgigatSistemi.Views
{
    partial class UserView
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
            btnAdd = new Button();
            dataGridView = new DataGridView();
            txtSearch = new TextBox();
            label2 = new Label();
            TabPageStreetDetail = new TabPage();
            txtUserId = new TextBox();
            lbl1 = new Label();
            label9 = new Label();
            txtUser = new TextBox();
            btnCancel = new Button();
            btnSave = new Button();
            txtPassword = new TextBox();
            lbl2 = new Label();
            txtRole = new TextBox();
            label3 = new Label();
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
            formBorderPanel.TabIndex = 3;
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
            label1.Size = new Size(142, 28);
            label1.TabIndex = 0;
            label1.Text = "KULLANICILAR";
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
            tabControl1.TabIndex = 4;
            // 
            // TabPageStreetList
            // 
            TabPageStreetList.Controls.Add(btnDelete);
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
            btnDelete.Location = new Point(92, 59);
            btnDelete.Margin = new Padding(4, 3, 4, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Kaldır";
            btnDelete.UseVisualStyleBackColor = true;
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
            dataGridView.Location = new Point(12, 92);
            dataGridView.Margin = new Padding(4, 3, 4, 3);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(694, 275);
            dataGridView.TabIndex = 10;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Location = new Point(12, 35);
            txtSearch.Margin = new Padding(4, 3, 4, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(694, 23);
            txtSearch.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(11, 12);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(138, 21);
            label2.TabIndex = 7;
            label2.Text = "Kullanıcıları Listele";
            // 
            // TabPageStreetDetail
            // 
            TabPageStreetDetail.Controls.Add(txtRole);
            TabPageStreetDetail.Controls.Add(label3);
            TabPageStreetDetail.Controls.Add(txtUserId);
            TabPageStreetDetail.Controls.Add(lbl1);
            TabPageStreetDetail.Controls.Add(label9);
            TabPageStreetDetail.Controls.Add(txtUser);
            TabPageStreetDetail.Controls.Add(btnCancel);
            TabPageStreetDetail.Controls.Add(btnSave);
            TabPageStreetDetail.Controls.Add(txtPassword);
            TabPageStreetDetail.Controls.Add(lbl2);
            TabPageStreetDetail.Location = new Point(4, 24);
            TabPageStreetDetail.Name = "TabPageStreetDetail";
            TabPageStreetDetail.Padding = new Padding(3);
            TabPageStreetDetail.Size = new Size(792, 387);
            TabPageStreetDetail.TabIndex = 1;
            TabPageStreetDetail.Text = "Street Detail";
            TabPageStreetDetail.UseVisualStyleBackColor = true;
            // 
            // txtUserId
            // 
            txtUserId.Location = new Point(381, 53);
            txtUserId.Margin = new Padding(4, 3, 4, 3);
            txtUserId.Name = "txtUserId";
            txtUserId.ReadOnly = true;
            txtUserId.Size = new Size(162, 23);
            txtUserId.TabIndex = 46;
            txtUserId.Text = "0";
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Segoe UI", 12F);
            lbl1.Location = new Point(237, 55);
            lbl1.Margin = new Padding(4, 0, 4, 0);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(93, 21);
            lbl1.TabIndex = 45;
            lbl1.Text = "Kullanıcı No";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(236, 80);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(95, 21);
            label9.TabIndex = 44;
            label9.Text = "Kullanıcı Adı";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(381, 82);
            txtUser.Margin = new Padding(4, 3, 4, 3);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(162, 23);
            txtUser.TabIndex = 43;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(394, 190);
            btnCancel.Margin = new Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 30;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(274, 190);
            btnSave.Margin = new Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 29;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(381, 111);
            txtPassword.Margin = new Padding(4, 3, 4, 3);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(162, 23);
            txtPassword.TabIndex = 28;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("Segoe UI", 12F);
            lbl2.Location = new Point(236, 109);
            lbl2.Margin = new Padding(4, 0, 4, 0);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(42, 21);
            lbl2.TabIndex = 26;
            lbl2.Text = "Şifre";
            // 
            // txtRole
            // 
            txtRole.Location = new Point(381, 140);
            txtRole.Margin = new Padding(4, 3, 4, 3);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(162, 23);
            txtRole.TabIndex = 48;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(236, 138);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(33, 21);
            label3.TabIndex = 47;
            label3.Text = "Rol";
            // 
            // UserView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(formBorderPanel);
            Name = "UserView";
            Text = "UserView";
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
        private Button btnDelete;
        private Button btnAdd;
        private DataGridView dataGridView;
        private TextBox txtSearch;
        private Label label2;
        private TabPage TabPageStreetDetail;
        private Label label9;
        private TextBox txtUser;
        private Button btnCancel;
        private Button btnSave;
        private TextBox txtPassword;
        private Label lbl2;
        private TextBox txtUserId;
        private Label lbl1;
        private TextBox txtRole;
        private Label label3;
    }
}