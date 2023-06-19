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
    public partial class UserLogSinginForm : Form
    {
        private UserLoginForm form1;
        private UserSinginForm form2;
        public UserLogSinginForm()
        {
            InitializeComponent();
        }

        private void UserLogSinginForm_Load(object sender, EventArgs e)
        {

        }

        // login button
        private void button1_Click(object sender, EventArgs e)
        {
            if (form1 == null || form1.IsDisposed)
            {
                form1 = new UserLoginForm();
                form1.Show();
            }
            else
            {
                form1.Focus();
            }
            Close();
        }

        // singin button
        private void button2_Click(object sender, EventArgs e)
        {
            if (form2 == null || form2.IsDisposed)
            {
                form2 = new UserSinginForm();
                form2.Show();
            }
            else
            {
                form2.Focus();
            }
            Close();
        }
    }
}
