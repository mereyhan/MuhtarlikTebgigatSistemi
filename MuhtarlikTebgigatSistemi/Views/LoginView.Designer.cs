namespace MuhtarlikTebgigatSistemi.Views
{
    partial class LoginView
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
            label2 = new Label();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnRegister = new LinkLabel();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F);
            label1.Location = new Point(95, 106);
            label1.Name = "label1";
            label1.Size = new Size(90, 18);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F);
            label2.Location = new Point(95, 164);
            label2.Name = "label2";
            label2.Size = new Size(41, 18);
            label2.TabIndex = 1;
            label2.Text = "Şifre";
            // 
            // txtUserName
            // 
            txtUserName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtUserName.Location = new Point(95, 127);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(200, 23);
            txtUserName.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPassword.Location = new Point(95, 185);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(200, 23);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Font = new Font("Arial", 12F);
            btnLogin.Location = new Point(120, 265);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(150, 35);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Giriş";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            btnRegister.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnRegister.AutoSize = true;
            btnRegister.Font = new Font("Arial", 9F);
            btnRegister.LinkColor = Color.Maroon;
            btnRegister.Location = new Point(222, 303);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(48, 15);
            btnRegister.TabIndex = 5;
            btnRegister.TabStop = true;
            btnRegister.Text = "Kayıt Ol";
            // 
            // panel1
            // 
            panel1.BackColor = Color.IndianRed;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(934, 70);
            panel1.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackColor = Color.IndianRed;
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 70);
            panel2.Name = "panel2";
            panel2.Size = new Size(272, 491);
            panel2.TabIndex = 7;
            // 
            // panel3
            // 
            panel3.BackColor = Color.IndianRed;
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(662, 70);
            panel3.Name = "panel3";
            panel3.Size = new Size(272, 491);
            panel3.TabIndex = 7;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Control;
            panel4.Controls.Add(label1);
            panel4.Controls.Add(txtUserName);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(btnLogin);
            panel4.Controls.Add(btnRegister);
            panel4.Controls.Add(txtPassword);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(272, 70);
            panel4.Name = "panel4";
            panel4.Size = new Size(390, 481);
            panel4.TabIndex = 8;
            // 
            // panel5
            // 
            panel5.BackColor = Color.IndianRed;
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(272, 551);
            panel5.Name = "panel5";
            panel5.Size = new Size(390, 10);
            panel5.TabIndex = 7;
            // 
            // LoginView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(934, 561);
            Controls.Add(panel4);
            Controls.Add(panel5);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "LoginView";
            Text = "LoginView";
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private Button btnLogin;
        private LinkLabel btnRegister;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
    }
}