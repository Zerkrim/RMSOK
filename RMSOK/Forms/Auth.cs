using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMSOK.Forms
{
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPass.Checked == true)
                tbPass.UseSystemPasswordChar = false;
            else
                tbPass.UseSystemPasswordChar = true;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string sqlExpression = "select loginU, passU from Users Where loginU = '" + tbLogin.Text + "' " +
"and passU = '" + tbPass.Text + "'";
            using (SqlConnection connect = new SqlConnection(Class.DataBase.ConnStr))
            {
                connect.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connect);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        string Имя_пользователя = tbLogin.Text;
                        string Пароль_пользователя = tbPass.Text;
                        this.Hide();
                        Forms.MainMenu mn = new Forms.MainMenu();
                        mn.Show();
                    }
                    else
                    {
                        MessageBox.Show("Неверный логин или пароль");
                    }
                }
            }
        }
    }
}
