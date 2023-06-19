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
    public partial class UserSinginForm : Form
    {
        private UserLogSinginForm home_form;
        public UserSinginForm()
        {
            InitializeComponent();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            if (home_form == null || home_form.IsDisposed)
            {
                home_form = new UserLogSinginForm();
                home_form.Show();
            }
            else
            {
                home_form.Focus();
            }
            Close();
        }

        private void UserSinginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
