using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RMSOK.Class
{
    class DataBank
    {
#pragma warning disable CS0649 // Полю "DataBank.Namestud" нигде не присваивается значение, поэтому оно всегда будет иметь значение по умолчанию null.
        public static string Namestud;
#pragma warning restore CS0649 // Полю "DataBank.Namestud" нигде не присваивается значение, поэтому оно всегда будет иметь значение по умолчанию null.
        public static string ConnStr = $@"Data Source=62.78.81.19;Initial Catalog=RmsokDB;
                                         Persist Security Info=True;
                                         User ID=25-тпБутенкоКС;Password=855696";
        public static SqlConnection con = new SqlConnection(ConnStr);
        public static DataTable Query(string sql)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, ConnStr);
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка обращения к БД!\nПроверьте вводимые данные" + ex.Message, "Уведомление", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return dt;
            }
        }
        static public bool ExecuteSqlCommand(string sql, DataTable toFill)
        {
            //try
            //{
            SqlDataAdapter adapter = new SqlDataAdapter(sql, ConnStr);
            adapter.Fill(toFill);

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Ошибка обращения к БД!\nПроверьте вводимые данные.", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return false;
            //}

            return true;
        }
    }
}
