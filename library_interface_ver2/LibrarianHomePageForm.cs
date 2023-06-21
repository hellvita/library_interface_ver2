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
    public partial class LibrarianHomePageForm : Form
    {
        private EmploeeAuthForm login_form;
        public LibrarianHomePageForm()
        {
            InitializeComponent();
        }

        private void LibrarianHomePageForm_Load(object sender, EventArgs e)
        {

        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            if (login_form == null || login_form.IsDisposed)
            {
                login_form = new EmploeeAuthForm();
                login_form.Show();
            }
            else
            {
                login_form.Focus();
            }
            Close();
        }
    }
}
