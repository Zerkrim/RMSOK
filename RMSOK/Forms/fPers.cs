using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace RMSOK.Forms
{
    public partial class fPers : Form
    {
        public fPers()
        {
            InitializeComponent();
            //Защита от дурака combobox
            cbCeha.KeyPress += (sender, e) => e.Handled = true;
            cbVidZan.KeyPress += (sender, e) => e.Handled = true;
            cbGender.KeyPress += (sender, e) => e.Handled = true;

            cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbCeha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbVidZan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            tbIdCeh.Text = Convert.ToString(cbCeha.SelectedIndex);
            tbIdCeh.Text = Regex.Replace(tbIdCeh.Text, "[-]", ""); //Убирает символ "-"

            

            timer1.Enabled = true;
            timer1.Interval = 10;
            timer1.Start();
        }

        private void fPers_Load(object sender, EventArgs e)
        {
            this.cehaTableAdapter.Fill(this.rmsokDBDataSet.Ceha);
            SelectTablePersonals(); //Загрузка таблицы
            dgvPersonal.AutoResizeColumns(); //Автоподбор ширины ячеек
        }

        private void SelectTablePersonals()
        {
            try
            {
                string sqlText = "select * from Personals, Ceha Where Personals.status_ = 'нет' and Personals.fkCeh = Ceha.id_ceh";
                SqlDataAdapter adapter = new SqlDataAdapter(sqlText, Class.DataBase.ConnStr);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvPersonal.DataSource = table;
                dgvPersonal.Columns[0].Visible = false;
                dgvPersonal.Columns[1].HeaderText = "Полное имя";
                dgvPersonal.Columns[2].HeaderText = "Паспорт";
                dgvPersonal.Columns[3].HeaderText = "СНИЛС";
                dgvPersonal.Columns[4].HeaderText = "ИНН";
                dgvPersonal.Columns[15].HeaderText = "Подразделение";
                dgvPersonal.Columns[5].Visible = false;
                dgvPersonal.Columns[6].HeaderText = "Адрес проживания";
                dgvPersonal.Columns[7].HeaderText = "Ставка";
                dgvPersonal.Columns[8].HeaderText = "Оклад";
                dgvPersonal.Columns[9].HeaderText = "Номер телефона";
                dgvPersonal.Columns[10].HeaderText = "Должность";
                dgvPersonal.Columns[11].HeaderText = "Вид занятости";
                dgvPersonal.Columns[12].HeaderText = "Пол";
                dgvPersonal.Columns[13].Visible = false;

                dgvPersonal.Columns[14].Visible = false;
                dgvPersonal.Columns[16].Visible = false;
                dgvPersonal.Columns[17].Visible = false;
                dgvPersonal.Columns[18].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Проверьте верность запроса." + ex, "Ошибка БД", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void cbCeha_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbIdCeh.Text = Convert.ToString(cbCeha.SelectedIndex);
            tbIdCeh.Text = Regex.Replace(tbIdCeh.Text, "[-]", ""); //Убирает символ "-"
        }

        private void btnTarif_Click(object sender, EventArgs e)
        {
            Forms.fTarifSet ftarset = new Forms.fTarifSet();
            ftarset.Show();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            //Добавление записи
           using (SqlConnection con = new SqlConnection(Class.DataBase.ConnStr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = $@"SET ANSI_WARNINGS OFF; 
                insert into Personals values (@fio, @pasport, @snils, @inn, @fkCeh, 
                @adress, @stavka, @oklad, 
                @nomberphone, @dolch, @vidzan, @gender, 
                @status_)";

                cmd.Parameters.Add("@fio", SqlDbType.VarChar);
                cmd.Parameters.Add("@pasport", SqlDbType.VarChar);
                cmd.Parameters.Add("@snils", SqlDbType.VarChar);
                cmd.Parameters.Add("@inn", SqlDbType.VarChar);
                cmd.Parameters.Add("@fkCeh", SqlDbType.Int);
                cmd.Parameters.Add("@adress", SqlDbType.VarChar);
                cmd.Parameters.Add("@stavka", SqlDbType.Float);
                cmd.Parameters.Add("@oklad", SqlDbType.Money);
                cmd.Parameters.Add("@nomberphone", SqlDbType.VarChar);
                cmd.Parameters.Add("@dolch", SqlDbType.VarChar);
                cmd.Parameters.Add("@vidzan", SqlDbType.VarChar);
                cmd.Parameters.Add("@gender", SqlDbType.VarChar);
                cmd.Parameters.Add("@status_", SqlDbType.VarChar);

                cmd.Parameters["@fio"].Value = tbFIO.Text;
                cmd.Parameters["@pasport"].Value = mtbPasport.Text;
                cmd.Parameters["@snils"].Value = mtbSnils.Text;
                cmd.Parameters["@inn"].Value = mtbInn.Text;
                cmd.Parameters["@fkCeh"].Value = tbIdCeh.Text;
                cmd.Parameters["@adress"].Value = tbAdress.Text;
                cmd.Parameters["@stavka"].Value = tbStavka.Text;
                cmd.Parameters["@oklad"].Value = tbOklad.Text;
                cmd.Parameters["@nomberphone"].Value = mtbPhone.Text;
                cmd.Parameters["@dolch"].Value = tbDolch.Text;
                cmd.Parameters["@vidzan"].Value = cbVidZan.Text;
                cmd.Parameters["@gender"].Value = cbGender.Text;
                cmd.Parameters["@status_"].Value = "нет";

                cmd.ExecuteNonQuery();
                MessageBox.Show("Запись доавблена");

                SelectTablePersonals();

                CreateExcelNaim_na_Raboty();
           }

        }
        private void CreateExcelNaim_na_Raboty()
        {
            //Создание трудового договора
            string tempPath = Path.GetTempFileName();

            File.WriteAllBytes(tempPath, Properties.Resources.Трудовой_договор);

            Excel.Application excelApplication = new Excel.Application();
            Excel._Workbook excelWorkbook;
            excelWorkbook = excelApplication.Workbooks.Open(tempPath);

            Excel.Worksheet worksheet = excelWorkbook.Sheets[1];


            Excel.Range r1 = worksheet.Range[worksheet.Cells[24, 2], worksheet.Cells[26, 2]];

            worksheet.Name = "Трудовой договор";

            string sqlText = $@"select * from Personals, Ceha";
           // Where id_pers = " + dgvPersonal.CurrentRow.Cells[0].Value.ToString();

            SqlConnection conn = new SqlConnection(Class.DataBank.ConnStr);
            using (SqlCommand cmd = new SqlCommand(sqlText, conn))
            {
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        /*worksheet.Cells[2, 3] = dr["fio"];
                        worksheet.Cells[6, 3] = dr["fio"];
                        worksheet.Cells[8, 3] = dr["date_time"];
                        worksheet.Cells[8, 5] = dr["inn"];
                        worksheet.Cells[8, 7] = dr["snils"];
                        worksheet.Cells[10, 9] = dr["oklad"];
                        worksheet.Cells[12, 3] = dr["dolgnost"];
                        worksheet.Cells[14, 3] = dr["name_ceh"];
                        worksheet.Cells[16, 3] = dr["vid_zanaytosti"];
                        worksheet.Cells[18, 3] = dr["kol_stavok"];
                        worksheet.Cells[12, 9] = dr["fot"];
                        worksheet.Cells[14, 9] = dr["avans"];*/
                    }
                }
            }
            excelApplication.Visible = true;
            excelApplication.UserControl = true;
        }

        private void dgvPersonal_DoubleClick(object sender, EventArgs e)
        {
            tbFIO.Text = dgvPersonal.CurrentRow.Cells[1].Value.ToString();
            mtbPasport.Text = dgvPersonal.CurrentRow.Cells[2].Value.ToString();
            mtbSnils.Text = dgvPersonal.CurrentRow.Cells[3].Value.ToString();
            mtbInn.Text = dgvPersonal.CurrentRow.Cells[4].Value.ToString();
            cbCeha.SelectedItem = dgvPersonal.CurrentRow.Cells[5].Value.ToString();
            tbAdress.Text = dgvPersonal.CurrentRow.Cells[6].Value.ToString();
            tbStavka.Text = dgvPersonal.CurrentRow.Cells[7].Value.ToString();
            tbOklad.Text = dgvPersonal.CurrentRow.Cells[8].Value.ToString();
            mtbPhone.Text = dgvPersonal.CurrentRow.Cells[9].Value.ToString();
            tbDolch.Text = dgvPersonal.CurrentRow.Cells[10].Value.ToString();
            cbVidZan.Text = dgvPersonal.CurrentRow.Cells[11].Value.ToString();
            cbGender.Text = dgvPersonal.CurrentRow.Cells[12].Value.ToString();

            tbCehName.Text = dgvPersonal.CurrentRow.Cells[15].Value.ToString();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Изменить запись?", "Сообщение",
              MessageBoxButtons.OKCancel,
              MessageBoxIcon.Question,
              MessageBoxDefaultButton.Button1);
            if (result == DialogResult.OK)
            {
                string sqlText = $@"update Personals set fio = '{tbFIO.Text.ToString()}', 
                                    pasport = '{mtbPasport.Text.ToString()}', snils = '{mtbSnils.Text.ToString()}', 
                                    inn = '{mtbInn.Text.ToString()}', 
                                    fkCeh = '{tbIdCeh.Text.ToString()}', adress = '{tbAdress.Text.ToString()}', 
                                    stavka = '{tbStavka.Text.ToString()}', oklad = '{tbOklad.Text.ToString()}', 
                                    nomberphone = '{mtbPhone.Text.ToString()}', dolch = '{tbDolch.Text.ToString()}', 
                                    vidzan = '{cbVidZan.Text.ToString()}', gender = '{cbGender.Text.ToString()}', 
                                    status_ = 'нет' " +
                                    $"Where id_per = '{dgvPersonal.CurrentRow.Cells[0].Value.ToString()}'";
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
                SelectTablePersonals();
            }
        }

        private void ExcelUvolen()
        {
            string tempPath = Path.GetTempFileName();

            File.WriteAllBytes(tempPath, Properties.Resources.Приказ_об_увольнении);

            Excel.Application excelApplication = new Excel.Application();
            Excel._Workbook excelWorkbook;
            excelWorkbook = excelApplication.Workbooks.Open(tempPath);

            Excel.Worksheet worksheet = excelWorkbook.Sheets[1];


            Excel.Range r1 = worksheet.Range[worksheet.Cells[24, 2], worksheet.Cells[26, 2]];

            worksheet.Name = "Приказ об увольнении";

                        worksheet.Cells[17, 1] = tbFIO.Text;
                        worksheet.Cells[19, 1] = tbCehName.Text;
                        worksheet.Cells[22, 1] = tbDolch.Text;
                        worksheet.Cells[43, 9] = lDateTime.Text;
                        worksheet.Cells[12, 6] = lDateTime.Text;

            excelApplication.Visible = true;
            excelApplication.UserControl = true;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Добавить в корзину?", "Сообщение",
              MessageBoxButtons.OKCancel,
              MessageBoxIcon.Question,
              MessageBoxDefaultButton.Button1);
            if (result == DialogResult.OK)
            {
                string sqlText = $@"update Personals set 
                                    status_ = 'да' " +
                                    $"Where id_per = '{dgvPersonal.CurrentRow.Cells[0].Value.ToString()}'";
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
                SelectTablePersonals();
                ExcelUvolen();
            }
        }

        private void LoadThach()
        {
            try
            {
                string sqlText = "select * from Personals, Ceha Where Personals.status_ = 'да' and Personals.fkCeh = Ceha.id_ceh";
                SqlDataAdapter adapter = new SqlDataAdapter(sqlText, Class.DataBase.ConnStr);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvPersonal.DataSource = table;
                dgvPersonal.Columns[0].Visible = false;
                dgvPersonal.Columns[1].HeaderText = "Полное имя";
                dgvPersonal.Columns[2].HeaderText = "Паспорт";
                dgvPersonal.Columns[3].HeaderText = "СНИЛС";
                dgvPersonal.Columns[4].HeaderText = "ИНН";
                dgvPersonal.Columns[15].HeaderText = "Подразделение";
                dgvPersonal.Columns[5].Visible = false;
                dgvPersonal.Columns[6].HeaderText = "Адрес проживания";
                dgvPersonal.Columns[7].HeaderText = "Ставка";
                dgvPersonal.Columns[8].HeaderText = "Оклад";
                dgvPersonal.Columns[9].HeaderText = "Номер телефона";
                dgvPersonal.Columns[10].HeaderText = "Должность";
                dgvPersonal.Columns[11].HeaderText = "Вид занятости";
                dgvPersonal.Columns[12].HeaderText = "Пол";
                dgvPersonal.Columns[13].Visible = false;

                dgvPersonal.Columns[14].Visible = false;
                dgvPersonal.Columns[16].Visible = false;
                dgvPersonal.Columns[17].Visible = false;
                dgvPersonal.Columns[18].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Проверьте верность запроса." + ex, "Ошибка БД", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnTrach_Click(object sender, EventArgs e)
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

        private void cbLoadTrach_CheckedChanged(object sender, EventArgs e)
        {
            if (cbLoadTrach.Checked == false)
            {
                SelectTablePersonals();

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
                LoadThach();

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
                string sqlText = $@"update Personals set 
                                    status_ = 'нет' " +
                                    $"Where id_per = '{dgvPersonal.CurrentRow.Cells[0].Value.ToString()}'";
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
                LoadThach();
            }
        }

        private void btnDeleted_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Удалить запись?", "Сообщение",
               MessageBoxButtons.OKCancel,
               MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button1);
            string sqlTextDel = "delete from Personals "
                    + "Where id_per = '" + dgvPersonal.CurrentRow.Cells[0].Value.ToString() + "'";
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
            LoadThach();
        }

        private void btnDogovor_Click(object sender, EventArgs e)
        {
            string tempPath = Path.GetTempFileName();

            File.WriteAllBytes(tempPath, Properties.Resources.Трудовой_договор);

            Excel.Application excelApplication = new Excel.Application();
            Excel._Workbook excelWorkbook;
            excelWorkbook = excelApplication.Workbooks.Open(tempPath);

            Excel.Worksheet worksheet = excelWorkbook.Sheets[1];


            Excel.Range r1 = worksheet.Range[worksheet.Cells[24, 2], worksheet.Cells[26, 2]];

            worksheet.Name = "Трудовой договор";

            string sqlText = $@"select * from Personals, Ceha";
            // Where id_pers = " + dgvPersonal.CurrentRow.Cells[0].Value.ToString();

            SqlConnection conn = new SqlConnection(Class.DataBank.ConnStr);
            using (SqlCommand cmd = new SqlCommand(sqlText, conn))
            {
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        /*worksheet.Cells[2, 3] = dr["fio"];
                        worksheet.Cells[6, 3] = dr["fio"];
                        worksheet.Cells[8, 3] = dr["date_time"];
                        worksheet.Cells[8, 5] = dr["inn"];
                        worksheet.Cells[8, 7] = dr["snils"];
                        worksheet.Cells[10, 9] = dr["oklad"];
                        worksheet.Cells[12, 3] = dr["dolgnost"];
                        worksheet.Cells[14, 3] = dr["name_ceh"];
                        worksheet.Cells[16, 3] = dr["vid_zanaytosti"];
                        worksheet.Cells[18, 3] = dr["kol_stavok"];
                        worksheet.Cells[12, 9] = dr["fot"];
                        worksheet.Cells[14, 9] = dr["avans"];*/
                    }
                }
            }
            excelApplication.Visible = true;
            excelApplication.UserControl = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lDateTime.Text = DateTime.Now.ToLongDateString();
        }
    }
}
