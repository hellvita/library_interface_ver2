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
    // choosing interface form
    public partial class Form1 : Form
    {
        private EmploeeAuthForm form2;
        private UserLogSinginForm form3;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (form3 == null || form3.IsDisposed)
            {
                form3 = new UserLogSinginForm();
                form3.Show();
            }
            else
            {
                form3.Focus();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (form2 == null || form2.IsDisposed)
            {
                form2 = new EmploeeAuthForm();
                form2.Show();
            }
            else
            {
                form2.Focus();
            }
        }
    }
}
