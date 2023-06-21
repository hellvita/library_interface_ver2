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
    public partial class EditBookForm : Form
    {
        private LibrarianHomePageForm homepage_form;
        public EditBookForm()
        {
            InitializeComponent();
        }

        private void EditBookForm_Load(object sender, EventArgs e)
        {
            label_position.Text = LibrarianHomePageForm.positionName;
            label_fullname.Text = LibrarianHomePageForm.fullName;
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            if (homepage_form == null || homepage_form.IsDisposed)
            {
                homepage_form = new LibrarianHomePageForm();
                homepage_form.Show();
            }
            else
            {
                homepage_form.Focus();
            }
            Close();
        }

        private void button_search_Click(object sender, EventArgs e)
        {

        }

        private void button_edit_Click(object sender, EventArgs e)
        {

        }

        private void button_save_Click(object sender, EventArgs e)
        {

        }

        private void button_delete_Click(object sender, EventArgs e)
        {

        }
    }
}
