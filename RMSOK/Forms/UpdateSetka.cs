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
    public partial class UpdateSetka : Form
    {
        public UpdateSetka()
        {
            InitializeComponent();
        }

        private void LoadDB()
        {
            try
            {
                string sqlText = "select * from TarifSetka";
                SqlDataAdapter adapter = new SqlDataAdapter(sqlText, Class.DataBase.ConnStr);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].HeaderText = "Разряд";
                dataGridView1.Columns[2].HeaderText = "Тариф коэффициента";

                dataGridView1.Columns[2].Width = 130;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Проверьте верность запроса." + ex, "Ошибка БД", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void UpdateSetka_Load_1(object sender, EventArgs e)
        {
            LoadDB();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Добавить запись?", "Сообщение",
              MessageBoxButtons.OKCancel,
              MessageBoxIcon.Question,
              MessageBoxDefaultButton.Button1);
            if (result == DialogResult.OK)
            {
                string sqlText = $@"insert into TarifSetka (razrad, tarifKof) values ('{tbRazrad.Text.ToString()}', '{tbKof.Text.ToString()}')";
                using (SqlConnection con = new SqlConnection(Class.DataBase.ConnStr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(sqlText, con);
                    int kol = cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Запись добавлена."
                        ,
                        "Сообщение",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                LoadDB();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Изменить запись?", "Сообщение",
              MessageBoxButtons.OKCancel,
              MessageBoxIcon.Question,
              MessageBoxDefaultButton.Button1);
            if (result == DialogResult.OK)
            {
                string sqlText = $@"update TarifSetka set razrad = '{tbRazrad.Text.ToString()}', tarifKof = '{tbKof.Text.ToString()}' " +
                                    $"Where id_tarif = '{dataGridView1.CurrentRow.Cells[0].Value.ToString()}'";
                using (SqlConnection con = new SqlConnection(Class.DataBase.ConnStr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(sqlText, con);
                    int kol = cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Запись изменена."
                        ,
                        "Сообщение",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                LoadDB();
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            tbRazrad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tbKof.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Удалить запись?", "Сообщение",
              MessageBoxButtons.OKCancel,
              MessageBoxIcon.Question,
              MessageBoxDefaultButton.Button1);
            if (result == DialogResult.OK)
            {
                string sqlText = $@"delete from TarifSetka Where id_tarif = '{dataGridView1.CurrentRow.Cells[0].Value.ToString()}'";
                using (SqlConnection con = new SqlConnection(Class.DataBase.ConnStr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(sqlText, con);
                    int kol = cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Запись удалена."
                        ,
                        "Сообщение",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                LoadDB();
            }
        }
    }
}
