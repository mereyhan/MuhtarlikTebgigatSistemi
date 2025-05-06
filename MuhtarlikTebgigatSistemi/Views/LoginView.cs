using MuhtarlikTebgigatSistemi.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuhtarlikTebgigatSistemi.Views
{
    public partial class LoginView : Form, ILoginView
    {
        private bool isLoginSuccessful;
        public LoginView()
        {
            InitializeComponent();
            btnLogin.Click += BtnLogin_Click;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            LoginEvent?.Invoke(this, EventArgs.Empty);
        }

        public string UserName { get => txtUserName.Text; }
        public string Password { get => txtPassword.Text; }

        public bool IsLoginSuccessful { get => isLoginSuccessful; set => isLoginSuccessful = value; }
        public event EventHandler LoginEvent;

        public void CloseView()
        {
            this.Close();
        }

        public void ShowError(string message)
        {
            MessageBox.Show(message, "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
