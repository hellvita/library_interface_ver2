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
            if (typeID.Equals("1") && EditBookForm.typeNum == 1) { table = "fiction"; }
            else if (typeID.Equals("2") && EditBookForm.typeNum == 2) { table = "scientic"; }
            else if (typeID.Equals("3") && EditBookForm.typeNum == 3) { table = "documentary"; }
            else if (typeID.Equals("4") && EditBookForm.typeNum == 4) { table = "professional"; }
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
                if (!EditBookForm.authorIsEmpty) { }
                if (!EditBookForm.yearIsEmpty) { }
                if (!EditBookForm.genreIsEmpty) { }
                if (!EditBookForm.coverIsEmpty) { }
                if (!EditBookForm.elcopyIsEmpty) { }
                if (!EditBookForm.elcopyIsEmpty) { }
                if (!EditBookForm.amountIsEmpty) { }
                if (!EditBookForm.dscrIsEmpty) { }
                if (!EditBookForm.laguageIsEmpty) { }
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
