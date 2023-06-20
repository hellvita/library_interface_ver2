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
    public partial class BookFullDescriptionForm : Form
    {
        DataBase database = new DataBase();
        public BookFullDescriptionForm()
        {
            InitializeComponent();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BookFullDescriptionForm_Load(object sender, EventArgs e)
        {
            loadDataFromDB();
        }

        private void loadDataFromDB() {
            database.openConenection();



            database.closeConenection();
        }
    }
}
