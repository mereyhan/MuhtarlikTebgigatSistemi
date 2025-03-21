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
    public partial class MainView : Form, IMainView
    {
        public MainView()
        {
            InitializeComponent();
            btnDocuments.Click += delegate { ShowDocumentView?.Invoke(this, EventArgs.Empty); };
            customizeDesing();
        }

        private void customizeDesing()
        {
            panelDocumentsSubMenu.Visible = false;
            panelEditSubMenu.Visible = false;
            panelSystemSubMenu.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelDocumentsSubMenu.Visible == true)
                panelDocumentsSubMenu.Visible = false;
            if (panelEditSubMenu.Visible == true)
                panelEditSubMenu.Visible = false;
            if (panelSystemSubMenu.Visible == true)
                panelSystemSubMenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnDocuments_Click(object sender, EventArgs e)
        {
            showSubMenu(panelDocumentsSubMenu);
        }
        #region DocumentsSubMenu
        private void button1_Click(object sender, EventArgs e)
        {
            // ...
            hideSubMenu();
        }
#endregion

        private void btnEdit_Click(object sender, EventArgs e)
        {
            showSubMenu(panelEditSubMenu);
        }
        #region EditSubMenu
        private void button4_Click(object sender, EventArgs e)
        {
            // ...
            hideSubMenu();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            // ...
            hideSubMenu();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            // ...
            hideSubMenu();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            // ...
            hideSubMenu();
        }
#endregion

        private void btnSystem_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSystemSubMenu);
        }
        #region SystemSubMenu
        private void button7_Click(object sender, EventArgs e)
        {
            // ...
            hideSubMenu();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            // ...
            hideSubMenu();
        }
#endregion

        public event EventHandler ShowDocumentView;
        public event EventHandler ShowOwnerView;
        public event EventHandler ShowAdminView;
    }
}
