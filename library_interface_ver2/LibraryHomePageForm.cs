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
    public partial class LibraryHomePageForm : Form
    {
        DataBase database = new DataBase();
        public LibraryHomePageForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void LibraryHomePageForm_Load(object sender, EventArgs e)
        {
            label_userID.Text = "Користувач №" + UserLoginForm.ulog;
            FillBookTypesList();
        }

        private void FillBookTypesList() {
            database.openConenection();

           // MySqlDataAdapter adapter = new MySqlDataAdapter();
          //  DataTable table = new DataTable();

            string query_str = "SELECT COUNT(*) FROM books_types";

            MySqlCommand command = new MySqlCommand(query_str, database.GetConnection());
            var rowsAmount = (long)command.ExecuteScalar();


            for (int i = 1; i < rowsAmount+1; i++) {
                string subquery_str = $"SELECT BOOK_TYPE_NAME FROM books_types WHERE BOOK_TYPE_ID = '{i}'";
                MySqlCommand subcommand = new MySqlCommand(subquery_str, database.GetConnection());
                object obj = subcommand.ExecuteScalar();
                string text = obj.ToString();
                comboBox_bookTypes.Items.Add(text);
            }

            comboBox_bookTypes.SelectedIndex = 0;

            database.closeConenection();
        }
    }
}
