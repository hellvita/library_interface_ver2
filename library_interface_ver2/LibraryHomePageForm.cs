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
        private UserAccountForm uAcc_form;
        public static int selectedBookID;
        public static int selectedBookTypeID;
        public static int selectedBookGenreID;
        public static string selectedBookTable;
        int field1_book_id; int field1_book_type_id; string field1_table; int field1_book_genre_id;
        int field2_book_id; int field2_book_type_id; string field2_table; int field2_book_genre_id;
        int field3_book_id; int field3_book_type_id; string field3_table; int field3_book_genre_id;
        private string curTable;
        private int curGenreID;
        private int curTypeID;
        LibraryHomePageForm classObj = new LibraryHomePageForm();

        public LibraryHomePageForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            comboBox_bookTypes.SelectedIndexChanged += ComboBoxSelectedIndexChanged;
        }

        private void LibraryHomePageForm_Load(object sender, EventArgs e)
        {
            setStartHomePageView();
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
                case 1: { fillFirstField(true, false); } break;
                case 2: { fillFirstField(true, false); fillSecondField(true, false); } break;
                case 3: { fillFirstField(true, false); fillSecondField(true, false); fillThirdField(true, false); } break;
            }
          
        }

        private void execCoverQuery(string table, int typeID, int bookID, int field) {
            database.openConenection();
            string query_getCover = $"SELECT COVER FROM {table} WHERE BOOK_TYPE_ID = {typeID} AND BOOK_ID = {bookID};";
            MySqlCommand subcommand = new MySqlCommand(query_getCover, database.GetConnection());
            object obj = subcommand.ExecuteScalar();
            string coverPath = obj.ToString();
            if(field == 1 ) pictureBox_bookCover1.Image = Image.FromFile($"{coverPath}");
            else if(field == 2 ) pictureBox_bookCover2.Image = Image.FromFile($"{coverPath}");
            else if(field == 3 ) pictureBox_bookCover3.Image = Image.FromFile($"{coverPath}");
            database.closeConenection();
        }
        private void execBookNameQuery(string table, int typeID, int bookID, int field) {
            database.openConenection();
            string query_getName = $"SELECT BOOK_NAME FROM {table} WHERE BOOK_TYPE_ID = {typeID} AND BOOK_ID = {bookID};";
            MySqlCommand subcommand = new MySqlCommand(query_getName, database.GetConnection());
            object obj = subcommand.ExecuteScalar();
            string nameStr = getNsymb(obj.ToString(), 15, 1);
            if (field == 1) linkLabel_bookName1.Text = $"{nameStr}";
            else if (field == 2) linkLabel_bookName2.Text = $"{nameStr}";
            else if (field == 3) linkLabel_bookName3.Text = $"{nameStr}";
            database.closeConenection();
        }
        private void execAuthorQuery(string table, int typeID, int bookID, int field) {
            database.openConenection();
            string query_getAuthor = $"SELECT AUTHOR FROM {table} WHERE BOOK_TYPE_ID = {typeID} AND BOOK_ID = {bookID};";
            MySqlCommand subcommand = new MySqlCommand(query_getAuthor, database.GetConnection());
            object obj = subcommand.ExecuteScalar();
            string autthorStr = obj.ToString();
            if (field == 1) label_author1.Text = $"{autthorStr}";
            else if (field == 2) label_author2.Text = $"{autthorStr}";
            else if (field == 3) label_author3.Text = $"{autthorStr}";
            database.closeConenection();
        }
        private void execYearQuery(string table, int typeID, int bookID, int field) {
            database.openConenection();
            string query_getYear = $"SELECT PUBLICATION_YEAR FROM {table} WHERE BOOK_TYPE_ID = {typeID} AND BOOK_ID = {bookID};";
            MySqlCommand subcommand = new MySqlCommand(query_getYear, database.GetConnection());
            object obj = subcommand.ExecuteScalar();
            string yearStr = obj.ToString();
            if (field == 1) label_bookYear1.Text = $"{yearStr}";
            else if (field == 2) label_bookYear2.Text = $"{yearStr}";
            else if (field == 3) label_bookYear3.Text = $"{yearStr}";
            database.closeConenection();
        }
        private void execDescrQuery(string table, int typeID, int bookID, int field) {
            database.openConenection();
            string query_getDescription = $"SELECT BOOK_DESCRIPTION FROM {table} WHERE BOOK_TYPE_ID = {typeID} AND BOOK_ID = {bookID};";
            MySqlCommand subcommand = new MySqlCommand(query_getDescription, database.GetConnection());
            object obj = subcommand.ExecuteScalar();
            string descriptionStr = getNsymb(obj.ToString(), 360, 2);
            if (field == 1) label_description1.Text = $"{descriptionStr}";
            else if(field == 2) label_description2.Text = $"{descriptionStr}";
            else if(field == 3) label_description3.Text = $"{descriptionStr}";
            database.closeConenection();
        }
        private void execGetGenreQuery(string table, int typeID, int bookID, int field) {
            database.openConenection();
            string query_getGenreID11 = $"SELECT GENRE_ID FROM {table} WHERE BOOK_TYPE_ID = {typeID} AND BOOK_ID = {bookID};";
            MySqlCommand subcommand = new MySqlCommand(query_getGenreID11, database.GetConnection());
            if (field == 1) field1_book_genre_id = (int)subcommand.ExecuteScalar();
            else if(field == 2) field2_book_genre_id = (int)subcommand.ExecuteScalar();
            else if(field == 3) field3_book_genre_id = (int)subcommand.ExecuteScalar();
            database.closeConenection();
        }
        private void fillFirstField(bool homepage, bool thisIsEmpty) {            
            if (homepage)
            {
                field1_book_id = 1; field1_book_type_id = 1;
                field1_table = "fiction";

                execCoverQuery(field1_table, field1_book_type_id, field1_book_id, 1);
                execBookNameQuery(field1_table, field1_book_type_id, field1_book_id, 1);
                execAuthorQuery(field1_table, field1_book_type_id, field1_book_id, 1);
                execYearQuery(field1_table, field1_book_type_id, field1_book_id, 1);
                execDescrQuery(field1_table, field1_book_type_id, field1_book_id, 1);

                execGetGenreQuery(field1_table, field1_book_type_id, field1_book_id, 1);
            }
            else if (thisIsEmpty) { panel_shortBookDescr1.Visible = false; }
            else {
                field1_book_id = 1; field1_book_type_id = classObj.GETcurTypeID;
                field1_table = classObj.GETcurTable; field1_book_genre_id = classObj.GETcurGenreID;

                execCoverQuery(field1_table, field1_book_type_id, field1_book_id, 1);
                execBookNameQuery(field1_table, field1_book_type_id, field1_book_id, 1);
                execAuthorQuery(field1_table, field1_book_type_id, field1_book_id, 1);
                execYearQuery(field1_table, field1_book_type_id, field1_book_id, 1);
                execDescrQuery(field1_table, field1_book_type_id, field1_book_id, 1);
            }            
        }
        private void fillSecondField(bool homepage, bool thisIsEmpty) {
            if (homepage)
            {
                field2_book_id = 1; field2_book_type_id = 2;
                field2_table = "scientic";

                execCoverQuery(field2_table, field2_book_type_id, field2_book_id, 2);
                execBookNameQuery(field2_table, field2_book_type_id, field2_book_id, 2);
                execAuthorQuery(field2_table, field2_book_type_id, field2_book_id, 2);
                execYearQuery(field2_table, field2_book_type_id, field2_book_id, 2);
                execDescrQuery(field2_table, field2_book_type_id, field2_book_id, 2);

                execGetGenreQuery(field2_table, field2_book_type_id, field2_book_id, 2);
            }
            else if (thisIsEmpty) { panel_shortBookDescr2.Visible = false; }
            else
            {
                field2_book_id = 2; field2_book_type_id = classObj.GETcurTypeID;
                field2_table = classObj.GETcurTable; field2_book_genre_id = classObj.GETcurGenreID;

                execCoverQuery(field2_table, field2_book_type_id, field2_book_id, 2);
                execBookNameQuery(field2_table, field2_book_type_id, field2_book_id, 2);
                execAuthorQuery(field2_table, field2_book_type_id, field2_book_id, 2);
                execYearQuery(field2_table, field2_book_type_id, field2_book_id, 2);
                execDescrQuery(field2_table, field2_book_type_id, field2_book_id, 2);
            }
        }
        private void fillThirdField(bool homepage, bool thisIsEmpty) {
            if (homepage)
            {
                field3_book_id = 1; field3_book_type_id = 3;
                field3_table = "documentary";

                execCoverQuery(field3_table, field3_book_type_id, field3_book_id, 3);
                execBookNameQuery(field3_table, field3_book_type_id, field3_book_id, 3);
                execAuthorQuery(field3_table, field3_book_type_id, field3_book_id, 3);
                execYearQuery(field3_table, field3_book_type_id, field3_book_id, 3);
                execDescrQuery(field3_table, field3_book_type_id, field3_book_id, 3);

                execGetGenreQuery(field3_table, field3_book_type_id, field3_book_id, 3);
            }
            else if (thisIsEmpty) { panel_shortBookDescr3.Visible = false; }
            else
            {
                field3_book_id = 3; field3_book_type_id = classObj.GETcurTypeID;
                field3_table = classObj.GETcurTable; field3_book_genre_id = classObj.GETcurGenreID;

                execCoverQuery(field3_table, field3_book_type_id, field3_book_id, 3);
                execBookNameQuery(field3_table, field3_book_type_id, field3_book_id, 3);
                execAuthorQuery(field3_table, field3_book_type_id, field3_book_id, 3);
                execYearQuery(field3_table, field3_book_type_id, field3_book_id, 3);
                execDescrQuery(field3_table, field3_book_type_id, field3_book_id, 3);
            }
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

        private void setStartHomePageView() {
            label_userID.Text = "Користувач №" + UserLoginForm.ulog;
            comboBox_pages.SelectedIndex = 0;
            textBox_search.Text = "";
            UpdateLists(0);

            comboBox_bookGenres.SelectedIndex = 0;
            comboBox_subject_areas.SelectedIndex = 0;
            comboBox_books_subjects.SelectedIndex = 0;
            comboBox_disciplines.SelectedIndex = 0;

            comboBox_bookTypes.SelectedIndex = 0;
            comboBox_language.SelectedIndex = 1;

            panel_mainBooksOverview.Visible = true;
            panel_shortBookDescr1.Visible = true;
            panel_shortBookDescr2.Visible = true;
            panel_shortBookDescr3.Visible = true;
            panel_noresults.Visible = false;

            fillBooksPreviewOf(3);
        }

        private void button_home_Click(object sender, EventArgs e)
        {
            setStartHomePageView();
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
            setSearchingValues();
            bookSearching();            
            showNoRes();
        }

        private void setSearchingValues() {
            string genreText = "";
            if (comboBox_disciplines.Visible) genreText = comboBox_disciplines.Text;
            else if (comboBox_books_subjects.Visible) genreText = comboBox_books_subjects.Text;
            else if (comboBox_subject_areas.Visible) genreText = comboBox_subject_areas.Text;
            else if (comboBox_bookGenres.Visible) genreText = comboBox_bookGenres.Text;
            textBox_search.Text = $"{comboBox_bookTypes.Text}, {genreText}, {comboBox_language.Text}";
        }

        private void showNoRes() {

            panel_mainBooksOverview.Visible = false;
            panel_noresults.Visible = true;
        }


        private void bookSearching() {

            if (comboBox_bookTypes.SelectedIndex == 0) { SETcurTable("fiction"); SETcurGenreID(getCurGenreID(0)); SETcurTypeID(1); }
            else if (comboBox_bookTypes.SelectedIndex == 1) { SETcurTable("scientic"); SETcurGenreID(getCurGenreID(1)); SETcurTypeID(2); }
            else if (comboBox_bookTypes.SelectedIndex == 2) { SETcurTable("documentary"); SETcurGenreID(getCurGenreID(2)); SETcurTypeID(3); }
            else if (comboBox_bookTypes.SelectedIndex == 3) { SETcurTable("professional"); SETcurGenreID(getCurGenreID(3)); SETcurTypeID(4); }

            database.openConenection();

            string query_str = $"SELECT COUNT(*) FROM {curTable}";

            MySqlCommand command = new MySqlCommand(query_str, database.GetConnection());
            var rowsAmount = (long)command.ExecuteScalar();
            string subquery_str;
            if (rowsAmount == 1) {
                fillFirstField(false, false);
                fillSecondField(false, true);
                fillThirdField(false, true);
            }
            else if (rowsAmount == 2) {
                fillFirstField(false, false);
                fillSecondField(false, false);
                fillThirdField(false, true);
            }
            else if (rowsAmount >= 3) {
                fillFirstField(false, false);
                fillSecondField(false, false);
                fillThirdField(false, false);
            }

            database.closeConenection();
        }

        private int getCurGenreID(int type) {
            database.openConenection();
            int genreID = 1;
            string curGenreName;
            string query_str;
            MySqlCommand command;
            switch (type)
            {
                case 0: {
                        curGenreName = comboBox_bookGenres.Text;
                        query_str = $"SELECT GENRE_ID FROM genres WHERE GENRE = '{curGenreName}'";
                        command = new MySqlCommand(query_str, database.GetConnection());
                        genreID = (int)command.ExecuteScalar();
                    } break;
                case 1: {
                        curGenreName = comboBox_books_subjects.Text;
                        query_str = $"SELECT SUB_AREA_ID FROM subject_areas WHERE SUB_AREA = '{curGenreName}'";
                        command = new MySqlCommand(query_str, database.GetConnection());
                        genreID = (int)command.ExecuteScalar();
                    } break;
                case 2: {
                        curGenreName = comboBox_subject_areas.Text;
                        query_str = $"SELECT SUBJECT_ID FROM books_subjects WHERE BOOK_SUBJECT = '{curGenreName}'";
                        command = new MySqlCommand(query_str, database.GetConnection());
                        genreID = (int)command.ExecuteScalar();
                    } break;
                case 3: {
                        curGenreName = comboBox_bookGenres.Text;
                        query_str = $"SELECT DISCIPLINE_ID FROM disciplines WHERE DISCIPLINE = '{curGenreName}'";
                        command = new MySqlCommand(query_str, database.GetConnection());
                        genreID = (int)command.ExecuteScalar();
                    } break;
            }
            database.closeConenection();
            return genreID;
        }

        private void button_userAcc_Click(object sender, EventArgs e)
        {
            if (uAcc_form == null || uAcc_form.IsDisposed)
            {
                uAcc_form = new UserAccountForm();
                uAcc_form.Show();
            }
            else
            {
                uAcc_form.Focus();
            }
            Close();
        }

        public string GETcurTable
        {
            get
            {
                return curTable;
            }
        }
        public int GETcurGenreID
        {
            get
            {
                return curGenreID;
            }
        }
        public int GETcurTypeID
        {
            get
            {
                return curTypeID;
            }
        }

        public void SETcurTable(string table) { curTable = table; }
        public void SETcurGenreID(int id) { curGenreID = id; }
        public void SETcurTypeID(int id) { curTypeID = id; }
    }
}
