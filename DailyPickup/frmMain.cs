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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        public static int intUserID;
        public static string strUserType = "";
        public static string strUserName = "";

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Application.ExitThread();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Alpha Net Tech. Pvt. Ltd: Message Service", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                if (strUserType == "Administrator")
                {

                }
                else if (strUserType == "Manager")
                {
                    menuItemAdmin.Enabled = false;
                }
                else if (strUserType == "Clerk")
                {
                    menuItemAdmin.Enabled = false;
                    menuItemAllocate.Enabled = false;
                    menuItemView.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Alpha Net Tech. Pvt. Ltd: Message Service", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menuItemChangePassword_Click(object sender, EventArgs e)
        {
            try
            {
                frmChangePassword frmChangePassword = new frmChangePassword();
                frmChangePassword.MdiParent = this;
                frmChangePassword.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Alpha Net Tech. Pvt. Ltd: Message Service", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menuItemManageUser_Click(object sender, EventArgs e)
        {
            try
            {
                frmManageUsers frmManageUsers = new frmManageUsers();
                frmManageUsers.MdiParent = this;
                frmManageUsers.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Alpha Net Tech. Pvt. Ltd: Message Service", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menuItemExit_Click(object sender, EventArgs e)
        {
            try
            {
                Application.ExitThread();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Alpha Net Tech. Pvt. Ltd: Message Service", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menuItemManageVehicle_Click(object sender, EventArgs e)
        {
            try
            {
                frmManageVehicles frmManageVehicles = new frmManageVehicles();
                frmManageVehicles.MdiParent = this;
                frmManageVehicles.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Alpha Net Tech. Pvt. Ltd: Message Service", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menuItemManageDrivers_Click(object sender, EventArgs e)
        {
            try
            {
                frmManageDrivers frmManageDrivers = new frmManageDrivers();
                frmManageDrivers.MdiParent = this;
                frmManageDrivers.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Alpha Net Tech. Pvt. Ltd: Message Service", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menuItemVehicleFuel_Click(object sender, EventArgs e)
        {
            try
            {
                frmManageVehicleFuel frmManageVehicleFuel = new frmManageVehicleFuel();
                frmManageVehicleFuel.MdiParent = this;
                frmManageVehicleFuel.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Alpha Net Tech. Pvt. Ltd: Message Service", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menuItemVehicleMaintenance_Click(object sender, EventArgs e)
        {
            try
            {
                frmManageMaintenanceCharges frmManageMaintenanceCharges = new frmManageMaintenanceCharges();
                frmManageMaintenanceCharges.MdiParent = this;
                frmManageMaintenanceCharges.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Alpha Net Tech. Pvt. Ltd: Message Service", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menuItemRouteAndDriver_Click(object sender, EventArgs e)
        {
            try
            {
                frmManageVehicleRoutes frmManageVehicleRoutes = new frmManageVehicleRoutes();
                frmManageVehicleRoutes.MdiParent = this;
                frmManageVehicleRoutes.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Alpha Net Tech. Pvt. Ltd: Message Service", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menuItemFuelCharges_Click(object sender, EventArgs e)
        {
            try
            {
                frmViewVehicleFuelReport frmViewVehicleFuelReport = new frmViewVehicleFuelReport();
                frmViewVehicleFuelReport.MdiParent = this;
                frmViewVehicleFuelReport.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Alpha Net Tech. Pvt. Ltd: Message Service", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menuItemMaintenanceCost_Click(object sender, EventArgs e)
        {
            try
            {
                frmViewVehicleMaintenanceReport frmViewVehicleMaintenanceReport = new frmViewVehicleMaintenanceReport();
                frmViewVehicleMaintenanceReport.MdiParent = this;
                frmViewVehicleMaintenanceReport.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Alpha Net Tech. Pvt. Ltd: Message Service", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}