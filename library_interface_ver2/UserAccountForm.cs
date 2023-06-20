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
    public partial class UserAccountForm : Form
    {
        private LibraryHomePageForm homepage_form;
        public UserAccountForm()
        {
            InitializeComponent();
        }

        private void UserAccountForm_Load(object sender, EventArgs e)
        {

        }

        private void button_back_Click(object sender, EventArgs e)
        {
            if (homepage_form == null || homepage_form.IsDisposed)
            {
                homepage_form = new LibraryHomePageForm();
                homepage_form.Show();
            }
            else
            {
                homepage_form.Focus();
            }
            Close();
        }
    }
}
