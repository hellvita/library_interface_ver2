using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace library_interface_ver2
{
    public partial class EmploeeAuthForm : Form
    {
                DataBase database = new DataBase();
        public EmploeeAuthForm()
        {
            InitializeComponent();
        }

        private void EmploeeAuthForm_Load(object sender, EventArgs e)
        {

        }
    }
}
