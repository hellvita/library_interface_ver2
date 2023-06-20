using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library_interface_ver2
{
    public partial class LibraryHomePageForm : Form
    {
        public LibraryHomePageForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void LibraryHomePageForm_Load(object sender, EventArgs e)
        {
            label_userID.Text = "Користувач №" + UserLoginForm.ulog;
        }
    }
}
