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
    public partial class UserLoginForm : Form
    {
        DataBase database = new DataBase();
        private UserLogSinginForm home_form;
        public UserLoginForm()
        {
            InitializeComponent();
        }

        private void UserLoginForm_Load(object sender, EventArgs e)
        {

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
    }
}
