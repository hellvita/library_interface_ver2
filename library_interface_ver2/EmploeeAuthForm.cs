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
    public partial class EmploeeAuthForm : Form
    {
        DataBase database = new DataBase();
        private LibrarianHomePageForm homepage_form;
        public static int emploeeID = 1;
        public static int positionID = 1;
        public static int positionNameID = 1;
        public EmploeeAuthForm()
        {
            InitializeComponent();
        }

        private void EmploeeAuthForm_Load(object sender, EventArgs e)
        {
            textBox_emloee_pwd.PasswordChar = '•';
            textBox_emloee_pwd.MaxLength = 20;
            textBox_emloee_login.MaxLength = 10;
        }

        // login button
        private void button1_Click(object sender, EventArgs e)
        {
            database.openConenection();

            var emplLogin = md5.hashPwd(textBox_emloee_login.Text);
            var emplPwd = md5.hashPwd(textBox_emloee_pwd.Text);


            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            if (emplLogin != "" && emplPwd != "")
            {

                string query_str = $"SELECT * FROM login_attributes WHERE EMPLOYEE_LOGIN = '{emplLogin}' AND EMPLOYEE_PASSWORD = '{emplPwd}'";

                MySqlCommand command = new MySqlCommand(query_str, database.GetConnection());

                adapter.SelectCommand = command;
                adapter.Fill(table);

                if (table.Rows.Count == 1)
                {
                    setEmplNameAndPos(emplLogin);
                    // login success
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
                else
                {
                    // login fail
                    label_error_msg.Visible = Visible;
                }
                database.closeConenection();
            }
            else
            {
                // login fail
                label_error_msg.Visible = Visible;
            }
        }

        private void setEmplNameAndPos(string login) {
            string query_str;
            MySqlCommand command;

            query_str = $"SELECT EMPLOYEE_ID FROM login_attributes WHERE EMPLOYEE_LOGIN = '{login}'";
            command = new MySqlCommand(query_str, database.GetConnection());
            emploeeID = (int)command.ExecuteScalar();

            query_str = $"SELECT POSITION_ID FROM all_employees WHERE EMPLOYEE_ID = {emploeeID}";
            command = new MySqlCommand(query_str, database.GetConnection());
            positionID = (int)command.ExecuteScalar();

            query_str = $"SELECT POSITION_NAME_ID FROM positions WHERE POSITION_ID = '{positionID}';";
            command = new MySqlCommand(query_str, database.GetConnection());
            positionNameID = (int)command.ExecuteScalar();

        }
    }
}
