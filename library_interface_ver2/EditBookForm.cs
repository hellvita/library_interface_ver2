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
    public partial class EditBookForm : Form
    {
        DataBase database = new DataBase();
        private LibrarianHomePageForm homepage_form;
        private DeleteBookForm deleteBook_form;
        private ApplyBookChangesForm editBook_form;
        public static int typeNum;
        public static string curBookType, curBookName, curBookAuthor, curBookYear, curBookGenre;
        public static string curBookCover, curBookElCopy, curBookAmount, curBookDescr, curBookLanguage;
        public static bool typeFielsIsEmpty, nameIsEmpty, authorIsEmpty, yearIsEmpty, genreIsEmpty;
        public static bool coverIsEmpty, elcopyIsEmpty, amountIsEmpty, dscrIsEmpty, laguageIsEmpty;
        public EditBookForm()
        {
            InitializeComponent();
            comboBox_bookTypes.SelectedIndexChanged += ComboBoxSelectedIndexChanged;
        }

        private void EditBookForm_Load(object sender, EventArgs e)
        {
            setFielLimitation();
            label_position.Text = LibrarianHomePageForm.positionName;
            label_fullname.Text = LibrarianHomePageForm.fullName;
            FillBookTypesList();
            FillGenreTypeList();
            FillSubjectAreaTypeList();
            FillBooksSubjectTypeList();
            FillDisciplineTypeList();
            FillLanguageList();
        }
        private void setFielLimitation() {
            textBox_bookName.MaxLength = 100;
            textBox_amount.MaxLength = 3;
            textBox_author.MaxLength = 30;
            textBox_year.MaxLength = 4;
            textBox_cover.MaxLength = 255;
            textBox_electronCopy.MaxLength = 255;
            textBox_description.MaxLength = 16777215;
        }
        private void ComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            int curType = comboBox_bookTypes.SelectedIndex;
            UpdateLists(curType);
        }

        private void UpdateLists(int curValue)
        {
            switch (curValue)
            {
                case 0:
                    {
                        comboBox_disciplines.Visible = false;
                        comboBox_books_subjects.Visible = false;
                        comboBox_subject_areas.Visible = false;
                        comboBox_bookGenres.Visible = true;
                    }
                    break;
                case 1:
                    {
                        comboBox_disciplines.Visible = false;
                        comboBox_books_subjects.Visible = false;
                        comboBox_subject_areas.Visible = true;
                        comboBox_bookGenres.Visible = false;
                    }
                    break;
                case 2:
                    {
                        comboBox_disciplines.Visible = false;
                        comboBox_books_subjects.Visible = true;
                        comboBox_subject_areas.Visible = false;
                        comboBox_bookGenres.Visible = false;
                    }
                    break;
                case 3:
                    {
                        comboBox_disciplines.Visible = true;
                        comboBox_books_subjects.Visible = false;
                        comboBox_subject_areas.Visible = false;
                        comboBox_bookGenres.Visible = false;
                    }
                    break;
            }

        }

        private void button_back_Click(object sender, EventArgs e)
        {
            if (homepage_form == null || homepage_form.IsDisposed)
            {
                homepage_form = new LibrarianHomePageForm();
                homepage_form.Show();
            }
            else
            {
                homepage_form.Focus();
            }
            Close();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            checkFields();
            if (!typeFielsIsEmpty && nameIsEmpty && authorIsEmpty && yearIsEmpty && !genreIsEmpty && coverIsEmpty && elcopyIsEmpty && amountIsEmpty && dscrIsEmpty && laguageIsEmpty) 
            { showBookByType(curBookGenre); }
            else if (!typeFielsIsEmpty && nameIsEmpty && authorIsEmpty && yearIsEmpty && genreIsEmpty && coverIsEmpty && elcopyIsEmpty && amountIsEmpty && dscrIsEmpty && laguageIsEmpty) 
            { showBookByType("0"); }
        }

        private void showBookByType(string genre) {
            if (comboBox_bookTypes.SelectedIndex == 0) { showAllFiction(genre); }
            else if (comboBox_bookTypes.SelectedIndex == 1) { showAllScientic(genre); }
            else if (comboBox_bookTypes.SelectedIndex == 2) { showAllDocumentary(genre); }
            else if (comboBox_bookTypes.SelectedIndex == 3) { showAllProfessional(genre); }
        }

        private void FillBookTypesList()
        {
            database.openConenection();

            string query_str = "SELECT COUNT(*) FROM books_types";

            MySqlCommand command = new MySqlCommand(query_str, database.GetConnection());
            var rowsAmount = (long)command.ExecuteScalar();


            for (int i = 1; i < rowsAmount + 1; i++)
            {
                string subquery_str = $"SELECT BOOK_TYPE_NAME FROM books_types WHERE BOOK_TYPE_ID = '{i}'";
                MySqlCommand subcommand = new MySqlCommand(subquery_str, database.GetConnection());
                object obj = subcommand.ExecuteScalar();
                string text = obj.ToString();
                comboBox_bookTypes.Items.Add(text);
            }

            database.closeConenection();
        }
        private void FillGenreTypeList()
        {
            database.openConenection();

            string query_str = "SELECT COUNT(*) FROM genres";

            MySqlCommand command = new MySqlCommand(query_str, database.GetConnection());
            var rowsAmount = (long)command.ExecuteScalar();


            for (int i = 1; i < rowsAmount + 1; i++)
            {
                string subquery_str = $"SELECT GENRE FROM genres WHERE GENRE_ID = '{i}'";
                MySqlCommand subcommand = new MySqlCommand(subquery_str, database.GetConnection());
                object obj = subcommand.ExecuteScalar();
                string text = obj.ToString();
                comboBox_bookGenres.Items.Add(text);
            }

            database.closeConenection();
        }
        private void FillSubjectAreaTypeList()
        {
            database.openConenection();

            string query_str = "SELECT COUNT(*) FROM subject_areas";

            MySqlCommand command = new MySqlCommand(query_str, database.GetConnection());
            var rowsAmount = (long)command.ExecuteScalar();


            for (int i = 1; i < rowsAmount + 1; i++)
            {
                string subquery_str = $"SELECT SUB_AREA FROM subject_areas WHERE SUB_AREA_ID = '{i}'";
                MySqlCommand subcommand = new MySqlCommand(subquery_str, database.GetConnection());
                object obj = subcommand.ExecuteScalar();
                string text = obj.ToString();
                comboBox_subject_areas.Items.Add(text);
            }

            database.closeConenection();
        }
        private void FillBooksSubjectTypeList()
        {
            database.openConenection();

            string query_str = "SELECT COUNT(*) FROM books_subjects";

            MySqlCommand command = new MySqlCommand(query_str, database.GetConnection());
            var rowsAmount = (long)command.ExecuteScalar();


            for (int i = 1; i < rowsAmount + 1; i++)
            {
                string subquery_str = $"SELECT BOOK_SUBJECT FROM books_subjects WHERE SUBJECT_ID = '{i}'";
                MySqlCommand subcommand = new MySqlCommand(subquery_str, database.GetConnection());
                object obj = subcommand.ExecuteScalar();
                string text = obj.ToString();
                comboBox_books_subjects.Items.Add(text);
            }

            database.closeConenection();
        }
        private void FillDisciplineTypeList()
        {
            database.openConenection();

            string query_str = "SELECT COUNT(*) FROM disciplines";

            MySqlCommand command = new MySqlCommand(query_str, database.GetConnection());
            var rowsAmount = (long)command.ExecuteScalar();


            for (int i = 1; i < rowsAmount + 1; i++)
            {
                string subquery_str = $"SELECT DISCIPLINE FROM disciplines WHERE DISCIPLINE_ID = '{i}'";
                MySqlCommand subcommand = new MySqlCommand(subquery_str, database.GetConnection());
                object obj = subcommand.ExecuteScalar();
                string text = obj.ToString();
                comboBox_disciplines.Items.Add(text);
            }

            database.closeConenection();
        }
        private void FillLanguageList()
        {
            database.openConenection();

            string query_str = "SELECT COUNT(*) FROM writing_languages";

            MySqlCommand command = new MySqlCommand(query_str, database.GetConnection());
            var rowsAmount = (long)command.ExecuteScalar();


            for (int i = 1; i < rowsAmount + 1; i++)
            {
                string subquery_str = $"SELECT BOOK_LANGUAGE FROM writing_languages WHERE LANGUAGE_ID = '{i}'";
                MySqlCommand subcommand = new MySqlCommand(subquery_str, database.GetConnection());
                object obj = subcommand.ExecuteScalar();
                string text = obj.ToString();
                comboBox_language.Items.Add(text);
            }

            database.closeConenection();
        }

        private void showAllFiction(string genre) {
            database.openConenection();

            DataTable table = new DataTable();
            MySqlDataAdapter adapter;
            string query_str;
            if (genre.Equals("0"))
            {
                query_str = "SELECT BOOK_TYPE_ID, BOOK_ID, BOOK_NAME, AUTHOR, (SELECT GENRE FROM genres WHERE GENRE_ID = fiction.GENRE_ID) AS GENERE, PUBLICATION_YEAR, (SELECT BOOK_LANGUAGE FROM writing_languages WHERE LANGUAGE_ID = fiction.LANGUAGE_ID) AS LANGUAGE, COVER, BOOK_DESCRIPTION, AMOUNT, ELECTRONIC_COPY FROM fiction";
                adapter = new MySqlDataAdapter(query_str, database.GetConnection());
            }
            else {
                query_str = $"SELECT BOOK_TYPE_ID, BOOK_ID, BOOK_NAME, AUTHOR, PUBLICATION_YEAR, (SELECT BOOK_LANGUAGE FROM writing_languages WHERE LANGUAGE_ID = fiction.LANGUAGE_ID) AS LANGUAGE, COVER, BOOK_DESCRIPTION, AMOUNT, ELECTRONIC_COPY FROM fiction WHERE GENRE_ID = (SELECT GENRE_ID FROM genres WHERE GENRE = '{genre}')";
                adapter = new MySqlDataAdapter(query_str, database.GetConnection());
            }

            adapter.Fill(table);
            dataGV_books.DataSource = table;

            database.closeConenection();
        }

        private void showAllScientic(string genre)
        {
            database.openConenection();

            DataTable table = new DataTable();
            MySqlDataAdapter adapter;
            string query_str;
            if (genre.Equals("0"))
            {
                query_str = "SELECT BOOK_TYPE_ID, BOOK_ID, BOOK_NAME, AUTHOR, (SELECT SUB_AREA FROM subject_areas WHERE SUB_AREA_ID = scientic.SUB_AREA_ID) AS SUB_AREA, PUBLICATION_YEAR, (SELECT BOOK_LANGUAGE FROM writing_languages WHERE LANGUAGE_ID = scientic.LANGUAGE_ID) AS LANGUAGE, COVER, BOOK_DESCRIPTION, AMOUNT, ELECTRONIC_COPY FROM scientic";
                adapter = new MySqlDataAdapter(query_str, database.GetConnection());
            }
            else
            {
                query_str = $"SELECT BOOK_TYPE_ID, BOOK_ID, BOOK_NAME, AUTHOR, PUBLICATION_YEAR, (SELECT BOOK_LANGUAGE FROM writing_languages WHERE LANGUAGE_ID = scientic.LANGUAGE_ID) AS LANGUAGE, COVER, BOOK_DESCRIPTION, AMOUNT, ELECTRONIC_COPY FROM scientic WHERE SUB_AREA_ID = (SELECT SUB_AREA_ID FROM subject_areas WHERE SUB_AREA = '{genre}')"; 
                adapter = new MySqlDataAdapter(query_str, database.GetConnection());
            }

            adapter.Fill(table);
            dataGV_books.DataSource = table;

            database.closeConenection();
        }

        private void showAllDocumentary(string genre)
        {
            database.openConenection();

            DataTable table = new DataTable();
            MySqlDataAdapter adapter;
            string query_str;
            if (genre.Equals("0"))
            {
                query_str = "SELECT BOOK_TYPE_ID, BOOK_ID, BOOK_NAME, AUTHOR, (SELECT BOOK_SUBJECT FROM books_subjects WHERE SUBJECT_ID = documentary.SUBJECT_ID) AS BOOK_SUBJECT, PUBLICATION_YEAR, (SELECT BOOK_LANGUAGE FROM writing_languages WHERE LANGUAGE_ID = documentary.LANGUAGE_ID) AS LANGUAGE, COVER, BOOK_DESCRIPTION, AMOUNT, ELECTRONIC_COPY FROM documentary";
                adapter = new MySqlDataAdapter(query_str, database.GetConnection());
            }
            else
            {
                query_str = $"SELECT BOOK_TYPE_ID, BOOK_ID, BOOK_NAME, AUTHOR, PUBLICATION_YEAR, (SELECT BOOK_LANGUAGE FROM writing_languages WHERE LANGUAGE_ID = documentary.LANGUAGE_ID) AS LANGUAGE, COVER, BOOK_DESCRIPTION, AMOUNT, ELECTRONIC_COPY FROM documentary WHERE SUBJECT_ID = (SELECT SUBJECT_ID FROM books_subjects WHERE BOOK_SUBJECT = '{genre}')";  
                adapter = new MySqlDataAdapter(query_str, database.GetConnection());
            }

            adapter.Fill(table);
            dataGV_books.DataSource = table;

            database.closeConenection();
        }

        private void showAllProfessional(string genre)
        {
            database.openConenection();

            DataTable table = new DataTable();
            MySqlDataAdapter adapter;
            string query_str;
            if (genre.Equals("0"))
            {
                query_str = "SELECT BOOK_TYPE_ID, BOOK_ID, BOOK_NAME, AUTHOR, (SELECT DISCIPLINE FROM disciplines WHERE DISCIPLINE_ID = professional.DISCIPLINE_ID) AS DISCIPLINE, PUBLICATION_YEAR, (SELECT BOOK_LANGUAGE FROM writing_languages WHERE LANGUAGE_ID = professional.LANGUAGE_ID) AS LANGUAGE, COVER, BOOK_DESCRIPTION, AMOUNT, ELECTRONIC_COPY FROM professional";
                adapter = new MySqlDataAdapter(query_str, database.GetConnection());
            }
            else
            {
                query_str = $"SELECT BOOK_TYPE_ID, BOOK_ID, BOOK_NAME, AUTHOR, PUBLICATION_YEAR, (SELECT BOOK_LANGUAGE FROM writing_languages WHERE LANGUAGE_ID = professional.LANGUAGE_ID) AS LANGUAGE, COVER, BOOK_DESCRIPTION, AMOUNT, ELECTRONIC_COPY FROM professional WHERE DISCIPLINE_ID = (SELECT DISCIPLINE_ID FROM disciplines WHERE DISCIPLINE = '{genre}')";
                adapter = new MySqlDataAdapter(query_str, database.GetConnection());
            }

            adapter.Fill(table);
            dataGV_books.DataSource = table;

            database.closeConenection();
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            checkFields();
            if (editBook_form == null || editBook_form.IsDisposed)
            {
                editBook_form = new ApplyBookChangesForm();
                editBook_form.Show();
            }
            else
            {
                editBook_form.Focus();
            }
        }


        private void button_delete_Click(object sender, EventArgs e)
        {
            if (deleteBook_form == null || deleteBook_form.IsDisposed)
            {
                deleteBook_form = new DeleteBookForm();
                deleteBook_form.Show();
            }
            else
            {
                deleteBook_form.Focus();
            }
        }




        private void button_clearFields_Click(object sender, EventArgs e)
        {
            clearAllFields();
        }

        private void clearAllFields() {
            comboBox_bookTypes.SelectedIndex = -1;
            comboBox_language.SelectedIndex = -1;
            comboBox_bookGenres.SelectedIndex = -1;
            comboBox_subject_areas.SelectedIndex = -1;
            comboBox_books_subjects.SelectedIndex = -1;
            comboBox_disciplines.SelectedIndex = -1;
            textBox_bookName.Text = "";
            textBox_author.Text = "";
            textBox_amount.Text = "";
            textBox_cover.Text = "";
            textBox_year.Text = "";
            textBox_electronCopy.Text = "";
            textBox_description.Text = "";
        }

        private void checkFields() {
            checkbookTypes();
            checkbookName();
            checkbookAuthor();
            checkbookYear();
            checkbookGenre();
            checkbookCover();
            checkbookElCopy();
            checkbookAmount();
            checkbookDescr();
            checkbookLaguage();
        }

        private void checkbookTypes()
        {
            typeNum = comboBox_bookTypes.SelectedIndex + 1;
            curBookType = comboBox_bookTypes.Text;
            if (curBookType == "") { typeFielsIsEmpty = true; }
            else typeFielsIsEmpty = false;
        }

        private void checkbookName()
        {
            curBookName = textBox_bookName.Text;
            if (curBookName == "") { nameIsEmpty = true; }
            else nameIsEmpty = false;
        }

        private void checkbookAuthor()
        {
            curBookAuthor = textBox_author.Text;
            if (curBookAuthor == "") { authorIsEmpty = true; }
            else authorIsEmpty = false;
        }

        private void checkbookYear()
        {
            curBookYear = textBox_year.Text;
            if (curBookYear == "") { yearIsEmpty = true; }
            else yearIsEmpty = false;
        }

        private void checkbookGenre()
        {
            curBookGenre = comboBox_bookGenres.Text;
            if (curBookGenre == "") { genreIsEmpty = true; }
            else genreIsEmpty = false;
        }

        private void checkbookCover()
        {
            curBookCover = textBox_cover.Text;
            if (curBookCover == "") { coverIsEmpty = true; }
            else coverIsEmpty = false;
        }

        private void checkbookElCopy()
        {
            curBookElCopy = textBox_electronCopy.Text;
            if (curBookElCopy == "") { elcopyIsEmpty = true; }
            else elcopyIsEmpty = false;
        }

        private void checkbookAmount()
        {
            curBookAmount = textBox_amount.Text;
            if (curBookAmount == "") { amountIsEmpty = true; }
            else amountIsEmpty = false;
        }

        private void checkbookDescr()
        {
            curBookDescr = textBox_description.Text;
            if (curBookDescr == "") { dscrIsEmpty = true; }
            else dscrIsEmpty = false;
        }

        private void checkbookLaguage()
        {
            curBookLanguage = comboBox_language.Text;
            if (curBookLanguage == "") { laguageIsEmpty = true; }
            else laguageIsEmpty = false;
        }
    }
}
