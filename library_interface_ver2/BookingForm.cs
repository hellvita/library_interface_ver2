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
    public partial class BookingForm : Form
    {
        DataBase database = new DataBase();
        public BookingForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void BookingForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            database.openConenection();
            string query_str = $"SELECT * FROM reserved_books WHERE (BOOK_ID = '{LibraryHomePageForm.selectedBookID}') and (USER_ID = '{UserLoginForm.ulog}') and (BOOK_TYPE_ID = '{LibraryHomePageForm.selectedBookTypeID}')";

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            MySqlCommand command = new MySqlCommand(query_str, database.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count == 0)
            {
                string subquery_str = $"INSERT INTO reserved_books (BOOK_TYPE_ID, BOOK_ID, USER_ID, RESERVED_DATATIME) VALUES ({LibraryHomePageForm.selectedBookTypeID}, {LibraryHomePageForm.selectedBookID}, {UserLoginForm.ulog}, '{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}')";
                MySqlCommand subcommand = new MySqlCommand(subquery_str, database.GetConnection());
                if (subcommand.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Книга успішно заброньована!", "Успіх!");
                }
                else { MessageBox.Show("Не вдалося забронювати книгу!", "Помилка!"); }
            }
            else
            {
                string subquery_str = $"UPDATE reserved_books SET RESERVED_DATATIME = '{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}' WHERE (BOOK_ID = '{LibraryHomePageForm.selectedBookID}') and (USER_ID = '{UserLoginForm.ulog}') and (BOOK_TYPE_ID = '{LibraryHomePageForm.selectedBookTypeID}')";
                MySqlCommand subcommand = new MySqlCommand(subquery_str, database.GetConnection());
                if (subcommand.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Книга успішно заброньована!", "Успіх!");
                }
                else { MessageBox.Show("Не вдалося забронювати книгу!", "Помилка!"); }
            }

            database.closeConenection();
            Close();
        }
    }
}
