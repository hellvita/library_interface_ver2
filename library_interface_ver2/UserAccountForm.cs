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
    public partial class UserAccountForm : Form
    {
        DataBase database = new DataBase();
        private LibraryHomePageForm homepage_form;
        private AccDeleteConfirmForm accDelete_form;
        string originalFname;
        string originalPhone;
        string originalEmail;
        public UserAccountForm()
        {
            InitializeComponent();
        }

        private void UserAccountForm_Load(object sender, EventArgs e)
        {
            setUserData();
            textBox_userID.ReadOnly = true;
            textBox_fullName.ReadOnly = true;
            textBox_phone.ReadOnly = true;
            textBox_email.ReadOnly = true;
            button_editFname.Visible = true;
            button_editPhone.Visible = true;
            button_editEmail.Visible = true;
            button_saveFname.Visible = false;
            button_savePhone.Visible = false;
            button_saveEmail.Visible = false;
            textBox_phone.MaxLength = 18;
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            if (homepage_form == null || homepage_form.IsDisposed)
            {
                homepage_form = new LibraryHomePageForm();
                homepage_form.Show();
            }
            else
            {
                homepage_form.Focus();
            }
            Close();
        }

        private void button_editFname_Click(object sender, EventArgs e)
        {
            originalFname = textBox_fullName.Text;
            textBox_fullName.ReadOnly = false;
            button_editFname.Visible = false;
            button_saveFname.Visible = true;
        }

        private void button_editPhone_Click(object sender, EventArgs e)
        {
            originalPhone = textBox_phone.Text;
            textBox_phone.ReadOnly = false;
            button_editPhone.Visible = false;
            button_savePhone.Visible = true;
        }

        private void button_editEmail_Click(object sender, EventArgs e)
        {
            originalEmail = textBox_email.Text;
            textBox_email.ReadOnly = false;
            button_editEmail.Visible = false;
            button_saveEmail.Visible = true;
        }

        private void button_saveFname_Click(object sender, EventArgs e)
        {
            string newFname = textBox_fullName.Text;

            if (nameIsOK(newFname))
            {
                database.openConenection();

                string query_str = $"UPDATE users SET FULL_NAME = '{newFname}' WHERE USER_ID = '{UserLoginForm.ulog}'";
                MySqlCommand command = new MySqlCommand(query_str, database.GetConnection());

                if (command.ExecuteNonQuery() != 1) { 
                    MessageBox.Show("Не вдалося обновити дані ;(", "Помилка!");
                    textBox_fullName.Text = originalFname;
                }

                database.closeConenection();
            }
            else {
                MessageBox.Show("Дані введено не вірно. Спробуйте ще раз.\nВикористовуйте виключно крилицю або латиницю", "ПІБ: помилка!");
                textBox_fullName.Text = originalFname;
            }
                        
            textBox_fullName.ReadOnly = true;
            button_editFname.Visible = true;
            button_saveFname.Visible = false;
        }

        private void button_savePhone_Click(object sender, EventArgs e)
        {
            string newPhone = textBox_phone.Text;

            if (phoneIsOK(newPhone))
            {
                database.openConenection();

                string query_str = $"UPDATE users SET PHONE = '{newPhone}' WHERE USER_ID = '{UserLoginForm.ulog}'";
                MySqlCommand command = new MySqlCommand(query_str, database.GetConnection());

                if (command.ExecuteNonQuery() != 1)
                {
                    MessageBox.Show("Не вдалося обновити дані ;(", "Помилка!");
                    textBox_phone.Text = originalPhone;
                }

                database.closeConenection();
            }
            else
            {
                MessageBox.Show("Дані введено не вірно. Спробуйте ще раз.\nВикористовуйте виключно цифри та дотримуйтесь обмежень.\n(Максимум 18 символів)", "Номер телефону: помилка!");
                textBox_phone.Text = originalPhone;
            }

            textBox_phone.ReadOnly = true;
            button_editPhone.Visible = true;
            button_savePhone.Visible = false;
        }

        private void button_saveEmail_Click(object sender, EventArgs e)
        {
            string newEmail = textBox_email.Text;

            if (emailIsOK(newEmail))
            {
                database.openConenection();

                string query_str = $"UPDATE users SET EMAIL = '{newEmail}' WHERE USER_ID = '{UserLoginForm.ulog}'";
                MySqlCommand command = new MySqlCommand(query_str, database.GetConnection());

                if (command.ExecuteNonQuery() != 1)
                {
                    MessageBox.Show("Не вдалося обновити дані ;(", "Помилка!");
                    textBox_email.Text = originalEmail;
                }
                database.closeConenection();
            }
            else
            {
                MessageBox.Show("Дані введено не вірно. Спробуйте ще раз.\nВикористовуйте лише латиницю та цифри.", "Поштова скринька: помилка!");
                textBox_email.Text = originalEmail;
            }
            textBox_email.ReadOnly = true;
            button_editEmail.Visible = true;
            button_saveEmail.Visible = false;
        }

        private void button_deleteAcc_Click(object sender, EventArgs e)
        {
            if (accDelete_form == null || accDelete_form.IsDisposed)
            {
                accDelete_form = new AccDeleteConfirmForm();
                accDelete_form.Show();
            }
            else
            {
                accDelete_form.Focus();
            }
            Close();
        }

        private void setUserData() {
            database.openConenection();

            string query_str = $"SELECT FULL_NAME FROM users WHERE USER_ID = '{UserLoginForm.ulog}'";
            MySqlCommand command = new MySqlCommand(query_str, database.GetConnection());
            object obj = command.ExecuteScalar();
            string userFnameStr = obj.ToString();

            query_str = $"SELECT PHONE FROM users WHERE USER_ID = '{UserLoginForm.ulog}'";
            command = new MySqlCommand(query_str, database.GetConnection());
            obj = command.ExecuteScalar();
            string userPhoneStr = obj.ToString();

            query_str = $"SELECT EMAIL FROM users WHERE USER_ID = '{UserLoginForm.ulog}'";
            command = new MySqlCommand(query_str, database.GetConnection());
            obj = command.ExecuteScalar();
            string userEmailStr = obj.ToString();

            textBox_userID.Text = UserLoginForm.ulog;
            textBox_fullName.Text = userFnameStr;
            textBox_phone.Text = userPhoneStr;
            textBox_email.Text = userEmailStr;

            database.closeConenection();
        }
        private bool nameIsOK(string name)
        {
            if (name != "" && name != "ПІБ")
            {
                Regex r = new Regex("^[a-zA-Z а-яА-яїЇєЄіІ']+$");
                Match match = r.Match(name);
                if (match.Success)
                {
                    return true;
                }
            }

            return false;
        }
        private bool phoneIsOK(string phone)
        {
            if (phone != "" && phone != "+380 000 000 00 00")
            {
                Regex r = new Regex("^[0-9+ ']+$");
                Match match = r.Match(phone);
                if (match.Success)
                {
                    string query_str = $"SELECT PHONE FROM users WHERE PHONE = '{phone}'";

                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    DataTable table = new DataTable();

                    MySqlCommand command = new MySqlCommand(query_str, database.GetConnection());

                    adapter.SelectCommand = command;
                    adapter.Fill(table);
                    if (table.Rows.Count == 0) return true;
                }
            }
            return false;
        }
        private bool emailIsOK(string email)
        {
            if (email != "" && email != "hisentia@gmail.com")
            {
                Regex r = new Regex("^[a-zA-Z0-9_@.']+$");
                Match match = r.Match(email);
                if (match.Success) {
                    string query_str = $"SELECT EMAIL FROM users WHERE EMAIL = '{email}'";

                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    DataTable table = new DataTable();

                    MySqlCommand command = new MySqlCommand(query_str, database.GetConnection());

                    adapter.SelectCommand = command;
                    adapter.Fill(table);
                    if (table.Rows.Count == 0) return true;
                }                    
            }
            return false;
        }
    }
}
