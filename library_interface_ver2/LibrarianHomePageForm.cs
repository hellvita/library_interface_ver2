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
    public partial class LibrarianHomePageForm : Form
    {
        DataBase database = new DataBase();
        private EmploeeAuthForm login_form;
        private UserSinginForm userSingin_form;
        private EditBookForm bookEdit_form;
        public static bool registerByLibrarian = false;
        public static string positionName = "";
        public static string fullName = "";
        public LibrarianHomePageForm()
        {
            InitializeComponent();
        }

        private void LibrarianHomePageForm_Load(object sender, EventArgs e)
        {
            setEmploeeInfo();
        }

        private void setEmploeeInfo() {
            database.openConenection();

            MySqlCommand command;
            object obj;
            string query_str;
            string table = "";
            int posID = EmploeeAuthForm.positionID;
            int empID = EmploeeAuthForm.emploeeID;
            int posNameID = EmploeeAuthForm.positionNameID;

            if (posID == 1 || posID == 2 || posID == 3) { table = "library_staff"; }
            else if (posID == 4 || posID == 5) { table = "administrators"; }
            else if (posID == 6 || posID == 7) { table = "managers"; }

            query_str = $"SELECT POSITION_NAME FROM job_titles WHERE POSITION_NAME_ID = {posNameID}";
            command = new MySqlCommand(query_str, database.GetConnection());
            obj = command.ExecuteScalar();
            positionName = obj.ToString();

            query_str = $"SELECT FULL_NAME FROM {table} WHERE EMPLOYEE_ID = {empID} AND POSITION_ID = {posID}";
            command = new MySqlCommand(query_str, database.GetConnection());
            obj = command.ExecuteScalar();
            fullName = obj.ToString();

            label_position.Text = $"{positionName}:";
            label_fname.Text = $"{fullName}";

            database.closeConenection();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            if (login_form == null || login_form.IsDisposed)
            {
                login_form = new EmploeeAuthForm();
                login_form.Show();
            }
            else
            {
                login_form.Focus();
            }
            Close();
        }

        private void button_addUser_Click(object sender, EventArgs e)
        {
            registerByLibrarian = true;
            if (userSingin_form == null || userSingin_form.IsDisposed)
            {
                userSingin_form = new UserSinginForm();
                userSingin_form.Show();
            }
            else
            {
                userSingin_form.Focus();
            }
        }

        private void button_bookEdit_Click(object sender, EventArgs e)
        {
            if (bookEdit_form == null || bookEdit_form.IsDisposed)
            {
                bookEdit_form = new EditBookForm();
                bookEdit_form.Show();
            }
            else
            {
                bookEdit_form.Focus();
            }
            Close();
        }
    }
}
