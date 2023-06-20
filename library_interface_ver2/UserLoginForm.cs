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
    public partial class UserLoginForm : Form
    {
        DataBase database = new DataBase();
        private UserLogSinginForm home_form;
        private LibraryHomePageForm lib_homepage_form;
        public UserLoginForm()
        {
            InitializeComponent();
        }

        private void UserLoginForm_Load(object sender, EventArgs e)
        {
            textBox_user_pwd.PasswordChar = '☺';
            textBox_user_pwd.MaxLength = 20;
            textBox_user_login.MaxLength = 5;
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            if (home_form == null || home_form.IsDisposed)
            {
                home_form = new UserLogSinginForm();
                home_form.Show();
            }
            else
            {
                home_form.Focus();
            }
            Close();
        }

        // login button
        private void button1_Click(object sender, EventArgs e)
        {
            var userLogin = textBox_user_login.Text;
            var userPwd = md5.hashPwd(textBox_user_pwd.Text);

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            if (userLogin != "" && userPwd != "") {

                string query_str = $"SELECT * FROM users WHERE USER_ID = '{userLogin}' AND USER_PASSWORD = '{userPwd}'";

                MySqlCommand command = new MySqlCommand(query_str, database.GetConnection());

                adapter.SelectCommand = command;
                adapter.Fill(table);
            }

            if (table.Rows.Count == 1) {
                // login success
                if (lib_homepage_form == null || lib_homepage_form.IsDisposed)
                {
                    lib_homepage_form = new LibraryHomePageForm();
                    lib_homepage_form.Show();
                }
                else
                {
                    lib_homepage_form.Focus();
                }
                Close();
            }
            else {
                // login fail
                label_error_msg.Visible = Visible;
            }

        }
    }
}
