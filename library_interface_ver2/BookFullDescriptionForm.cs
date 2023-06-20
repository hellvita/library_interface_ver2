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

            string query_str = $"SELECT COVER FROM {LibraryHomePageForm.selectedBookTable} WHERE BOOK_TYPE_ID = {LibraryHomePageForm.selectedBookTypeID} AND BOOK_ID = {LibraryHomePageForm.selectedBookID}";
            MySqlCommand subcommand = new MySqlCommand(query_str, database.GetConnection());
            object obj = subcommand.ExecuteScalar();
            string coverPath = obj.ToString();
            pictureBox_bookCover.Image = Image.FromFile($"{coverPath}");
            
            query_str = $"SELECT BOOK_NAME FROM {LibraryHomePageForm.selectedBookTable} WHERE BOOK_TYPE_ID = {LibraryHomePageForm.selectedBookTypeID} AND BOOK_ID = {LibraryHomePageForm.selectedBookID}";
            subcommand = new MySqlCommand(query_str, database.GetConnection());
            obj = subcommand.ExecuteScalar();
            string nameStr = obj.ToString();
            label_bookName.Text = $"{nameStr}";

            query_str = $"SELECT AUTHOR FROM {LibraryHomePageForm.selectedBookTable} WHERE BOOK_TYPE_ID = {LibraryHomePageForm.selectedBookTypeID} AND BOOK_ID = {LibraryHomePageForm.selectedBookID}";
            subcommand = new MySqlCommand(query_str, database.GetConnection());
            obj = subcommand.ExecuteScalar();
            string autthorStr = obj.ToString();
            label_bookAuthor.Text = $"Автор: {autthorStr}";

            query_str = $"SELECT PUBLICATION_YEAR FROM {LibraryHomePageForm.selectedBookTable} WHERE BOOK_TYPE_ID = {LibraryHomePageForm.selectedBookTypeID} AND BOOK_ID = {LibraryHomePageForm.selectedBookID}";
            subcommand = new MySqlCommand(query_str, database.GetConnection());
            obj = subcommand.ExecuteScalar();
            string yearStr = obj.ToString();
            label_publicationYear.Text = $"Рік видання: {yearStr}";

            query_str = $"SELECT BOOK_TYPE_NAME FROM books_types WHERE BOOK_TYPE_ID = {LibraryHomePageForm.selectedBookTypeID}";
            subcommand = new MySqlCommand(query_str, database.GetConnection());
            obj = subcommand.ExecuteScalar();
            string typeStr = obj.ToString();

            string genreTable = ""; string genreID = ""; string genreName = "";
            if (LibraryHomePageForm.selectedBookTypeID == 1) { genreTable = "genres"; genreID = "GENRE_ID"; genreName = "GENRE"; }
            else if (LibraryHomePageForm.selectedBookTypeID == 2) { genreTable = "subject_areas"; genreID = "SUB_AREA_ID"; genreName = "SUB_AREA"; }
            else if (LibraryHomePageForm.selectedBookTypeID == 3) { genreTable = "books_subjects"; genreID = "SUBJECT_ID"; genreName = "BOOK_SUBJECT"; }
            else if (LibraryHomePageForm.selectedBookTypeID == 4) { genreTable = "disciplines"; genreID = "DISCIPLINE_ID"; genreName = "DISCIPLINE"; }

            query_str = $"SELECT {genreName} FROM {genreTable} WHERE {genreID} = {LibraryHomePageForm.selectedBookGenreID}";
            subcommand = new MySqlCommand(query_str, database.GetConnection());
            obj = subcommand.ExecuteScalar();
            string genreStr = obj.ToString();
            label_type_genre.Text = $"{typeStr}, {genreStr}";

            query_str = $"SELECT BOOK_DESCRIPTION FROM {LibraryHomePageForm.selectedBookTable} WHERE BOOK_TYPE_ID = {LibraryHomePageForm.selectedBookTypeID} AND BOOK_ID = {LibraryHomePageForm.selectedBookID}";
            subcommand = new MySqlCommand(query_str, database.GetConnection());
            obj = subcommand.ExecuteScalar();
            string descriptionStr = obj.ToString();
            label_fullDescription.Text = $"{descriptionStr}";


            database.closeConenection();
        }

        private void button_downloadBook_Click(object sender, EventArgs e)
        {
            database.openConenection();
            string query_str = $"SELECT * FROM downloaded_books WHERE (BOOK_ID = '{LibraryHomePageForm.selectedBookID}') and (USER_ID = '{UserLoginForm.ulog}') and (BOOK_TYPE_ID = '{LibraryHomePageForm.selectedBookTypeID}')";

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            MySqlCommand command = new MySqlCommand(query_str, database.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count == 0)
            {
                string subquery_str = $"INSERT INTO downloaded_books (BOOK_TYPE_ID, BOOK_ID, USER_ID, DOWNLOAD_DATE) VALUES ({LibraryHomePageForm.selectedBookTypeID}, {LibraryHomePageForm.selectedBookID}, {UserLoginForm.ulog}, '{DateTime.Now.ToString("yyyy-MM-dd")}')";
                MySqlCommand subcommand = new MySqlCommand(subquery_str, database.GetConnection());
                if (subcommand.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Книга успішно завантажена!", "Успіх!");
                }
                else { MessageBox.Show("Не вдалося завантажии книгу!", "Помилка!"); }
            }
            else {
                string subquery_str = $"UPDATE downloaded_books SET DOWNLOAD_DATE = '{DateTime.Now.ToString("yyyy-MM-dd")}' WHERE (BOOK_ID = '{LibraryHomePageForm.selectedBookID}') and (USER_ID = '{UserLoginForm.ulog}') and (BOOK_TYPE_ID = '{LibraryHomePageForm.selectedBookTypeID}')";
                MySqlCommand subcommand = new MySqlCommand(subquery_str, database.GetConnection());
                if (subcommand.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Книга успішно завантажена!", "Успіх!");
                }
                else { MessageBox.Show("Не вдалося завантажии книгу!", "Помилка!"); }
            }

            database.closeConenection();
        }
    }
}
