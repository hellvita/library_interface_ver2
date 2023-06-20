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
        private UserLoginForm login_form;
        private BookFullDescriptionForm description_form;
        public static int selectedBookID;
        public static int selectedBookTypeID;
        public static int selectedBookGenreID;
        public static string selectedBookTable;
        int field1_book_id; int field1_book_type_id; string field1_table; int field1_book_genre_id;
        int field2_book_id; int field2_book_type_id; string field2_table; int field2_book_genre_id;
        int field3_book_id; int field3_book_type_id; string field3_table; int field3_book_genre_id;
        public LibraryHomePageForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            comboBox_bookTypes.SelectedIndexChanged += ComboBoxSelectedIndexChanged;
        }

        private void LibraryHomePageForm_Load(object sender, EventArgs e)
        {
            panel_mainBooksOverview.Visible = true;
            panel_noresults.Visible = false;
            label_userID.Text = "Користувач №" + UserLoginForm.ulog;
            comboBox_pages.SelectedIndex = 0;
            FillBookTypesList();
            FillGenreTypeList();
            FillSubjectAreaTypeList();
            FillBooksSubjectTypeList();
            FillDisciplineTypeList();
            FillLanguageList();
            fillBooksPreviewOf(3);
            
        }

        private void FillBookTypesList() {
            database.openConenection();

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

        private void FillGenreTypeList() {
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

            comboBox_bookGenres.SelectedIndex = 0;

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

            comboBox_subject_areas.SelectedIndex = 0;

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

            comboBox_books_subjects.SelectedIndex = 0;

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

            comboBox_disciplines.SelectedIndex = 0;

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

            comboBox_language.SelectedIndex = 1;

            database.closeConenection();
        }

        private void fillBooksPreviewOf(int field_amount) {
            
            switch (field_amount) {
                case 1: { fillFirstField(true); } break;
                case 2: { fillFirstField(true); fillSecondField(true); } break;
                case 3: { fillFirstField(true); fillSecondField(true); fillThirdField(true); } break;
            }
          
        }

        private void fillFirstField(bool homepage) {
            database.openConenection();
            if (homepage) {
                field1_book_id = 1; field1_book_type_id = 1;
                field1_table = "fiction";

                string query_getCover11 = $"SELECT COVER FROM {field1_table} WHERE BOOK_TYPE_ID = {field1_book_type_id} AND BOOK_ID = {field1_book_id};";
                MySqlCommand subcommand = new MySqlCommand(query_getCover11, database.GetConnection());
                object obj = subcommand.ExecuteScalar();
                string coverPath = obj.ToString();
                pictureBox_bookCover1.Image = Image.FromFile($"{coverPath}");

                string query_getName11 = $"SELECT BOOK_NAME FROM {field1_table} WHERE BOOK_TYPE_ID = {field1_book_type_id} AND BOOK_ID = {field1_book_id};";
                subcommand = new MySqlCommand(query_getName11, database.GetConnection());
                obj = subcommand.ExecuteScalar();
                string nameStr = getNsymb(obj.ToString(), 15, 1);
                linkLabel_bookName1.Text = $"{nameStr}";

                string query_getAuthor11 = $"SELECT AUTHOR FROM {field1_table} WHERE BOOK_TYPE_ID = {field1_book_type_id} AND BOOK_ID = {field1_book_id};";
                subcommand = new MySqlCommand(query_getAuthor11, database.GetConnection());
                obj = subcommand.ExecuteScalar();
                string autthorStr = obj.ToString();
                label_author1.Text = $"{autthorStr}";

                string query_getYear11 = $"SELECT PUBLICATION_YEAR FROM {field1_table} WHERE BOOK_TYPE_ID = {field1_book_type_id} AND BOOK_ID = {field1_book_id};";
                subcommand = new MySqlCommand(query_getYear11, database.GetConnection());
                obj = subcommand.ExecuteScalar();
                string yearStr = obj.ToString();
                label_bookYear1.Text = $"{yearStr}";

                string query_getDescription11 = $"SELECT BOOK_DESCRIPTION FROM {field1_table} WHERE BOOK_TYPE_ID = {field1_book_type_id} AND BOOK_ID = {field1_book_id};";
                subcommand = new MySqlCommand(query_getDescription11, database.GetConnection());
                obj = subcommand.ExecuteScalar();
                string descriptionStr = getNsymb(obj.ToString(), 360, 2);
                label_description1.Text = $"{descriptionStr}";

                string query_getGenreID11 = $"SELECT GENRE_ID FROM {field1_table} WHERE BOOK_TYPE_ID = {field1_book_type_id} AND BOOK_ID = {field1_book_id};";
                subcommand = new MySqlCommand(query_getGenreID11, database.GetConnection());
                field1_book_genre_id = (int)subcommand.ExecuteScalar();
            }
            database.closeConenection();
        }
        private void fillSecondField(bool homepage) {
            database.openConenection();
            if (homepage)
            {
                field2_book_id = 1; field2_book_type_id = 2;
                field2_table = "scientic";

                string query_getCover21 = $"SELECT COVER FROM {field2_table} WHERE BOOK_TYPE_ID = {field2_book_type_id} AND BOOK_ID = {field2_book_id};";
                MySqlCommand subcommand = new MySqlCommand(query_getCover21, database.GetConnection());
                object obj = subcommand.ExecuteScalar();
                string coverPath = obj.ToString();
                pictureBox_bookCover2.Image = Image.FromFile($"{coverPath}");

                string query_getName21 = $"SELECT BOOK_NAME FROM {field2_table} WHERE BOOK_TYPE_ID = {field2_book_type_id} AND BOOK_ID = {field2_book_id};";
                subcommand = new MySqlCommand(query_getName21, database.GetConnection());
                obj = subcommand.ExecuteScalar();
                string nameStr = getNsymb(obj.ToString(), 15, 1);
                linkLabel_bookName2.Text = $"{nameStr}";

                string query_getAuthor21 = $"SELECT AUTHOR FROM {field2_table} WHERE BOOK_TYPE_ID = {field2_book_type_id} AND BOOK_ID = {field2_book_id};";
                subcommand = new MySqlCommand(query_getAuthor21, database.GetConnection());
                obj = subcommand.ExecuteScalar();
                string autthorStr = obj.ToString();
                label_author2.Text = $"{autthorStr}";

                string query_getYear21 = $"SELECT PUBLICATION_YEAR FROM {field2_table} WHERE BOOK_TYPE_ID = {field2_book_type_id} AND BOOK_ID = {field2_book_id};";
                subcommand = new MySqlCommand(query_getYear21, database.GetConnection());
                obj = subcommand.ExecuteScalar();
                string yearStr = obj.ToString();
                label_bookYear2.Text = $"{yearStr}";

                string query_getDescription21 = $"SELECT BOOK_DESCRIPTION FROM {field2_table} WHERE BOOK_TYPE_ID = {field2_book_type_id} AND BOOK_ID = {field2_book_id};";
                subcommand = new MySqlCommand(query_getDescription21, database.GetConnection());
                obj = subcommand.ExecuteScalar();
                string descriptionStr = getNsymb(obj.ToString(), 360, 2);
                label_description2.Text = $"{descriptionStr}";

                string query_getGenreID21 = $"SELECT SUB_AREA_ID FROM {field2_table} WHERE BOOK_TYPE_ID = {field2_book_type_id} AND BOOK_ID = {field2_book_id};";
                subcommand = new MySqlCommand(query_getGenreID21, database.GetConnection());
                field2_book_genre_id = (int)subcommand.ExecuteScalar();
            }
            database.closeConenection();
        }
        private void fillThirdField(bool homepage) {
            database.openConenection();
            if (homepage)
            {
                field3_book_id = 1; field3_book_type_id = 3;
                field3_table = "documentary";

                string query_getCover31 = $"SELECT COVER FROM {field3_table} WHERE BOOK_TYPE_ID = {field3_book_type_id} AND BOOK_ID = {field3_book_id};";
                MySqlCommand subcommand = new MySqlCommand(query_getCover31, database.GetConnection());
                object obj = subcommand.ExecuteScalar();
                string coverPath = obj.ToString();
                pictureBox_bookCover3.Image = Image.FromFile($"{coverPath}");

                string query_getName31 = $"SELECT BOOK_NAME FROM {field3_table} WHERE BOOK_TYPE_ID = {field3_book_type_id} AND BOOK_ID = {field3_book_id};";
                subcommand = new MySqlCommand(query_getName31, database.GetConnection());
                obj = subcommand.ExecuteScalar();
                string nameStr = getNsymb(obj.ToString(), 15, 1);
                linkLabel_bookName3.Text = $"{nameStr}";

                string query_getAuthor31 = $"SELECT AUTHOR FROM {field3_table} WHERE BOOK_TYPE_ID = {field3_book_type_id} AND BOOK_ID = {field3_book_id};";
                subcommand = new MySqlCommand(query_getAuthor31, database.GetConnection());
                obj = subcommand.ExecuteScalar();
                string autthorStr = obj.ToString();
                label_author3.Text = $"{autthorStr}";

                string query_getYear31 = $"SELECT PUBLICATION_YEAR FROM {field3_table} WHERE BOOK_TYPE_ID = {field3_book_type_id} AND BOOK_ID = {field3_book_id};";
                subcommand = new MySqlCommand(query_getYear31, database.GetConnection());
                obj = subcommand.ExecuteScalar();
                string yearStr = obj.ToString();
                label_bookYear3.Text = $"{yearStr}";

                string query_getDescription31 = $"SELECT BOOK_DESCRIPTION FROM {field3_table} WHERE BOOK_TYPE_ID = {field3_book_type_id} AND BOOK_ID = {field3_book_id};";
                subcommand = new MySqlCommand(query_getDescription31, database.GetConnection());
                obj = subcommand.ExecuteScalar();
                string descriptionStr = getNsymb(obj.ToString(), 360, 2);
                label_description3.Text = $"{descriptionStr}";

                string query_getGenreID31 = $"SELECT SUBJECT_ID FROM {field3_table} WHERE BOOK_TYPE_ID = {field3_book_type_id} AND BOOK_ID = {field3_book_id};";
                subcommand = new MySqlCommand(query_getGenreID31, database.GetConnection());
                field3_book_genre_id = (int)subcommand.ExecuteScalar();
            }
            database.closeConenection();
        }

        private string getNsymb(string str, int lenth, int name1_desc2) {

            if (str.Length > lenth) {
                str = str.Substring(0, lenth);
                if (name1_desc2 == 1) str += "...";
            }
            if(name1_desc2 == 2) str += "...";
            return str;
        }

        private void UpdateLists(int curValue) {
            switch (curValue) {
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
                    { comboBox_disciplines.Visible = true; 
                     comboBox_books_subjects.Visible = false; 
                     comboBox_subject_areas.Visible = false; 
                     comboBox_bookGenres.Visible = false; }
                    break;
            }

        }

        private void ComboBoxSelectedIndexChanged(object sender, EventArgs e) {
            int curType = comboBox_bookTypes.SelectedIndex;
            UpdateLists(curType);
        }

        private void button_home_Click(object sender, EventArgs e)
        {
            panel_mainBooksOverview.Visible = true;
            panel_noresults.Visible = false;
        }

        private void linkLabel_bookName1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            selectedBookID = field1_book_id;
            selectedBookTypeID = field1_book_type_id;
            selectedBookTable = field1_table;
            selectedBookGenreID = field1_book_genre_id;
            openFullDescription();
        }

        private void linkLabel_bookName2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            selectedBookID = field2_book_id;
            selectedBookTypeID = field2_book_type_id;
            selectedBookTable = field2_table;
            selectedBookGenreID = field2_book_genre_id;
            openFullDescription();
        }

        private void linkLabel_bookName3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            selectedBookID = field3_book_id;
            selectedBookTypeID = field3_book_type_id;
            selectedBookTable = field3_table;
            selectedBookGenreID = field3_book_genre_id;
            openFullDescription();
        }

        private void openFullDescription() {
            if (description_form == null || description_form.IsDisposed)
            {
                description_form = new BookFullDescriptionForm();
                description_form.Show();
            }
            else
            {
                description_form.Focus();
            }
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            if (login_form == null || login_form.IsDisposed)
            {
                login_form = new UserLoginForm();
                login_form.Show();
            }
            else
            {
                login_form.Focus();
            }
            Close();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            panel_mainBooksOverview.Visible = false;
            panel_noresults.Visible = true;
        }
    }
}
