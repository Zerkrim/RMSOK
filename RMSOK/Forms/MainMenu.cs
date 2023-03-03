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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnShowCeh_Click(object sender, EventArgs e)
        {
            /*while (tlpMainPanel.Controls.Count > 0)
            {
                tlpMainPanel.Controls[0].Dispose();
            }
            var ucceh = new UserControls.ucCeha();
            tlpMainPanel.Controls.Add(ucceh);*/

            Forms.fCeha fceha = new Forms.fCeha();
            fceha.Show();

        }

        private void btnShowPers_Click(object sender, EventArgs e)
        {
            /* while (tlpMainPanel.Controls.Count > 0)
             {
                 tlpMainPanel.Controls[0].Dispose();
             }
             var ucpers = new UserControls.ucPers();
             tlpMainPanel.Controls.Add(ucpers);*/

            Forms.fPers fpers = new Forms.fPers();
            fpers.Show();
        }

        private void btnShowOtch_Click(object sender, EventArgs e)
        {
            Forms.fOtch fotch = new Forms.fOtch();
            fotch.Show();
        }

        private void btnShowTarif_Click(object sender, EventArgs e)
        {
            Forms.fTarifSet ftarset = new Forms.fTarifSet();
            ftarset.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Forms.Auth at = new Forms.Auth();
            this.Hide();
            at.Show();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
