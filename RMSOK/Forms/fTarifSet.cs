using RMSOK.RmsokDBDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMSOK.Forms
{
    public partial class fTarifSet : Form
    {
        public fTarifSet()
        {
            InitializeComponent();
        }

        private void fTarifSet_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rmsokDBDataSet.TarifSetka". При необходимости она может быть перемещена или удалена.
            this.tarifSetkaTableAdapter.Fill(this.rmsokDBDataSet.TarifSetka);

        }

        private void изменитьСеткуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateSetka us = new UpdateSetka();
            this.Close();
            us.Show();
        }
    }
}
