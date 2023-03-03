using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace RMSOK.Forms
{
    public partial class fCeha : Form
    {
        public fCeha()
        {
            InitializeComponent();

            timer1.Enabled = true;
            timer1.Interval = 10;
            timer1.Start();
        }

        private void LoadDGV()
        {
            try
            {
                string sqlText = "select * from Ceha Where status_ = 'нет'";
                SqlDataAdapter adapter = new SqlDataAdapter(sqlText, Class.DataBase.ConnStr);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvCeha.DataSource = table;
                dgvCeha.Columns[0].Visible = false;
                dgvCeha.Columns[1].HeaderText = "Наименование";
                dgvCeha.Columns[2].HeaderText = "Адрес";
                dgvCeha.Columns[3].HeaderText = "Руководитель";
                dgvCeha.Columns[4].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Проверьте верность запроса." + ex, "Ошибка БД", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void fCeha_Load(object sender, EventArgs e)
        {
            LoadDGV();
            dgvCeha.AutoResizeColumns();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(Class.DataBase.ConnStr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = $@"SET ANSI_WARNINGS OFF; 
                insert into Ceha values (@naimen, @adress, @rukovod, 
                @status_)";

                cmd.Parameters.Add("@naimen", SqlDbType.VarChar);
                cmd.Parameters.Add("@adress", SqlDbType.VarChar);
                cmd.Parameters.Add("@rukovod", SqlDbType.VarChar);
                cmd.Parameters.Add("@status_", SqlDbType.VarChar);

                cmd.Parameters["@fio"].Value = tbNaim.Text;
                cmd.Parameters["@pasport"].Value = tbAress.Text;
                cmd.Parameters["@snils"].Value = tbRukov.Text;
                cmd.Parameters["@status_"].Value = "нет";

                cmd.ExecuteNonQuery();
                MessageBox.Show("Запись добавлена");

                LoadDGV();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Изменить запись?", "Сообщение",
              MessageBoxButtons.OKCancel,
              MessageBoxIcon.Question,
              MessageBoxDefaultButton.Button1);
            if (result == DialogResult.OK)
            {
                string sqlText = $@"update Ceha set naimen = '{tbNaim.Text.ToString()}', 
                                    adress = '{tbAress.Text.ToString()}', rukovod = '{tbRukov.Text.ToString()}', 
                                    status_ = 'нет' " +
                                    $"Where id_ceh = '{dgvCeha.CurrentRow.Cells[0].Value.ToString()}'";
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
                LoadDGV();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Добавить в корзину?", "Сообщение",
              MessageBoxButtons.OKCancel,
              MessageBoxIcon.Question,
              MessageBoxDefaultButton.Button1);
            if (result == DialogResult.OK)
            {
                string sqlText = $@"update Ceha set 
                                    status_ = 'да' " +
                                    $"Where id_ceh = '{dgvCeha.CurrentRow.Cells[0].Value.ToString()}'";
                using (SqlConnection con = new SqlConnection(Class.DataBase.ConnStr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(sqlText, con);
                    int kol = cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Запись добавлена в корзину."
                        ,
                        "Сообщение",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                LoadDGV();
            }
        }

        private void btnTrah_Click(object sender, EventArgs e)
        {
            if (cbLoadTrach.Checked == false)
            {
                cbLoadTrach.Checked = true;

            }
            else
            {
                cbLoadTrach.Checked = false;

            }
        }

        private void LoadTrach()
        {
            try
            {
                string sqlText = "select * from Ceha Where status_ = 'да'";
                SqlDataAdapter adapter = new SqlDataAdapter(sqlText, Class.DataBase.ConnStr);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvCeha.DataSource = table;
                dgvCeha.Columns[0].Visible = false;
                dgvCeha.Columns[1].HeaderText = "Наименование";
                dgvCeha.Columns[2].HeaderText = "Адрес";
                dgvCeha.Columns[3].HeaderText = "Руководитель";
                dgvCeha.Columns[4].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Проверьте верность запроса." + ex, "Ошибка БД", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void cbLoadTrach_CheckedChanged(object sender, EventArgs e)
        {
            if (cbLoadTrach.Checked == false)
            {
                LoadDGV();

                btnInsert.Enabled = true;
                btnInsert.Visible = true;

                btnUpdate.Enabled = true;
                btnUpdate.Visible = true;

                tbBackRow.Enabled = false;
                tbBackRow.Visible = false;

                btnDeleted.Enabled = false;
                btnDeleted.Visible = false;
            }
            else
            {
                LoadTrach();

                btnInsert.Enabled = false;
                btnInsert.Visible = false;

                btnUpdate.Enabled = false;
                btnUpdate.Visible = false;

                tbBackRow.Enabled = true;
                tbBackRow.Visible = true;

                btnDeleted.Enabled = true;
                btnDeleted.Visible = true;
            }
        }

        private void tbBackRow_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Восстановить запись?", "Сообщение",
              MessageBoxButtons.OKCancel,
              MessageBoxIcon.Question,
              MessageBoxDefaultButton.Button1);
            if (result == DialogResult.OK)
            {
                string sqlText = $@"update Ceha set 
                                    status_ = 'нет' " +
                                    $"Where id_ceh = '{dgvCeha.CurrentRow.Cells[0].Value.ToString()}'";
                using (SqlConnection con = new SqlConnection(Class.DataBase.ConnStr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(sqlText, con);
                    int kol = cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Запись восстановлена."
                        ,
                        "Сообщение",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                LoadTrach();
            }
        }

        private void btnDeleted_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Удалить запись?", "Сообщение",
               MessageBoxButtons.OKCancel,
               MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button1);
            string sqlTextDel = "delete from Ceha "
                    + "Where id_ceh = '" + dgvCeha.CurrentRow.Cells[0].Value.ToString() + "'";
            using (SqlConnection con2 = new SqlConnection(Class.DataBase.ConnStr))
            {
                con2.Open();
                SqlCommand cmd = new SqlCommand(sqlTextDel, con2);
                int kol = cmd.ExecuteNonQuery();
                con2.Close();

                MessageBox.Show("Записей удалено: "
                    + kol.ToString(),
                    "Сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            LoadTrach();
        }

        private void dgvCeha_DoubleClick(object sender, EventArgs e)
        {
            tbNaim.Text =dgvCeha.CurrentRow.Cells[1].Value.ToString();
            tbAress.Text = dgvCeha.CurrentRow.Cells[2].Value.ToString();
            tbRukov.Text = dgvCeha.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnOtch_Click(object sender, EventArgs e)
        {
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = excelApp.Workbooks.Add();
            Excel.Worksheet worksheet = workbook.Sheets[1];
            worksheet.Name = "Отчет по подразделениям";

            worksheet.Cells[2, 2] = "Отчет по подразделениям";
            worksheet.Cells[12, 1] = "Бутенко Кирилл";
            worksheet.Cells[12, 2] = lDateTime.Text;
            Excel.Range rng1 = worksheet.Range[worksheet.Cells[2, 2], worksheet.Cells[2, 2]];
            rng1.Cells.Font.Name = "Verdana";
            rng1.Cells.Font.Size = 16;
            rng1.Font.Bold = true;

            worksheet.Cells[4, 1] = "Наименование подразделения";
            worksheet.Cells[4, 2] = "Адрес подразделения";
            worksheet.Cells[4, 3] = "Руководитель подразделения";

            Excel.Range rng2 = worksheet.Range[worksheet.Cells[4, 1], worksheet.Cells[4, 3]];
            rng2.Font.Bold = true;

            string sqlText = "select * from Ceha Where status_ = 'нет'";
            SqlDataAdapter adapter = new SqlDataAdapter(sqlText, Class.DataBase.ConnStr);
            DataTable table = new DataTable();
            adapter.Fill(table);

            int i = 5;
            foreach (DataRow row in table.Rows)
            {
                worksheet.Cells[i, 1] = row["naimen"];
                worksheet.Cells[i, 2] = row["adress"];
                worksheet.Cells[i, 3] = row["rukovod"];
                i++;
                Excel.Range rng3 = worksheet.Range[worksheet.Cells[4, 1], worksheet.Cells[i - 1, 3]];
                rng3.Borders.get_Item(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous;
                rng3.Borders.get_Item(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous;
                rng3.Borders.get_Item(Excel.XlBordersIndex.xlInsideHorizontal).LineStyle = Excel.XlLineStyle.xlContinuous;
                rng3.Borders.get_Item(Excel.XlBordersIndex.xlInsideVertical).LineStyle = Excel.XlLineStyle.xlContinuous;
                rng3.Borders.get_Item(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous;
                rng3.Borders.get_Item(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous;
            }
            excelApp.Visible = true;
            excelApp.UserControl = true;
        }

        private void lDateTime_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lDateTime.Text = DateTime.Now.ToLongDateString();
        }
    }
}
