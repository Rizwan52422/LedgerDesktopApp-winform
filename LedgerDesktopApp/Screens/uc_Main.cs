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
    public partial class uc_Main: UserControl
    {
        public uc_Main()
        {
            InitializeComponent();
        }
        bool sideBarExpand;
        private void uc_Main_Load(object sender, EventArgs e)
        {
            panelRightBarMain.Visible = false;
            sideBarExpand = false;
            panelRightBarMain.Width = panelRightBarMain.MinimumSize.Width;
        }

        private void timerRightSideBar_Tick(object sender, EventArgs e)
        {
            if (sideBarExpand)
            {
                panelRightBarMain.Width -= 10;
                if (panelRightBarMain.Width == panelRightBarMain.MinimumSize.Width)
                {
                    sideBarExpand = false;
                    timerRightSideBar.Stop();
                }
            }
            else
            {
                panelRightBarMain.Width += 10;
                if (panelRightBarMain.Width == panelRightBarMain.MaximumSize.Width)
                {
                    sideBarExpand = true;
                    timerRightSideBar.Stop();
                }
            }
        }

        private void btnGetStartedMain_Click(object sender, EventArgs e)
        {
            panelRightBarMain.Visible = true;
            panelRightBarMain.Height = this.Height;
            timerRightSideBar.Start();
        }

        private void btnRefuseAll_Click(object sender, EventArgs e)
        {
            timerRightSideBar.Start();
        }

        private void btnHideRightPanel_Click(object sender, EventArgs e)
        {
            timerRightSideBar.Start();
        }

        private void btnAcceptAll_Click(object sender, EventArgs e)
        {


        }
    }
}
