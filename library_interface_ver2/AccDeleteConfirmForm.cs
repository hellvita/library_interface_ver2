﻿using System;
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
    public partial class AccDeleteConfirmForm : Form
    {
        DataBase database = new DataBase();
        private UserLogSinginForm loginSingin_form;
        private UserAccountForm uacc_form;
        public AccDeleteConfirmForm()
        {
            InitializeComponent();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            database.openConenection();
            string query_deleteAcc = $"DELETE FROM users WHERE USER_ID = {UserLoginForm.ulog}";
            MySqlCommand command = new MySqlCommand(query_deleteAcc, database.GetConnection());

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Ваш акаунт було видалено...", "Успіх!");
            }
            else { MessageBox.Show("Сталася помилка видалення даних!", "Помилка!"); }


            database.closeConenection();

            if (loginSingin_form == null || loginSingin_form.IsDisposed)
            {
                loginSingin_form = new UserLogSinginForm();
                loginSingin_form.Show();
            }
            else
            {
                loginSingin_form.Focus();
            }
            Close();
        }

        private void button_cancle_Click(object sender, EventArgs e)
        {
            if (uacc_form == null || uacc_form.IsDisposed)
            {
                uacc_form = new UserAccountForm();
                uacc_form.Show();
            }
            else
            {
                uacc_form.Focus();
            }
            Close();
        }
    }
}
