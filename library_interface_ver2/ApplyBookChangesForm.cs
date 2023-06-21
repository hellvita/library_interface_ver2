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
    public partial class ApplyBookChangesForm : Form
    {
        DataBase database = new DataBase();
        private string bookID = "";
        private string typeID = "";
        public ApplyBookChangesForm()
        {
            InitializeComponent();
        }

        private void ApplyBookChangesForm_Load(object sender, EventArgs e)
        {
            textBox_bookID.MaxLength = 7;
            textBox_typeID.MaxLength = 2;
        }

        private void button_apply_Click(object sender, EventArgs e)
        {
            database.openConenection();

            bool dataIsOK = true;

            bookID = textBox_bookID.Text;
            typeID = textBox_typeID.Text;


            string table = "";
            string genreName = "";
            string genreIDName = "";
            string genreTable = "";
            if (typeID.Equals("1") && EditBookForm.typeNum == 1) { table = "fiction"; genreIDName = "GENRE_ID"; genreTable = "genres"; genreName = "GENRE"; }
            else if (typeID.Equals("2") && EditBookForm.typeNum == 2) { table = "scientic"; genreIDName = "SUB_AREA_ID"; genreTable = "subject_areas"; genreName = "SUB_AREA"; }
            else if (typeID.Equals("3") && EditBookForm.typeNum == 3) { table = "documentary"; genreIDName = "SUBJECT_ID"; genreTable = "books_subjects"; genreName = "BOOK_SUBJECT"; }
            else if (typeID.Equals("4") && EditBookForm.typeNum == 4) { table = "professional"; genreIDName = "DISCIPLINE_ID"; genreTable = "disciplines"; genreName = "DISCIPLINE"; }
            else { MessageBox.Show("Сталася помилка!\nПеревірте правильність введених даних", "Помилка!"); dataIsOK = false; }

            if (dataIsOK) {
                if (!EditBookForm.nameIsEmpty) {
                    MySqlDataAdapter adapter1 = new MySqlDataAdapter();
                    DataTable table1 = new DataTable();

                    string query_selectBook = $"SELECT * FROM {table} WHERE BOOK_TYPE_ID = {typeID} AND BOOK_ID = {bookID}";
                    MySqlCommand command1 = new MySqlCommand(query_selectBook, database.GetConnection());

                    adapter1.SelectCommand = command1;
                    adapter1.Fill(table1);
                    if (table1.Rows.Count == 1)
                    {
                        string query_deleteBook = $"UPDATE {table} SET BOOK_NAME = '{EditBookForm.curBookName}' WHERE BOOK_TYPE_ID = {typeID} and BOOK_ID = {bookID}";
                        MySqlCommand command2 = new MySqlCommand(query_deleteBook, database.GetConnection());

                        if (command2.ExecuteNonQuery() != 1)
                        {
                            MessageBox.Show("Не вдалося змінити назву книги!", "Помилка!");
                        }
                    }
                    else { MessageBox.Show("Сталася помилка!\nПеревірте правильність введених даних", "Помилка!"); }
                }
                if (!EditBookForm.authorIsEmpty) {
                    MySqlDataAdapter adapter1 = new MySqlDataAdapter();
                    DataTable table1 = new DataTable();

                    string query_selectBook = $"SELECT * FROM {table} WHERE BOOK_TYPE_ID = {typeID} AND BOOK_ID = {bookID}";
                    MySqlCommand command1 = new MySqlCommand(query_selectBook, database.GetConnection());

                    adapter1.SelectCommand = command1;
                    adapter1.Fill(table1);
                    if (table1.Rows.Count == 1)
                    {
                        string query_deleteBook = $"UPDATE {table} SET AUTHOR = '{EditBookForm.curBookAuthor}' WHERE BOOK_TYPE_ID = {typeID} and BOOK_ID = {bookID}";
                        MySqlCommand command2 = new MySqlCommand(query_deleteBook, database.GetConnection());

                        if (command2.ExecuteNonQuery() != 1)
                        {
                            MessageBox.Show("Не вдалося змінити автора книги!", "Помилка!");
                        }
                    }
                    else { MessageBox.Show("Сталася помилка!\nПеревірте правильність введених даних", "Помилка!"); }
                }
                if (!EditBookForm.yearIsEmpty) {
                    MySqlDataAdapter adapter1 = new MySqlDataAdapter();
                    DataTable table1 = new DataTable();

                    string query_selectBook = $"SELECT * FROM {table} WHERE BOOK_TYPE_ID = {typeID} AND BOOK_ID = {bookID}";
                    MySqlCommand command1 = new MySqlCommand(query_selectBook, database.GetConnection());

                    adapter1.SelectCommand = command1;
                    adapter1.Fill(table1);
                    if (table1.Rows.Count == 1)
                    {
                        string query_deleteBook = $"UPDATE {table} SET PUBLICATION_YEAR = '{EditBookForm.curBookYear}' WHERE BOOK_TYPE_ID = {typeID} and BOOK_ID = {bookID}";
                        MySqlCommand command2 = new MySqlCommand(query_deleteBook, database.GetConnection());

                        if (command2.ExecuteNonQuery() != 1)
                        {
                            MessageBox.Show("Не вдалося змінити рік публікації!", "Помилка!");
                        }
                    }
                    else { MessageBox.Show("Сталася помилка!\nПеревірте правильність введених даних", "Помилка!"); }
                }
                if (!EditBookForm.genreIsEmpty) {
                    MySqlDataAdapter adapter1 = new MySqlDataAdapter();
                    DataTable table1 = new DataTable();

                    string query_selectBook = $"SELECT * FROM {table} WHERE BOOK_TYPE_ID = {typeID} AND BOOK_ID = {bookID}";
                    MySqlCommand command1 = new MySqlCommand(query_selectBook, database.GetConnection());

                    adapter1.SelectCommand = command1;
                    adapter1.Fill(table1);
                    if (table1.Rows.Count == 1)
                    {
                        string query_deleteBook = $"UPDATE {table} SET {genreIDName} = (SELECT {genreIDName} FROM {genreTable} WHERE {genreName} = '{EditBookForm.curBookGenre}') WHERE BOOK_TYPE_ID = {typeID} and BOOK_ID = {bookID}";
                        MySqlCommand command2 = new MySqlCommand(query_deleteBook, database.GetConnection());

                        if (command2.ExecuteNonQuery() != 1)
                        {
                            MessageBox.Show("Не вдалося змінити жанр/тематику!", "Помилка!");
                        }
                    }
                    else { MessageBox.Show("Сталася помилка!\nПеревірте правильність введених даних", "Помилка!"); }
                }
                if (!EditBookForm.coverIsEmpty) {
                    MySqlDataAdapter adapter1 = new MySqlDataAdapter();
                    DataTable table1 = new DataTable();

                    string query_selectBook = $"SELECT * FROM {table} WHERE BOOK_TYPE_ID = {typeID} AND BOOK_ID = {bookID}";
                    MySqlCommand command1 = new MySqlCommand(query_selectBook, database.GetConnection());

                    adapter1.SelectCommand = command1;
                    adapter1.Fill(table1);
                    if (table1.Rows.Count == 1)
                    {
                        string query_deleteBook = $"UPDATE {table} SET COVER = '{EditBookForm.curBookCover}' WHERE BOOK_TYPE_ID = {typeID} and BOOK_ID = {bookID}";
                        MySqlCommand command2 = new MySqlCommand(query_deleteBook, database.GetConnection());

                        if (command2.ExecuteNonQuery() != 1)
                        {
                            MessageBox.Show("Не вдалося змінити обкладинку!", "Помилка!");
                        }
                    }
                    else { MessageBox.Show("Сталася помилка!\nПеревірте правильність введених даних", "Помилка!"); }
                }
                if (!EditBookForm.elcopyIsEmpty) {
                    MySqlDataAdapter adapter1 = new MySqlDataAdapter();
                    DataTable table1 = new DataTable();

                    string query_selectBook = $"SELECT * FROM {table} WHERE BOOK_TYPE_ID = {typeID} AND BOOK_ID = {bookID}";
                    MySqlCommand command1 = new MySqlCommand(query_selectBook, database.GetConnection());

                    adapter1.SelectCommand = command1;
                    adapter1.Fill(table1);
                    if (table1.Rows.Count == 1)
                    {
                        string query_deleteBook = $"UPDATE {table} SET ELECTRONIC_COPY = '{EditBookForm.curBookElCopy}' WHERE BOOK_TYPE_ID = {typeID} and BOOK_ID = {bookID}";
                        MySqlCommand command2 = new MySqlCommand(query_deleteBook, database.GetConnection());

                        if (command2.ExecuteNonQuery() != 1)
                        {
                            MessageBox.Show("Не вдалося змінити посилання на електронну копію!", "Помилка!");
                        }
                    }
                    else { MessageBox.Show("Сталася помилка!\nПеревірте правильність введених даних", "Помилка!"); }
                }
                if (!EditBookForm.amountIsEmpty) {
                    MySqlDataAdapter adapter1 = new MySqlDataAdapter();
                    DataTable table1 = new DataTable();

                    string query_selectBook = $"SELECT * FROM {table} WHERE BOOK_TYPE_ID = {typeID} AND BOOK_ID = {bookID}";
                    MySqlCommand command1 = new MySqlCommand(query_selectBook, database.GetConnection());

                    adapter1.SelectCommand = command1;
                    adapter1.Fill(table1);
                    if (table1.Rows.Count == 1)
                    {
                        string query_deleteBook = $"UPDATE {table} SET AMOUNT = '{EditBookForm.curBookAmount}' WHERE BOOK_TYPE_ID = {typeID} and BOOK_ID = {bookID}";
                        MySqlCommand command2 = new MySqlCommand(query_deleteBook, database.GetConnection());

                        if (command2.ExecuteNonQuery() != 1)
                        {
                            MessageBox.Show("Не вдалося змінити поточну кількість примірників!", "Помилка!");
                        }
                    }
                    else { MessageBox.Show("Сталася помилка!\nПеревірте правильність введених даних", "Помилка!"); }
                }
                if (!EditBookForm.dscrIsEmpty) {
                    MySqlDataAdapter adapter1 = new MySqlDataAdapter();
                    DataTable table1 = new DataTable();

                    string query_selectBook = $"SELECT * FROM {table} WHERE BOOK_TYPE_ID = {typeID} AND BOOK_ID = {bookID}";
                    MySqlCommand command1 = new MySqlCommand(query_selectBook, database.GetConnection());

                    adapter1.SelectCommand = command1;
                    adapter1.Fill(table1);
                    if (table1.Rows.Count == 1)
                    {
                        string query_deleteBook = $"UPDATE {table} SET BOOK_DESCRIPTION = '{EditBookForm.curBookDescr}' WHERE BOOK_TYPE_ID = {typeID} and BOOK_ID = {bookID}";
                        MySqlCommand command2 = new MySqlCommand(query_deleteBook, database.GetConnection());

                        if (command2.ExecuteNonQuery() != 1)
                        {
                            MessageBox.Show("Не вдалося змінити опис!", "Помилка!");
                        }
                    }
                    else { MessageBox.Show("Сталася помилка!\nПеревірте правильність введених даних", "Помилка!"); }
                }
                if (!EditBookForm.laguageIsEmpty) {
                    MySqlDataAdapter adapter1 = new MySqlDataAdapter();
                    DataTable table1 = new DataTable();

                    string query_selectBook = $"SELECT * FROM {table} WHERE BOOK_TYPE_ID = {typeID} AND BOOK_ID = {bookID}";
                    MySqlCommand command1 = new MySqlCommand(query_selectBook, database.GetConnection());

                    adapter1.SelectCommand = command1;
                    adapter1.Fill(table1);
                    if (table1.Rows.Count == 1)
                    {
                        string query_deleteBook = $"UPDATE {table} SET LANGUAGE_ID = (SELECT LANGUAGE_ID FROM writing_languages WHERE BOOK_LANGUAGE = '{EditBookForm.curBookLanguage}') WHERE BOOK_TYPE_ID = {typeID} and BOOK_ID = {bookID}";
                        MySqlCommand command2 = new MySqlCommand(query_deleteBook, database.GetConnection());

                        if (command2.ExecuteNonQuery() != 1)
                        {
                            MessageBox.Show("Не вдалося змінити мову видання!", "Помилка!");
                        }
                    }
                    else { MessageBox.Show("Сталася помилка!\nПеревірте правильність введених даних", "Помилка!"); }
                }
            }
            database.closeConenection();
            Close();
        }


        private void button_cancle_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
