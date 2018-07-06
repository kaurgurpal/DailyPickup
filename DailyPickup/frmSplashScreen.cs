using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DailyPickup
{
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();
        }
        private int intTickCount = 0;

        private void frmSplashScreen_Load(object sender, EventArgs e)
        {
            try
            {
                tmrSplashScreen.Enabled = true;
            }
            catch { }
        }

        private void tmrSplashScreen_Tick(object sender, EventArgs e)
        {
            try
            {
                intTickCount++;
                if (intTickCount > 5)
                {
                    tmrSplashScreen.Stop();
                    tmrSplashScreen.Dispose();
                    this.Hide();

                    frmLogin frmLogin = new frmLogin();
                    frmLogin.Show();
                    frmLogin.TopMost = true;
                }
            }
            catch { }
        }
    }
}