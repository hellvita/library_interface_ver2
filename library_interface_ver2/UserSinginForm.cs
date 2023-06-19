using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;

namespace library_interface_ver2
{
    public partial class UserSinginForm : Form
    {
        DataBase database = new DataBase();
        private UserLogSinginForm home_form;
        public UserSinginForm()
        {
            InitializeComponent();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            CloseThisForm();
        }

        private void UserSinginForm_Load(object sender, EventArgs e)
        {
            textBox_user_pwd.PasswordChar = '☺';
            textBox_user_pwd.MaxLength = 20;
            textBox_user_fname.MaxLength = 100;
            textBox_user_phone.MaxLength = 18;
            textBox_user_email.MaxLength = 100;
        }

        // singin button
        private void button1_Click(object sender, EventArgs e)
        {
            var userFullName = textBox_user_fname.Text;
            var userPhone = textBox_user_phone.Text;
            var userEmail = textBox_user_email.Text;
            var userPwd = md5.hashPwd(textBox_user_pwd.Text);

            if (DataIsOK(userFullName, userPhone, userEmail)) {

                CloseThisForm();
            }
        }

        private bool DataIsOK(string name, string phone, string email) {
            bool nameOK = false;
            bool phoneOK = false;
            bool emailOK = false;

            nameOK = nameIsOK(name);
            phoneOK = phoneIsOK(phone);

            if (nameOK && phoneOK && emailOK) return true;
            return false;
        }

        private bool nameIsOK(string name) {
            if (name != "" && name != "ПІБ") {
                Regex r = new Regex("^[a-zA-Z а-яА-яїЇєЄіІ']+$");
                Match match = r.Match(name);
                if (match.Success)
                {
                    textBox_user_fname.ForeColor = Color.Black;
                    return true;
                }
            }
            textBox_user_fname.ForeColor = Color.Red;
            textBox_user_fname.Text = "ПІБ";
            return false;
        }

        private bool phoneIsOK(string phone) {


            if (phone != "" && phone != "+380 000 000 00 00") {
                textBox_user_phone.ForeColor = Color.Black;
                string query_str = $"SELECT PHONE FROM users WHERE PHONE = '{phone}'";

                MySqlDataAdapter adapter = new MySqlDataAdapter();
                DataTable table = new DataTable();

                MySqlCommand command = new MySqlCommand(query_str, database.GetConnection());

                adapter.SelectCommand = command;
                adapter.Fill(table);
                if (table.Rows.Count == 0) return true;
            }
            textBox_user_phone.ForeColor = Color.Red;
            textBox_user_phone.Text = "+380 000 000 00 00";
            return false;
        }

        private void CloseThisForm() {
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
    }
}
