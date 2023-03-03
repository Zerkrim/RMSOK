using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace RMSOK.Forms
{
    public partial class fOtch : Form
    {
        public fOtch()
        {
            InitializeComponent();
            timer1.Enabled = true;
            timer1.Interval = 10;
            timer1.Start();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            string tempPath = Path.GetTempFileName();

            File.WriteAllBytes(tempPath, Properties.Resources.Приказ_об_увольнении);

            Excel.Application excelApplication = new Excel.Application();
            Excel._Workbook excelWorkbook;
            excelWorkbook = excelApplication.Workbooks.Open(tempPath);

            Excel.Worksheet worksheet = excelWorkbook.Sheets[1];


            Excel.Range r1 = worksheet.Range[worksheet.Cells[24, 2], worksheet.Cells[26, 2]];

            worksheet.Name = "Приказ об увольнении";

            excelApplication.Visible = true;
            excelApplication.UserControl = true;
        }

        private void button4_Click(object sender, EventArgs e)
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            lDateTime.Text = DateTime.Now.ToLongDateString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = excelApp.Workbooks.Add();
            Excel.Worksheet worksheet = workbook.Sheets[1];
            worksheet.Name = "Отчет о сутрудниках";

            worksheet.Cells[2, 6] = "Отчет о сутрудниках";
            worksheet.Cells[11, 1] = "Бутенко Кирилл";
            worksheet.Cells[11, 2] = lDateTime.Text;
            Excel.Range rng1 = worksheet.Range[worksheet.Cells[2, 6], worksheet.Cells[2, 6]];
            rng1.Cells.Font.Name = "Verdana";
            rng1.Cells.Font.Size = 16;
            rng1.Font.Bold = true;

            worksheet.Cells[4, 1] = "ФИО";
            worksheet.Cells[4, 2] = "Паспорт";
            worksheet.Cells[4, 3] = "СНИЛС";
            worksheet.Cells[4, 4] = "ИНН";
            worksheet.Cells[4, 5] = "Подразделение";
            worksheet.Cells[4, 6] = "Адрес";
            worksheet.Cells[4, 7] = "Ставка";
            worksheet.Cells[4, 8] = "Оклад";
            worksheet.Cells[4, 9] = "Номер телефона";
            worksheet.Cells[4, 10] = "Должность";
            worksheet.Cells[4, 11] = "Вид занятости";
            worksheet.Cells[4, 12] = "Пол";

            Excel.Range rng2 = worksheet.Range[worksheet.Cells[4, 1], worksheet.Cells[4, 12]];
            rng2.Font.Bold = true;

            string sqlText = "select * from Personals, Ceha Where Personals.status_ = 'нет' and Personals.fkCeh = Ceha.id_ceh";
            SqlDataAdapter adapter = new SqlDataAdapter(sqlText, Class.DataBase.ConnStr);
            DataTable table = new DataTable();
            adapter.Fill(table);

            worksheet.Columns[1].ColumnWidth = 30;
            worksheet.Columns[2].ColumnWidth = 15;
            worksheet.Columns[3].ColumnWidth = 15;
            worksheet.Columns[4].ColumnWidth = 15;
            worksheet.Columns[5].ColumnWidth = 15;
            worksheet.Columns[6].ColumnWidth = 40;
            worksheet.Columns[7].ColumnWidth = 20;
            worksheet.Columns[8].ColumnWidth = 20;
            worksheet.Columns[9].ColumnWidth = 20;
            worksheet.Columns[10].ColumnWidth = 10;
            worksheet.Columns[11].ColumnWidth = 20;
            worksheet.Columns[12].ColumnWidth = 20;

            int i = 5;
            foreach (DataRow row in table.Rows)
            {
                worksheet.Cells[i, 1] = row["fio"];
                worksheet.Cells[i, 2] = row["pasport"];
                worksheet.Cells[i, 3] = row["snils"];
                worksheet.Cells[i, 4] = row["inn"];
                worksheet.Cells[i, 5] = row[15];
                worksheet.Cells[i, 6] = row["adress"];
                worksheet.Cells[i, 7] = row["stavka"];
                worksheet.Cells[i, 8] = row["oklad"];
                worksheet.Cells[i, 9] = row["nomberphone"];
                worksheet.Cells[i, 10] = row["dolch"];
                worksheet.Cells[i, 11] = row["vidzan"];
                worksheet.Cells[i, 12] = row["gender"];

                i++;
                Excel.Range rng3 = worksheet.Range[worksheet.Cells[4, 1], worksheet.Cells[i - 1, 12]];
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
    }
}
