using LedgerDesktopApp.Screens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LedgerDesktopApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            panelRightBarMain.Visible = false;
            sideBarExpand = false;
            panelRightBarMain.Width = panelRightBarMain.MinimumSize.Width;
        }
        bool sideBarExpand;
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

        private void MoveToDevicesInfoPage()
        {
            uc_MainLayout uc1 = new uc_MainLayout();
            uc1.Dock = DockStyle.Fill;
            this.Controls.Add(uc1);
            uc1.BringToFront();
            this.Dock = DockStyle.Fill;

            panelRightBarMain.Visible = false;
            panelRightBarMain.Width = panelRightBarMain.MinimumSize.Width;
            sideBarExpand = false;
            timerRightSideBar.Stop();

            // hide the main panel
            panelMenu.Visible = false;
            panelMenu.Width = panelRightBarMain.MinimumSize.Width;
        }
        private void btnGetStartedMain_Click(object sender, EventArgs e)
        {
            panelRightBarMain.Visible = true;
            panelRightBarMain.Height = this.Height;
            timerRightSideBar.Start();
        }

        private void btnHideRightPanel_Click(object sender, EventArgs e)
        {
            timerRightSideBar.Start();
        }

        private void frmMain_ResizeBegin(object sender, EventArgs e)
        {
            panelRightBarMain.Height = this.Height;
        }

        private void frmMain_SizeChanged(object sender, EventArgs e)
        {
            panelRightBarMain.Height = this.Height;
        }

        private void btnAcceptAll_Click(object sender, EventArgs e)
        {
            MoveToDevicesInfoPage();
        }

        private void btnRefuseAll_Click(object sender, EventArgs e)
        {
            MoveToDevicesInfoPage();
        }

        private void btnNoDevice_Click(object sender, EventArgs e)
        {
            timerRightSideBar.Start();
        }
    }
}
