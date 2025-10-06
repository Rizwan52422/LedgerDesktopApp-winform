using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LedgerDesktopApp.Screens
{
    public partial class uc_MainLayout : UserControl
    {
        public uc_MainLayout()
        {
            InitializeComponent();
        }
        private void ChangeHoverAffect(Panel panel)
        {
            panel.BackColor = Color.FromArgb(62, 65, 63);
        }

        private void ChangetheLeaveAffect(Panel panel)
        {
            panel.BackColor = Color.FromArgb(35, 40, 30);
        }
        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            ChangeHoverAffect(panel1);
            btnLedgerStax.Visible = true;
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            ChangetheLeaveAffect(panel1);
            btnLedgerStax.Visible = false;

        }

        private void panel2_MouseEnter(object sender, EventArgs e)
        {
            ChangeHoverAffect(panel2);
            btnLedgerFlex.Visible = true;
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            ChangetheLeaveAffect(panel2);
            btnLedgerFlex.Visible = false;
        }

        private void panel3_MouseEnter(object sender, EventArgs e)
        {
            ChangeHoverAffect(panel3);
            btnLedgerNanoS.Visible = true;
        }

        private void panel3_MouseLeave(object sender, EventArgs e)
        {
            ChangetheLeaveAffect(panel3);
            btnLedgerNanoS.Visible = false;
        }

        private void panel4_MouseEnter(object sender, EventArgs e)
        {
            ChangeHoverAffect(panel4);
            btnLedgerNanoSPlus.Visible = true;
        }

        private void panel4_MouseLeave(object sender, EventArgs e)
        {
            ChangetheLeaveAffect(panel4);
            btnLedgerNanoSPlus.Visible = false;
        }

        private void panel5_MouseEnter(object sender, EventArgs e)
        {
            ChangeHoverAffect(panel5);
            btnLedgerNanoX.Visible = true;
        }

        private void panel5_MouseLeave(object sender, EventArgs e)
        {
            ChangetheLeaveAffect(panel5);
            btnLedgerNanoX.Visible = false;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            frmMain frmMain = (frmMain)Application.OpenForms["frmMain"];
            frmMain.Controls.Clear();

            uc_MainPage uc1 = new uc_MainPage();
            uc1.Dock = DockStyle.Fill;

            frmMain.Controls.Add(uc1);

        }
    }
}
